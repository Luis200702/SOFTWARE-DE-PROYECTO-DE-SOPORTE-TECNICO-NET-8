using Microsoft.Data.SqlClient;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucRecepcion : UserControl
    {
        private List<DispositivoTemporal> listaEquipos = new List<DispositivoTemporal>();
        private int indicePestanaActual = 0;
        private int contadorEquipos = 1;
        private UIButton botonSeleccionado = null;
        private string tipoDispositivo = "";

        public ucRecepcion()
        {
            InitializeComponent();
        }

        private void ucRecepcion_Load(object sender, EventArgs e) 
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");

            // Texto por defecto para la Sucursal (ahora es un TextBox bloqueado)
            txtSucursal.Text = "Sucursal Norte";

            CargarDatosComboBox();
            cmbEstado.SelectedIndex = 0;
            MostrarNumeroOrden();

            listaEquipos.Add(new DispositivoTemporal());

            btnEquipo.Tag = 0;
            btnEquipo.Click += btnEquipo_Click;

            txtIdentificacionCliente.Leave += txtIdentificacionCliente_Leave;

            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarca, "");
        }

        //Metodo para permitir seleccionar un boton (usado en otros objetos)
        public void SeleccionarBoton(UIButton boton)
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.FillColor = Color.FromArgb(239, 243, 247);
                botonSeleccionado.ForeColor = Color.FromArgb(70, 86, 103);
                botonSeleccionado.RectColor = Color.FromArgb(220, 226, 232);
            }

            boton.FillColor = Color.FromArgb(0, 165, 155);
            boton.ForeColor = Color.FromArgb(255, 255, 255);
            boton.RectColor = Color.FromArgb(0, 165, 155);

            botonSeleccionado = boton;
        }

        private void btnComputadora_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(btnComputadora);
            tipoDispositivo = "computadora";

            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarca, tipoDispositivo);
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(btnTelefono);
            tipoDispositivo = "telefono";

            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarca, tipoDispositivo);
        }

        private void CargarDatosComboBox()
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // Solo cargamos los técnicos de la base de datos
                    string ConsultaTecnicos = "SELECT Id, Nombre FROM Usuarios WHERE Perfil = 'Tecnico'";
                    SqlDataAdapter daTecnicos = new SqlDataAdapter(ConsultaTecnicos, db.oCon);
                    DataTable dtTecnicos = new DataTable();
                    daTecnicos.Fill(dtTecnicos);

                    cmbTecnico.DataSource = dtTecnicos;
                    cmbTecnico.DisplayMember = "Nombre";
                    cmbTecnico.ValueMember = "Id";

                    // Si hay técnicos, seleccionamos al primero por defecto
                    if (cmbTecnico.Items.Count > 0)
                    {
                        cmbTecnico.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos en los ComboBox: " + ex.Message);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void MostrarNumeroOrden()
        {
            var db = new Conexion_Base_de_Datos();

            if (db.abrirConexion())
            {
                try
                {
                    string query = "SELECT ISNULL(MAX(id), 0) FROM ordenes";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        int ultimoId = Convert.ToInt32(cmd.ExecuteScalar());
                        lblOrden.Text = "ORD-" + DateTime.Now.Year + "-" + (ultimoId + 1).ToString("D3");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el número de orden: " + ex.Message);
                    lblOrden.Text = "ORD-" + DateTime.Now.Year + "-001";
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
            else
            {
                lblOrden.Text = "ORD-" + DateTime.Now.Year + "-001";
            }
        }

        //autocompletado por si existe el cliente en la base de datos
        private void txtIdentificacionCliente_Leave(object sender, EventArgs e)
        {
            string cedula = txtIdentificacionCliente.Text.Trim();
            if (string.IsNullOrEmpty(cedula)) return;

            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string ConsultaCliente = "SELECT TOP 1 nombre, telefono, correo FROM clientes WHERE cedula_pasaporte = @cedula";
                    using (SqlCommand cmd = new SqlCommand(ConsultaCliente, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@cedula", cedula);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNombres.Text = reader["nombre"].ToString();
                                txtNumeroTelefonico.Text = reader["telefono"].ToString();
                                txtCorreo.Text = reader["correo"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar cliente: " + ex.Message);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void GuardarRecepcion()
        {
            //Metodo para guardar los equipos asosiados al cliente en la recepcion
            GuardarDatosEnMemoria();

            foreach (var eq in listaEquipos)
            {
                if (string.IsNullOrEmpty(eq.Tipo))
                {
                    MessageBox.Show("Por favor selecciona si el equipo es computadora o teléfono en todas las pestañas.");
                    return;
                }
            }

            var db = new Conexion_Base_de_Datos();

            if (!db.abrirConexion())
            {
                MessageBox.Show("No se pudo conectar a la base de datos");
                return;
            }

            SqlTransaction transaccion = db.oCon.BeginTransaction();

            try
            {
                // verificacion si existe o no el cliente
                string queryVerificarCliente = "SELECT id FROM clientes WHERE cedula_pasaporte = @cedula";
                int idCliente = 0;

                using (SqlCommand cmdVal = new SqlCommand(queryVerificarCliente, db.oCon, transaccion))
                {
                    cmdVal.Parameters.AddWithValue("@cedula", txtIdentificacionCliente.Text.Trim());
                    var resultado = cmdVal.ExecuteScalar();
                    if (resultado != null)
                    {
                        idCliente = Convert.ToInt32(resultado);
                    }
                }

                if (idCliente == 0)
                {
                    string ConsultaCliente = @"INSERT INTO clientes (nombre, telefono, correo, cedula_pasaporte) 
                                            VALUES (@nombre, @telefono, @correo, @cedula); 
                                            SELECT SCOPE_IDENTITY();"; 

                    using (SqlCommand cmd = new SqlCommand(ConsultaCliente, db.oCon, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombres.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefono", txtNumeroTelefonico.Text.Trim());
                        cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                        cmd.Parameters.AddWithValue("@cedula", txtIdentificacionCliente.Text.Trim());

                        idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                // Extraemos el técnico del ComboBox y la sucursal del TextBox
                int tecnicoId = Convert.ToInt32(cmbTecnico.SelectedValue);
                string sucursalNombre = txtSucursal.Text.Trim();

                for (int i = 0; i < listaEquipos.Count; i++)
                {
                    var equipo = listaEquipos[i];

                    string queryDispositivo = @"INSERT INTO dispositivos (cliente_id, tipo, marca, modelo, serie_imei, color, estado_llegada) 
                                                VALUES (@cliente_id, @tipo, @marca, @modelo, @serie_imei, @color, @estado_llegada); 
                                                SELECT SCOPE_IDENTITY();";

                    int idDispositivo;
                    using (SqlCommand cmd = new SqlCommand(queryDispositivo, db.oCon, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@cliente_id", idCliente);
                        cmd.Parameters.AddWithValue("@tipo", equipo.Tipo);
                        cmd.Parameters.AddWithValue("@marca", equipo.Marca.Trim());
                        cmd.Parameters.AddWithValue("@modelo", equipo.Modelo.Trim());
                        cmd.Parameters.AddWithValue("@serie_imei", equipo.Serie.Trim());
                        cmd.Parameters.AddWithValue("@color", equipo.Color.Trim());
                        cmd.Parameters.AddWithValue("@estado_llegada", cmbEstado.Items[equipo.IndiceEstado].ToString());

                        idDispositivo = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string queryOrden = @"INSERT INTO ordenes (numero_orden, cliente_id, dispositivo_id, tecnico_id, sucursal, 
                                         descripcion_problema, diagnostico_inicial, costo_estimado, fecha_ingreso, fecha_estimada_entrega, estado) 
                                         VALUES (@num_orden, @cli_id, @disp_id, @tec_id, @sucursal, @prob, @diag, @costo, @f_ingreso, @f_entrega, @estado)";

                    using (SqlCommand cmd = new SqlCommand(queryOrden, db.oCon, transaccion))
                    {
                        string numOrdenFinal = listaEquipos.Count > 1 ? $"{lblOrden.Text}-{i + 1}" : lblOrden.Text;

                        cmd.Parameters.AddWithValue("@num_orden", numOrdenFinal);
                        cmd.Parameters.AddWithValue("@cli_id", idCliente);
                        cmd.Parameters.AddWithValue("@disp_id", idDispositivo);
                        cmd.Parameters.AddWithValue("@tec_id", tecnicoId);
                        cmd.Parameters.AddWithValue("@sucursal", sucursalNombre);
                        cmd.Parameters.AddWithValue("@prob", equipo.Problema.Trim());
                        cmd.Parameters.AddWithValue("@diag", equipo.Observaciones.Trim());
                        cmd.Parameters.AddWithValue("@costo", string.IsNullOrEmpty(txtCosto.Text) ? 0 : decimal.Parse(txtCosto.Text));
                        cmd.Parameters.AddWithValue("@f_ingreso", DateTime.Now);
                        cmd.Parameters.AddWithValue("@f_entrega", dtmFecha.Value.Date);
                        cmd.Parameters.AddWithValue("@estado", "Recibido");

                        cmd.ExecuteNonQuery();
                    }
                }

                transaccion.Commit();
                MessageBox.Show("¡Recepción y equipos guardados exitosamente en la base de datos!");

                ReiniciarFormularioCompleto();
            }
            catch (Exception ex)
            {
                try { transaccion.Rollback(); } catch { }
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
            }
            finally
            {
                db.cerrarConexion();
            }
        }

        private void ReiniciarFormularioCompleto()
        {
            txtNombres.Clear();
            txtNumeroTelefonico.Clear();
            txtCorreo.Clear();
            txtIdentificacionCliente.Clear();

            txtDescripcionProblema.Clear();
            txtObservaciones.Clear();
            txtCosto.Text = "0";
            cmbEstado.SelectedIndex = 0;

            // Restablecer valores por defecto de la asignación
            if (cmbTecnico.Items.Count > 0) cmbTecnico.SelectedIndex = 0;
            txtSucursal.Text = "Sucursal Norte";

            dtmFecha.Value = DateTime.Now;

            listaEquipos.Clear();
            listaEquipos.Add(new DispositivoTemporal());
            indicePestanaActual = 0;
            contadorEquipos = 1;

            List<Control> controlesABorrar = new List<Control>();
            foreach (Control ctrl in flpEquipos.Controls)
            {
                if (ctrl is Sunny.UI.UIButton btn && btn.Name != "btnEquipo" && btn.Name != "btnAgregarEquipo")
                {
                    controlesABorrar.Add(btn);
                }
            }
            foreach (var ctrl in controlesABorrar)
            {
                flpEquipos.Controls.Remove(ctrl);
            }

            // Resetear el botón principal "Equipo 1"
            btnEquipo.Tag = 0;
            btnEquipo.FillColor = Color.FromArgb(0, 150, 137);
            btnEquipo.RectColor = Color.FromArgb(0, 150, 137);
            btnEquipo.ForeColor = Color.FromArgb(22, 35, 52);

            // Limpiar botones de tipo de dispositivo
            tipoDispositivo = "";
            cmbMarca.Text = "";
            if (botonSeleccionado != null)
            {
                botonSeleccionado.FillColor = Color.FromArgb(22, 35, 52);
                botonSeleccionado.RectColor = Color.Gray;
                botonSeleccionado.ForeColor = Color.White;
                botonSeleccionado = null;
            }

            // Cargar datos limpios en la pantalla para el Equipo 1
            CargarDatosA_Pantalla(0);

            // Generar el nuevo número de orden para el siguiente registro
            MostrarNumeroOrden();

            // Recargar marcas generales
            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarca, "");
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            if (cmbTecnico.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un técnico asignado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GuardarRecepcion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarFormularioCompleto();
        }

        private void GuardarDatosEnMemoria() // Lista de dispositivos 
        {
            if (listaEquipos.Count == 0) return;

            var equipo = listaEquipos[indicePestanaActual];

            equipo.Tipo = tipoDispositivo;
            equipo.Marca = cmbMarca.Text;
            equipo.Modelo = txtModelo.Text;
            equipo.Serie = txtSerie.Text;
            equipo.Color = txtColor.Text;
            equipo.IndiceEstado = cmbEstado.SelectedIndex;
            equipo.Problema = txtDescripcionProblema.Text;
            equipo.Observaciones = txtObservaciones.Text;
        }

        private void CargarDatosA_Pantalla(int indice)
        {
            var equipo = listaEquipos[indice];

            tipoDispositivo = equipo.Tipo;

            // Recargar las marcas correspondientes al tipo antes de asignar el texto al ComboBox
            CatalogoMarcas.CargarMarcasEnComboBox(cmbMarca, tipoDispositivo);
            cmbMarca.Text = equipo.Marca;

            txtModelo.Text = equipo.Modelo;
            txtSerie.Text = equipo.Serie;
            txtColor.Text = equipo.Color;
            cmbEstado.SelectedIndex = equipo.IndiceEstado >= 0 ? equipo.IndiceEstado : 0;
            txtDescripcionProblema.Text = equipo.Problema;
            txtObservaciones.Text = equipo.Observaciones;

            if (tipoDispositivo == "computadora")
                SeleccionarBoton(btnComputadora);
            else if (tipoDispositivo == "telefono")
                SeleccionarBoton(btnTelefono);
            else
            {
                if (botonSeleccionado != null)
                {
                    botonSeleccionado.FillColor = Color.FromArgb(22, 35, 52);
                    botonSeleccionado.RectColor = Color.Gray;
                    botonSeleccionado.ForeColor = Color.White;
                    botonSeleccionado = null;
                }
            }

            indicePestanaActual = indice;
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            GuardarDatosEnMemoria();
            listaEquipos.Add(new DispositivoTemporal());

            contadorEquipos++;

            Sunny.UI.UIButton btnNuevo = new Sunny.UI.UIButton();
            btnNuevo.Name = "btnEquipo" + contadorEquipos;
            btnNuevo.Text = "Equipo " + contadorEquipos;
            btnNuevo.Size = new Size(100, 34);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Margin = new Padding(3, 3, 3, 3);
            btnNuevo.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Radius = 12;

            btnNuevo.Tag = listaEquipos.Count - 1;
            btnNuevo.Click += btnEquipo_Click;

            flpEquipos.Controls.Add(btnNuevo);

            flpEquipos.Controls.Remove(btnAgregarEquipo);
            flpEquipos.Controls.Add(btnAgregarEquipo);

            btnNuevo.PerformClick();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            Sunny.UI.UIButton botonPresionado = (Sunny.UI.UIButton)sender;

            GuardarDatosEnMemoria();

            foreach (Control ctrl in flpEquipos.Controls)
            {
                if (ctrl is Sunny.UI.UIButton btn && btn.Name != "btnAgregarEquipo")
                {
                    btn.FillColor = Color.FromArgb(22, 35, 52);
                    btn.RectColor = Color.Gray;
                    btn.ForeColor = Color.White;
                }
            }

            botonPresionado.FillColor = Color.FromArgb(0, 150, 137);
            botonPresionado.RectColor = Color.FromArgb(0, 150, 137);
            botonPresionado.ForeColor = Color.FromArgb(22, 35, 52);

            if (botonPresionado.Tag != null)
            {
                int nuevoIndice = Convert.ToInt32(botonPresionado.Tag);
                CargarDatosA_Pantalla(nuevoIndice);
            }
        }

        private void flpEquipos_Click(object sender, EventArgs e)
        {

        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            UITextBox txt = sender as UITextBox;
            if (txt == null) return;

            if (char.IsControl(e.KeyChar))
                return;

            // Solo números y coma
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }

            // Solo una coma
            if (e.KeyChar == ',' && txt.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCosto.Text))
                return;

            // Convertir la coma a punto solo para poder convertirlo a decimal
            string texto = txtCosto.Text.Replace('.', ','); // por si acaso escriben punto
            texto = texto.Replace(',', '.');

            if (decimal.TryParse(texto, System.Globalization.NumberStyles.Any,
                                       System.Globalization.CultureInfo.InvariantCulture, out decimal precio)
                && precio >= 0)
            {
                // Mostramos con coma
                txtCosto.Text = precio.ToString("0.00").Replace('.', ',');
            }
            else
            {
                MessageBox.Show("El costo debe ser un número positivo.\nEjemplo: 150,50",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCosto.Focus();
                txtCosto.SelectAll();
            }
        }

        public bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            // Validación de correo
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, patron, RegexOptions.IgnoreCase);
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string correo = txtCorreo.Text.Trim();

            if (!string.IsNullOrWhiteSpace(correo) && !EsEmailValido(correo))
            {
                // Marcar el error 
                txtCorreo.RectColor = Color.Red;

                // Avisar al usuario 
                MessageBox.Show("El formato del correo no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Cancelar el evento para que el cursor no pueda salir
                e.Cancel = true;
            }
            else
            {
                // Si es válido, restaorar el color original
                txtCorreo.RectColor = Color.FromArgb(220, 224, 230); // El color de borde del diseño
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como el Retroceso para poder borrar
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir solo letras y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Si la tecla presionada no es una letra ni un espacio, se cancela el evento
                e.Handled = true;
            }
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como el Retroceso para poder borrar
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir solo números (del 0 al 9)
            if (!char.IsDigit(e.KeyChar))
            {
                // Si la tecla presionada no es un número, se bloquea la entrada
                e.Handled = true;
            }
        }

        private void lblDatosCliente_Click(object sender, EventArgs e)
        {

        }
    }
}