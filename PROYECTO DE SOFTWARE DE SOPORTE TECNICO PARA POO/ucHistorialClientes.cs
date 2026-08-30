using System.Data;

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
        }

        private void AplicarDiseñoGrid()
        {
            // =====================================================
            // LISTA DE CLIENTES - LADO IZQUIERDO
            // =====================================================

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

            // Evitar que WinForms cambie los colores automáticamente
            dgvClientesNuevo.EnableHeadersVisualStyles = false;

            // =====================================================
            // HISTORIAL - LADO DERECHO
            // =====================================================

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

        // --- 3. SELECCIÓN DE CLIENTE Y CARGA DEL HISTORIAL ---
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
            DataTable HistorialClientes = oCon.retornarRegistrosUsuarios(@"select
                        O.numero_orden as ORDEN,
                        convert(varchar, O.fecha_ingreso, 103) as FECHA,
                        D.marca + ' ' + D.modelo as DISPOSITIVO,
                        isnull(O.descripcion_problema, 'Reparación general') as REPARACIÓN,
                        isnull(O.costo_estimado, 0) as COSTO,
                        O.estado as ESTADO,
                        U.Nombre as TÉCNICO
                        from ordenes O
                        inner join dispositivos D on O.dispositivo_id = D.id
                        inner join Usuarios U on O.tecnico_id = U.Id
                        where O.cliente_id = " + idCliente + @"
                        order by O.fecha_ingreso desc");

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
            }

            if (lblTotalVisitas != null) lblTotalVisitas.Text = HistorialClientes.Rows.Count.ToString();

            decimal totalGastado = 0;
            foreach (DataRow row in HistorialClientes.Rows)
            {
                totalGastado += Convert.ToDecimal(row["COSTO"]);
            }
            if (lblTotalGastado != null) lblTotalGastado.Text = $"${totalGastado:0.00}";

            dgvNuevoHistorial.ClearSelection();
        }

        private void dgvNuevoHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Value != null)
            {
                string nombreColumna = dgvNuevoHistorial.Columns[e.ColumnIndex].Name;

                if (nombreColumna == "ORDEN")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(0, 160, 130);
                    e.CellStyle.Font = new Font(dgvNuevoHistorial.Font, FontStyle.Bold);
                }

                if (nombreColumna == "COSTO")
                {
                    if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                    {
                        e.Value = $"${valor:N0}";
                        e.CellStyle.ForeColor = Color.FromArgb(80, 80, 80);
                        e.CellStyle.Font = new Font(dgvNuevoHistorial.Font, FontStyle.Bold);
                        e.FormattingApplied = true;
                    }
                }
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
    }
}