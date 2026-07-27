using Microsoft.VisualBasic.Logging;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmMenu : Form
    {
        private float posicionActualY;
        private float posicionObjetivoY;

        // Variables para la animación de extensión/retracción horizontal (0.0 a 1.0)
        private float progresoAncho = 0f;
        private float progresoAnchoObjetivo = 0f;

        private System.Windows.Forms.Button botonSeleccionado;
        private System.Windows.Forms.Button ultimoBotonActivo; // Guarda la referencia mientras se repliega

        // Variable para mantener el botón que recibió Clic (Sección actual)
        private System.Windows.Forms.Button botonActivo;

        public frmMenu()
        {
            //Crear e inicializar todos los componentes del diseño
            InitializeComponent();

            // 1. Activar DoubleBuffer para evitar parpadeos en el panel
            typeof(System.Windows.Forms.Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, pnlContenedorMenu, new object[] { true });

            // 2. Conectar evento Paint enfocado en pnlContenedorMenu
            pnlContenedorMenu.Paint += PnlContenedorMenu_Paint;

            // 3. Configurar Timer de animación
            timerDesplazamiento.Interval = 10;
            timerDesplazamiento.Tick -= timerDesplazamiento_Tick;
            timerDesplazamiento.Tick += timerDesplazamiento_Tick;

            // 4. Configurar botones transparentes, eventos MouseEnter y Click
            foreach (Control c in pnlContenedorMenu.Controls)
            {
                if (c is System.Windows.Forms.Button btn)
                {
                    btn.UseVisualStyleBackColor = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.Transparent;
                    btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btn.ForeColor = ColorTranslator.FromHtml("#9BA8AB");

                    btn.MouseEnter -= BotonMenu_MouseEnter;
                    btn.MouseEnter += BotonMenu_MouseEnter;

                    btn.Click -= BotonMenu_Click;
                    btn.Click += BotonMenu_Click;
                }
            }

            botonSeleccionado = null;
            ultimoBotonActivo = null;
            botonActivo = null;
        }

        // EVENTO CLICK: Marca el botón como activo y le aplica el estado seleccionado
        private void BotonMenu_Click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button btn)
            {
                // Restaurar color del texto del botón activo anterior
                if (botonActivo != null && botonActivo != btn)
                {
                    botonActivo.ForeColor = ColorTranslator.FromHtml("#9BA8AB");
                }

                botonActivo = btn;
                botonActivo.ForeColor = Color.White; // Destacar texto del botón seleccionado
                pnlContenedorMenu.Invalidate();      // Redibujar panel para mostrar el degradado
            }
        }

        // DIBUJO EN EL PANEL
        private void PnlContenedorMenu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int anchoTotal = pnlContenedorMenu.Width;

            // Recortar límites del panel
            e.Graphics.SetClip(new RectangleF(0, 0, anchoTotal, pnlContenedorMenu.Height));

            // =========================================================================
            // 1. DIBUJAR DEGRADADO EN EL BOTÓN SELECCIONADO POR CLIC (SECCIÓN ACTIVA)
            // =========================================================================
            if (botonActivo != null)
            {
                int altoActivo = botonActivo.Height;
                int radioActivo = altoActivo;
                float rCornerBaseActivo = 16f;
                int xObjetivoActivo = botonActivo.Left;
                float yActivo = botonActivo.Top;

                float distanciaDisponibleActiva = anchoTotal - (xObjetivoActivo + radioActivo / 2f);
                float rCornerActivo = Math.Max(0f, Math.Min(rCornerBaseActivo, distanciaDisponibleActiva));

                using (GraphicsPath pathActivo = CrearPathCapsula(xObjetivoActivo, yActivo, altoActivo, radioActivo, rCornerActivo, anchoTotal))
                {
                    RectangleF rectGradiente = new RectangleF(xObjetivoActivo, yActivo, anchoTotal - xObjetivoActivo, altoActivo);
                    if (rectGradiente.Width > 1)
                    {
                        Color colorInicio = ColorTranslator.FromHtml("#52C4B1"); // Color claro/brillante       El original si quiero = #6FE6D0
                        Color colorFin = Color.FromArgb(0, 74, 92, 92);         // Transparente a la derecha

                        using (LinearGradientBrush brushGradiente = new LinearGradientBrush(
                            rectGradiente, colorInicio, colorFin, LinearGradientMode.Horizontal))
                        {
                            // Coloreado más de la mitad (55%) y luego se va desvaneciendo progresivamente
                            ColorBlend blend = new ColorBlend();
                            blend.Colors = new Color[] {
                                colorInicio,
                                Color.FromArgb(180, colorInicio),
                                colorFin
                            };
                            blend.Positions = new float[] { 0.0f, 0.55f, 1.0f };
                            brushGradiente.InterpolationColors = blend;

                            e.Graphics.FillPath(brushGradiente, pathActivo);
                        }
                    }
                }
            }

            // =========================================================================
            // 2. DIBUJAR ANIMACIÓN FLOTANTE ORIGINAL (HOVER AL PASAR EL CURSOR)
            // =========================================================================
            if (progresoAncho > 0.001f)
            {
                System.Windows.Forms.Button btn = botonSeleccionado ?? ultimoBotonActivo;
                if (btn != null)
                {
                    int alto = btn.Height;
                    int radio = alto;
                    float rCornerBase = 16f;
                    int xObjetivo = btn.Left;

                    float xCalculado = anchoTotal - (anchoTotal - xObjetivo) * progresoAncho;
                    float y = posicionActualY;

                    float distanciaDisponible = anchoTotal - (xCalculado + radio / 2f);
                    float rCorner = Math.Max(0f, Math.Min(rCornerBase * progresoAncho, distanciaDisponible));

                    Color colorCapsula = Color.FromArgb(26, 28, 44); // Color original

                    using (GraphicsPath pathHover = CrearPathCapsula(xCalculado, y, alto, radio, rCorner, anchoTotal))
                    {
                        using (SolidBrush brush = new SolidBrush(colorCapsula))
                        {
                            e.Graphics.FillPath(brush, pathHover);
                        }
                    }
                }
            }

            e.Graphics.ResetClip();
        }

        // Método auxiliar para construir la figura geométrica cóncava original
        private GraphicsPath CrearPathCapsula(float xCalculado, float y, int alto, int radio, float rCorner, int anchoTotal)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            if (rCorner > 0.5f)
            {
                // 1. Curva cóncava superior derecha
                path.AddArc(anchoTotal - 2 * rCorner, y - 2 * rCorner, 2 * rCorner, 2 * rCorner, 0, 90);

                // 2. Semicírculo del extremo izquierdo
                path.AddArc(xCalculado, y, radio, radio, 270, -180);

                // 3. Curva cóncava inferior derecha
                path.AddArc(anchoTotal - 2 * rCorner, y + alto, 2 * rCorner, 2 * rCorner, 270, 90);

                // 4. Cierre del borde derecho vertical
                path.AddLine(anchoTotal, y + alto + rCorner, anchoTotal, y - rCorner);
            }
            else
            {
                path.AddLine(anchoTotal, y, xCalculado + radio / 2f, y);
                path.AddArc(xCalculado, y, radio, radio, 270, -180);
                path.AddLine(xCalculado + radio / 2f, y + alto, anchoTotal, y + alto);
                path.AddLine(anchoTotal, y + alto, anchoTotal, y);
            }

            path.CloseFigure();
            return path;
        }

        // EVENTO MOUSE ENTER: Activa y despliega la pestaña original al posicionarse en un botón del menú
        private void BotonMenu_MouseEnter(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button btn)
            {
                if (botonSeleccionado != null && botonSeleccionado != btn && botonSeleccionado != botonActivo)
                {
                    botonSeleccionado.ForeColor = ColorTranslator.FromHtml("#9BA8AB");
                }

                // Si viene de estar completamente oculto, ajusta la altura Y inmediatamente al botón
                if (progresoAnchoObjetivo == 0f && progresoAncho == 0f)
                {
                    posicionActualY = btn.Top;
                }

                botonSeleccionado = btn;
                ultimoBotonActivo = btn;

                if (btn != botonActivo)
                {
                    botonSeleccionado.ForeColor = ColorTranslator.FromHtml("#6FE6D0");
                }

                posicionObjetivoY = btn.Top;
                progresoAnchoObjetivo = 1.0f; // Expandir a la izquierda

                timerDesplazamiento.Start();
            }
        }

        // ANIMACIÓN Y VALIDACIÓN CONTINUA DEL MOUSE
        private void timerDesplazamiento_Tick(object sender, EventArgs e)
        {
            // Validar de forma directa si el cursor físico está dentro de pnlContenedorMenu
            Point posicionMouse = pnlContenedorMenu.PointToClient(Cursor.Position);
            bool estaDentroDelPanel = pnlContenedorMenu.ClientRectangle.Contains(posicionMouse);

            // Si el cursor NO está dentro del panel, forzar contraer a la derecha
            if (!estaDentroDelPanel)
            {
                if (botonSeleccionado != null && botonSeleccionado != botonActivo)
                {
                    botonSeleccionado.ForeColor = ColorTranslator.FromHtml("#9BA8AB");
                    botonSeleccionado = null;
                }
                progresoAnchoObjetivo = 0.0f; // Recoger hacia la derecha
            }

            bool huboMovimiento = false;

            // 1. Animación Vertical (Y)
            float distanciaY = posicionObjetivoY - posicionActualY;
            if (Math.Abs(distanciaY) > 0.5f)
            {
                posicionActualY += distanciaY / 3f;
                huboMovimiento = true;
            }
            else
            {
                posicionActualY = posicionObjetivoY;
            }

            // 2. Animación Horizontal (Ancho)
            float distanciaAncho = progresoAnchoObjetivo - progresoAncho;
            if (Math.Abs(distanciaAncho) > 0.005f)
            {
                progresoAncho += distanciaAncho / 5f;
                huboMovimiento = true;
            }
            else
            {
                progresoAncho = progresoAnchoObjetivo;
            }

            // Cuando la pestaña se repliega por completo (0.0) y el mouse sigue fuera, apagamos el Timer
            if (progresoAncho <= 0.001f && progresoAnchoObjetivo == 0f)
            {
                progresoAncho = 0f;
                ultimoBotonActivo = null;
                timerDesplazamiento.Stop();
                pnlContenedorMenu.Invalidate();
                return;
            }

            // Redibujar solo mientras haya movimiento activo
            if (huboMovimiento)
            {
                pnlContenedorMenu.Invalidate();
            }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRecepcionEquipos_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucRecepcionEquipos());
        }

        private void btnSeguimientoReparaciones_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucSeguimientoReparaciones());
        }

        private void btnDevoluciónEntrega_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucDevolucion());
        }

        private void btnGestionStock_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucStock());
        }

        private void btnDerivacionOrdenes_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucDerivacion());
        }

        private void btnVentaDispositivos_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucVentaDispositivos());
        }

        private void btnTradeIn_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucTradeIn());
        }

        private void btnHistorialCliente_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucHistorialClientes());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucReportes());
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucGestionUsuarios());
        }

        private void btnConfiguracionGeneral_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucConfiguracion());
        }

        private void AbrirUserControl(UserControl uc)
        {
            pnlInterfaces.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlInterfaces.Controls.Add(uc);
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
