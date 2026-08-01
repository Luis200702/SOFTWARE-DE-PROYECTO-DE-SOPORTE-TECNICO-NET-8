namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class frmInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            pnlIzquierda = new Panel();
            pnlDerecha = new Panel();
            label1 = new Label();
            lblDerechos = new Label();
            btnAcceder = new Sunny.UI.UIButton();
            txtContraseña = new Sunny.UI.UITextBox();
            txtUsuario = new Sunny.UI.UITextBox();
            lblContraseña = new Label();
            lblUsuario = new Label();
            lblInicioSesion = new Label();
            pictureBox1 = new PictureBox();
            pnlIzquierda.SuspendLayout();
            pnlDerecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlIzquierda
            // 
            pnlIzquierda.BackColor = Color.FromArgb(15, 23, 42);
            pnlIzquierda.Controls.Add(pictureBox1);
            pnlIzquierda.Location = new Point(0, 0);
            pnlIzquierda.Name = "pnlIzquierda";
            pnlIzquierda.Size = new Size(442, 511);
            pnlIzquierda.TabIndex = 0;
            // 
            // pnlDerecha
            // 
            pnlDerecha.BackColor = Color.FromArgb(30, 41, 59);
            pnlDerecha.Controls.Add(label1);
            pnlDerecha.Controls.Add(lblDerechos);
            pnlDerecha.Controls.Add(btnAcceder);
            pnlDerecha.Controls.Add(txtContraseña);
            pnlDerecha.Controls.Add(txtUsuario);
            pnlDerecha.Controls.Add(lblContraseña);
            pnlDerecha.Controls.Add(lblUsuario);
            pnlDerecha.Controls.Add(lblInicioSesion);
            pnlDerecha.Location = new Point(442, 0);
            pnlDerecha.Name = "pnlDerecha";
            pnlDerecha.Size = new Size(442, 511);
            pnlDerecha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(147, 162, 183);
            label1.Location = new Point(52, 116);
            label1.Name = "label1";
            label1.Size = new Size(240, 17);
            label1.TabIndex = 18;
            label1.Text = "Ingresa tus credenciales para continuar.";
            // 
            // lblDerechos
            // 
            lblDerechos.AutoSize = true;
            lblDerechos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDerechos.ForeColor = Color.FromArgb(147, 162, 183);
            lblDerechos.Location = new Point(131, 347);
            lblDerechos.Name = "lblDerechos";
            lblDerechos.Size = new Size(182, 17);
            lblDerechos.TabIndex = 17;
            lblDerechos.Text = "Versión 1.0 · TechDKV © 2026";
            // 
            // btnAcceder
            // 
            btnAcceder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAcceder.BackColor = Color.Transparent;
            btnAcceder.FillColor = Color.FromArgb(0, 150, 137);
            btnAcceder.FillHoverColor = Color.FromArgb(0, 150, 137);
            btnAcceder.FillPressColor = Color.FromArgb(0, 150, 137);
            btnAcceder.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnAcceder.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(52, 308);
            btnAcceder.MinimumSize = new Size(1, 1);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Radius = 12;
            btnAcceder.RectPressColor = Color.FromArgb(0, 150, 137);
            btnAcceder.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnAcceder.Size = new Size(343, 36);
            btnAcceder.TabIndex = 16;
            btnAcceder.Text = "Acceder";
            btnAcceder.TipsFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.TipsForeColor = Color.Black;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.Transparent;
            txtContraseña.FillColor = Color.FromArgb(41, 53, 72);
            txtContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(52, 271);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.MaxLength = 255;
            txtContraseña.Minimum = 0D;
            txtContraseña.MinimumSize = new Size(1, 16);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Padding = new Padding(5);
            txtContraseña.Radius = 12;
            txtContraseña.ShowText = false;
            txtContraseña.Size = new Size(343, 29);
            txtContraseña.TabIndex = 15;
            txtContraseña.TextAlignment = ContentAlignment.MiddleLeft;
            txtContraseña.Watermark = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Transparent;
            txtUsuario.FillColor = Color.FromArgb(41, 53, 72);
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(52, 206);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.MaxLength = 255;
            txtUsuario.Minimum = 0D;
            txtUsuario.MinimumSize = new Size(1, 16);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(5);
            txtUsuario.Radius = 12;
            txtUsuario.ShowText = false;
            txtUsuario.Size = new Size(343, 29);
            txtUsuario.TabIndex = 14;
            txtUsuario.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsuario.Watermark = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblContraseña.ForeColor = Color.FromArgb(147, 162, 183);
            lblContraseña.Location = new Point(50, 245);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(96, 21);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(147, 162, 183);
            lblUsuario.Location = new Point(52, 180);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(69, 21);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // lblInicioSesion
            // 
            lblInicioSesion.AutoSize = true;
            lblInicioSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInicioSesion.ForeColor = Color.FromArgb(147, 162, 183);
            lblInicioSesion.Location = new Point(52, 95);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Size = new Size(154, 21);
            lblInicioSesion.TabIndex = 0;
            lblInicioSesion.Text = "Accede a tu cuenta";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(pnlDerecha);
            Controls.Add(pnlIzquierda);
            MaximizeBox = false;
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += frmInicioSesion_Load;
            pnlIzquierda.ResumeLayout(false);
            pnlDerecha.ResumeLayout(false);
            pnlDerecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlIzquierda;
        private Panel pnlDerecha;
        private Label lblInicioSesion;
        private Label lblContraseña;
        private Label lblUsuario;
        private Sunny.UI.UITextBox txtContraseña;
        private Sunny.UI.UITextBox txtUsuario;
        private Sunny.UI.UIButton btnAcceder;
        private Label lblDerechos;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
