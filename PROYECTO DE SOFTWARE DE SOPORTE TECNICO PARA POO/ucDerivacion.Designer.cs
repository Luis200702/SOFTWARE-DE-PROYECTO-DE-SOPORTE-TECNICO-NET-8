namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucDerivacion
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
            pnltituloderivacion = new Panel();
            panel1 = new Panel();
            lblnumeroderivaciones = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            btnNuevaDerivacion = new Button();
            label2 = new Label();
            lbltipoderivacion = new Label();
            label3 = new Label();
            pnltituloderivacion.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnltituloderivacion
            // 
            pnltituloderivacion.BorderStyle = BorderStyle.Fixed3D;
            pnltituloderivacion.Controls.Add(label1);
            pnltituloderivacion.Location = new Point(0, 2);
            pnltituloderivacion.Name = "pnltituloderivacion";
            pnltituloderivacion.Size = new Size(1025, 82);
            pnltituloderivacion.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnNuevaDerivacion);
            panel1.Controls.Add(lblnumeroderivaciones);
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 58);
            panel1.TabIndex = 1;
            // 
            // lblnumeroderivaciones
            // 
            lblnumeroderivaciones.AutoSize = true;
            lblnumeroderivaciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnumeroderivaciones.ForeColor = Color.White;
            lblnumeroderivaciones.Location = new Point(44, 11);
            lblnumeroderivaciones.Name = "lblnumeroderivaciones";
            lblnumeroderivaciones.Size = new Size(120, 21);
            lblnumeroderivaciones.TabIndex = 0;
            lblnumeroderivaciones.Text = "3 Derivaciones ";
            lblnumeroderivaciones.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(644, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 602);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lbltipoderivacion);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(645, 152);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 24);
            label1.Name = "label1";
            label1.Size = new Size(331, 32);
            label1.TabIndex = 0;
            label1.Text = "Derivación Entre Sucursales";
            // 
            // btnNuevaDerivacion
            // 
            btnNuevaDerivacion.BackColor = Color.LightSeaGreen;
            btnNuevaDerivacion.FlatStyle = FlatStyle.Popup;
            btnNuevaDerivacion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaDerivacion.ForeColor = Color.White;
            btnNuevaDerivacion.Location = new Point(436, 11);
            btnNuevaDerivacion.Name = "btnNuevaDerivacion";
            btnNuevaDerivacion.Size = new Size(170, 30);
            btnNuevaDerivacion.TabIndex = 1;
            btnNuevaDerivacion.Text = "+ Nueva Derivación ";
            btnNuevaDerivacion.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(10, 4);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 0;
            label2.Text = "ORD-2026_001";
            label2.Click += label2_Click;
            // 
            // lbltipoderivacion
            // 
            lbltipoderivacion.AutoSize = true;
            lbltipoderivacion.BackColor = Color.FromArgb(26, 28, 44);
            lbltipoderivacion.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltipoderivacion.ForeColor = Color.Gold;
            lbltipoderivacion.Location = new Point(126, 4);
            lbltipoderivacion.Name = "lbltipoderivacion";
            lbltipoderivacion.Size = new Size(71, 17);
            lbltipoderivacion.TabIndex = 1;
            lbltipoderivacion.Text = "Pendiente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 35);
            label3.Name = "label3";
            label3.Size = new Size(299, 21);
            label3.TabIndex = 2;
            label3.Text = "Kevin Pinargote B - Redmi Poco x 5 pro ";
            // 
            // ucDerivacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 44);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnltituloderivacion);
            Name = "ucDerivacion";
            Size = new Size(1025, 686);
            pnltituloderivacion.ResumeLayout(false);
            pnltituloderivacion.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnltituloderivacion;
        private Panel panel1;
        private Label lblnumeroderivaciones;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button btnNuevaDerivacion;
        private Label label2;
        private Label lbltipoderivacion;
        private Label label3;
    }
}
