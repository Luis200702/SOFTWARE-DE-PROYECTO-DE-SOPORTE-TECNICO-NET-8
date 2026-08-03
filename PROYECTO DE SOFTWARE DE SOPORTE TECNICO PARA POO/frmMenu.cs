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

        // Variables para la animación de extensión/retracción horizontal 
        private float progresoAncho = 0f;
        private float progresoAnchoObjetivo = 0f;

        private System.Windows.Forms.Button botonSeleccionado;
        private System.Windows.Forms.Button ultimoBotonActivo; 

        // Variable para mantener el botón que recibió Clic 
        private System.Windows.Forms.Button botonActivo;

        public frmMenu()
        {
            //Crear e inicializar todos los componentes del diseño
            InitializeComponent();

            // Configurar el evento CheckedChanged del ToggleSwitch
            //toggleSwitch1.CheckedChanged += toggleSwitch1_CheckedChanged;

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
                botonActivo.ForeColor = Color.White; // Destaca texto del botón seleccionado
                progresoAnchoObjetivo = 0f;          // Oculta hover inmediatamente al hacer clic
                pnlContenedorMenu.Invalidate();      // Redibuja panel para mostrar el degradado
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
                float xActivo = botonActivo.Left;
                float yActivo = botonActivo.Top;
                float anchoActivo = botonActivo.Width;
                float altoActivo = botonActivo.Height;
                float radioActivo = altoActivo / 2f;

                using (GraphicsPath pathActivo = CrearPathHoverBoton(xActivo, yActivo, anchoActivo, altoActivo, radioActivo))
                {
                    RectangleF rectGradiente = new RectangleF(xActivo, yActivo, anchoActivo, altoActivo);
                    if (rectGradiente.Width > 1)
                    {
                        Color colorInicio = ColorTranslator.FromHtml("#2F7C70"); // Color claro/brillante       Otro si quiero por si acaso: #3E9B8B
                        Color colorFin = Color.FromArgb(0, 74, 92, 98);         // Transparente a la derecha

                        using (LinearGradientBrush brushGradiente = new LinearGradientBrush(
                            rectGradiente, colorInicio, colorFin, LinearGradientMode.Horizontal))
                        {
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
            // 2. DIBUJAR ANIMACIÓN FLOTANTE (HOVER) LIMITADA EXCLUSIVAMENTE AL ÁREA DEL BOTÓN
            // =========================================================================
            if (progresoAncho > 0.001f)
            {
                System.Windows.Forms.Button btn = botonSeleccionado ?? ultimoBotonActivo;
                if (btn != null && btn != botonActivo)
                {
                    float xBtn = btn.Left;
                    float y = posicionActualY;
                    float anchoMax = btn.Width;
                    float alto = btn.Height;

                    // Animación de ancho y desplazamiento dentro del botón 
                    float anchoActual = anchoMax * progresoAncho;
                    float xActual = xBtn + (anchoMax - anchoActual);
                    float radio = alto / 2f;

                    Color colorCapsula = Color.FromArgb(25, 255, 255, 255); // Blanco leve y translúcido

                    using (GraphicsPath pathHover = CrearPathHoverBoton(xActual, y, anchoActual, alto, radio))
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

        // Método auxiliar para la figura cóncava original del Click 
        private GraphicsPath CrearPathCapsula(float xCalculado, float y, int alto, int radio, float rCorner, int anchoTotal)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            if (rCorner > 0.5f)
            {
                path.AddArc(anchoTotal - 2 * rCorner, y - 2 * rCorner, 2 * rCorner, 2 * rCorner, 0, 90);
                path.AddArc(xCalculado, y, radio, radio, 270, -180);
                path.AddArc(anchoTotal - 2 * rCorner, y + alto, 2 * rCorner, 2 * rCorner, 270, 90);
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

        // Método auxiliar para construir la forma redondeada dentro del botón
        private GraphicsPath CrearPathHoverBoton(float x, float y, float ancho, float alto, float radio)
        {
            GraphicsPath path = new GraphicsPath();
            if (ancho <= 0 || alto <= 0) return path;

            radio = Math.Min(radio, Math.Min(ancho / 2f, alto / 2f));
            if (radio < 0) radio = 0;

            path.StartFigure();
            path.AddArc(x, y, 2 * radio, 2 * radio, 90, 180);
            path.AddLine(x + radio, y, x + ancho - radio, y);
            path.AddArc(x + ancho - 2 * radio, y, 2 * radio, 2 * radio, 270, 180);
            path.AddLine(x + ancho - radio, y + alto, x + radio, y + alto);
            path.CloseFigure();
            return path;
        }

        // EVENTO MOUSE ENTER: Activa y despliega la pestaña al posicionarse en un botón del menú
        private void BotonMenu_MouseEnter(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button btn)
            {
                if (btn == botonActivo)
                {
                    if (botonSeleccionado != null && botonSeleccionado != botonActivo)
                    {
                        botonSeleccionado.ForeColor = ColorTranslator.FromHtml("#9BA8AB");
                    }
                    botonSeleccionado = null;
                    progresoAnchoObjetivo = 0f;
                    timerDesplazamiento.Start();
                    return;
                }

                if (botonSeleccionado != null && botonSeleccionado != btn && botonSeleccionado != botonActivo)
                {
                    botonSeleccionado.ForeColor = ColorTranslator.FromHtml("#9BA8AB");
                }

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
                progresoAnchoObjetivo = 1.0f; // Expandir

                timerDesplazamiento.Start();
            }
        }

        // ANIMACIÓN Y VALIDACIÓN CONTINUA DEL MOUSE
        private void timerDesplazamiento_Tick(object sender, EventArgs e)
        {
            Point posicionMouse = pnlContenedorMenu.PointToClient(Cursor.Position);
            bool estaDentroDelPanel = pnlContenedorMenu.ClientRectangle.Contains(posicionMouse);

            if (!estaDentroDelPanel)
            {
                if (botonSeleccionado != null && botonSeleccionado != botonActivo)
                {
                    botonSeleccionado.ForeColor = ColorTranslator.FromHtml("#9BA8AB");
                    botonSeleccionado = null;
                }
                progresoAnchoObjetivo = 0.0f; // Contraer
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

            if (progresoAncho <= 0.001f && progresoAnchoObjetivo == 0f)
            {
                progresoAncho = 0f;
                ultimoBotonActivo = null;
                timerDesplazamiento.Stop();
                pnlContenedorMenu.Invalidate();
                return;
            }

            if (huboMovimiento)
            {
                pnlContenedorMenu.Invalidate();
            }
        }

        public void MostrarAdministrador()
        {
            btnGestionUsuarios.Visible = true;
            btnConfiguracionGeneral.Visible = true;
        }

        // ====================================================================
        // EVENTO DEL BOTÓN DE TEMA: Cambia entre Modo Oscuro y Modo Claro
        // ====================================================================
        //private void toggleSwitch1_CheckedChanged(object sender, EventArgs e)
        //{
        //    // True = Modo Oscuro, False = Modo Claro
        //    bool esOscuro = toggleSwitch1.Checked;

        //    // Aplica el tema a todo el formulario actual y sus controles/paneles internos
        //    TemaManager.AplicarTema(this, esOscuro);
        //}




        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRecepcionEquipos_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucRecepcion());
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
