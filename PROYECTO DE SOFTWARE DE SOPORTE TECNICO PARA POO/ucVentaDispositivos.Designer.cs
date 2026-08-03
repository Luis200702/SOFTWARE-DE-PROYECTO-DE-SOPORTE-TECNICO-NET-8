namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucVentaDispositivos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlInformacion = new Panel();
            btnVenta = new Sunny.UI.UIButton();
            txtDispositivoComprador = new Sunny.UI.UITextBox();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.FromArgb(30, 41, 59);
            pnlSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(-7, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1037, 59);
            pnlSuperior.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MdiCartVariant;
            pictureBox1.Location = new Point(31, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(313, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Venta de Dispositivos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.BackColor = Color.FromArgb(30, 41, 59);
            pnlInformacion.Controls.Add(btnVenta);
            pnlInformacion.Controls.Add(txtDispositivoComprador);
            pnlInformacion.Location = new Point(0, 59);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1022, 59);
            pnlInformacion.TabIndex = 3;
            // 
            // btnVenta
            // 
            btnVenta.FillColor = Color.FromArgb(0, 150, 137);
            btnVenta.Font = new Font("Microsoft Sans Serif", 12F);
            btnVenta.Location = new Point(873, 14);
            btnVenta.MinimumSize = new Size(1, 1);
            btnVenta.Name = "btnVenta";
            btnVenta.Radius = 12;
            btnVenta.RectColor = Color.FromArgb(0, 150, 137);
            btnVenta.Size = new Size(129, 31);
            btnVenta.TabIndex = 20;
            btnVenta.Text = "Nueva Venta";
            btnVenta.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // txtDispositivoComprador
            // 
            txtDispositivoComprador.FillColor = Color.FromArgb(41, 53, 72);
            txtDispositivoComprador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDispositivoComprador.ForeColor = Color.White;
            txtDispositivoComprador.Icon = Properties.Resources.TablerSearch;
            txtDispositivoComprador.Location = new Point(29, 14);
            txtDispositivoComprador.Margin = new Padding(4, 5, 4, 5);
            txtDispositivoComprador.MinimumSize = new Size(1, 16);
            txtDispositivoComprador.Name = "txtDispositivoComprador";
            txtDispositivoComprador.Padding = new Padding(5);
            txtDispositivoComprador.Radius = 12;
            txtDispositivoComprador.RectColor = Color.FromArgb(39, 53, 72);
            txtDispositivoComprador.ShowText = false;
            txtDispositivoComprador.Size = new Size(295, 30);
            txtDispositivoComprador.TabIndex = 3;
            txtDispositivoComprador.TextAlignment = ContentAlignment.MiddleLeft;
            txtDispositivoComprador.Watermark = "Buscar dispositivo o comprador";
            // 
            // ucVentaDispositivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlSuperior);
            Name = "ucVentaDispositivos";
            Size = new Size(1022, 781);
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInformacion.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlInformacion;
        private Sunny.UI.UIButton btnVenta;
        private Sunny.UI.UITextBox txtDispositivoComprador;
    }
}
