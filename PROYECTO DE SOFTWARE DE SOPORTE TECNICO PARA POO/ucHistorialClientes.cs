using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucHistorialClientes : UserControl
    {
        public ucHistorialClientes()
        {
            InitializeComponent();
            AplicarDiseñoGrid();
        }

        // --- 1. DISEÑO BASE DE AMBAS TABLAS ESTILO WEB ---
        private void AplicarDiseñoGrid()
        {
            // --------------------------------------------------------
            // A) TABLA IZQUIERDA (dgvClientesNuevo) - Lista de Clientes
            // --------------------------------------------------------
            dgvClientesNuevo.BackgroundColor = Color.White;
            dgvClientesNuevo.BorderStyle = BorderStyle.None;
            dgvClientesNuevo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientesNuevo.GridColor = Color.FromArgb(240, 240, 240);
            dgvClientesNuevo.RowHeadersVisible = false;
            dgvClientesNuevo.AllowUserToAddRows = false;
            dgvClientesNuevo.AllowUserToDeleteRows = false;
            dgvClientesNuevo.AllowUserToResizeRows = false;
            dgvClientesNuevo.AllowUserToResizeColumns = false;
            dgvClientesNuevo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientesNuevo.ColumnHeadersVisible = false; // Ocultamos el encabezado para que se vea como una lista limpia

            DataGridViewCellStyle estiloFilaIzq = new DataGridViewCellStyle();
            estiloFilaIzq.BackColor = Color.White;
            estiloFilaIzq.ForeColor = Color.FromArgb(60, 60, 60);
            estiloFilaIzq.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            estiloFilaIzq.SelectionBackColor = Color.FromArgb(235, 252, 242); // Verde agua muy claro
            estiloFilaIzq.SelectionForeColor = Color.FromArgb(0, 160, 130);
            estiloFilaIzq.Padding = new Padding(10); // Espaciado interno
            dgvClientesNuevo.RowsDefaultCellStyle = estiloFilaIzq;

            // --------------------------------------------------------
            // B) TABLA DERECHA (dgvNuevoHistorial) - Historial de Órdenes
            // --------------------------------------------------------
            dgvNuevoHistorial.BackgroundColor = Color.White;
            dgvNuevoHistorial.BorderStyle = BorderStyle.None;
            dgvNuevoHistorial.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNuevoHistorial.GridColor = Color.FromArgb(240, 240, 240);
            dgvNuevoHistorial.RowHeadersVisible = false;
            dgvNuevoHistorial.AllowUserToAddRows = false;
            dgvNuevoHistorial.AllowUserToDeleteRows = false;
            dgvNuevoHistorial.AllowUserToResizeRows = false;
            dgvNuevoHistorial.AllowUserToResizeColumns = false;
            dgvNuevoHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvNuevoHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNuevoHistorial.ColumnHeadersHeight = 50;
            dgvNuevoHistorial.RowTemplate.Height = 60; // Filas altas para las píldoras

            dgvNuevoHistorial.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle estiloEncabezadoDer = new DataGridViewCellStyle();
            estiloEncabezadoDer.BackColor = Color.White;
            estiloEncabezadoDer.ForeColor = Color.FromArgb(80, 80, 80);
            estiloEncabezadoDer.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            estiloEncabezadoDer.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estiloEncabezadoDer.SelectionBackColor = Color.White;
            estiloEncabezadoDer.SelectionForeColor = Color.FromArgb(80, 80, 80);
            dgvNuevoHistorial.ColumnHeadersDefaultCellStyle = estiloEncabezadoDer;
            dgvNuevoHistorial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            DataGridViewCellStyle estiloFilaDer = new DataGridViewCellStyle();
            estiloFilaDer.BackColor = Color.White;
            estiloFilaDer.ForeColor = Color.FromArgb(60, 60, 60);
            estiloFilaDer.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            estiloFilaDer.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estiloFilaDer.SelectionBackColor = Color.FromArgb(248, 250, 252);
            estiloFilaDer.SelectionForeColor = Color.FromArgb(60, 60, 60);
            dgvNuevoHistorial.RowsDefaultCellStyle = estiloFilaDer;
            dgvNuevoHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void ucHistorialClientes_Load(object sender, EventArgs e)
        {
            // Configuramos la tabla izquierda para que acepte saltos de línea (tu lógica)
            dgvClientesNuevo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientesNuevo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Si quieres cargar todos los clientes al iniciar:
            CargarListaClientes("");
        }

        // --- 2. LÓGICA DE BÚSQUEDA DE CLIENTES (PANEL IZQUIERDO) ---
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string valorBusqueda = txtBuscar.Text.Trim();
            CargarListaClientes(valorBusqueda);
        }

        private void CargarListaClientes(string busqueda)
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string query = @"
                        SELECT 
                            C.id, 
                            C.nombre + CHAR(13) + CHAR(10) + 
                            ISNULL(C.telefono, 'Sin teléfono') + CHAR(13) + CHAR(10) + 
                            CAST(COUNT(O.id) AS VARCHAR) + ' órdenes' AS InfoCliente,
                            C.nombre,
                            C.telefono,
                            C.correo
                        FROM Clientes C
                        LEFT JOIN ordenes O ON C.id = O.cliente_id
                        WHERE C.nombre LIKE '%' + @busqueda + '%' 
                           OR C.cedula_pasaporte LIKE '%' + @busqueda + '%'
                           OR C.correo LIKE '%' + @busqueda + '%'
                        GROUP BY C.id, C.nombre, C.telefono, C.correo
                        ORDER BY C.nombre";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", busqueda);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Limpiamos columnas para crearlas nosotros y asegurar el diseño
                        dgvClientesNuevo.Columns.Clear();
                        dgvClientesNuevo.AutoGenerateColumns = false;

                        dgvClientesNuevo.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            DataPropertyName = "InfoCliente",
                            Name = "InfoCliente",
                            HeaderText = "Clientes",
                            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        });

                        dgvClientesNuevo.DataSource = dt;
                        dgvClientesNuevo.ClearSelection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
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
                    string telefono = filaSeleccionada["telefono"].ToString();
                    string correo = filaSeleccionada["correo"].ToString();

                    // Mostramos los datos básicos (Tu lógica adaptada)
                    if (lblNombreCompleto != null) lblNombreCompleto.Text = nombre;
                    if (lblContacto != null) lblContacto.Text = $"{telefono} • {correo}";

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
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // He renombrado los alias (AS ORDEN, AS COSTO) para que el diseño visual coincida exacto
                    string query = @"
                        SELECT 
                            O.numero_orden AS ORDEN,
                            CONVERT(varchar, O.fecha_ingreso, 103) AS FECHA,
                            D.marca + ' ' + D.modelo AS DISPOSITIVO,
                            ISNULL(O.descripcion_problema, 'Reparación general') AS REPARACIÓN,
                            ISNULL(O.costo_estimado, 0) AS COSTO,
                            O.estado AS ESTADO,
                            U.Nombre AS TÉCNICO
                        FROM ordenes O
                        INNER JOIN dispositivos D ON O.dispositivo_id = D.id
                        INNER JOIN Usuarios U ON O.tecnico_id = U.Id
                        WHERE O.cliente_id = @idCliente
                        ORDER BY O.fecha_ingreso DESC";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Usamos AutoGenerateColumns y limpiamos lo previo para no duplicar columnas
                        dgvNuevoHistorial.Columns.Clear();
                        dgvNuevoHistorial.AutoGenerateColumns = true;
                        dgvNuevoHistorial.DataSource = dt;

                        // Ajustes de Ancho para la tabla de la derecha
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

                        // Actualizamos las estadísticas (Tu lógica)
                        if (lblTotalVisitas != null) lblTotalVisitas.Text = dt.Rows.Count.ToString();

                        decimal totalGastado = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            totalGastado += Convert.ToDecimal(row["COSTO"]);
                        }
                        if (lblTotalGastado != null) lblTotalGastado.Text = $"${totalGastado:0.00}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el historial del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
            dgvNuevoHistorial.ClearSelection();
        }

        // --- 4. FORMATO DE TEXTO DE LA TABLA DERECHA (NÚMERO VERDE Y MONEDA) ---
        private void dgvNuevoHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Value != null)
            {
                string nombreColumna = dgvNuevoHistorial.Columns[e.ColumnIndex].Name;

                if (nombreColumna == "ORDEN")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(0, 160, 130); // Verde estilo Figma
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

        // --- 5. PÍLDORAS REDONDEADAS DE LA TABLA DERECHA ---
        private void dgvNuevoHistorial_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string nombreColumna = dgvNuevoHistorial.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "ESTADO")
            {
                string estado = e.Value?.ToString() ?? "";
                Color colorPrincipal = Color.Gray;
                Color colorFondo = Color.White;

                // Colores basados en los estados de tu sistema
                if (estado.ToLower().Contains("reparación") || estado.ToLower().Contains("diagnóstico"))
                {
                    colorPrincipal = Color.FromArgb(230, 140, 0); // Naranja
                    colorFondo = Color.FromArgb(255, 245, 230);
                }
                else if (estado.ToLower().Contains("entregado") || estado.ToLower().Contains("listo"))
                {
                    colorPrincipal = Color.FromArgb(140, 80, 220); // Morado
                    colorFondo = Color.FromArgb(245, 240, 255);
                }
                else
                {
                    colorPrincipal = Color.FromArgb(40, 180, 90); // Verde
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
    }
}