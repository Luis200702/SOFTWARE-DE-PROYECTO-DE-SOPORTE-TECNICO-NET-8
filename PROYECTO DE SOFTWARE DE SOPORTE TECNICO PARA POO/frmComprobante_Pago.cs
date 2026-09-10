using Sunny.UI;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmComprobante_Pago : Form
    {
        private string rutaArchivoSeleccionado = "";
        public byte[] ComprobanteBytes { get; private set; } = Array.Empty<byte>();
        public string NombreComprobante { get; private set; } = "";

        public frmComprobante_Pago()
        {
            InitializeComponent();
            AplicarDiseñoFigma();
            ConfigurarDragAndDrop();

            btnAdjuntar.Enabled = false;
        }


        private void AplicarDiseñoFigma()
        {

            Color grisTextoClaro = Color.FromArgb(130, 140, 150);
            Color grisTextoOscuro = Color.FromArgb(70, 80, 90);
            Color verdeBoton = Color.FromArgb(144, 202, 195); // El verde agua suave
            Color amarilloTexto = Color.FromArgb(210, 120, 30);

            // En lugar de un salto de línea forzado con \n, deja que fluya o divídelo bien:
            lblAlerta.Text = "Asegúrate de que el comprobante muestre el monto, \nfecha y referencia de la transferencia.";

            // 2. Ajuste dinámico de los botones para que no se superpongan
            if (btnCancelar != null && btnAdjuntar != null)
            {
                btnCancelar.FillColor = Color.White;
                btnCancelar.FillHoverColor = Color.FromArgb(245, 245, 245);
                btnCancelar.ForeColor = grisTextoOscuro;
                btnCancelar.RectColor = Color.FromArgb(220, 220, 220);
                btnCancelar.Cursor = Cursors.Hand;
                btnCancelar.Width = 110; // Ancho fijo

                btnAdjuntar.FillColor = verdeBoton;
                btnAdjuntar.FillHoverColor = Color.FromArgb(120, 190, 180);
                btnAdjuntar.RectColor = verdeBoton;
                btnAdjuntar.ForeColor = Color.White;
                btnAdjuntar.Cursor = Cursors.Hand;
                btnAdjuntar.Width = 220; // 🔥 Ancho ampliado para que quepa todo el texto sin recortes

                // Centramos ambos botones juntos en el formulario para evitar que se pisen
                int espacioEntreBotones = 15;
                int anchoTotalBotones = btnCancelar.Width + espacioEntreBotones + btnAdjuntar.Width;
                int posicionXInicial = (this.ClientSize.Width - anchoTotalBotones) / 2;

                btnCancelar.Location = new Point(posicionXInicial, btnCancelar.Location.Y);
                btnAdjuntar.Location = new Point(posicionXInicial + btnCancelar.Width + espacioEntreBotones, btnCancelar.Location.Y);
            }

            // 4. Panel de Carga usando UIPanel
            if (pnlCarga != null && pnlCarga is UIPanel pnlDrop)
            {
                pnlDrop.FillColor = Color.White;
                pnlDrop.RectColor = Color.Transparent;
                pnlDrop.Cursor = Cursors.Hand;
                pnlDrop.Paint -= PnlCarga_Paint;
                pnlDrop.Paint += PnlCarga_Paint;

                pnlDrop.Controls.Clear();

                // A) Ícono central (Imagen)
                UIAvatar iconImg = new UIAvatar();
                iconImg.Symbol = 61502; // Ícono de fotografía
                iconImg.FillColor = Color.White;
                iconImg.BackColor = Color.White;
                iconImg.ForeColor = Color.FromArgb(180, 190, 200); // Gris clarito
                iconImg.Size = new Size(60, 50);
                iconImg.Location = new Point((pnlDrop.Width - iconImg.Width) / 2, (pnlDrop.Height / 2) - 35);
                pnlDrop.Controls.Add(iconImg);

                // B) Texto Principal
                Label lblArrastra = new Label();
                lblArrastra.Text = "Arrastra aquí o haz clic para seleccionar";
                lblArrastra.ForeColor = Color.FromArgb(100, 110, 120);
                lblArrastra.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                lblArrastra.AutoSize = false;
                lblArrastra.TextAlign = ContentAlignment.MiddleCenter;
                lblArrastra.Size = new Size(pnlDrop.Width, 25);
                lblArrastra.Location = new Point(0, iconImg.Bottom + 5);
                lblArrastra.BackColor = Color.White;
                pnlDrop.Controls.Add(lblArrastra);

                // C) Texto Secundario (Formatos)
                Label lblFormato = new Label();
                lblFormato.Text = "PNG, JPG, JPEG · máx. 5 MB";
                lblFormato.ForeColor = Color.FromArgb(140, 150, 160);
                lblFormato.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
                lblFormato.AutoSize = false;
                lblFormato.TextAlign = ContentAlignment.MiddleCenter;
                lblFormato.Size = new Size(pnlDrop.Width, 20);
                lblFormato.Location = new Point(0, lblArrastra.Bottom);
                lblFormato.BackColor = Color.White;
                pnlDrop.Controls.Add(lblFormato);
            }
        }

        // --- 2. DIBUJO DEL BORDE PUNTEADO REDONDEADO PARA UIPANEL ---
        private void PnlCarga_Paint(object sender, PaintEventArgs e)
        {
            UIPanel pnl = sender as UIPanel;
            if (pnl == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Creamos el lápiz para el borde punteado
            using (Pen pen = new Pen(Color.FromArgb(210, 215, 220), 1.5f))
            {
                pen.DashStyle = DashStyle.Dash;
                pen.DashPattern = new float[] { 5, 5 };

                int radio = pnl.Radius;
                Rectangle rect = new Rectangle(1, 1, pnl.Width - 3, pnl.Height - 3);

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                    path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                    path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                    path.CloseFigure();

                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        // --- 3. LÓGICA DE DRAG & DROP (ARRASTRAR Y SOLTAR) ---
        private void ConfigurarDragAndDrop()
        {
            if (pnlCarga == null)
                return;

            ConfigurarControlParaCarga(pnlCarga);

            foreach (Control control in pnlCarga.Controls)
            {
                ConfigurarControlParaCarga(control);
            }
        }

        private void ConfigurarControlParaCarga(Control control)
        {
            control.AllowDrop = true;

            // Evita registrar los mismos eventos más de una vez.
            control.DragEnter -= PnlCarga_DragEnter;
            control.DragDrop -= PnlCarga_DragDrop;
            control.Click -= PnlCarga_Click;

            control.DragEnter += PnlCarga_DragEnter;
            control.DragDrop += PnlCarga_DragDrop;
            control.Click += PnlCarga_Click;
        }

        private void PnlCarga_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void PnlCarga_DragDrop(object sender, DragEventArgs e)
        {
            string[]? archivos = e.Data.GetData(DataFormats.FileDrop) as string[];

            if (archivos != null && archivos.Length > 0)
            {
                ProcesarArchivo(archivos[0]);
            }
        }

        private void PnlCarga_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecciona el comprobante";
                ofd.Filter = "Imágenes (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ProcesarArchivo(ofd.FileName);
                }
            }
        }
        private void MostrarVistaPrevia(string rutaArchivo, string nombreArchivo)
        {
            foreach (Control control in pnlCarga.Controls)
            {
                if (control is PictureBox pictureBox && pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;
                }

                control.Dispose();
            }

            pnlCarga.Controls.Clear();

            PictureBox picComprobante = new PictureBox
            {
                Size = new Size(pnlCarga.Width - 40, pnlCarga.Height - 70),
                Location = new Point(20, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.White,
                Cursor = Cursors.Hand
            };

            using (FileStream stream = new FileStream(
                rutaArchivo,
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read))
            using (Image imagenTemporal = Image.FromStream(stream))
            {
                picComprobante.Image = new Bitmap(imagenTemporal);
            }

            Label lblArchivo = new Label
            {
                Text = nombreArchivo + "  ·  Haz clic para cambiar",
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.FromArgb(70, 80, 90),
                BackColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoEllipsis = true,
                Size = new Size(pnlCarga.Width - 20, 30),
                Location = new Point(10, pnlCarga.Height - 45),
                Cursor = Cursors.Hand
            };

            pnlCarga.Controls.Add(picComprobante);
            pnlCarga.Controls.Add(lblArchivo);

            ConfigurarControlParaCarga(picComprobante);
            ConfigurarControlParaCarga(lblArchivo);
        }

        private void ProcesarArchivo(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo) || !File.Exists(rutaArchivo))
            {
                MessageBox.Show(
                    "No se pudo encontrar el archivo seleccionado.",
                    "Archivo no válido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            FileInfo fileInfo = new FileInfo(rutaArchivo);
            string extension = Path.GetExtension(rutaArchivo).ToLowerInvariant();

            if (extension != ".png" &&
                extension != ".jpg" &&
                extension != ".jpeg")
            {
                MessageBox.Show(
                    "Solo se permiten imágenes PNG, JPG o JPEG.",
                    "Formato no válido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (fileInfo.Length > 5 * 1024 * 1024)
            {
                MessageBox.Show(
                    "El archivo es demasiado grande. El límite es 5 MB.",
                    "Archivo demasiado grande",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MostrarVistaPrevia(rutaArchivo, fileInfo.Name);

                rutaArchivoSeleccionado = rutaArchivo;
                btnAdjuntar.Enabled = true;
            }
            catch
            {
                rutaArchivoSeleccionado = "";
                btnAdjuntar.Enabled = false;

                MessageBox.Show(
                    "El archivo seleccionado no pudo mostrarse como imagen.",
                    "Imagen no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // --- 4. ACCIONES DE LOS BOTONES ---
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivoSeleccionado))
            {
                MessageBox.Show(
                    "Por favor, selecciona o arrastra un comprobante primero.",
                    "Falta comprobante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                ComprobanteBytes = File.ReadAllBytes(rutaArchivoSeleccionado);
                NombreComprobante = Path.GetFileName(rutaArchivoSeleccionado);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar el comprobante: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}