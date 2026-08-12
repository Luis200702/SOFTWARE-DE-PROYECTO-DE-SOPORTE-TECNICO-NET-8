using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucDerivacion : UserControl
    {
        private List<Orden> ordenes = new List<Orden>();

        public ucDerivacion()
        {
            InitializeComponent();
            ConfigurarGrid();
            CargarDatos();

            // Aseguramos que los eventos estén conectados
            dgvderivacionsucursales.CellClick += dgvderivacionsucursales_CellClick;
            dgvderivacionsucursales.CellPainting += dgvderivacionsucursales_CellPainting;
        }

        public class Orden
        {
            public int IdDerivacion { get; set; }
            public string Codigo { get; set; }      // ORD-2024-004
            public string Estado { get; set; }      // Pendiente
            public string Cliente { get; set; }     // Laura Vega
            public string Producto { get; set; }    // Xiaomi Redmi 12
            public string Origen { get; set; }      // Sucursal Norte
            public string Destino { get; set; }     // Sucursal Centro
            public DateTime Fecha { get; set; }
            public string Motivo { get; set; }      // Falta de repuesto
            public string Detalle { get; set; }     // Conector USB-C Redmi 12
        }

        private void ucDerivacion_Load(object sender, EventArgs e)
        { }

        private void ConfigurarGrid()
        {
            dgvderivacionsucursales.BackgroundColor = Color.FromArgb(26, 28, 44);
            dgvderivacionsucursales.ColumnHeadersVisible = false;
            dgvderivacionsucursales.RowHeadersVisible = false;
            dgvderivacionsucursales.AllowUserToAddRows = false;
            dgvderivacionsucursales.AllowUserToResizeRows = false;
            dgvderivacionsucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvderivacionsucursales.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvderivacionsucursales.RowTemplate.Height = 75; // alto de cada "tarjeta"
            dgvderivacionsucursales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvderivacionsucursales.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 247, 250);
            dgvderivacionsucursales.DefaultCellStyle.SelectionForeColor = Color.Black;

            if (dgvderivacionsucursales.Columns.Count == 0)
            {
                dgvderivacionsucursales.Columns.Add("colTarjeta", "");
            }
            dgvderivacionsucursales.Columns[0].Width = 500;

            // Fuente base
            dgvderivacionsucursales.Font = new Font("Segoe UI", 9F);
        }

        private void dgvderivacionsucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= ordenes.Count) return;

            Orden ordenSeleccionada = ordenes[e.RowIndex];

            // Muestra el panel de detalles
            pnlDetallesDerivaciones.Visible = true;

            // (Aquí puedes asignar textos a los labels de tu panel lateral si lo deseas)
        }

        // --- CARGA DE DATOS REALES DESDE SQL SERVER ---
        public void CargarDatos()
        {
            ordenes.Clear();
            var db = new Conexion_Base_de_Datos();

            if (db.abrirConexion())
            {
                try
                {
                    // Consulta con JOIN para extraer los datos relacionales (Cliente y Dispositivo)
                    string query = @"
                        SELECT 
                            d.IdDerivacion,
                            o.numero_orden AS Codigo,
                            d.Estado,
                            c.nombre AS ClienteNombre,
                            disp.marca + ' ' + disp.modelo AS Producto,
                            d.SucursalOrigen,
                            d.SucursalDestino,
                            d.FechaDerivacion,
                            d.Motivo,
                            d.Detalle
                        FROM DerivacionesSucursales d
                        INNER JOIN ordenes o ON d.IdOrden = o.id
                        INNER JOIN clientes c ON o.cliente_id = c.id
                        INNER JOIN dispositivos disp ON o.dispositivo_id = disp.id
                        ORDER BY d.IdDerivacion DESC";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ordenes.Add(new Orden
                                {
                                    IdDerivacion = Convert.ToInt32(reader["IdDerivacion"]),
                                    Codigo = reader["Codigo"].ToString(),
                                    Estado = reader["Estado"].ToString(),
                                    Cliente = reader["ClienteNombre"].ToString(),
                                    Producto = reader["Producto"].ToString(),
                                    Origen = reader["SucursalOrigen"].ToString(),
                                    Destino = reader["SucursalDestino"].ToString(),
                                    Fecha = reader["FechaDerivacion"] != DBNull.Value ? Convert.ToDateTime(reader["FechaDerivacion"]) : DateTime.Now,
                                    Motivo = reader["Motivo"].ToString(),
                                    Detalle = reader["Detalle"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las derivaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }

            // Pintamos las tarjetas en el DataGridView
            dgvderivacionsucursales.Rows.Clear();
            foreach (var o in ordenes)
            {
                dgvderivacionsucursales.Rows.Add(""); // Fila vacía, el CellPainting dibuja la tarjeta
            }
        }

        // --- LÓGICA DE DIBUJO (ESTILO FIGMA) ---
        private void dgvderivacionsucursales_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= ordenes.Count) return;

            Orden o = ordenes[e.RowIndex];
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (SolidBrush fondoBrush = new SolidBrush(Color.FromArgb(15, 23, 42)))
            {
                g.FillRectangle(fondoBrush, e.CellBounds);
            }

            int x = e.CellBounds.Left + 10;
            int y = e.CellBounds.Top + 8;

            // --- Línea 1: Badge código + Badge estado ---
            Size sizeCodigo = DibujarBadge(g, o.Codigo, x, y,
                Color.FromArgb(238, 242, 255), Color.FromArgb(80, 90, 200));
            x += sizeCodigo.Width + 8;

            // Cambiar color del badge según el estado
            Color bgEstado = Color.FromArgb(255, 243, 224); // Amarillo por defecto (Pendiente)
            Color fgEstado = Color.FromArgb(200, 120, 20);

            if (o.Estado == "Aceptada")
            {
                bgEstado = Color.FromArgb(220, 252, 231);
                fgEstado = Color.FromArgb(22, 101, 52);
            }
            else if (o.Estado == "Rechazada")
            {
                bgEstado = Color.FromArgb(254, 226, 226);
                fgEstado = Color.FromArgb(153, 27, 27);
            }

            DibujarBadge(g, "⏱ " + o.Estado, x, y, bgEstado, fgEstado);

            // --- Línea 2: Cliente · Producto (negrita) + fecha a la derecha ---
            x = e.CellBounds.Left + 10;
            y += 26;
            using (Font boldFont = new Font("Segoe UI", 9.5F, FontStyle.Bold))
            {
                string linea2 = $"{o.Cliente} · {o.Producto}";
                g.DrawString(linea2, boldFont, Brushes.White, x, y);
            }

            string fechaTxt = o.Fecha.ToString("dd/MM/yyyy");
            SizeF fechaSize = g.MeasureString(fechaTxt, dgvderivacionsucursales.Font);
            g.DrawString(fechaTxt, dgvderivacionsucursales.Font, Brushes.Gray,
                e.CellBounds.Right - fechaSize.Width - 10, y + 2);

            // --- Línea 3: Origen -> Destino ---
            y += 20;
            using (Brush grayBrush = new SolidBrush(Color.FromArgb(160, 165, 180)))
            {
                g.DrawString($"{o.Origen} → {o.Destino}", dgvderivacionsucursales.Font, grayBrush, x, y);
            }

            // --- Línea 4: ícono + Motivo · Detalle ---
            y += 20;
            using (Brush grayBrush = new SolidBrush(Color.FromArgb(160, 165, 180)))
            {
                g.DrawString($"ⓘ {o.Motivo} · {o.Detalle}", dgvderivacionsucursales.Font, grayBrush, x, y);
            }

            e.Handled = true;
        }

        private Size DibujarBadge(Graphics g, string texto, int x, int y, Color fondo, Color letra)
        {
            using (Font f = new Font("Segoe UI", 8F, FontStyle.Bold))
            {
                SizeF textSize = g.MeasureString(texto, f);
                int padX = 8, padY = 3;
                Rectangle rect = new Rectangle(x, y, (int)textSize.Width + padX * 2, (int)textSize.Height + padY * 2);

                using (GraphicsPath path = RoundedRect(rect, 8))
                using (SolidBrush brush = new SolidBrush(fondo))
                using (SolidBrush textBrush = new SolidBrush(letra))
                {
                    g.FillPath(brush, path);
                    g.DrawString(texto, f, textBrush, x + padX, y + padY);
                }

                return rect.Size;
            }
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void label15_Click(object sender, EventArgs e) => pnlDetallesDerivaciones.Visible = false;
        private void btnxdetalles_Click(object sender, EventArgs e) => pnlDetallesDerivaciones.Visible = false;
        private void uiButton3_Click(object sender, EventArgs e) => pnlDetallesDerivaciones.Visible = false;
    }
}