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
            pnlIzquierda = new Panel();
            pnlDerecha = new Panel();
            lblContraseña = new Label();
            lblUsuario = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            btnAcceder = new Button();
            lblInicioSesion = new Label();
            pnlDerecha.SuspendLayout();
            SuspendLayout();
            // 
            // pnlIzquierda
            // 
            pnlIzquierda.Location = new Point(0, 0);
            pnlIzquierda.Name = "pnlIzquierda";
            pnlIzquierda.Size = new Size(442, 511);
            pnlIzquierda.TabIndex = 0;
            // 
            // pnlDerecha
            // 
            pnlDerecha.Controls.Add(lblContraseña);
            pnlDerecha.Controls.Add(lblUsuario);
            pnlDerecha.Controls.Add(txtContraseña);
            pnlDerecha.Controls.Add(txtUsuario);
            pnlDerecha.Controls.Add(btnAcceder);
            pnlDerecha.Controls.Add(lblInicioSesion);
            pnlDerecha.Location = new Point(442, 0);
            pnlDerecha.Name = "pnlDerecha";
            pnlDerecha.Size = new Size(442, 511);
            pnlDerecha.TabIndex = 1;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(50, 249);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(50, 186);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(52, 269);
            txtContraseña.MaxLength = 32;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(343, 23);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(52, 206);
            txtUsuario.MaxLength = 32;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(343, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(164, 300);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(123, 54);
            btnAcceder.TabIndex = 1;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // lblInicioSesion
            // 
            lblInicioSesion.AutoSize = true;
            lblInicioSesion.Location = new Point(161, 53);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Size = new Size(108, 15);
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
            Text = "Inicio de Sesión";
            pnlDerecha.ResumeLayout(false);
            pnlDerecha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlIzquierda;
        private Panel pnlDerecha;
        private Label lblInicioSesion;
        private Button btnAcceder;
        private Label lblContraseña;
        private Label lblUsuario;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
    }
}
