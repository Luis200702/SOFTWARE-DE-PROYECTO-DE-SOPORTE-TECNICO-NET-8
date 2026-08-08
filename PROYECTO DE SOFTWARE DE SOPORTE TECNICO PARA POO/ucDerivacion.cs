using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            dgvderivacionsucursales.CellClick += dgvderivacionsucursales_CellClick;

        }


        public class Orden
        {
            public string Codigo { get; set; }      // ORD-2024-004
            public string Estado { get; set; }      // Pendiente
            public string Cliente { get; set; }      // Laura Vega
            public string Producto { get; set; }     // Xiaomi Redmi 12
            public string Origen { get; set; }       // Sucursal Norte
            public string Destino { get; set; }      // Sucursal Centro
            public DateTime Fecha { get; set; }
            public string Motivo { get; set; }       // Falta de repuesto
            public string Detalle { get; set; }      // Conector USB-C Redmi 12
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

            dgvderivacionsucursales.Columns.Add("colTarjeta", "");
            dgvderivacionsucursales.Columns[0].Width = 500;

            // Fuente base
            dgvderivacionsucursales.Font = new Font("Segoe UI", 9F);
        }

        private void dgvderivacionsucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Evita errores si el clic fue en el encabezado o fuera de una fila válida
            if (e.RowIndex < 0 || e.RowIndex >= ordenes.Count) return;

            Orden ordenSeleccionada = ordenes[e.RowIndex];

            // Muestra el panel
            pnlDetallesDerivaciones.Visible = true;

            // Si quieres además llenar el panel con los datos de esa orden:
            //lblCodigo.Text = ordenSeleccionada.Codigo;
            //lblEstado.Text = ordenSeleccionada.Estado;
            //lblCliente.Text = ordenSeleccionada.Cliente;
            //lblProducto.Text = ordenSeleccionada.Producto;
            //lblOrigen.Text = ordenSeleccionada.Origen;
            //lblDestino.Text = ordenSeleccionada.Destino;
            //lblMotivo.Text = ordenSeleccionada.Motivo;
            //lblDetalle.Text = ordenSeleccionada.Detalle;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaDerivacion_Click(object sender, EventArgs e)
        {

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }




        private void ucDerivacion_Load_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void pnltituloderivacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiUserControl1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblnombreDetalle_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void CargarDatos()
        {
            ordenes.Add(new Orden
            {
                Codigo = "ORD-2024-004",
                Estado = "Pendiente",
                Cliente = "Laura Vega",
                Producto = "Xiaomi Redmi 12",
                Origen = "Sucursal Norte",
                Destino = "Sucursal Centro",
                Fecha = new DateTime(2024, 7, 22),
                Motivo = "Falta de repuesto",
                Detalle = "Conector USB-C Redmi 12"
            });

            dgvderivacionsucursales.Rows.Clear();
            foreach (var o in ordenes)
                dgvderivacionsucursales.Rows.Add(""); // fila vacía, el dibujo lo hace CellPainting
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= ordenes.Count) return;

            Orden o = ordenes[e.RowIndex];
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


            using (SolidBrush fondoBrush = new SolidBrush(Color.FromArgb(15, 23, 42)))
            {
                g.FillRectangle(fondoBrush, e.CellBounds);
            }
            // Fondo de la celda
            //e.PaintBackground(e.CellBounds, true);

            int x = e.CellBounds.Left + 10;
            int y = e.CellBounds.Top + 8;

            // --- Línea 1: Badge código + Badge estado ---
            Size sizeCodigo = DibujarBadge(g, o.Codigo, x, y,
                Color.FromArgb(238, 242, 255), Color.FromArgb(80, 90, 200));
            x += sizeCodigo.Width + 8;

            DibujarBadge(g, "⏱ " + o.Estado, x, y,
                Color.FromArgb(255, 243, 224), Color.FromArgb(200, 120, 20));

            // --- Línea 2: Cliente · Producto  (negrita) + fecha a la derecha ---
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

            e.Handled = true; // le decimos al grid que ya dibujamos todo nosotros
        }

        // Función auxiliar para dibujar cada "badge" redondeado
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

        // Función auxiliar para esquinas redondeadas
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvderivacionsucursales_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void lblcodigo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblestadoDetalle_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            pnlDetallesDerivaciones.Visible = false;
        }

        private void btnxdetalles_Click(object sender, EventArgs e)
        {
            pnlDetallesDerivaciones.Visible = false;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNuevaDerivacion_Click_1(object sender, EventArgs e)
        {
            pnlNuevaDerivacion.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNuevaDerivacion.Visible = false;
        }

        private void pnlNuevaDerivacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            pnlDetallesDerivaciones.Visible = false;
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            pnlNuevaDerivacion.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

