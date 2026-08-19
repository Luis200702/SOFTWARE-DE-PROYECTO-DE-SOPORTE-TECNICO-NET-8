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
            pictureBox1 = new PictureBox();
            pnlDerecha = new Panel();
            label1 = new Label();
            lblDerechos = new Label();
            btnAcceder = new Sunny.UI.UIButton();
            txtContrasena = new Sunny.UI.UITextBox();
            btnVerContrasena = new Sunny.UI.UISymbolButton();
            txtUsuario = new Sunny.UI.UITextBox();
            lblContraseña = new Label();
            lblUsuario = new Label();
            lblInicioSesion = new Label();
            pnlIzquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDerecha.SuspendLayout();
            txtContrasena.SuspendLayout();
            SuspendLayout();
            // 
            // pnlIzquierda
            // 
            pnlIzquierda.BackColor = Color.FromArgb(28, 43, 60);
            pnlIzquierda.Controls.Add(pictureBox1);
            pnlIzquierda.Location = new Point(0, 0);
            pnlIzquierda.Name = "pnlIzquierda";
            pnlIzquierda.Size = new Size(442, 511);
            pnlIzquierda.TabIndex = 0;
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
            // pnlDerecha
            // 
            pnlDerecha.BackColor = Color.FromArgb(243, 246, 250);
            pnlDerecha.Controls.Add(label1);
            pnlDerecha.Controls.Add(lblDerechos);
            pnlDerecha.Controls.Add(btnAcceder);
            pnlDerecha.Controls.Add(txtContrasena);
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(70, 86, 103);
            label1.Location = new Point(52, 106);
            label1.Name = "label1";
            label1.Size = new Size(283, 21);
            label1.TabIndex = 18;
            label1.Text = "Ingresa tus credenciales para continuar.";
            // 
            // lblDerechos
            // 
            lblDerechos.AutoSize = true;
            lblDerechos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDerechos.ForeColor = Color.FromArgb(70, 86, 103);
            lblDerechos.Location = new Point(149, 402);
            lblDerechos.Name = "lblDerechos";
            lblDerechos.Size = new Size(160, 15);
            lblDerechos.TabIndex = 17;
            lblDerechos.Text = "Versión 1.0 · TechDKV © 2026";
            // 
            // btnAcceder
            // 
            btnAcceder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAcceder.BackColor = Color.Transparent;
            btnAcceder.FillColor = Color.FromArgb(0, 165, 155);
            btnAcceder.FillHoverColor = Color.FromArgb(0, 145, 137);
            btnAcceder.FillPressColor = Color.FromArgb(0, 150, 137);
            btnAcceder.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnAcceder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(52, 348);
            btnAcceder.MinimumSize = new Size(1, 1);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Radius = 12;
            btnAcceder.RectColor = Color.FromArgb(0, 165, 155);
            btnAcceder.RectHoverColor = Color.FromArgb(80, 160, 255);
            btnAcceder.RectPressColor = Color.FromArgb(0, 150, 137);
            btnAcceder.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnAcceder.Size = new Size(343, 37);
            btnAcceder.TabIndex = 16;
            btnAcceder.Text = "Acceder";
            btnAcceder.TipsFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.TipsForeColor = Color.Black;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.Transparent;
            txtContrasena.ButtonSymbol = 61552;
            txtContrasena.Controls.Add(btnVerContrasena);
            txtContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.ForeColor = Color.FromArgb(24, 43, 62);
            txtContrasena.Location = new Point(52, 274);
            txtContrasena.Margin = new Padding(4, 5, 4, 5);
            txtContrasena.MaxLength = 255;
            txtContrasena.Minimum = 0D;
            txtContrasena.MinimumSize = new Size(1, 16);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Padding = new Padding(5);
            txtContrasena.PasswordChar = '●';
            txtContrasena.Radius = 12;
            txtContrasena.RectColor = Color.FromArgb(220, 226, 232);
            txtContrasena.RectDisableColor = Color.FromArgb(0, 165, 155);
            txtContrasena.RectReadOnlyColor = Color.FromArgb(0, 165, 155);
            txtContrasena.ShowText = false;
            txtContrasena.Size = new Size(343, 37);
            txtContrasena.Symbol = 61572;
            txtContrasena.SymbolColor = Color.FromArgb(0, 165, 155);
            txtContrasena.TabIndex = 15;
            txtContrasena.TextAlignment = ContentAlignment.MiddleLeft;
            txtContrasena.Watermark = "Contraseña";
            txtContrasena.WatermarkColor = Color.FromArgb(145, 158, 172);
            // 
            // btnVerContrasena
            // 
            btnVerContrasena.FillColor = Color.White;
            btnVerContrasena.FillHoverColor = Color.White;
            btnVerContrasena.Font = new Font("Microsoft Sans Serif", 12F);
            btnVerContrasena.Location = new Point(307, 1);
            btnVerContrasena.MinimumSize = new Size(1, 1);
            btnVerContrasena.Name = "btnVerContrasena";
            btnVerContrasena.Radius = 12;
            btnVerContrasena.RectColor = Color.White;
            btnVerContrasena.RectHoverColor = Color.White;
            btnVerContrasena.RectPressColor = Color.White;
            btnVerContrasena.RectSelectedColor = Color.White;
            btnVerContrasena.Size = new Size(35, 35);
            btnVerContrasena.Symbol = 61552;
            btnVerContrasena.SymbolColor = Color.FromArgb(70, 86, 103);
            btnVerContrasena.TabIndex = 20;
            btnVerContrasena.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnVerContrasena.Click += btnVerContrasena_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Transparent;
            txtUsuario.ButtonRectHoverColor = Color.FromArgb(0, 165, 155);
            txtUsuario.ButtonRectPressColor = Color.FromArgb(0, 165, 155);
            txtUsuario.ButtonStyleInherited = false;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(24, 43, 62);
            txtUsuario.Location = new Point(52, 195);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.MaxLength = 255;
            txtUsuario.Minimum = 0D;
            txtUsuario.MinimumSize = new Size(1, 16);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(5);
            txtUsuario.Radius = 12;
            txtUsuario.RectColor = Color.FromArgb(220, 226, 232);
            txtUsuario.RectDisableColor = Color.FromArgb(0, 165, 155);
            txtUsuario.RectReadOnlyColor = Color.FromArgb(0, 165, 155);
            txtUsuario.ShowText = false;
            txtUsuario.Size = new Size(343, 37);
            txtUsuario.Symbol = 61447;
            txtUsuario.SymbolColor = Color.FromArgb(0, 165, 155);
            txtUsuario.TabIndex = 14;
            txtUsuario.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsuario.Watermark = "Usuario";
            txtUsuario.WatermarkColor = Color.FromArgb(145, 158, 172);
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblContraseña.ForeColor = Color.FromArgb(24, 43, 62);
            lblContraseña.Location = new Point(52, 248);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(96, 21);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(24, 43, 62);
            lblUsuario.Location = new Point(52, 169);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(69, 21);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // lblInicioSesion
            // 
            lblInicioSesion.AutoSize = true;
            lblInicioSesion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInicioSesion.ForeColor = Color.FromArgb(24, 43, 62);
            lblInicioSesion.Location = new Point(52, 76);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Size = new Size(199, 30);
            lblInicioSesion.TabIndex = 0;
            lblInicioSesion.Text = "Accede a tu cuenta";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDerecha.ResumeLayout(false);
            pnlDerecha.PerformLayout();
            txtContrasena.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlIzquierda;
        private Panel pnlDerecha;
        private Label lblInicioSesion;
        private Label lblContraseña;
        private Label lblUsuario;
        private Sunny.UI.UITextBox txtContrasena;
        private Sunny.UI.UITextBox txtUsuario;
        private Sunny.UI.UIButton btnAcceder;
        private Label lblDerechos;
        private Label label1;
        private PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton btnVerContrasena;
    }
}
