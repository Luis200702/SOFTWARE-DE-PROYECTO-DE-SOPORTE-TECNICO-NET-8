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

        private string sucursalActual;


        private float posicionActualY;
        private float posicionObjetivoY;

        // Variables para la animación de extensión/retracción horizontal 
        private float progresoAncho = 0f;
        private float progresoAnchoObjetivo = 0f;

        private System.Windows.Forms.Button botonSeleccionado;
        private System.Windows.Forms.Button ultimoBotonActivo;

        // Variable para mantener el botón que recibió Clic 
        private System.Windows.Forms.Button botonActivo;
        public frmMenu(string sucursal)
        {
            InitializeComponent();
            sucursalActual = sucursal;
        }
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
                    btn.ForeColor = ColorTranslator.FromHtml("#EBEFF0");   // Color Pale Gray, por defecto 

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
                    botonActivo.ForeColor = ColorTranslator.FromHtml("#EBEFF0");  // Color Pale Gray
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
            // VARIABLE DE CONFIGURACIÓN DE REDONDEO
            // Cambiar este valor libremente (ej. 4f, 6f, 8f, 10f) para ajustar 
            // qué tan redondeadas o cuadradas quieres las esquinas.
            // =========================================================================
            float radioEsquinas = 6f;

            // =========================================================================
            // 1. DIBUJAR DEGRADADO EN EL BOTÓN SELECCIONADO POR CLIC (SECCIÓN ACTIVA)
            // =========================================================================
            if (botonActivo != null)
            {
                float xActivo = botonActivo.Left;
                float yActivo = botonActivo.Top;
                float anchoActivo = botonActivo.Width;
                float altoActivo = botonActivo.Height;

                using (GraphicsPath pathActivo = CrearPathRedondeado(xActivo, yActivo, anchoActivo, altoActivo, radioEsquinas))
                {
                    RectangleF rectGradiente = new RectangleF(xActivo, yActivo, anchoActivo, altoActivo);
                    if (rectGradiente.Width > 1)
                    {
                        Color colorInicio = ColorTranslator.FromHtml("#009689");
                        Color colorFin = Color.FromArgb(0, 72, 92, 98);

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
            // 2. DIBUJAR ANIMACIÓN FLOTANTE (HOVER) DENTRO DEL ÁREA DEL BOTÓN
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

                    // Animación de ancho y desplazamiento fluido 
                    float anchoActual = anchoMax * progresoAncho;
                    float xActual = xBtn + (anchoMax - anchoActual); // Que crezca desde la izquierda, cámbialo a xBtn

                    Color colorCapsula = Color.FromArgb(25, 255, 255, 255); // Blanco leve y translúcido

                    using (GraphicsPath pathHover = CrearPathRedondeado(xActual, y, anchoActual, alto, radioEsquinas))
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

        // =========================================================================
        // MÉTODO ÚNICO Y UNIVERSAL PARA RECTÁNGULOS CON ESQUINAS REDONDEADAS PERFECTAS
        // =========================================================================
        private GraphicsPath CrearPathRedondeado(float x, float y, float ancho, float alto, float radio)
        {
            GraphicsPath path = new GraphicsPath();
            if (ancho <= 0 || alto <= 0) return path;

            // Asegurar matemáticamente que el radio nunca deforme la figura
            radio = Math.Min(radio, Math.Min(ancho / 2f, alto / 2f));
            if (radio < 0) radio = 0;

            float diametro = radio * 2f;

            path.StartFigure();
            // Esquina superior izquierda
            path.AddArc(x, y, diametro, diametro, 180, 90);
            // Esquina superior derecha
            path.AddArc(x + ancho - diametro, y, diametro, diametro, 270, 90);
            // Esquina inferior derecha
            path.AddArc(x + ancho - diametro, y + alto - diametro, diametro, diametro, 0, 90);
            // Esquina inferior izquierda
            path.AddArc(x, y + alto - diametro, diametro, diametro, 90, 90);
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
                        botonSeleccionado.ForeColor = ColorTranslator.FromHtml("#EBEFF0");  // Color Pale Gray
                    }
                    botonSeleccionado = null;
                    progresoAnchoObjetivo = 0f;
                    timerDesplazamiento.Start();
                    return;
                }

                if (botonSeleccionado != null && botonSeleccionado != btn && botonSeleccionado != botonActivo)
                {
                    botonSeleccionado.ForeColor = ColorTranslator.FromHtml("#EBEFF0");   // Color Pale Gray
                }

                if (progresoAnchoObjetivo == 0f && progresoAncho == 0f)
                {
                    posicionActualY = btn.Top;
                }

                botonSeleccionado = btn;
                ultimoBotonActivo = btn;

                if (btn != botonActivo)
                {
                    botonSeleccionado.ForeColor = ColorTranslator.FromHtml("#1FE5CC");
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
                    botonSeleccionado.ForeColor = ColorTranslator.FromHtml("#EBEFF0");   // Color Pale Gray
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
            btnReportes.Visible = true;
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
            // Instanciamos el UserControl leyendo directamente la sucursal almacenada en la sesión
            ucDerivacion uc = new ucDerivacion();

            // Si ucDerivacion lee Sesion.SucursalActual en su constructor o Load, 
            // simplemente abrir el UserControl con tu método estandarizado:
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