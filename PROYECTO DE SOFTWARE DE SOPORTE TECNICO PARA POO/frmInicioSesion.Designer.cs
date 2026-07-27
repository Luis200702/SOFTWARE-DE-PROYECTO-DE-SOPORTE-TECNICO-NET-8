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
            lblInicioSesion = new Label();
            btnAcceder = new Button();
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
            pnlDerecha.Controls.Add(btnAcceder);
            pnlDerecha.Controls.Add(lblInicioSesion);
            pnlDerecha.Location = new Point(442, 0);
            pnlDerecha.Name = "pnlDerecha";
            pnlDerecha.Size = new Size(442, 511);
            pnlDerecha.TabIndex = 1;
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
    }
}
