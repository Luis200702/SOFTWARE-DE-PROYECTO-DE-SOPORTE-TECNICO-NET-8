using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucDevolucion : UserControl
    {
        private byte[]? comprobantePago = null;
        private string nombreComprobante = "";
        private decimal totalOrden = 0;

        public ucDevolucion()
        {
            InitializeComponent();
        }

        ucRecepcion UnSoloBoton = new ucRecepcion();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBusqueda = txtBuscarOrden.Text.Trim();

            if (string.IsNullOrEmpty(valorBusqueda))
            {
                MessageBox.Show(
                    "Por favor, ingrese una cédula o un nombre para buscar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // En Devolución solo mostramos órdenes que ya están listas para entregar.
            string query = @"
                SELECT O.id, O.numero_orden
                FROM ordenes O
                INNER JOIN Clientes C ON O.cliente_id = C.id
                WHERE (C.cedula_pasaporte LIKE @busqueda
                       OR C.nombre LIKE @busqueda)
                  AND O.estado = 'Listo'";

            Conexion_Base_de_Datos conexionBD = new Conexion_Base_de_Datos();

            try
            {
                if (conexionBD.abrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexionBD.oCon))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", "%" + valorBusqueda + "%");

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                // Evita que el evento se ejecute mientras se cambia el DataSource.
                                cmbListaOrdenes.SelectedIndexChanged -= cmbListaOrdenes_SelectedIndexChanged;

                                cmbListaOrdenes.DataSource = dt;
                                cmbListaOrdenes.DisplayMember = "numero_orden";
                                cmbListaOrdenes.ValueMember = "id";

                                cmbListaOrdenes.SelectedIndexChanged += cmbListaOrdenes_SelectedIndexChanged;

                                if (cmbListaOrdenes.SelectedValue != null &&
                                    int.TryParse(cmbListaOrdenes.SelectedValue.ToString(), out int idPrimeraOrden))
                                {
                                    CargarDetallesOrden(idPrimeraOrden);
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontraron órdenes listas para entregar con esa cédula o nombre.",
                                    "No encontrado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                cmbListaOrdenes.DataSource = null;
                                ReiniciarDatosPago();
                                LimpiarCamposResumen();
                                OcultarPaneles();
                            }
                        }
                    }

                    conexionBD.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al realizar la búsqueda: " + ex.Message,
                    "Error de Base de Datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                conexionBD.cerrarConexion();
            }
        }

        private void cmbListaOrdenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbListaOrdenes.SelectedValue == null)
                return;

            if (int.TryParse(cmbListaOrdenes.SelectedValue.ToString(), out int idOrdenSeleccionada))
            {
                CargarDetallesOrden(idOrdenSeleccionada);
            }
        }

        private void CargarDetallesOrden(int idOrden)
        {
            // Cada vez que se cambia de orden se elimina cualquier comprobante anterior.
            ReiniciarDatosPago();

            string query = @"
    SELECT TOP 1
        O.numero_orden AS numero_orden,
        C.nombre AS Cliente,
        C.cedula_pasaporte AS Cedula,
        C.telefono AS Telefono,
        CONCAT(D.marca, ' ', D.modelo) AS Dispositivo,
        T.nombre AS Tecnico,
        O.fecha_ingreso AS Ingreso,
        O.trabajo_realizado AS TrabajoRealizado
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
                    using (SqlCommand cmd = new SqlCommand(query, conexionBD.oCon))
                    {
                        cmd.Parameters.AddWithValue("@idOrden", idOrden);

                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                pnlResumen.Visible = true;
                                pnlTrabajoRealizado.Visible = true;
                                pnlDesgloseCosto.Visible = true;
                                pnlFormaDePago.Visible = true;
                                btnRegistraEntrega.Visible = true;

                                // El botón de comprobante solo aparece al seleccionar Transferencia.
                                btnComprobante.Visible = false;

                                lblNumeroOrden.Text = lector["numero_orden"] != DBNull.Value
                                    ? lector["numero_orden"].ToString()
                                    : "S/N";

                                lblCliente.Text = lector["Cliente"] != DBNull.Value
                                    ? lector["Cliente"].ToString()
                                    : "";

                                lblCedula.Text = lector["Cedula"] != DBNull.Value
                                    ? lector["Cedula"].ToString()
                                    : "";

                                lblTelefono.Text = lector["Telefono"] != DBNull.Value
                                    ? lector["Telefono"].ToString()
                                    : "";

                                lblDispositivo.Text = lector["Dispositivo"] != DBNull.Value
                                    ? lector["Dispositivo"].ToString()
                                    : "Sin dispositivo";

                                lblTecnicoAsignado.Text = lector["Tecnico"] != DBNull.Value
                                    ? lector["Tecnico"].ToString()
                                    : "Asignado";

                                if (lector["Ingreso"] != DBNull.Value &&
                                    DateTime.TryParse(lector["Ingreso"].ToString(), out DateTime fechaIngreso))
                                {
                                    lblFechaIngreso.Text = fechaIngreso.ToString("dd/MM/yyyy HH:mm");
                                }
                                else
                                {
                                    lblFechaIngreso.Text = "Sin fecha";
                                }

                                // Más adelante cambiaremos esta columna por trabajo_realizado
                                // cuando la agreguemos a la tabla ordenes.
                                lblDescripcionTrabajo.Text = lector["TrabajoRealizado"] != DBNull.Value
                                    ? lector["TrabajoRealizado"].ToString()
                                    : "Sin observaciones registradas.";
                            }
                        }
                    }

                    CargarDesgloseCostos(idOrden);
                    conexionBD.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los detalles de la orden: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                conexionBD.cerrarConexion();
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
            if (cmbFormaPago.SelectedItem == null)
                return;

            string formaPago = cmbFormaPago.SelectedItem.ToString();

            if (formaPago == "Transferencia")
            {
                // Ya no abrimos el formulario automáticamente.
                // El usuario decide cuándo pulsar el botón.
                btnComprobante.Visible = true;
                btnComprobante.Enabled = true;

                btnComprobante.Text = comprobantePago != null
                    ? "Comprobante adjunto ✓"
                    : "Adjuntar comprobante";
            }
            else
            {
                comprobantePago = null;
                nombreComprobante = "";

                btnComprobante.Visible = false;
                btnComprobante.Text = "Adjuntar comprobante";
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            if (cmbFormaPago.SelectedItem == null ||
                cmbFormaPago.SelectedItem.ToString() != "Transferencia")
            {
                return;
            }

            using (frmComprobante_Pago comprobante = new frmComprobante_Pago())
            {
                if (comprobante.ShowDialog() == DialogResult.OK)
                {
                    comprobantePago = comprobante.ComprobanteBytes;
                    nombreComprobante = comprobante.NombreComprobante;

                    btnComprobante.Text = "Comprobante adjunto ✓";
                }
            }
        }

        private void LimpiarCamposResumen()
        {
            // Antes se limpiaba lblOrden, que es el texto de instrucciones.
            // El número real de orden se muestra en lblNumeroOrden.
            lblNumeroOrden.Text = "x";
            lblCliente.Text = "x";
            lblCedula.Text = "x";
            lblTelefono.Text = "x";
            lblDispositivo.Text = "x";
            lblTecnicoAsignado.Text = "x";
            lblFechaIngreso.Text = "x";
            lblDescripcionTrabajo.Text = "Sin observaciones registradas.";
        }

        private void CargarDesgloseCostos(int idOrden)
        {
            dgvDesglose.Rows.Clear();
            decimal totalCosto = 0;

            var db = new Conexion_Base_de_Datos();

            if (db.abrirConexion())
            {
                try
                {
                    // Se usa PrecioCobrado de DetallesOrden para conservar el valor
                    // que tenía el repuesto cuando se agregó a la orden.
                    string queryRepuestos = @"
                        SELECT
                            r.NombreRepuesto,
                            d.Cantidad,
                            d.PrecioCobrado
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
                                string descripcion = reader["NombreRepuesto"].ToString() ?? "Repuesto";
                                int cantidad = reader["Cantidad"] != DBNull.Value
                                    ? Convert.ToInt32(reader["Cantidad"])
                                    : 1;

                                decimal precioUnitario = reader["PrecioCobrado"] != DBNull.Value
                                    ? Convert.ToDecimal(reader["PrecioCobrado"])
                                    : 0;

                                decimal subtotal = precioUnitario * cantidad;

                                string descripcionFila = cantidad > 1
                                    ? $"{descripcion} x{cantidad}"
                                    : descripcion;

                                dgvDesglose.Rows.Add(descripcionFila, $"${subtotal:F2}");
                                totalCosto += subtotal;
                            }
                        }
                    }

                    // Para este proyecto costo_estimado se utiliza como mano de obra.
                    string queryManoObra =
                        "SELECT ISNULL(costo_estimado, 0) FROM ordenes WHERE id = @idOrden";

                    using (SqlCommand cmdManoObra = new SqlCommand(queryManoObra, db.oCon))
                    {
                        cmdManoObra.Parameters.AddWithValue("@idOrden", idOrden);

                        object? result = cmdManoObra.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal costoManoObra = Convert.ToDecimal(result);

                            if (costoManoObra > 0)
                            {
                                dgvDesglose.Rows.Add("Mano de obra", $"${costoManoObra:F2}");
                                totalCosto += costoManoObra;
                            }
                        }
                    }

                    lblTotalDesglose.Text = $"${totalCosto:F2}";
                    lblTotalCobrar.Text = $"${totalCosto:F2}";
                    totalOrden = totalCosto;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al cargar el desglose de costos: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void btnRegistraEntrega_Click(object sender, EventArgs e)
        {
            if (cmbListaOrdenes.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione una orden.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbFormaPago.SelectedItem == null ||
                cmbFormaPago.SelectedItem.ToString() == "Seleccionar...")
            {
                MessageBox.Show(
                    "Seleccione una forma de pago.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string formaPago = cmbFormaPago.SelectedItem.ToString();

            if (formaPago == "Transferencia" && comprobantePago == null)
            {
                MessageBox.Show(
                    "Debe adjuntar el comprobante de la transferencia.",
                    "Comprobante requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int idOrden = Convert.ToInt32(cmbListaOrdenes.SelectedValue);
            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();

            try
            {
                if (db.abrirConexion())
                {
                    string query = @"
                        UPDATE ordenes
                        SET forma_pago = @formaPago,
                            monto_pagado = @montoPagado,
                            fecha_entrega = GETDATE(),
                            comprobante_pago = @comprobante,
                            nombre_comprobante = @nombreComprobante,
                            estado = 'Entregado'
                        WHERE id = @idOrden";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@formaPago", formaPago);
                        cmd.Parameters.AddWithValue("@montoPagado", totalOrden);
                        cmd.Parameters.AddWithValue("@idOrden", idOrden);

                        cmd.Parameters.Add("@comprobante", SqlDbType.VarBinary, -1).Value =
                            (object?)comprobantePago ?? DBNull.Value;

                        cmd.Parameters.AddWithValue(
                            "@nombreComprobante",
                            string.IsNullOrEmpty(nombreComprobante)
                                ? DBNull.Value
                                : nombreComprobante);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show(
                                "La entrega fue registrada correctamente.",
                                "Entrega registrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LimpiarDespuesDeEntrega();
                        }
                        else
                        {
                            MessageBox.Show(
                                "No se pudo actualizar la orden.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al registrar la entrega: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                db.cerrarConexion();
            }
        }

        private void ReiniciarDatosPago()
        {
            comprobantePago = null;
            nombreComprobante = "";
            totalOrden = 0;

            btnComprobante.Text = "Adjuntar comprobante";
            btnComprobante.Visible = false;

            if (cmbFormaPago.Items.Count > 0)
                cmbFormaPago.SelectedIndex = 0;
        }

        private void LimpiarDespuesDeEntrega()
        {
            ReiniciarDatosPago();

            txtBuscarOrden.Clear();
            txtObservaciones.Clear();

            cmbListaOrdenes.DataSource = null;
            dgvDesglose.Rows.Clear();

            lblTotalDesglose.Text = "$0.00";
            lblTotalCobrar.Text = "$0.00";

            LimpiarCamposResumen();
            OcultarPaneles();

            txtBuscarOrden.Focus();
        }
    }
}
