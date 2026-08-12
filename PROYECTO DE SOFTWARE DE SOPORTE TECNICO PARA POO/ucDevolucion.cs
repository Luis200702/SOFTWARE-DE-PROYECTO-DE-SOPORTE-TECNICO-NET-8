using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucDevolucion : UserControl
    {
        public ucDevolucion()
        {
            InitializeComponent();
        }

        ucRecepcion UnSoloBoton = new ucRecepcion();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBusqueda = txtBuscarOrden.Text.Trim();

            // Validar que el campo no esté vacío
            if (string.IsNullOrEmpty(valorBusqueda))
            {
                MessageBox.Show("Por favor, ingrese una cédula o un nombre para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Consulta para buscar las órdenes asociadas al cliente
            string query = @"
        SELECT O.id, O.numero_orden
        FROM ordenes O
        INNER JOIN Clientes C ON O.cliente_id = C.id
        WHERE C.cedula_pasaporte LIKE @busqueda OR C.nombre LIKE @busqueda";

            Conexion_Base_de_Datos conexionBD = new Conexion_Base_de_Datos();

            try
            {
                if (conexionBD.abrirConexion())
                {
                    SqlCommand cmd = new SqlCommand(query, conexionBD.oCon);
                    cmd.Parameters.AddWithValue("@busqueda", "%" + valorBusqueda + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Desconectamos temporalmente el evento para evitar conflictos al asignar el DataSource
                        cmbListaOrdenes.SelectedIndexChanged -= cmbListaOrdenes_SelectedIndexChanged;

                        cmbListaOrdenes.DataSource = dt;
                        cmbListaOrdenes.DisplayMember = "numero_orden";
                        cmbListaOrdenes.ValueMember = "id";

                        // Volvemos a conectar el evento de selección
                        cmbListaOrdenes.SelectedIndexChanged += cmbListaOrdenes_SelectedIndexChanged;

                        // Forzamos a cargar los detalles y mostrar los paneles con la primera orden encontrada
                        if (cmbListaOrdenes.SelectedValue != null && int.TryParse(cmbListaOrdenes.SelectedValue.ToString(), out int idPrimerOrden))
                        {
                            CargarDetallesOrden(idPrimerOrden);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro con esa cédula o nombre.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbListaOrdenes.DataSource = null;
                        LimpiarCamposResumen();
                        OcultarPaneles();
                    }

                    conexionBD.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento que se dispara al seleccionar una orden específica del ComboBox
        private void cmbListaOrdenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbListaOrdenes.SelectedValue == null) return;

            // Evitamos que se ejecute si el valor es un DataRowView en blanco
            if (int.TryParse(cmbListaOrdenes.SelectedValue.ToString(), out int idOrdenSeleccionada))
            {
                CargarDetallesOrden(idOrdenSeleccionada);
            }
        }

        // Método para traer la información completa de la orden seleccionada
        private void CargarDetallesOrden(int idOrden)
        {
            // 1. Modificamos la consulta para traer también el trabajo realizado/observaciones
            string query = @"
        SELECT TOP 1
            O.numero_orden AS numero_orden,
            C.nombre AS Cliente,
            C.cedula_pasaporte AS Cedula,
            C.telefono AS Telefono,
            CONCAT(D.marca, ' ', D.modelo) AS Dispositivo,
            T.nombre AS Tecnico,
            O.fecha_ingreso AS Ingreso,
            O.diagnostico_inicial AS TrabajoRealizado -- Cambia esto por 'O.observaciones' si creaste una columna específica
        FROM ordenes O
        INNER JOIN Clientes C ON O.cliente_id = C.id
        INNER JOIN Dispositivos D ON O.dispositivo_id = D.id
        INNER JOIN Usuarios T ON O.tecnico_id = T.id
        WHERE O.id = @idOrden";

            Conexion_Base_de_Datos conexionBD = new Conexion_Base_de_Datos();

            try
            {
                if (conexionBD.abrirConexion())
                {
                    SqlCommand cmd = new SqlCommand(query, conexionBD.oCon);
                    cmd.Parameters.AddWithValue("@idOrden", idOrden);

                    SqlDataReader lector = cmd.ExecuteReader();

                    if (lector.Read())
                    {
                        // Mostramos los paneles de resumen y entrega
                        pnlResumen.Visible = true;
                        pnlTrabajoRealizado.Visible = true;
                        pnlDesgloseCosto.Visible = true;
                        pnlFormaDePago.Visible = true;
                        btnRegistraEntrega.Visible = true;
                        btnComprobante.Visible = true;

                        // Rellenamos los datos del resumen
                        lblNumeroOrden.Text = lector["numero_orden"] != DBNull.Value ? lector["numero_orden"].ToString() : "S/N";
                        lblCliente.Text = lector["Cliente"] != DBNull.Value ? lector["Cliente"].ToString() : "";
                        lblCedula.Text = lector["Cedula"] != DBNull.Value ? lector["Cedula"].ToString() : "";
                        lblTelefono.Text = lector["Telefono"] != DBNull.Value ? lector["Telefono"].ToString() : "";
                        lblDispositivo.Text = lector["Dispositivo"] != DBNull.Value ? lector["Dispositivo"].ToString() : "Sin dispositivo";
                        lblTecnicoAsignado.Text = lector["Tecnico"] != DBNull.Value ? lector["Tecnico"].ToString() : "Asignado";

                        // Formateamos la fecha de ingreso
                        if (lector["Ingreso"] != DBNull.Value && DateTime.TryParse(lector["Ingreso"].ToString(), out DateTime fechaIngreso))
                        {
                            lblFechaIngreso.Text = fechaIngreso.ToString("dd/MM/yyyy HH:mm");
                        }
                        else
                        {
                            lblFechaIngreso.Text = "Sin fecha";
                        }

                        // 2. Llenamos el panel de "Trabajo realizado" usando el Label de tu diseño
                        lblDescripcionTrabajo.Text = lector["TrabajoRealizado"] != DBNull.Value ? lector["TrabajoRealizado"].ToString() : "Sin observaciones registradas.";
                    }

                    lector.Close();

                    CargarDesgloseCostos(idOrden);
                    conexionBD.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ucDevolucion_Load(object sender, EventArgs e)
        {
            if (cmbFormaPago.Items.Count > 0)
                cmbFormaPago.SelectedIndex = 0;

            OcultarPaneles();
        }

        private void OcultarPaneles()
        {
            pnlResumen.Visible = false;
            pnlTrabajoRealizado.Visible = false;
            pnlDesgloseCosto.Visible = false;
            pnlFormaDePago.Visible = false;
            btnRegistraEntrega.Visible = false;
            btnComprobante.Visible = false;
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            UnSoloBoton.SeleccionarBoton(btnReparado);
        }

        private void btnParcial_Click(object sender, EventArgs e)
        {
            UnSoloBoton.SeleccionarBoton(btnParcial);
        }

        private void btnSinReparar_Click(object sender, EventArgs e)
        {
            UnSoloBoton.SeleccionarBoton(btnSinReparar);
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPago.SelectedItem != null && cmbFormaPago.SelectedItem.ToString() == "Transferencia")
            {
                frmComprobante_Pago Comprobante = new frmComprobante_Pago();
                Comprobante.ShowDialog();
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            pdComprobante.ShowDialog();
        }

        private void LimpiarCamposResumen()
        {
            lblOrden.Text = "x";
            lblCliente.Text = "x";
            lblCedula.Text = "x";
            lblTelefono.Text = "x";
            lblDispositivo.Text = "x";
            lblTecnicoAsignado.Text = "x";
            lblFechaIngreso.Text = "x";
        }

        private void CargarDesgloseCostos(int idOrden)
        {
            // Limpiamos la grilla antes de cargar nuevos datos
            dgvDesglose.Rows.Clear();
            decimal totalCosto = 0;

            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // 1. CARGAR LOS REPUESTOS USADOS
                    // Unimos DetallesOrden con Repuestos para obtener el nombre y el precio de venta real
                    string queryRepuestos = @"
                SELECT r.NombreRepuesto, r.PrecioVenta 
                FROM DetallesOrden d
                INNER JOIN Repuestos r ON d.IdRepuesto = r.IdRepuesto
                WHERE d.IdOrden = @idOrden";

                    using (SqlCommand cmd = new SqlCommand(queryRepuestos, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@idOrden", idOrden);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string descripcion = reader["NombreRepuesto"].ToString();
                                decimal precio = Convert.ToDecimal(reader["PrecioVenta"]);

                                // Agregamos la fila a la grilla
                                dgvDesglose.Rows.Add(descripcion, $"${precio:F2}");
                                totalCosto += precio; // Vamos sumando
                            }
                        }
                    }

                    // 2. CARGAR LA MANO DE OBRA (costo_estimado)
                    string queryManoObra = "SELECT ISNULL(costo_estimado, 0) FROM ordenes WHERE id = @idOrden";
                    using (SqlCommand cmdManoObra = new SqlCommand(queryManoObra, db.oCon))
                    {
                        cmdManoObra.Parameters.AddWithValue("@idOrden", idOrden);
                        object result = cmdManoObra.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal costoManoObra = Convert.ToDecimal(result);
                            if (costoManoObra > 0)
                            {
                                // Agregamos la fila de mano de obra
                                dgvDesglose.Rows.Add("Mano de obra", $"${costoManoObra:F2}");
                                totalCosto += costoManoObra;
                            }
                        }
                    }

                    // 3. ACTUALIZAR LOS TOTALES EN LA INTERFAZ
                    lblTotalDesglose.Text = $"${totalCosto:F2}";

                    // Si tienes el label grande a la derecha (el del panel "Registrar Entrega"):
                    // lblTotalCobrar.Text = $"${totalCosto:F2}"; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el desglose de costos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }
    }
}