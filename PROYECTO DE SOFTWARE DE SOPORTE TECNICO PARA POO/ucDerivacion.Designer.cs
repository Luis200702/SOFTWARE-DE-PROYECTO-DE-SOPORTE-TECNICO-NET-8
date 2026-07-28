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
            label1 = new Label();
            panel1 = new Panel();
            btnNuevaDerivacion = new Button();
            lblnumeroderivaciones = new Label();
            panel2 = new Panel();
            dtgDetallesDerivacion = new DataGridView();
            panel3 = new Panel();
            label4 = new Label();
            lblOrigenderivacion = new Label();
            lblfechaderivacion = new Label();
            lblGMarcaderivacion = new Label();
            lblmarcaderivacion = new Label();
            lblfallaDerivacion = new Label();
            lblmotivoderivación = new Label();
            lblDestinoderivacion = new Label();
            lblUsarioderivaci = new Label();
            lbltipoderivacion = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel5 = new Panel();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            pnltituloderivacion.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDetallesDerivacion).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pnltituloderivacion
            // 
            pnltituloderivacion.BorderStyle = BorderStyle.FixedSingle;
            pnltituloderivacion.Controls.Add(label1);
            pnltituloderivacion.Location = new Point(0, 2);
            pnltituloderivacion.Name = "pnltituloderivacion";
            pnltituloderivacion.Size = new Size(1025, 82);
            pnltituloderivacion.TabIndex = 0;
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnNuevaDerivacion);
            panel1.Controls.Add(lblnumeroderivaciones);
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 58);
            panel1.TabIndex = 1;
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
            btnNuevaDerivacion.Click += btnNuevaDerivacion_Click;
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
            panel2.Controls.Add(dtgDetallesDerivacion);
            panel2.Location = new Point(644, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 602);
            panel2.TabIndex = 0;
            // 
            // dtgDetallesDerivacion
            // 
            dtgDetallesDerivacion.BackgroundColor = Color.FromArgb(26, 28, 44);
            dtgDetallesDerivacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDetallesDerivacion.Location = new Point(-2, -4);
            dtgDetallesDerivacion.Name = "dtgDetallesDerivacion";
            dtgDetallesDerivacion.Size = new Size(381, 601);
            dtgDetallesDerivacion.TabIndex = 0;
            dtgDetallesDerivacion.CellContentClick += dtgDetallesDerivacion_CellContentClick;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblOrigenderivacion);
            panel3.Controls.Add(lblfechaderivacion);
            panel3.Controls.Add(lblGMarcaderivacion);
            panel3.Controls.Add(lblmarcaderivacion);
            panel3.Controls.Add(lblfallaDerivacion);
            panel3.Controls.Add(lblmotivoderivación);
            panel3.Controls.Add(lblDestinoderivacion);
            panel3.Controls.Add(lblUsarioderivaci);
            panel3.Controls.Add(lbltipoderivacion);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(645, 128);
            panel3.TabIndex = 2;
            panel3.Click += panel3_Click;
            panel3.Paint += panel3_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(174, 70);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 8;
            label4.Text = "➔ ";
            // 
            // lblOrigenderivacion
            // 
            lblOrigenderivacion.AutoSize = true;
            lblOrigenderivacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrigenderivacion.ForeColor = SystemColors.ButtonShadow;
            lblOrigenderivacion.Location = new Point(16, 65);
            lblOrigenderivacion.Name = "lblOrigenderivacion";
            lblOrigenderivacion.Size = new Size(130, 21);
            lblOrigenderivacion.TabIndex = 7;
            lblOrigenderivacion.Text = "Sucursal Centra  ";
            // 
            // lblfechaderivacion
            // 
            lblfechaderivacion.AutoSize = true;
            lblfechaderivacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfechaderivacion.ForeColor = SystemColors.ButtonShadow;
            lblfechaderivacion.Location = new Point(525, 65);
            lblfechaderivacion.Name = "lblfechaderivacion";
            lblfechaderivacion.Size = new Size(96, 21);
            lblfechaderivacion.TabIndex = 4;
            lblfechaderivacion.Text = "26/07/2026";
            // 
            // lblGMarcaderivacion
            // 
            lblGMarcaderivacion.AutoSize = true;
            lblGMarcaderivacion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGMarcaderivacion.ForeColor = Color.White;
            lblGMarcaderivacion.Location = new Point(299, 31);
            lblGMarcaderivacion.Name = "lblGMarcaderivacion";
            lblGMarcaderivacion.Size = new Size(181, 25);
            lblGMarcaderivacion.TabIndex = 6;
            lblGMarcaderivacion.Text = "Redmi Poco x5 pro\r\n";
            // 
            // lblmarcaderivacion
            // 
            lblmarcaderivacion.AutoSize = true;
            lblmarcaderivacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmarcaderivacion.ForeColor = Color.White;
            lblmarcaderivacion.Location = new Point(299, 92);
            lblmarcaderivacion.Name = "lblmarcaderivacion";
            lblmarcaderivacion.Size = new Size(148, 21);
            lblmarcaderivacion.TabIndex = 5;
            lblmarcaderivacion.Text = "Redmi Poco x5 pro\r\n";
            // 
            // lblfallaDerivacion
            // 
            lblfallaDerivacion.AutoSize = true;
            lblfallaDerivacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfallaDerivacion.ForeColor = Color.White;
            lblfallaDerivacion.Location = new Point(161, 92);
            lblfallaDerivacion.Name = "lblfallaDerivacion";
            lblfallaDerivacion.Size = new Size(132, 21);
            lblfallaDerivacion.TabIndex = 5;
            lblfallaDerivacion.Text = "Conector USB-C ";
            // 
            // lblmotivoderivación
            // 
            lblmotivoderivación.AutoSize = true;
            lblmotivoderivación.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmotivoderivación.ForeColor = Color.White;
            lblmotivoderivación.Location = new Point(10, 90);
            lblmotivoderivación.Name = "lblmotivoderivación";
            lblmotivoderivación.Size = new Size(162, 21);
            lblmotivoderivación.TabIndex = 4;
            lblmotivoderivación.Text = "Falta de repuesto  -   ";
            // 
            // lblDestinoderivacion
            // 
            lblDestinoderivacion.AutoSize = true;
            lblDestinoderivacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestinoderivacion.ForeColor = SystemColors.ButtonShadow;
            lblDestinoderivacion.Location = new Point(202, 65);
            lblDestinoderivacion.Name = "lblDestinoderivacion";
            lblDestinoderivacion.Size = new Size(120, 21);
            lblDestinoderivacion.TabIndex = 3;
            lblDestinoderivacion.Text = "  sucursal norte";
            // 
            // lblUsarioderivaci
            // 
            lblUsarioderivaci.AutoSize = true;
            lblUsarioderivaci.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsarioderivaci.ForeColor = Color.White;
            lblUsarioderivaci.Location = new Point(10, 31);
            lblUsarioderivaci.Name = "lblUsarioderivaci";
            lblUsarioderivaci.Size = new Size(258, 25);
            lblUsarioderivaci.TabIndex = 2;
            lblUsarioderivaci.Text = "Kevin Pinargote Balarezo   -";
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
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Location = new Point(-1, 269);
            panel4.Name = "panel4";
            panel4.Size = new Size(645, 128);
            panel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(526, 63);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 4;
            label5.Text = "26/07/2026";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(299, 31);
            label7.Name = "label7";
            label7.Size = new Size(188, 25);
            label7.TabIndex = 6;
            label7.Text = " Redmi note 60 pro ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(332, 92);
            label8.Name = "label8";
            label8.Size = new Size(147, 21);
            label8.TabIndex = 5;
            label8.Text = "Remid note 60 pro\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(161, 92);
            label9.Name = "label9";
            label9.Size = new Size(165, 21);
            label9.TabIndex = 5;
            label9.Text = "Bateria no disponible";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(10, 90);
            label10.Name = "label10";
            label10.Size = new Size(162, 21);
            label10.TabIndex = 4;
            label10.Text = "Falta de repuesto  -   ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonShadow;
            label11.Location = new Point(10, 63);
            label11.Name = "label11";
            label11.Size = new Size(257, 21);
            label11.TabIndex = 3;
            label11.Text = "Sucursal Centra  ➔  sucursal norte";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(10, 31);
            label12.Name = "label12";
            label12.Size = new Size(174, 25);
            label12.TabIndex = 2;
            label12.Text = "Luiz Cruz Agual   -";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(26, 28, 44);
            label13.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Gold;
            label13.Location = new Point(126, 4);
            label13.Name = "label13";
            label13.Size = new Size(71, 17);
            label13.TabIndex = 1;
            label13.Text = "Pendiente";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.LightSeaGreen;
            label14.Location = new Point(10, 4);
            label14.Name = "label14";
            label14.Size = new Size(94, 17);
            label14.TabIndex = 0;
            label14.Text = "ORD-2026_002";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label20);
            panel5.Controls.Add(label21);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(label23);
            panel5.Location = new Point(-1, 397);
            panel5.Name = "panel5";
            panel5.Size = new Size(645, 128);
            panel5.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ButtonShadow;
            label15.Location = new Point(525, 65);
            label15.Name = "label15";
            label15.Size = new Size(96, 21);
            label15.TabIndex = 4;
            label15.Text = "26/07/2026";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(299, 31);
            label16.Name = "label16";
            label16.Size = new Size(188, 25);
            label16.TabIndex = 6;
            label16.Text = "IPhone 15 Pro Max \r\n";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(299, 92);
            label17.Name = "label17";
            label17.Size = new Size(148, 21);
            label17.TabIndex = 5;
            label17.Text = "IPhone 15 Pro Max ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(161, 92);
            label18.Name = "label18";
            label18.Size = new Size(66, 21);
            label18.TabIndex = 5;
            label18.Text = "Display ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(10, 90);
            label19.Name = "label19";
            label19.Size = new Size(162, 21);
            label19.TabIndex = 4;
            label19.Text = "Falta de repuesto  -   ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.ButtonShadow;
            label20.Location = new Point(10, 63);
            label20.Name = "label20";
            label20.Size = new Size(257, 21);
            label20.TabIndex = 3;
            label20.Text = "Sucursal Centra  ➔  sucursal norte";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(10, 31);
            label21.Name = "label21";
            label21.Size = new Size(241, 25);
            label21.TabIndex = 2;
            label21.Text = "Justin Maldonado Cruz   -";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(26, 28, 44);
            label22.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Gold;
            label22.Location = new Point(126, 4);
            label22.Name = "label22";
            label22.Size = new Size(71, 17);
            label22.TabIndex = 1;
            label22.Text = "Pendiente";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.LightSeaGreen;
            label23.Location = new Point(10, 4);
            label23.Name = "label23";
            label23.Size = new Size(94, 17);
            label23.TabIndex = 0;
            label23.Text = "ORD-2026_003";
            // 
            // ucDerivacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 44);
            Controls.Add(panel5);
            Controls.Add(panel4);
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
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDetallesDerivacion).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Label lblUsarioderivaci;
        private Label lblDestinoderivacion;
        private Label lblmotivoderivación;
        private Label lblmarcaderivacion;
        private Label lblfallaDerivacion;
        private Label lblfechaderivacion;
        private Label lblGMarcaderivacion;
        private Panel panel4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Panel panel5;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private DataGridView dtgDetallesDerivacion;
        private Label label4;
        private Label lblOrigenderivacion;
    }
}
