using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucStock : UserControl
    {
        // Variables para controlar el botón de alertas
        private bool mostrandoAlertas = false;
        private int cantidadAlertas = 0;

        public ucStock()
        {
            InitializeComponent();
            AplicarDiseñoGrid();
        }

        // --- 1. DISEÑO BASE DE LA TABLA ESTILO WEB ---
        private void AplicarDiseñoGrid()
        {
            dgvNuevo.BackgroundColor = Color.White;
            dgvNuevo.BorderStyle = BorderStyle.None;
            dgvNuevo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNuevo.GridColor = Color.FromArgb(240, 240, 240);
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
            dgvNuevo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

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
        }

        private void ucStock_Load(object sender, EventArgs e)
        {
            if (cmbCategorias.Items.Count > 0)
                cmbCategorias.SelectedIndex = 0;

            CargarDatos();
        }

        // --- 2. CARGAR DATOS Y CREAR COLUMNAS PARA BOTONES ---
        private void CargarDatos()
        {
            // La consulta usa @SoloAlertas para filtrar si el botón está activo
            string query = @"
                SELECT 
                    R.NombreRepuesto AS NOMBRE, 
                    ISNULL(R.Categoria, '—') AS CATEGORÍA, 
                    ISNULL(R.Compatibilidad, '—') AS COMPATIBLE, 
                    CONCAT(I.StockActual, ' / ', I.StockMinimo) AS STOCK, 
                    R.PrecioCosto AS COSTO, 
                    R.PrecioVenta AS VENTA, 
                    ISNULL(R.Proveedor, '—') AS PROVEEDOR,
                    CASE 
                        WHEN I.StockActual = 0 THEN 'Sin stock'
                        WHEN I.StockActual <= I.StockMinimo THEN 'Stock bajo'
                        ELSE 'Normal'
                    END AS ESTADO
                FROM Repuestos R
                INNER JOIN InventarioSucursal I ON R.IdRepuesto = I.IdRepuesto
                WHERE (@SoloAlertas = 0 OR I.StockActual <= I.StockMinimo)";

            Conexion_Base_de_Datos conexionBD = new Conexion_Base_de_Datos();

            try
            {
                if (conexionBD.abrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexionBD.oCon))
                    {
                        cmd.Parameters.AddWithValue("@SoloAlertas", mostrandoAlertas ? 1 : 0);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvNuevo.AutoGenerateColumns = true;
                        dgvNuevo.DataSource = dt;

                        // --- COLUMNAS PARA LOS BOTONES DINÁMICOS ---
                        if (!dgvNuevo.Columns.Contains("Agregar"))
                        {
                            DataGridViewButtonColumn btnAgregar = new DataGridViewButtonColumn();
                            btnAgregar.Name = "Agregar";
                            btnAgregar.HeaderText = "";
                            btnAgregar.Width = 45;
                            btnAgregar.FlatStyle = FlatStyle.Flat;
                            dgvNuevo.Columns.Add(btnAgregar);
                        }

                        if (!dgvNuevo.Columns.Contains("Delete"))
                        {
                            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                            btnDelete.Name = "Delete";
                            btnDelete.HeaderText = "";
                            btnDelete.Width = 45;
                            btnDelete.FlatStyle = FlatStyle.Flat;
                            dgvNuevo.Columns.Add(btnDelete);
                        }

                        // --- AJUSTE EXACTO DE ANCHOS ---
                        if (dgvNuevo.Columns.Count > 0)
                        {
                            if (dgvNuevo.Columns.Contains("NOMBRE")) dgvNuevo.Columns["NOMBRE"].Width = 160;
                            if (dgvNuevo.Columns.Contains("CATEGORÍA")) dgvNuevo.Columns["CATEGORÍA"].Width = 120;
                            if (dgvNuevo.Columns.Contains("COMPATIBLE")) dgvNuevo.Columns["COMPATIBLE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            if (dgvNuevo.Columns.Contains("STOCK")) dgvNuevo.Columns["STOCK"].Width = 110;
                            if (dgvNuevo.Columns.Contains("COSTO")) dgvNuevo.Columns["COSTO"].Width = 100;
                            if (dgvNuevo.Columns.Contains("VENTA")) dgvNuevo.Columns["VENTA"].Width = 100;
                            if (dgvNuevo.Columns.Contains("PROVEEDOR")) dgvNuevo.Columns["PROVEEDOR"].Width = 160;
                            if (dgvNuevo.Columns.Contains("ESTADO")) dgvNuevo.Columns["ESTADO"].Width = 140;
                        }

                        dgvNuevo.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionBD.cerrarConexion();
            }

            // Al final actualizamos el circulito naranja de las alertas
            ActualizarContadorAlertas();
        }

        // --- 3. CONTAR ALERTAS (Stock Mínimo) ---
        private void ActualizarContadorAlertas()
        {
            string query = "SELECT COUNT(*) FROM InventarioSucursal WHERE StockActual <= StockMinimo";
            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();
            try
            {
                if (db.abrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cantidadAlertas = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if (pnlInfo != null) pnlInfo.Invalidate();
                }
            }
            catch { }
            finally { db.cerrarConexion(); }
        }

        // --- 4. FORMATO DE TEXTO (MONEDA Y COLOR VERDE PARA VENTAS) ---
        private void dgvNuevo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Value != null)
            {
                string nombreColumna = dgvNuevo.Columns[e.ColumnIndex].Name;

                if (nombreColumna == "COSTO" || nombreColumna == "VENTA")
                {
                    if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                    {
                        e.Value = $"${valor:N2}";
                        e.FormattingApplied = true;
                    }
                }

                if (nombreColumna == "VENTA")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(0, 180, 110);
                    e.CellStyle.Font = new Font(dgvNuevo.Font, FontStyle.Bold);
                }

                if (nombreColumna == "COSTO")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.Font = new Font(dgvNuevo.Font, FontStyle.Bold);
                }
            }
        }

        // --- 5. MAGIA VISUAL (PÍLDORAS REDONDEADAS Y BOTONES DISEÑADOS) ---
        private void dgvNuevo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string nombreColumna = dgvNuevo.Columns[e.ColumnIndex].Name;

            // A) PÍLDORAS REDONDEADAS DEL STOCK
            if (nombreColumna == "ESTADO")
            {
                string estado = e.Value?.ToString() ?? "";
                Color colorPrincipal = Color.Gray;
                Color colorFondo = Color.White;

                switch (estado)
                {
                    case "Normal":
                        colorPrincipal = Color.FromArgb(0, 180, 110);
                        colorFondo = Color.FromArgb(235, 252, 240);
                        break;
                    case "Stock bajo":
                        colorPrincipal = Color.FromArgb(230, 160, 0);
                        colorFondo = Color.FromArgb(255, 250, 235);
                        break;
                    case "Sin stock":
                        colorPrincipal = Color.FromArgb(220, 50, 50);
                        colorFondo = Color.FromArgb(255, 235, 235);
                        break;
                }

                e.PaintBackground(e.CellBounds, true);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                int altoBadge = 26;
                int anchoTexto = (int)e.Graphics.MeasureString(estado, e.CellStyle.Font).Width;
                int anchoBadge = anchoTexto + 28;

                int x = e.CellBounds.Left + 15;
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
                }

                int dotSize = 6;
                int dotX = x + 10;
                int dotY = y + (altoBadge - dotSize) / 2;
                using (SolidBrush dotBrush = new SolidBrush(colorPrincipal))
                {
                    e.Graphics.FillEllipse(dotBrush, dotX, dotY, dotSize, dotSize);
                }

                int textX = dotX + dotSize + 5;
                int textY = y + (altoBadge - e.CellStyle.Font.Height) / 2 + 1;
                using (SolidBrush textBrush = new SolidBrush(colorPrincipal))
                {
                    e.Graphics.DrawString(estado, e.CellStyle.Font, textBrush, textX, textY);
                }

                e.Handled = true;
            }

            // B) BOTONES ESTILO FIGMA (NUEVO DISEÑO)
            if (nombreColumna == "Agregar" || nombreColumna == "Delete")
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                bool esAgregar = (nombreColumna == "Agregar");

                Color bgColor = esAgregar ? Color.FromArgb(235, 252, 242) : Color.FromArgb(255, 240, 240);
                Color borderColor = esAgregar ? Color.FromArgb(170, 235, 190) : Color.FromArgb(255, 200, 200);
                Color textColor = esAgregar ? Color.FromArgb(50, 170, 100) : Color.FromArgb(230, 70, 70);
                string text = esAgregar ? "↓" : "↑";

                int btnSize = 32;
                int x = e.CellBounds.Left + (e.CellBounds.Width - btnSize) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - btnSize) / 2;

                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radio = 8;
                    path.AddArc(x, y, radio, radio, 180, 90);
                    path.AddArc(x + btnSize - radio, y, radio, radio, 270, 90);
                    path.AddArc(x + btnSize - radio, y + btnSize - radio, radio, radio, 0, 90);
                    path.AddArc(x, y + btnSize - radio, radio, radio, 90, 90);
                    path.CloseFigure();

                    using (SolidBrush brush = new SolidBrush(bgColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }

                    using (Pen pen = new Pen(borderColor, 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }

                using (Font iconFont = new Font("Segoe UI", 12F, FontStyle.Bold))
                {
                    SizeF textSize = e.Graphics.MeasureString(text, iconFont);
                    float textX = x + (btnSize - textSize.Width) / 2;
                    float textY = y + (btnSize - textSize.Height) / 2 + 1;

                    using (SolidBrush textBrush = new SolidBrush(textColor))
                    {
                        e.Graphics.DrawString(text, iconFont, textBrush, textX, textY);
                    }
                }

                e.Handled = true;
            }
        }

        // --- 6. EVENTOS DEL BOTÓN DE ALERTAS ---
        private void btnAlertas_Click(object sender, EventArgs e)
        {
            mostrandoAlertas = !mostrandoAlertas; // Alterna el estado

            // Obligatorio en Sunny UI para que te deje cambiar los colores manualmente
            btnAlertas.Style = Sunny.UI.UIStyle.Custom;

            if (mostrandoAlertas)
            {
                // Propiedades exclusivas de Sunny UI
                btnAlertas.FillColor = Color.FromArgb(255, 245, 235); // Fondo naranja claro
                btnAlertas.RectColor = Color.FromArgb(255, 150, 0);   // Borde naranja oscuro
                btnAlertas.ForeColor = Color.FromArgb(255, 150, 0);   // Opcional: Letras naranjas
            }
            else
            {
                btnAlertas.FillColor = Color.White; // Vuelve a blanco
                btnAlertas.RectColor = Color.FromArgb(213, 218, 223); // Borde gris claro estándar
                btnAlertas.ForeColor = Color.FromArgb(100, 100, 100); // Letras grises
            }

            CargarDatos(); // Recargar tabla con o sin filtro
        }

        private void btnAlertas_Paint(object sender, PaintEventArgs e)
        {
            if (cantidadAlertas > 0)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                int size = 22;
                int x = btnAlertas.Width - size - 8;
                int y = (btnAlertas.Height - size) / 2;

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 150, 0)))
                {
                    e.Graphics.FillEllipse(brush, x, y, size, size);
                }

                string texto = cantidadAlertas > 99 ? "+99" : cantidadAlertas.ToString();
                using (Font f = new Font("Segoe UI", 8.5F, FontStyle.Bold))
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                {
                    SizeF textSize = e.Graphics.MeasureString(texto, f);
                    float textX = x + (size - textSize.Width) / 2;
                    float textY = y + (size - textSize.Height) / 2 + 1;
                    e.Graphics.DrawString(texto, f, textBrush, textX, textY);
                }
            }
        }

        // --- 7. ACCIONES DE CLIC EN LA TABLA Y NUEVO REPUESTO ---
        private void dgvNuevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvNuevo.Columns[e.ColumnIndex].Name == "Agregar")
            {
                frmAggStock frm = new frmAggStock();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
            else if (dgvNuevo.Columns[e.ColumnIndex].Name == "Delete")
            {
                frmDeleteStock frm = new frmDeleteStock();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
        }

        private void btnNuevoRepuesto_Click(object sender, EventArgs e)
        {
            frmRegistrarEntrega frm = new frmRegistrarEntrega();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }
    }
}