using System.Data;
using System.IO;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucHistorialClientes : UserControl
    {
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();
        public ucHistorialClientes()
        {
            InitializeComponent();

            AplicarDiseñoGrid();

            dgvClientesNuevo.RowPostPaint +=
                dgvClientesNuevo_RowPostPaint;

            dgvNuevoHistorial.CellContentClick -= dgvNuevoHistorial_CellContentClick;
            dgvNuevoHistorial.CellContentClick += dgvNuevoHistorial_CellContentClick;
        }

        private void AplicarDiseñoGrid()
        {

            dgvClientesNuevo.BackgroundColor = Color.White;
            dgvClientesNuevo.BorderStyle = BorderStyle.None;

            dgvClientesNuevo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientesNuevo.GridColor = Color.FromArgb(225, 230, 235);

            dgvClientesNuevo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientesNuevo.MultiSelect = false;

            dgvClientesNuevo.ColumnHeadersVisible = false;
            dgvClientesNuevo.RowHeadersVisible = false;

            dgvClientesNuevo.AllowUserToAddRows = false;
            dgvClientesNuevo.AllowUserToDeleteRows = false;
            dgvClientesNuevo.AllowUserToResizeRows = false;
            dgvClientesNuevo.ReadOnly = true;

            dgvClientesNuevo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvClientesNuevo.RowTemplate.Height = 74;

            dgvClientesNuevo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewCellStyle estiloCliente = new DataGridViewCellStyle();

            estiloCliente.BackColor = Color.White;
            estiloCliente.ForeColor = Color.FromArgb(24, 43, 62);

            estiloCliente.Font = new Font(
                "Segoe UI",
                9.5F,
                FontStyle.Regular
            );

            // Cliente seleccionado
            estiloCliente.SelectionBackColor = Color.FromArgb(232, 248, 247);
            estiloCliente.SelectionForeColor = Color.FromArgb(24, 43, 62);

            estiloCliente.Padding = new Padding(
                16, 10, 12, 10
            );

            estiloCliente.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvClientesNuevo.RowsDefaultCellStyle = estiloCliente;



            dgvClientesNuevo.EnableHeadersVisualStyles = false;


            dgvNuevoHistorial.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvNuevoHistorial.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvNuevoHistorial.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvNuevoHistorial.ColumnHeadersHeight = 50;
            dgvNuevoHistorial.RowTemplate.Height = 60;

            dgvNuevoHistorial.EnableHeadersVisualStyles = false;

            DataGridViewCellStyle estiloEncabezadoDer =
                new DataGridViewCellStyle();

            estiloEncabezadoDer.BackColor = Color.White;
            estiloEncabezadoDer.ForeColor = Color.FromArgb(70, 86, 103);
            estiloEncabezadoDer.Font =
                new Font("Segoe UI", 8.5F, FontStyle.Bold);

            estiloEncabezadoDer.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            estiloEncabezadoDer.SelectionBackColor = Color.White;
            estiloEncabezadoDer.SelectionForeColor =
                Color.FromArgb(70, 86, 103);

            dgvNuevoHistorial.ColumnHeadersDefaultCellStyle =
                estiloEncabezadoDer;

            dgvNuevoHistorial.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            DataGridViewCellStyle estiloFilaDer =
                new DataGridViewCellStyle();

            estiloFilaDer.BackColor = Color.White;
            estiloFilaDer.ForeColor = Color.FromArgb(24, 43, 62);
            estiloFilaDer.Font =
                new Font("Segoe UI", 9.5F, FontStyle.Regular);

            estiloFilaDer.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            estiloFilaDer.SelectionBackColor =
                Color.FromArgb(248, 250, 252);

            estiloFilaDer.SelectionForeColor =
                Color.FromArgb(24, 43, 62);

            dgvNuevoHistorial.RowsDefaultCellStyle = estiloFilaDer;

            dgvNuevoHistorial.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;
        }

        private void ucHistorialClientes_Load(object sender, EventArgs e)
        {
            dgvClientesNuevo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientesNuevo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            CargarListaClientes("");
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string valorBusqueda = txtBuscar.Text.Trim();
            CargarListaClientes(valorBusqueda);
        }

        private void CargarListaClientes(string busqueda)
        {
            DataTable HistorialClientes = oCon.retornarRegistrosUsuarios(@"
        SELECT 
            C.id, 
            C.nombre + CHAR(13) + CHAR(10) + 
            ISNULL(C.cedula_pasaporte, 'Sin cédula') + CHAR(13) + CHAR(10) + 
            CAST(COUNT(O.id) AS VARCHAR) + ' órdenes' AS InfoCliente,
            C.nombre,
            C.telefono,
            C.correo,
            C.cedula_pasaporte
        FROM Clientes C
        LEFT JOIN ordenes O ON C.id = O.cliente_id
        WHERE C.nombre LIKE '%" + busqueda + @"%' 
           OR C.cedula_pasaporte LIKE '%" + busqueda + @"%'
           OR C.correo LIKE '%" + busqueda + @"%'
        GROUP BY C.id, C.nombre, C.telefono, C.correo, C.cedula_pasaporte
        ORDER BY C.nombre");

            dgvClientesNuevo.Columns.Clear();
            dgvClientesNuevo.AutoGenerateColumns = false;

            dgvClientesNuevo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InfoCliente",
                Name = "InfoCliente",
                HeaderText = "Clientes",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClientesNuevo.DataSource = HistorialClientes;
            dgvClientesNuevo.ClearSelection();
        }


        private void dgvClientesNuevo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataRowView filaSeleccionada = (DataRowView)dgvClientesNuevo.Rows[e.RowIndex].DataBoundItem;
                    if (filaSeleccionada == null) return;

                    int idCliente = Convert.ToInt32(filaSeleccionada["id"]);
                    string nombre = filaSeleccionada["nombre"].ToString();
                    string correo = filaSeleccionada["correo"].ToString();
                    string cedula = filaSeleccionada["cedula_pasaporte"].ToString(); // Capturamos la cédula

                    if (lblNombreCompleto != null) lblNombreCompleto.Text = nombre;
                    if (lblContacto != null) lblContacto.Text = cedula; // Refleja la cédula en lugar del teléfono
                    if (lblCorreo != null) lblCorreo.Text = correo;

                    if (pnlHistorial != null)
                    {
                        pnlHistorial.Visible = true;
                        pnlHistorial.BringToFront();
                    }

                    CargarHistorialOrdenes(idCliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al cargar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHistorialOrdenes(int idCliente)
        {
            string consulta = @"
            SELECT
            o.numero_orden AS ORDEN,
            CONVERT(varchar, o.fecha_ingreso, 103) AS FECHA,
            d.marca + ' ' + d.modelo AS DISPOSITIVO,
            ISNULL(o.descripcion_problema, 'Reparación general') AS REPARACIÓN,
            ISNULL(o.costo_estimado, 0) AS COSTO,
            o.estado AS ESTADO,
            ISNULL(u.nombre, 'Sin asignar') AS TÉCNICO,
            ISNULL(o.forma_pago, '') AS FORMA_PAGO,
            o.comprobante_pago AS COMPROBANTE,
            o.nombre_comprobante AS NOMBRE_COMPROBANTE,
            f.factura_pdf AS FACTURA_PDF,
            f.nombre_factura AS NOMBRE_FACTURA,
            f.numero_factura AS NUMERO_FACTURA
            FROM ordenes o
            INNER JOIN dispositivos d
            ON o.dispositivo_id = d.id
            LEFT JOIN usuarios u
            ON o.tecnico_id = u.id
            LEFT JOIN facturas f
            ON f.orden_id = o.id
            WHERE o.cliente_id = " + idCliente + @"
            ORDER BY o.fecha_ingreso DESC";

            DataTable HistorialClientes = oCon.retornarRegistrosUsuarios(consulta);

            dgvNuevoHistorial.Columns.Clear();
            dgvNuevoHistorial.AutoGenerateColumns = true;
            dgvNuevoHistorial.DataSource = HistorialClientes;

            if (dgvNuevoHistorial.Columns.Count > 0)
            {
                dgvNuevoHistorial.Columns["ORDEN"].Width = 130;
                dgvNuevoHistorial.Columns["ORDEN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvNuevoHistorial.Columns["FECHA"].Width = 100;

                dgvNuevoHistorial.Columns["DISPOSITIVO"].Width = 180;
                dgvNuevoHistorial.Columns["DISPOSITIVO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvNuevoHistorial.Columns["REPARACIÓN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvNuevoHistorial.Columns["REPARACIÓN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvNuevoHistorial.Columns["COSTO"].Width = 90;
                dgvNuevoHistorial.Columns["ESTADO"].Width = 130;
                dgvNuevoHistorial.Columns["TÉCNICO"].Width = 140;

                dgvNuevoHistorial.Columns["FORMA_PAGO"].Visible = false;
                dgvNuevoHistorial.Columns["COMPROBANTE"].Visible = false;
                dgvNuevoHistorial.Columns["NOMBRE_COMPROBANTE"].Visible = false;

                dgvNuevoHistorial.Columns["FACTURA_PDF"].Visible = false;
                dgvNuevoHistorial.Columns["NOMBRE_FACTURA"].Visible = false;
                dgvNuevoHistorial.Columns["NUMERO_FACTURA"].Visible = false;
            }

            DataGridViewButtonColumn btnComprobante = new DataGridViewButtonColumn
            {
                Name = "VER_COMPROBANTE",
                HeaderText = "COMPROBANTE",
                Width = 120,
                FlatStyle = FlatStyle.Flat,
                UseColumnTextForButtonValue = false
            };
            DataGridViewButtonColumn btnFactura = new DataGridViewButtonColumn
            {
                Name = "VER_FACTURA",
                HeaderText = "FACTURA",
                Width = 110,
                FlatStyle = FlatStyle.Flat,
                UseColumnTextForButtonValue = false
            };

            btnFactura.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvNuevoHistorial.Columns.Add(btnFactura);

            btnComprobante.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNuevoHistorial.Columns.Add(btnComprobante);

            if (lblTotalVisitas != null)
                lblTotalVisitas.Text = HistorialClientes.Rows.Count.ToString();

            decimal totalGastado = 0;

            foreach (DataRow row in HistorialClientes.Rows)
            {
                totalGastado += Convert.ToDecimal(row["COSTO"]);
            }

            if (lblTotalGastado != null)
                lblTotalGastado.Text = $"${totalGastado:0.00}";

            dgvNuevoHistorial.ClearSelection();
        }

        private void dgvNuevoHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string nombreColumna = dgvNuevoHistorial.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "ORDEN" && e.Value != null)
            {
                e.CellStyle.ForeColor = Color.FromArgb(0, 160, 130);
                e.CellStyle.Font = new Font(dgvNuevoHistorial.Font, FontStyle.Bold);
            }

            if (nombreColumna == "COSTO" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                {
                    e.Value = $"${valor:N0}";
                    e.CellStyle.ForeColor = Color.FromArgb(80, 80, 80);
                    e.CellStyle.Font = new Font(dgvNuevoHistorial.Font, FontStyle.Bold);
                    e.FormattingApplied = true;
                }
            }

            if (nombreColumna == "VER_COMPROBANTE")
            {
                DataGridViewRow fila = dgvNuevoHistorial.Rows[e.RowIndex];

                string formaPago = fila.Cells["FORMA_PAGO"].Value?.ToString() ?? "";
                object comprobante = fila.Cells["COMPROBANTE"].Value;

                bool tieneComprobante =
                    formaPago.Equals("Transferencia", StringComparison.OrdinalIgnoreCase) &&
                    comprobante != null &&
                    comprobante != DBNull.Value;

                e.Value = tieneComprobante ? "Ver" : "—";

                if (tieneComprobante)
                {
                    e.CellStyle.ForeColor = Color.FromArgb(0, 165, 155);
                    e.CellStyle.Font = new Font(dgvNuevoHistorial.Font, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(140, 150, 160);
                }

                e.FormattingApplied = true;
            }
            if (nombreColumna == "VER_FACTURA")
            {
                DataGridViewRow fila =
                    dgvNuevoHistorial.Rows[e.RowIndex];

                object factura =
                    fila.Cells["FACTURA_PDF"].Value;

                bool tieneFactura =
                    factura != null &&
                    factura != DBNull.Value;

                e.Value = tieneFactura ? "Ver" : "—";

                if (tieneFactura)
                {
                    e.CellStyle.ForeColor =
                        Color.FromArgb(0, 165, 155);

                    e.CellStyle.Font =
                        new Font(
                            dgvNuevoHistorial.Font,
                            FontStyle.Bold
                        );
                }
                else
                {
                    e.CellStyle.ForeColor =
                        Color.FromArgb(140, 150, 160);
                }

                e.FormattingApplied = true;
            }
        }

        private void dgvNuevoHistorial_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string nombreColumna = dgvNuevoHistorial.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "ESTADO")
            {
                string estado = e.Value?.ToString() ?? "";
                Color colorPrincipal = Color.Gray;
                Color colorFondo = Color.White;

                if (estado.ToLower().Contains("reparación") || estado.ToLower().Contains("diagnóstico"))
                {
                    colorPrincipal = Color.FromArgb(230, 140, 0);
                    colorFondo = Color.FromArgb(255, 245, 230);
                }
                else if (estado.ToLower().Contains("entregado") || estado.ToLower().Contains("listo"))
                {
                    colorPrincipal = Color.FromArgb(140, 80, 220);
                    colorFondo = Color.FromArgb(245, 240, 255);
                }
                else
                {
                    colorPrincipal = Color.FromArgb(40, 180, 90);
                    colorFondo = Color.FromArgb(235, 252, 240);
                }

                e.PaintBackground(e.CellBounds, true);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                int altoBadge = 26;
                using (Font f = new Font("Segoe UI", 9F, FontStyle.Regular))
                {
                    int anchoTexto = (int)e.Graphics.MeasureString(estado, f).Width;
                    int anchoBadge = anchoTexto + 24;

                    int x = e.CellBounds.Left + (e.CellBounds.Width - anchoBadge) / 2;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - altoBadge) / 2;

                    using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                    {
                        int radio = 12;
                        path.AddArc(x, y, radio, radio, 180, 90);
                        path.AddArc(x + anchoBadge - radio, y, radio, radio, 270, 90);
                        path.AddArc(x + anchoBadge - radio, y + altoBadge - radio, radio, radio, 0, 90);
                        path.AddArc(x, y + altoBadge - radio, radio, radio, 90, 90);
                        path.CloseFigure();

                        using (SolidBrush bgBrush = new SolidBrush(colorFondo))
                        {
                            e.Graphics.FillPath(bgBrush, path);
                        }
                        using (Pen pen = new Pen(colorPrincipal, 1f))
                        {
                            e.Graphics.DrawPath(pen, path);
                        }
                    }

                    using (SolidBrush textBrush = new SolidBrush(colorPrincipal))
                    {
                        float textX = x + (anchoBadge - anchoTexto) / 2;
                        float textY = y + (altoBadge - f.Height) / 2 + 1;
                        e.Graphics.DrawString(estado, f, textBrush, textX, textY);
                    }
                }

                e.Handled = true;
            }
        }

        private void dgvNuevoHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string nombreColumna =
                dgvNuevoHistorial.Columns[e.ColumnIndex].Name;

            DataGridViewRow fila =
                dgvNuevoHistorial.Rows[e.RowIndex];

            if (nombreColumna == "VER_COMPROBANTE")
            {
                string formaPago =
                    fila.Cells["FORMA_PAGO"].Value?.ToString() ?? "";

                object valorComprobante =
                    fila.Cells["COMPROBANTE"].Value;

                if (!formaPago.Equals(
                    "Transferencia",
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Esta orden no fue pagada mediante transferencia.",
                        "Comprobante",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                if (valorComprobante == null ||
                    valorComprobante == DBNull.Value)
                {
                    MessageBox.Show(
                        "Esta orden no tiene un comprobante registrado.",
                        "Comprobante",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                byte[] imagenBytes =
                    (byte[])valorComprobante;

                string nombreArchivo =
                    fila.Cells["NOMBRE_COMPROBANTE"]
                        .Value?.ToString() ?? "Comprobante";

                MostrarComprobante(
                    imagenBytes,
                    nombreArchivo
                );

                return;
            }
            if (nombreColumna == "VER_FACTURA")
            {
                object valorFactura =
                    fila.Cells["FACTURA_PDF"].Value;

                if (valorFactura == null ||
                    valorFactura == DBNull.Value)
                {
                    MessageBox.Show(
                        "Esta orden no tiene una factura registrada.",
                        "Factura",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                byte[] facturaBytes =
                    (byte[])valorFactura;

                string nombreFactura =
                    fila.Cells["NOMBRE_FACTURA"]
                        .Value?.ToString() ?? "Factura.pdf";

                MostrarFacturaPDF(
                    facturaBytes,
                    nombreFactura
                );

                return;
            }
        }
        private void MostrarComprobante(byte[] imagenBytes, string nombreArchivo)
        {
            try
            {
                using MemoryStream ms = new MemoryStream(imagenBytes);
                using Image imagenTemporal = Image.FromStream(ms);

                Bitmap imagen = new Bitmap(imagenTemporal);

                Form frm = new Form
                {
                    Text = "TECH DKV - Comprobante de pago",
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(750, 650),
                    BackColor = Color.White,
                    MinimizeBox = false,
                    MaximizeBox = true
                };

                Label lblNombre = new Label
                {
                    Text = nombreArchivo,
                    Dock = DockStyle.Top,
                    Height = 45,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(24, 43, 62),
                    BackColor = Color.White
                };

                PictureBox pic = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = imagen,
                    BackColor = Color.FromArgb(245, 247, 249)
                };

                frm.Controls.Add(pic);
                frm.Controls.Add(lblNombre);

                frm.FormClosed += (s, e) =>
                {
                    pic.Image?.Dispose();
                };

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo mostrar el comprobante: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblContacto.Text))
            {
                MessageBox.Show("Por favor, seleccione un cliente del listado para poder editarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cedulaCliente = lblContacto.Text;

            frmEditarCliente EditarCLiente = new frmEditarCliente(cedulaCliente);

            if (EditarCLiente.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Datos del cliente actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaClientes("");
            }
        }

        private void dgvClientesNuevo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewRow fila = dgvClientesNuevo.Rows[e.RowIndex];

            if (fila.Selected)
            {
                using (SolidBrush brush =
                    new SolidBrush(Color.FromArgb(0, 165, 155)))
                {
                    e.Graphics.FillRectangle(
                        brush,
                        e.RowBounds.Left,
                        e.RowBounds.Top,
                        4,
                        e.RowBounds.Height
                    );
                }
            }
        }
        private void MostrarFacturaPDF(
        byte[] pdfBytes,
        string nombreArchivo)
        {
            try
            {
                if (!nombreArchivo.EndsWith(
                    ".pdf",
                    StringComparison.OrdinalIgnoreCase))
                {
                    nombreArchivo += ".pdf";
                }

                string rutaTemporal = Path.Combine(
                    Path.GetTempPath(),
                    nombreArchivo
                );

                File.WriteAllBytes(
                    rutaTemporal,
                    pdfBytes
                );

                System.Diagnostics.Process.Start(
                    new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = rutaTemporal,
                        UseShellExecute = true
                    }
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo abrir la factura: " + ex.Message,
                    "Factura",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvClientesNuevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}