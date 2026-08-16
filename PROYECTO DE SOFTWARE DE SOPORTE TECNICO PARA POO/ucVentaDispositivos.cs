using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucVentaDispositivos : UserControl
    {
        public ucVentaDispositivos()
        {
            InitializeComponent();
            AplicarDiseñoGrid();
        }

        // --- 1. DISEÑO BASE: FUERZA BRUTA CONTRA LOS BORDES ---
        private void AplicarDiseñoGrid()
        {
            dgvNuevo.BackgroundColor = Color.White;
            dgvNuevo.BorderStyle = BorderStyle.None;

            // 🔥 APAGAMOS TOTALMENTE LOS BORDES NATIVOS
            dgvNuevo.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvNuevo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNuevo.RowHeadersVisible = false;

            dgvNuevo.AllowUserToAddRows = false;
            dgvNuevo.AllowUserToDeleteRows = false;
            dgvNuevo.AllowUserToResizeRows = false;
            dgvNuevo.AllowUserToResizeColumns = false;
            dgvNuevo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvNuevo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNuevo.ColumnHeadersHeight = 50;
            dgvNuevo.RowTemplate.Height = 55;

            dgvNuevo.EnableHeadersVisualStyles = false;

            DataGridViewCellStyle estiloEncabezado = new DataGridViewCellStyle();
            estiloEncabezado.BackColor = Color.White;
            estiloEncabezado.ForeColor = Color.FromArgb(100, 100, 100);
            estiloEncabezado.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            estiloEncabezado.Alignment = DataGridViewContentAlignment.MiddleLeft;
            estiloEncabezado.Padding = new Padding(15, 0, 0, 0);
            estiloEncabezado.SelectionBackColor = Color.White;
            estiloEncabezado.SelectionForeColor = Color.FromArgb(100, 100, 100);
            dgvNuevo.ColumnHeadersDefaultCellStyle = estiloEncabezado;

            DataGridViewCellStyle estiloFila = new DataGridViewCellStyle();
            estiloFila.BackColor = Color.White;
            estiloFila.ForeColor = Color.FromArgb(60, 60, 60);
            estiloFila.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            estiloFila.Alignment = DataGridViewContentAlignment.MiddleLeft;
            estiloFila.Padding = new Padding(15, 0, 0, 0);
            estiloFila.SelectionBackColor = Color.FromArgb(248, 250, 252);
            estiloFila.SelectionForeColor = Color.FromArgb(60, 60, 60);
            dgvNuevo.RowsDefaultCellStyle = estiloFila;
            dgvNuevo.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // Aseguramos que los eventos estén conectados
            dgvNuevo.DataBindingComplete += DgvNuevo_DataBindingComplete;
            dgvNuevo.RowPostPaint += DgvNuevo_RowPostPaint;
        }

        private void ucVentaDispositivos_Load(object sender, EventArgs e)
        {
            dgvNuevo.BorderStyle = BorderStyle.None;
            dgvNuevo.GridColor = Color.FromArgb(230, 230, 230);
            dgvNuevo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNuevo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNuevo.RowHeadersVisible = false;
            CargarVentas();
        }

        // --- 2. CARGAR DATOS ---
        public void CargarVentas(string filtro = "")
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string query = @"
                        SELECT 
                            TipoVenta AS TIPO, 
                            MarcaNuevo + ' ' + ModeloNuevo AS DISPOSITIVO, 
                            EstadoEquipo AS ESTADO, 
                            PrecioOriginal AS PRECIO, 
                            NombreCliente AS COMPRADOR, 
                            FormaPago AS PAGO, 
                            GarantiaOfrecida AS GARANTÍA, 
                            FORMAT(FechaVenta, 'dd/MM/yyyy H:mm') AS FECHA 
                        FROM VentasDirectas";

                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        query += " WHERE NombreCliente LIKE @filtro OR CedulaCliente LIKE @filtro OR MarcaNuevo LIKE @filtro OR ModeloNuevo LIKE @filtro";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro))
                        {
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro.Trim() + "%");
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvNuevo.Columns.Clear();
                        dgvNuevo.AutoGenerateColumns = true;
                        dgvNuevo.DataSource = dt;

                        if (!dgvNuevo.Columns.Contains("ACCIÓN"))
                        {
                            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                            btnEditar.Name = "ACCIÓN";
                            btnEditar.HeaderText = "";
                            btnEditar.Width = 90;
                            btnEditar.FlatStyle = FlatStyle.Flat;
                            dgvNuevo.Columns.Add(btnEditar);
                        }

                        // 🔥 FORZAMOS ALINEACIÓN IZQUIERDA Y PADDING A CADA COLUMNA INDIVIDUALMENTE
                        foreach (DataGridViewColumn col in dgvNuevo.Columns)
                        {
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            col.DefaultCellStyle.Padding = new Padding(15, 0, 0, 0);
                        }

                        if (dgvNuevo.Columns.Count > 0)
                        {
                            if (dgvNuevo.Columns.Contains("TIPO")) dgvNuevo.Columns["TIPO"].Width = 100;
                            if (dgvNuevo.Columns.Contains("DISPOSITIVO")) dgvNuevo.Columns["DISPOSITIVO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            if (dgvNuevo.Columns.Contains("ESTADO")) dgvNuevo.Columns["ESTADO"].Width = 110;
                            if (dgvNuevo.Columns.Contains("PRECIO")) dgvNuevo.Columns["PRECIO"].Width = 100;
                            if (dgvNuevo.Columns.Contains("COMPRADOR")) dgvNuevo.Columns["COMPRADOR"].Width = 160;
                            if (dgvNuevo.Columns.Contains("PAGO")) dgvNuevo.Columns["PAGO"].Width = 130;
                            if (dgvNuevo.Columns.Contains("GARANTÍA")) dgvNuevo.Columns["GARANTÍA"].Width = 110;
                            if (dgvNuevo.Columns.Contains("FECHA")) dgvNuevo.Columns["FECHA"].Width = 140;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        // --- 3. QUITAR EL FOCO INICIAL AZUL ---
        private void DgvNuevo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvNuevo.ClearSelection();
            dgvNuevo.CurrentCell = null;
        }

        // --- 4. DIBUJAR LA LÍNEA GRIS INFERIOR A LA FUERZA ---
        private void DgvNuevo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(240, 240, 240), 1))
            {
                int y = e.RowBounds.Bottom - 1;
                e.Graphics.DrawLine(pen, e.RowBounds.Left, y, e.RowBounds.Right, y);
            }
        }

        // --- 5. BÚSQUEDA Y NUEVA VENTA ---
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarVentas(txtBuscar.Text);
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            frmNuevaVenta formRegistro = new frmNuevaVenta();
            formRegistro.ShowDialog();
            CargarVentas();
        }

        // --- 6. FORMATO DE PRECIO ---
        private void dgvNuevo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Value != null)
            {
                string nombreColumna = dgvNuevo.Columns[e.ColumnIndex].Name;

                if (nombreColumna == "PRECIO")
                {
                    if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                    {
                        e.Value = $"${valor:N2}";
                        e.CellStyle.ForeColor = Color.FromArgb(0, 180, 110);
                        e.CellStyle.Font = new Font(dgvNuevo.Font, FontStyle.Bold);
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        // --- 7. DIBUJO DE PÍLDORAS (SIN EMOJIS PROBLEMÁTICOS) ---
        private void dgvNuevo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewPaintParts partesPintado = e.PaintParts & ~DataGridViewPaintParts.Focus;

            string nombreColumna = dgvNuevo.Columns[e.ColumnIndex].Name;
            string valorCelda = e.Value?.ToString() ?? "";

            // --- 1. CELDAS PERSONALIZADAS (PÍLDORAS Y BOTONES) ---
            if (nombreColumna == "TIPO" || nombreColumna == "ESTADO" || nombreColumna == "PAGO" || nombreColumna == "ACCIÓN")
            {
                partesPintado &= ~DataGridViewPaintParts.ContentForeground;
                e.Paint(e.CellBounds, partesPintado);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // A) PÍLDORAS
                if (nombreColumna == "TIPO" || nombreColumna == "ESTADO" || nombreColumna == "PAGO")
                {
                    Color colorTexto = Color.Gray;
                    Color colorFondo = Color.White;
                    string textoMostrar = valorCelda;

                    if (valorCelda.ToLower().Contains("nuevo") && !valorCelda.ToLower().Contains("semi"))
                    {
                        colorTexto = Color.FromArgb(0, 180, 110);
                        colorFondo = Color.FromArgb(235, 252, 240);
                    }
                    else if (valorCelda.ToLower().Contains("semi") || valorCelda.ToLower().Contains("mano"))
                    {
                        if (nombreColumna == "ESTADO")
                        {
                            colorTexto = Color.FromArgb(230, 160, 0);
                            colorFondo = Color.FromArgb(255, 250, 235);
                        }
                        else
                        {
                            colorTexto = Color.FromArgb(80, 140, 220);
                            colorFondo = Color.FromArgb(240, 245, 255);
                        }
                    }
                    else if (valorCelda.ToLower().Contains("efectivo"))
                    {
                        colorTexto = Color.FromArgb(0, 180, 110);
                        colorFondo = Color.FromArgb(235, 252, 240);
                    }
                    else if (valorCelda.ToLower().Contains("transferencia"))
                    {
                        colorTexto = Color.FromArgb(80, 140, 220);
                        colorFondo = Color.FromArgb(240, 245, 255);
                    }

                    int altoBadge = 24;
                    int anchoTexto = (int)e.Graphics.MeasureString(textoMostrar, e.CellStyle.Font).Width;
                    int anchoBadge = anchoTexto + 28;

                    int x = e.CellBounds.Left + 15;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - altoBadge) / 2;

                    using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                    {
                        int radio = 10;
                        path.AddArc(x, y, radio, radio, 180, 90);
                        path.AddArc(x + anchoBadge - radio, y, radio, radio, 270, 90);
                        path.AddArc(x + anchoBadge - radio, y + altoBadge - radio, radio, radio, 0, 90);
                        path.AddArc(x, y + altoBadge - radio, radio, radio, 90, 90);
                        path.CloseFigure();

                        using (SolidBrush bgBrush = new SolidBrush(colorFondo))
                            e.Graphics.FillPath(bgBrush, path);
                    }

                    using (SolidBrush textBrush = new SolidBrush(colorTexto))
                    {
                        float textX = x + (anchoBadge - anchoTexto) / 2;
                        float textY = y + (altoBadge - e.CellStyle.Font.Height) / 2 + 1;
                        e.Graphics.DrawString(textoMostrar, e.CellStyle.Font, textBrush, textX, textY);
                    }
                }

                // B) BOTÓN EDITAR
                else if (nombreColumna == "ACCIÓN")
                {
                    Color verdeElegante = Color.FromArgb(0, 180, 140);
                    string textoBtn = "✎ Editar";

                    int btnAncho = 75;
                    int btnAlto = 28;
                    int x = e.CellBounds.Left + (e.CellBounds.Width - btnAncho) / 2;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - btnAlto) / 2;

                    using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                    {
                        int radio = 6;
                        path.AddArc(x, y, radio, radio, 180, 90);
                        path.AddArc(x + btnAncho - radio, y, radio, radio, 270, 90);
                        path.AddArc(x + btnAncho - radio, y + btnAlto - radio, radio, radio, 0, 90);
                        path.AddArc(x, y + btnAlto - radio, radio, radio, 90, 90);
                        path.CloseFigure();

                        using (SolidBrush brush = new SolidBrush(Color.White))
                            e.Graphics.FillPath(brush, path);

                        using (Pen pen = new Pen(verdeElegante, 1.5f))
                            e.Graphics.DrawPath(pen, path);
                    }

                    using (Font fontBtn = new Font("Segoe UI", 9F, FontStyle.Regular))
                    using (SolidBrush textBrush = new SolidBrush(verdeElegante))
                    {
                        SizeF textSize = e.Graphics.MeasureString(textoBtn, fontBtn);
                        float textX = x + (btnAncho - textSize.Width) / 2;
                        float textY = y + (btnAlto - textSize.Height) / 2 + 1;
                        e.Graphics.DrawString(textoBtn, fontBtn, textBrush, textX, textY);
                    }
                }

                // Borde inferior suave para columnas personalizadas
                using (Pen pen = new Pen(Color.FromArgb(230, 230, 230), 1))
                {
                    e.Graphics.DrawLine(pen,
                        e.CellBounds.Left,
                        e.CellBounds.Bottom - 1,
                        e.CellBounds.Right,
                        e.CellBounds.Bottom - 1);
                }

                e.Handled = true;
            }
            // --- 2. CELDAS NORMALES ---
            else
            {
                e.Paint(e.CellBounds, partesPintado);

                // Borde inferior suave
                using (Pen pen = new Pen(Color.FromArgb(230, 230, 230), 1))
                {
                    e.Graphics.DrawLine(pen,
                        e.CellBounds.Left,
                        e.CellBounds.Bottom - 1,
                        e.CellBounds.Right,
                        e.CellBounds.Bottom - 1);
                }

                e.Handled = true;
            }
        }

        // --- 8. ACCIÓN CLIC EN BOTÓN EDITAR ---
        private void dgvNuevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvNuevo.Columns[e.ColumnIndex].Name == "ACCIÓN")
            {
                string comprador = dgvNuevo.Rows[e.RowIndex].Cells["COMPRADOR"].Value?.ToString() ?? "Desconocido";
                MessageBox.Show($"Abriendo panel para editar venta de: {comprador}", "Editar Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}