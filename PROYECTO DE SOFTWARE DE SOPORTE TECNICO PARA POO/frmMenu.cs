using System.Drawing.Drawing2D;
using System.Reflection;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmMenu : Form
    {
        private string sucursalActual;

        private float posicionActualY;
        private float posicionObjetivoY;

        // Variables para la animación del menú: extensión/retracción horizontal, osea recorrre el ancho del botón
        private float progresoAncho = 0f;
        private float progresoAnchoObjetivo = 0f;

        private System.Windows.Forms.Button botonSeleccionado;
        private System.Windows.Forms.Button ultimoBotonActivo;

        // Variable para mantener el botón que recibió Clic en el menú
        private System.Windows.Forms.Button botonActivo;

        public frmMenu(string sucursal)
        {
            InitializeComponent();
            sucursalActual = sucursal;
        }

        public frmMenu()
        {
            InitializeComponent();

            // Activar DoubleBuffer para evitar parpadeos en el panel
            typeof(System.Windows.Forms.Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, pnlContenedorMenu, new object[] { true });

            // Evento Paint enfocado en pnlContenedorMenu
            pnlContenedorMenu.Paint += PnlContenedorMenu_Paint;

            // Timer de animación
            timerDesplazamiento.Interval = 10;
            timerDesplazamiento.Tick -= timerDesplazamiento_Tick;
            timerDesplazamiento.Tick += timerDesplazamiento_Tick;

            // Botones transparentes, eventos MouseEnter y Click
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

        // EVENTO CLICK: Marca el botón como activo (osea indica que esta en la interfaz respectiva)
        private void BotonMenu_Click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button btn)
            {
                // Se pone de nuevo el color Pale Gray 
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

        // DIBUJO EN EL PANEL (menú)
        private void PnlContenedorMenu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int anchoTotal = pnlContenedorMenu.Width;

            // Recortar límites del panel
            e.Graphics.SetClip(new RectangleF(0, 0, anchoTotal, pnlContenedorMenu.Height));

            // Variable para redondear las esquinas de los botones del menú
            float radioEsquinas = 6f;

            // Degradado de color para el botón activo 
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

            // Animación de selecionar el botón
            if (progresoAncho > 0.001f)
            {
                System.Windows.Forms.Button btn = botonSeleccionado ?? ultimoBotonActivo;
                if (btn != null && btn != botonActivo)
                {
                    float xBtn = btn.Left;
                    float y = posicionActualY;
                    float anchoMax = btn.Width;
                    float alto = btn.Height;

                    // Animación de ancho y desplazamiento 
                    float anchoActual = anchoMax * progresoAncho;
                    float xActual = xBtn + (anchoMax - anchoActual); // Que aparezca desde la izquierda

                    Color colorCapsula = Color.FromArgb(25, 255, 255, 255); // Blanco leve 

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

        // Redondea las esquinas de los botones del menú y del selecionado
        private GraphicsPath CrearPathRedondeado(float x, float y, float ancho, float alto, float radio)
        {
            GraphicsPath path = new GraphicsPath();
            if (ancho <= 0 || alto <= 0) return path;

            // para que el radio nunca deforme la figura
            radio = Math.Min(radio, Math.Min(ancho / 2f, alto / 2f));
            if (radio < 0) radio = 0;

            float diametro = radio * 2f;

            path.StartFigure();
            path.AddArc(x, y, diametro, diametro, 180, 90);
            path.AddArc(x + ancho - diametro, y, diametro, diametro, 270, 90);
            path.AddArc(x + ancho - diametro, y + alto - diametro, diametro, diametro, 0, 90);
            path.AddArc(x, y + alto - diametro, diametro, diametro, 90, 90);
            path.CloseFigure();

            return path;
        }

        // EVENTO MOUSE ENTER: Activa y despliega la animacion al botón del menú
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

        // Animación y siempre valida que el mouse este dentro del panel del menú
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

            // Animación vertical (Y)
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

            // Animación horizontal (Ancho)
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