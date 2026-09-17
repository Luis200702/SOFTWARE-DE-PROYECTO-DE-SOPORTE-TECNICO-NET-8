using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucDevolucion : UserControl
    {
        private byte[]? comprobantePago = null;
        private string nombreComprobante = "";
        private decimal totalOrden = 0;
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();

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

            string busqueda = valorBusqueda.Replace("'", "''");
            string sucursal = Sesion.SucursalActual.Replace("'", "''");
            string consulta = "select o.id, o.numero_orden from ordenes o inner join clientes c on o.cliente_id = c.id where o.sucursal = '" + sucursal + "' and o.estado = 'Listo' and (c.cedula_pasaporte like '%" + busqueda + "%' or c.nombre like '%" + busqueda + "%')";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            if (dt != null && dt.Rows.Count > 0)
            {
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
            ReiniciarDatosPago();

            string consulta = "select top 1 o.numero_orden as numero_orden, c.nombre as Cliente, c.cedula_pasaporte as Cedula, c.telefono as Telefono, concat(d.marca, ' ', d.modelo) as Dispositivo, u.nombre as Tecnico, o.fecha_ingreso as Ingreso, o.trabajo_realizado as TrabajoRealizado from ordenes o inner join clientes c on o.cliente_id = c.id inner join dispositivos d on o.dispositivo_id = d.id left join usuarios u on o.tecnico_id = u.id where o.id = " + idOrden;
            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];

                pnlResumen.Visible = true;
                pnlTrabajoRealizado.Visible = true;
                pnlDesgloseCosto.Visible = true;
                pnlFormaDePago.Visible = true;
                btnRegistraEntrega.Visible = true;
                btnComprobante.Visible = false;

                lblNumeroOrden.Text = fila["numero_orden"] != DBNull.Value ? fila["numero_orden"].ToString() : "S/N";
                lblCliente.Text = fila["Cliente"] != DBNull.Value ? fila["Cliente"].ToString() : "";
                lblCedula.Text = fila["Cedula"] != DBNull.Value ? fila["Cedula"].ToString() : "";
                lblTelefono.Text = fila["Telefono"] != DBNull.Value ? fila["Telefono"].ToString() : "";
                lblDispositivo.Text = fila["Dispositivo"] != DBNull.Value ? fila["Dispositivo"].ToString() : "Sin dispositivo";
                lblTecnicoAsignado.Text = fila["Tecnico"] != DBNull.Value ? fila["Tecnico"].ToString() : "Sin técnico";

                if (fila["Ingreso"] != DBNull.Value)
                {
                    DateTime fechaIngreso = Convert.ToDateTime(fila["Ingreso"]);
                    lblFechaIngreso.Text = fechaIngreso.ToString("dd/MM/yyyy HH:mm");
                }
                else
                {
                    lblFechaIngreso.Text = "Sin fecha";
                }

                lblDescripcionTrabajo.Text = fila["TrabajoRealizado"] != DBNull.Value ? fila["TrabajoRealizado"].ToString() : "Sin observaciones registradas.";
                CargarDesgloseCostos(idOrden);
            }
        }

        private void ucDevolucion_Load(object sender, EventArgs e)
        {
            if (cmbFormaPago.Items.Count > 0)
                cmbFormaPago.SelectedIndex = 0;

            OcultarPaneles();
            CargarClientesListos();
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

        private void CargarClientesListos()
        {
            string sucursal = Sesion.SucursalActual.Replace("'", "''");

            string consulta = @"
            SELECT DISTINCT
            c.id,
            c.nombre + ' - ' + ISNULL(c.cedula_pasaporte, 'Sin cédula') AS Cliente
            FROM clientes c
            INNER JOIN ordenes o
            ON o.cliente_id = c.id
            WHERE o.estado = 'Listo'
            AND o.sucursal = '" + sucursal + @"'
            ORDER BY Cliente";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            cmbBuscarCliente.SelectedIndexChanged -= cmbBuscarCliente_SelectedIndexChanged;

            cmbBuscarCliente.DataSource = dt;
            cmbBuscarCliente.DisplayMember = "Cliente";
            cmbBuscarCliente.ValueMember = "id";

            cmbBuscarCliente.SelectedIndex = -1;

            cmbBuscarCliente.SelectedIndexChanged += cmbBuscarCliente_SelectedIndexChanged;
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

            string consultaRepuestos = "select r.nombrerepuesto as NombreRepuesto, d.cantidad as Cantidad, d.preciocobrado as PrecioCobrado from detallesorden d inner join repuestos r on d.idrepuesto = r.idrepuesto where d.idorden = " + idOrden;
            DataTable dtRepuestos = oCon.retornarRegistrosUsuarios(consultaRepuestos);

            if (dtRepuestos != null)
            {
                foreach (DataRow fila in dtRepuestos.Rows)
                {
                    string descripcion = fila["NombreRepuesto"] != DBNull.Value ? fila["NombreRepuesto"].ToString() : "Repuesto";
                    int cantidad = fila["Cantidad"] != DBNull.Value ? Convert.ToInt32(fila["Cantidad"]) : 1;
                    decimal precioUnitario = fila["PrecioCobrado"] != DBNull.Value ? Convert.ToDecimal(fila["PrecioCobrado"]) : 0;
                    decimal subtotal = precioUnitario * cantidad;
                    string descripcionFila = cantidad > 1 ? descripcion + " x" + cantidad : descripcion;

                    dgvDesglose.Rows.Add(descripcionFila, "$" + subtotal.ToString("F2"));
                    totalCosto += subtotal;
                }
            }

            string consultaManoObra = "select isnull(costo_estimado, 0) as ManoObra from ordenes where id = " + idOrden;
            DataTable dtManoObra = oCon.retornarRegistrosUsuarios(consultaManoObra);

            if (dtManoObra != null && dtManoObra.Rows.Count > 0)
            {
                decimal costoManoObra = Convert.ToDecimal(dtManoObra.Rows[0]["ManoObra"]);

                if (costoManoObra > 0)
                {
                    dgvDesglose.Rows.Add("Mano de obra", "$" + costoManoObra.ToString("F2"));
                    totalCosto += costoManoObra;
                }
            }

            lblTotalDesglose.Text = "$" + totalCosto.ToString("F2");
            lblTotalCobrar.Text = "$" + totalCosto.ToString("F2");
            totalOrden = totalCosto;
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

            if (cmbFormaPago.SelectedItem == null || cmbFormaPago.SelectedItem.ToString() == "Seleccionar...")
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
                    string consulta = "update ordenes set forma_pago = @formaPago, monto_pagado = @montoPagado, fecha_entrega = getdate(), comprobante_pago = @comprobante, nombre_comprobante = @nombreComprobante, estado = 'Entregado' where id = @idOrden and estado = 'Listo' and sucursal = @sucursal";

                    using (SqlCommand cmd = new SqlCommand(consulta, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@formaPago", formaPago);
                        cmd.Parameters.AddWithValue("@montoPagado", totalOrden);
                        cmd.Parameters.AddWithValue("@idOrden", idOrden);
                        cmd.Parameters.AddWithValue("@sucursal", Sesion.SucursalActual);
                        cmd.Parameters.Add("@comprobante", SqlDbType.VarBinary, -1).Value = (object?)comprobantePago ?? DBNull.Value;
                        cmd.Parameters.AddWithValue("@nombreComprobante", string.IsNullOrEmpty(nombreComprobante) ? DBNull.Value : nombreComprobante);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            string numeroFactura =
                                lblNumeroOrden.Text.Replace("ORD-", "FAC-");

                            GuardarFactura(
                                db.oCon,
                                idOrden,
                                numeroFactura,
                                formaPago
                            );

                            MessageBox.Show(
                                "La entrega fue registrada correctamente.",
                                "Entrega registrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            List<DetalleFactura> detallesFactura =
                                new List<DetalleFactura>();

                            foreach (DataGridViewRow fila in dgvDesglose.Rows)
                            {
                                if (fila.IsNewRow)
                                    continue;

                                detallesFactura.Add(new DetalleFactura
                                {
                                    Descripcion = fila.Cells[0].Value?.ToString() ?? "",
                                    Valor = fila.Cells[1].Value?.ToString() ?? "$0.00"
                                });
                            }
                            frmFactura factura = new frmFactura(
                            numeroFactura,
                            lblNumeroOrden.Text,
                            lblCedula.Text,
                            lblCliente.Text,
                            lblTelefono.Text,
                            lblDispositivo.Text,
                            lblTecnicoAsignado.Text,
                            formaPago,
                            detallesFactura,
                            totalOrden
);
                            byte[] pdfBytes = factura.GenerarPDF();

                            string nombreFactura = numeroFactura + ".pdf";

                            GuardarPdfFactura(
                                db.oCon,
                                idOrden,
                                pdfBytes,
                                nombreFactura
                            );
                            factura.ShowDialog();

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
                if (db.oCon != null && db.oCon.State == ConnectionState.Open)
                {
                    db.cerrarConexion();
                }
            }
        }
        private void GuardarPdfFactura(
        SqlConnection conexion,
        int idOrden,
        byte[] pdfBytes,
        string nombreFactura)
        {
            string consulta = @"
        UPDATE facturas
        SET factura_pdf = @facturaPdf,
            nombre_factura = @nombreFactura
        WHERE orden_id = @idOrden";

            using (SqlCommand cmd = new SqlCommand(consulta, conexion))
            {
                cmd.Parameters.Add(
                    "@facturaPdf",
                    SqlDbType.VarBinary,
                    -1
                ).Value = pdfBytes;

                cmd.Parameters.AddWithValue(
                    "@nombreFactura",
                    nombreFactura
                );

                cmd.Parameters.AddWithValue(
                    "@idOrden",
                    idOrden
                );

                cmd.ExecuteNonQuery();
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
        private void GuardarFactura(
        SqlConnection conexion,
        int idOrden,
        string numeroFactura,
        string formaPago)
        {
            string sqlFactura = @"
        INSERT INTO facturas
        (
            orden_id,
            numero_factura,
            forma_pago,
            total
        )
        OUTPUT INSERTED.id
        VALUES
        (
            @ordenId,
            @numeroFactura,
            @formaPago,
            @total
        )";

            int idFactura;

            using (SqlCommand cmdFactura = new SqlCommand(sqlFactura, conexion))
            {
                cmdFactura.Parameters.AddWithValue("@ordenId", idOrden);
                cmdFactura.Parameters.AddWithValue("@numeroFactura", numeroFactura);
                cmdFactura.Parameters.AddWithValue("@formaPago", formaPago);
                cmdFactura.Parameters.AddWithValue("@total", totalOrden);

                idFactura = Convert.ToInt32(cmdFactura.ExecuteScalar());
            }

            foreach (DataGridViewRow fila in dgvDesglose.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                string descripcion =
                    fila.Cells[0].Value?.ToString() ?? "";

                string valorTexto =
                    fila.Cells[1].Value?.ToString() ?? "0";

                valorTexto = valorTexto
                    .Replace("$", "")
                    .Trim();

                decimal valor = 0;

                decimal.TryParse(
                    valorTexto,
                    NumberStyles.Any,
                    CultureInfo.CurrentCulture,
                    out valor
                );

                string sqlDetalle = @"
            INSERT INTO detalle_factura
            (
                factura_id,
                descripcion,
                valor
            )
            VALUES
            (
                @facturaId,
                @descripcion,
                @valor
            )";

                using (SqlCommand cmdDetalle =
                    new SqlCommand(sqlDetalle, conexion))
                {
                    cmdDetalle.Parameters.AddWithValue(
                        "@facturaId",
                        idFactura
                    );

                    cmdDetalle.Parameters.AddWithValue(
                        "@descripcion",
                        descripcion
                    );

                    cmdDetalle.Parameters.AddWithValue(
                        "@valor",
                        valor
                    );

                    cmdDetalle.ExecuteNonQuery();
                }
            }
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
            CargarClientesListos();
        }

        private void cmbBuscarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarCliente.SelectedValue == null)
                return;

            if (!int.TryParse(
                cmbBuscarCliente.SelectedValue.ToString(),
                out int idCliente))
            {
                return;
            }

            CargarOrdenesCliente(idCliente);
        }
        private void CargarOrdenesCliente(int idCliente)
        {
            string sucursal = Sesion.SucursalActual.Replace("'", "''");

            string consulta = @"
            SELECT
            o.id,
            o.numero_orden
            FROM ordenes o
            WHERE o.cliente_id = " + idCliente + @"
            AND o.estado = 'Listo'
            AND o.sucursal = '" + sucursal + @"'
            ORDER BY o.fecha_ingreso DESC";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            cmbListaOrdenes.SelectedIndexChanged -=
                cmbListaOrdenes_SelectedIndexChanged;

            cmbListaOrdenes.DataSource = dt;
            cmbListaOrdenes.DisplayMember = "numero_orden";
            cmbListaOrdenes.ValueMember = "id";

            cmbListaOrdenes.SelectedIndexChanged +=
                cmbListaOrdenes_SelectedIndexChanged;

            if (dt != null && dt.Rows.Count > 0)
            {
                cmbListaOrdenes.SelectedIndex = 0;

                int idOrden =
                    Convert.ToInt32(cmbListaOrdenes.SelectedValue);

                CargarDetallesOrden(idOrden);
            }
            else
            {
                cmbListaOrdenes.DataSource = null;

                LimpiarCamposResumen();
                OcultarPaneles();
            }
        }
    }
}
