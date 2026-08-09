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
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{

    public partial class ucRecepcion : UserControl
    {
        // Estas van al inicio, junto a 'contadorEquipos' y 'tipoDispositivo'
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
            cmbEstado.SelectedIndex = 0;
            cmbSucursal.SelectedIndex = 0;
            cmbTecnico.SelectedIndex = 0;

            MostrarNumeroOrden();

            listaEquipos.Add(new DispositivoTemporal());

            btnEquipo.Tag = 0;

            // 2. Nos aseguramos de que dispare el evento de cambio de pestaña al hacerle clic
            btnEquipo.Click += btnEquipo_Click;
        }

        public void SeleccionarBoton(UIButton boton)
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.FillColor = Color.FromArgb(22, 35, 52);
                botonSeleccionado.RectColor = Color.Gray;
                botonSeleccionado.ForeColor = Color.White;
            }

            boton.FillColor = Color.FromArgb(0, 150, 137);
            boton.RectColor = Color.FromArgb(0, 150, 137);
            boton.ForeColor = Color.FromArgb(22, 35, 52);

            botonSeleccionado = boton;
        }

        private void btnComputadora_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(btnComputadora);
            tipoDispositivo = "computadora";
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(btnTelefono);
            tipoDispositivo = "telefono";
        }

        private void MostrarNumeroOrden()
        {
            //var db = new Conexion_Base_de_Datos();

            //using (SqlConnection con = db.ObtenerConexion())
            //{
            //    con.Open();

            //    string query = "SELECT ISNULL(MAX(id), 0) FROM ordenes";

            //    using (SqlCommand cmd = new SqlCommand(query, con))
            //    {
            //        int ultimoId = Convert.ToInt32(cmd.ExecuteScalar());
            //        lblOrden.Text = "ORD-" + DateTime.Now.Year + "-" + (ultimoId + 1).ToString("D3");
            //    }
            //}
        }

        private void GuardarRecepcion()
        {
            var db = new Conexion_Base_de_Datos();

            ////using (SqlConnection con = db.ObtenerConexion())
            //{
            //    con.Open();

            //    // INSERT Cliente
            //    string queryCliente = @"INSERT INTO clientes 
            //            (nombre, telefono, correo, cedula, pasaporte, tipo_dispositivo)
            //            VALUES 
            //            (@nombre, @telefono, @correo, @cedula, @pasaporte, @tipo_dispositivo);
            //            SELECT SCOPE_IDENTITY();";

            //    int idCliente;
            //    using (SqlCommand cmd = new SqlCommand(queryCliente, con))
            //    {
            //        cmd.Parameters.AddWithValue("@nombre", txtNombres.Text.Trim());
            //        cmd.Parameters.AddWithValue("@telefono", txtNumeroTelefonico.Text.Trim());
            //        cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
            //        cmd.Parameters.AddWithValue("@cedula",
            //            string.IsNullOrEmpty(txtIdentificacionCliente.Text) ? (object)DBNull.Value : txtIdentificacionCliente.Text.Trim());
            //        cmd.Parameters.AddWithValue("@pasaporte",
            //            string.IsNullOrEmpty(txtIdentificacionCliente.Text) ? (object)DBNull.Value : txtIdentificacionCliente.Text.Trim());
            //        cmd.Parameters.AddWithValue("@tipo_dispositivo", tipoDispositivo);

            //        idCliente = Convert.ToInt32(cmd.ExecuteScalar());
            //    }

            //    // INSERT Dispositivo
            //    string queryDispositivo = @"INSERT INTO dispositivos 
            //            (tipo, marca, modelo, serie_imei, color, estado_llegada)
            //            VALUES 
            //            (@tipo, @marca, @modelo, @serie_imei, @color, @estado_llegada);
            //            SELECT SCOPE_IDENTITY();";

            //    int idDispositivo;
            //    using (SqlCommand cmd = new SqlCommand(queryDispositivo, con))
            //    {
            //        cmd.Parameters.AddWithValue("@tipo", tipoDispositivo);
            //        cmd.Parameters.AddWithValue("@marca", txtMarca.Text.Trim());
            //        cmd.Parameters.AddWithValue("@modelo", txtModelo.Text.Trim());
            //        cmd.Parameters.AddWithValue("@serie_imei", txtSerie.Text.Trim());
            //        cmd.Parameters.AddWithValue("@color", txtColor.Text.Trim());
            //        cmd.Parameters.AddWithValue("@estado_llegada", cmbEstado.SelectedItem?.ToString());

            //        idDispositivo = Convert.ToInt32(cmd.ExecuteScalar());
            //    }

            //    // INSERT Orden
            //    string queryOrden = @"INSERT INTO ordenes 
            //    (numero_orden, cliente_id, dispositivo_id, tecnico_id, sucursal_id, 
            //     descripcion_problema, diagnostico_inicial, estado,
            //     costo_estimado, fecha_ingreso, fecha_estimada_entrega)
            //    VALUES 
            //    (@numero_orden, @cliente_id, @dispositivo_id, @tecnico_id, @sucursal_id,
            //     @descripcion_problema, @diagnostico_inicial, @estado,
            //     @costo_estimado, @fecha_ingreso, @fecha_estimada_entrega)";

            //    using (SqlCommand cmd = new SqlCommand(queryOrden, con))
            //    {
            //        cmd.Parameters.AddWithValue("@cliente_id", idCliente);
            //        cmd.Parameters.AddWithValue("@dispositivo_id", idDispositivo);

            //        int[] idsTecnicos = { 0, 11, 13, 14 };
            //        cmd.Parameters.AddWithValue("@tecnico_id",
            //            cmbTecnico.SelectedIndex >= 0 ? (object)idsTecnicos[cmbTecnico.SelectedIndex] : DBNull.Value);

            //        int[] idsSucursales = { 1, 2, 3, 4 };
            //        cmd.Parameters.AddWithValue("@sucursal_id",
            //            cmbSucursal.SelectedIndex >= 0 ? (object)idsSucursales[cmbSucursal.SelectedIndex] : DBNull.Value);

            //        cmd.Parameters.AddWithValue("@descripcion_problema", txtDescripcionProblema.Text.Trim());
            //        cmd.Parameters.AddWithValue("@diagnostico_inicial", txtObservaciones.Text.Trim());
            //        cmd.Parameters.AddWithValue("@estado", "Recibido");
            //        cmd.Parameters.AddWithValue("@costo_estimado", decimal.Parse(txtCosto.Text));
            //        cmd.Parameters.AddWithValue("@fecha_ingreso", DateTime.Now);
            //        cmd.Parameters.AddWithValue("@fecha_estimada_entrega", dtmFecha.Value.Date);
            //        cmd.Parameters.AddWithValue("@numero_orden", lblOrden.Text);

            //        cmd.ExecuteNonQuery();
            //    }
            //}

            //MessageBox.Show("Recepción guardada correctamente.");
            //MostrarNumeroOrden();
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            if (cmbTecnico.SelectedIndex < 0 || cmbSucursal.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un técnico y una sucursal.");
                return;
            }
            GuardarRecepcion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Datos del cliente
            txtNombres.Text = "";
            txtNumeroTelefonico.Text = "";
            txtCorreo.Text = "";
            txtIdentificacionCliente.Text = "";

            // Datos del dispositivo
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtSerie.Text = "";
            txtColor.Text = "";
            cmbEstado.SelectedIndex = 0;

            // Datos de la reparación
            txtDescripcionProblema.Text = "";
            txtObservaciones.Text = "";
            cmbTecnico.SelectedIndex = 0;
            cmbSucursal.SelectedIndex = 0;
            txtCosto.Text = "0";
            dtmFecha.Value = DateTime.Now;

            // Botón tipo dispositivo
            tipoDispositivo = "";
            if (botonSeleccionado != null)
            {
                botonSeleccionado.FillColor = Color.FromArgb(22, 35, 52);
                botonSeleccionado.RectColor = Color.Gray;
                botonSeleccionado.ForeColor = Color.White;
                botonSeleccionado = null;
            }
        }

        private void GuardarDatosEnMemoria()
        {
            // Si la lista está vacía, no hay nada que guardar aún
            if (listaEquipos.Count == 0) return;

            // Rescata lo que hay actualmente en pantalla y lo guarda en el objeto de la lista
            var equipo = listaEquipos[indicePestanaActual];

            equipo.Tipo = tipoDispositivo;
            equipo.Marca = txtMarca.Text;
            equipo.Modelo = txtModelo.Text;
            equipo.Serie = txtSerie.Text;
            equipo.Color = txtColor.Text;
            equipo.IndiceEstado = cmbEstado.SelectedIndex;
            equipo.Problema = txtDescripcionProblema.Text;
            equipo.Observaciones = txtObservaciones.Text;
        }

        private void CargarDatosA_Pantalla(int indice)
        {
            // Saca los datos del objeto guardado y los pone de vuelta en los TextBox
            var equipo = listaEquipos[indice];

            tipoDispositivo = equipo.Tipo;
            txtMarca.Text = equipo.Marca;
            txtModelo.Text = equipo.Modelo;
            txtSerie.Text = equipo.Serie;
            txtColor.Text = equipo.Color;
            cmbEstado.SelectedIndex = equipo.IndiceEstado;
            txtDescripcionProblema.Text = equipo.Problema;
            txtObservaciones.Text = equipo.Observaciones;

            // Y muy importante: restauramos el color visual del botón de Computadora/Teléfono
            if (tipoDispositivo == "computadora")
                SeleccionarBoton(btnComputadora);
            else if (tipoDispositivo == "telefono")
                SeleccionarBoton(btnTelefono);
            else
            {
                // Si no hay tipo, despintamos ambos botones (opcional según tu diseño)
                if (botonSeleccionado != null)
                {
                    botonSeleccionado.FillColor = Color.FromArgb(22, 35, 52);
                    botonSeleccionado.RectColor = Color.Gray;
                    botonSeleccionado.ForeColor = Color.White;
                    botonSeleccionado = null;
                }
            }

            // Actualizamos en qué pestaña estamos actualmente
            indicePestanaActual = indice;
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            // Guardamos los datos de la pestaña actual antes de crear otra
            GuardarDatosEnMemoria();
            listaEquipos.Add(new DispositivoTemporal());

            contadorEquipos++;

            // 1. Crear un botón de la librería SunnyUI
            Sunny.UI.UIButton btnNuevo = new Sunny.UI.UIButton();
            btnNuevo.Name = "btnEquipo" + contadorEquipos;
            btnNuevo.Text = "Equipo " + contadorEquipos;
            btnNuevo.Size = new Size(90, 32);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Margin = new Padding(3, 3, 3, 3);
            btnNuevo.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Radius = 12;

            // Asignar el Tag para la memoria
            btnNuevo.Tag = listaEquipos.Count - 1;

            // 2. Conectar al evento de clic
            btnNuevo.Click += btnEquipo_Click;

            // 3. Agregar al panel
            flpEquipos.Controls.Add(btnNuevo);

            // 4. Asegurar que el botón de añadir quede al final (extremo derecho)
            flpEquipos.Controls.Remove(btnAgregarEquipo);
            flpEquipos.Controls.Add(btnAgregarEquipo);

            // 5. Simular clic para activarlo
            btnNuevo.PerformClick();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            // Recibimos el botón como Sunny.UI.UIButton
            Sunny.UI.UIButton botonPresionado = (Sunny.UI.UIButton)sender;

            // 1. Guardar la pestaña actual en memoria
            GuardarDatosEnMemoria();

            // 2. Recorrer el panel y pintar todos los botones de equipo como "Inactivos"
            foreach (Control ctrl in flpEquipos.Controls)
            {
                if (ctrl is Sunny.UI.UIButton btn && btn.Name != "btnAgregarEquipo")
                {
                    // Colores inactivos (igual que usas en tu método SeleccionarBoton)
                    btn.FillColor = Color.FromArgb(22, 35, 52);
                    btn.RectColor = Color.Gray;
                    btn.ForeColor = Color.White;
                }
            }

            // 3. Pintar SOLO el botón presionado como "Activo" (Turquesa)
            botonPresionado.FillColor = Color.FromArgb(0, 150, 137);
            botonPresionado.RectColor = Color.FromArgb(0, 150, 137);
            botonPresionado.ForeColor = Color.FromArgb(22, 35, 52);

            // 4. Cargar los datos correspondientes a esta pestaña
            if (botonPresionado.Tag != null)
            {
                int nuevoIndice = Convert.ToInt32(botonPresionado.Tag);
                CargarDatosA_Pantalla(nuevoIndice);
            }
        }

    }

}