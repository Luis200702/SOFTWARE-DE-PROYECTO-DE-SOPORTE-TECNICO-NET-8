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
            pnlderivacionesdatos = new Panel();
            dgvderivacionsucursales = new DataGridView();
            uiUserControl1 = new Sunny.UI.UIUserControl();
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
            lblcodigo = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            uiButton1 = new Sunny.UI.UIButton();
            btnAcceder = new Sunny.UI.UIButton();
            textBox1 = new TextBox();
            label14 = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label13 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label9 = new Label();
            lblnombreDetalle = new Label();
            lblcodigoDetalle = new Label();
            lblestadoDetalle = new Label();
            panel2 = new Panel();
            label3 = new Label();
            btnxdetalles = new Button();
            pnltituloderivacion.SuspendLayout();
            panel1.SuspendLayout();
            pnlderivacionesdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvderivacionsucursales).BeginInit();
            uiUserControl1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnltituloderivacion
            // 
            pnltituloderivacion.BorderStyle = BorderStyle.FixedSingle;
            pnltituloderivacion.Controls.Add(label1);
            pnltituloderivacion.Location = new Point(3, 3);
            pnltituloderivacion.Name = "pnltituloderivacion";
            pnltituloderivacion.Size = new Size(609, 59);
            pnltituloderivacion.TabIndex = 0;
            pnltituloderivacion.Paint += pnltituloderivacion_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 18);
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
            panel1.Location = new Point(3, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 58);
            panel1.TabIndex = 1;
            panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // btnNuevaDerivacion
            // 
            btnNuevaDerivacion.BackColor = Color.LightSeaGreen;
            btnNuevaDerivacion.FlatStyle = FlatStyle.Popup;
            btnNuevaDerivacion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaDerivacion.ForeColor = Color.White;
            btnNuevaDerivacion.Location = new Point(407, 11);
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
            // pnlderivacionesdatos
            // 
            pnlderivacionesdatos.Controls.Add(dgvderivacionsucursales);
            pnlderivacionesdatos.Controls.Add(uiUserControl1);
            pnlderivacionesdatos.Controls.Add(panel5);
            pnlderivacionesdatos.Controls.Add(pnltituloderivacion);
            pnlderivacionesdatos.Controls.Add(panel1);
            pnlderivacionesdatos.Dock = DockStyle.Left;
            pnlderivacionesdatos.Location = new Point(0, 0);
            pnlderivacionesdatos.Name = "pnlderivacionesdatos";
            pnlderivacionesdatos.Size = new Size(618, 686);
            pnlderivacionesdatos.TabIndex = 3;
            pnlderivacionesdatos.Paint += panel2_Paint;
            // 
            // dgvderivacionsucursales
            // 
            dgvderivacionsucursales.AllowUserToAddRows = false;
            dgvderivacionsucursales.AllowUserToDeleteRows = false;
            dgvderivacionsucursales.BackgroundColor = Color.FromArgb(26, 28, 44);
            dgvderivacionsucursales.BorderStyle = BorderStyle.Fixed3D;
            dgvderivacionsucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvderivacionsucursales.Location = new Point(0, 118);
            dgvderivacionsucursales.Name = "dgvderivacionsucursales";
            dgvderivacionsucursales.ReadOnly = true;
            dgvderivacionsucursales.Size = new Size(612, 157);
            dgvderivacionsucursales.TabIndex = 4;
            dgvderivacionsucursales.CellContentClick += dataGridView1_CellContentClick;
            dgvderivacionsucursales.CellPainting += dataGridView1_CellPainting;
            // 
            // uiUserControl1
            // 
            uiUserControl1.Controls.Add(label4);
            uiUserControl1.Controls.Add(lblOrigenderivacion);
            uiUserControl1.Controls.Add(lblfechaderivacion);
            uiUserControl1.Controls.Add(lblGMarcaderivacion);
            uiUserControl1.Controls.Add(lblmarcaderivacion);
            uiUserControl1.Controls.Add(lblfallaDerivacion);
            uiUserControl1.Controls.Add(lblmotivoderivación);
            uiUserControl1.Controls.Add(lblDestinoderivacion);
            uiUserControl1.Controls.Add(lblUsarioderivaci);
            uiUserControl1.Controls.Add(lbltipoderivacion);
            uiUserControl1.Controls.Add(lblcodigo);
            uiUserControl1.FillColor = Color.FromArgb(26, 28, 44);
            uiUserControl1.FillColor2 = Color.FromArgb(26, 28, 44);
            uiUserControl1.FillDisableColor = Color.FromArgb(26, 28, 44);
            uiUserControl1.Font = new Font("Microsoft Sans Serif", 12F);
            uiUserControl1.Location = new Point(3, 292);
            uiUserControl1.MinimumSize = new Size(1, 1);
            uiUserControl1.Name = "uiUserControl1";
            uiUserControl1.RectColor = Color.FromArgb(192, 192, 255);
            uiUserControl1.Size = new Size(603, 150);
            uiUserControl1.TabIndex = 0;
            uiUserControl1.Text = "uiUserControl1";
            uiUserControl1.TextAlignment = ContentAlignment.MiddleCenter;
            uiUserControl1.Click += uiUserControl1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(181, 87);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 19;
            label4.Text = "➔ ";
            // 
            // lblOrigenderivacion
            // 
            lblOrigenderivacion.AutoSize = true;
            lblOrigenderivacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrigenderivacion.ForeColor = SystemColors.ButtonShadow;
            lblOrigenderivacion.Location = new Point(23, 82);
            lblOrigenderivacion.Name = "lblOrigenderivacion";
            lblOrigenderivacion.Size = new Size(130, 21);
            lblOrigenderivacion.TabIndex = 18;
            lblOrigenderivacion.Text = "Sucursal Centra  ";
            // 
            // lblfechaderivacion
            // 
            lblfechaderivacion.AutoSize = true;
            lblfechaderivacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfechaderivacion.ForeColor = SystemColors.ButtonShadow;
            lblfechaderivacion.Location = new Point(499, 81);
            lblfechaderivacion.Name = "lblfechaderivacion";
            lblfechaderivacion.Size = new Size(96, 21);
            lblfechaderivacion.TabIndex = 13;
            lblfechaderivacion.Text = "26/07/2026";
            // 
            // lblGMarcaderivacion
            // 
            lblGMarcaderivacion.AutoSize = true;
            lblGMarcaderivacion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGMarcaderivacion.ForeColor = Color.White;
            lblGMarcaderivacion.Location = new Point(306, 48);
            lblGMarcaderivacion.Name = "lblGMarcaderivacion";
            lblGMarcaderivacion.Size = new Size(220, 25);
            lblGMarcaderivacion.TabIndex = 17;
            lblGMarcaderivacion.Text = "Marca del dispositivo ...";
            // 
            // lblmarcaderivacion
            // 
            lblmarcaderivacion.AutoSize = true;
            lblmarcaderivacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmarcaderivacion.ForeColor = Color.White;
            lblmarcaderivacion.Location = new Point(306, 109);
            lblmarcaderivacion.Name = "lblmarcaderivacion";
            lblmarcaderivacion.Size = new Size(182, 21);
            lblmarcaderivacion.TabIndex = 15;
            lblmarcaderivacion.Text = "Marca del dispositivo ...";
            // 
            // lblfallaDerivacion
            // 
            lblfallaDerivacion.AutoSize = true;
            lblfallaDerivacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfallaDerivacion.ForeColor = Color.White;
            lblfallaDerivacion.Location = new Point(168, 109);
            lblfallaDerivacion.Name = "lblfallaDerivacion";
            lblfallaDerivacion.Size = new Size(88, 21);
            lblfallaDerivacion.TabIndex = 16;
            lblfallaDerivacion.Text = "repuesto...";
            // 
            // lblmotivoderivación
            // 
            lblmotivoderivación.AutoSize = true;
            lblmotivoderivación.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmotivoderivación.ForeColor = Color.White;
            lblmotivoderivación.Location = new Point(17, 107);
            lblmotivoderivación.Name = "lblmotivoderivación";
            lblmotivoderivación.Size = new Size(106, 21);
            lblmotivoderivación.TabIndex = 14;
            lblmotivoderivación.Text = "falla...         -   ";
            // 
            // lblDestinoderivacion
            // 
            lblDestinoderivacion.AutoSize = true;
            lblDestinoderivacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestinoderivacion.ForeColor = SystemColors.ButtonShadow;
            lblDestinoderivacion.Location = new Point(209, 82);
            lblDestinoderivacion.Name = "lblDestinoderivacion";
            lblDestinoderivacion.Size = new Size(120, 21);
            lblDestinoderivacion.TabIndex = 12;
            lblDestinoderivacion.Text = "  sucursal norte";
            // 
            // lblUsarioderivaci
            // 
            lblUsarioderivaci.AutoSize = true;
            lblUsarioderivaci.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsarioderivaci.ForeColor = Color.White;
            lblUsarioderivaci.Location = new Point(17, 48);
            lblUsarioderivaci.Name = "lblUsarioderivaci";
            lblUsarioderivaci.Size = new Size(116, 25);
            lblUsarioderivaci.TabIndex = 11;
            lblUsarioderivaci.Text = "Nombre... : ";
            // 
            // lbltipoderivacion
            // 
            lbltipoderivacion.AutoSize = true;
            lbltipoderivacion.BackColor = Color.FromArgb(26, 28, 44);
            lbltipoderivacion.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltipoderivacion.ForeColor = Color.Gold;
            lbltipoderivacion.Location = new Point(133, 21);
            lbltipoderivacion.Name = "lbltipoderivacion";
            lbltipoderivacion.Size = new Size(71, 17);
            lbltipoderivacion.TabIndex = 10;
            lbltipoderivacion.Text = "Pendiente";
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcodigo.ForeColor = Color.LightSeaGreen;
            lblcodigo.Location = new Point(17, 21);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(92, 17);
            lblcodigo.TabIndex = 9;
            lblcodigo.Text = "ORD-2026_001";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(26, 28, 46);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(612, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(6, 686);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Controls.Add(lblnombreDetalle);
            panel4.Controls.Add(lblcodigoDetalle);
            panel4.Controls.Add(lblestadoDetalle);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(618, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(407, 686);
            panel4.TabIndex = 4;
            panel4.Paint += panel4_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(uiButton1, 1, 0);
            tableLayoutPanel2.Controls.Add(btnAcceder, 0, 0);
            tableLayoutPanel2.Location = new Point(31, 552);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(348, 52);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // uiButton1
            // 
            uiButton1.BackColor = Color.Transparent;
            uiButton1.FillColor = Color.Brown;
            uiButton1.FillHoverColor = Color.FromArgb(0, 150, 137);
            uiButton1.FillPressColor = Color.FromArgb(0, 150, 137);
            uiButton1.FillSelectedColor = Color.FromArgb(0, 150, 137);
            uiButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiButton1.Location = new Point(177, 3);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Radius = 12;
            uiButton1.RectPressColor = Color.FromArgb(0, 150, 137);
            uiButton1.RectSelectedColor = Color.FromArgb(0, 150, 137);
            uiButton1.Size = new Size(154, 36);
            uiButton1.TabIndex = 24;
            uiButton1.Text = "Rechazar";
            uiButton1.TipsFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiButton1.TipsForeColor = Color.Black;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.Transparent;
            btnAcceder.FillColor = Color.FromArgb(0, 110, 0);
            btnAcceder.FillHoverColor = Color.FromArgb(0, 150, 137);
            btnAcceder.FillPressColor = Color.FromArgb(0, 150, 137);
            btnAcceder.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnAcceder.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(3, 3);
            btnAcceder.MinimumSize = new Size(1, 1);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Radius = 12;
            btnAcceder.RectPressColor = Color.FromArgb(0, 150, 137);
            btnAcceder.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnAcceder.Size = new Size(154, 36);
            btnAcceder.TabIndex = 23;
            btnAcceder.Text = "Aceptar";
            btnAcceder.TipsFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.TipsForeColor = Color.Black;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(26, 25, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(50, 406);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Observaciones...";
            textBox1.Size = new Size(317, 119);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(22, 374);
            label14.Name = "label14";
            label14.Size = new Size(203, 17);
            label14.TabIndex = 21;
            label14.Text = "Repuesta de la sucursal destino ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 28, 46);
            panel3.Location = new Point(0, 355);
            panel3.Name = "panel3";
            panel3.Size = new Size(407, 6);
            panel3.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.Controls.Add(label12, 1, 0);
            tableLayoutPanel1.Controls.Add(label11, 1, 1);
            tableLayoutPanel1.Controls.Add(label10, 1, 2);
            tableLayoutPanel1.Controls.Add(label13, 1, 4);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label9, 1, 3);
            tableLayoutPanel1.Location = new Point(22, 205);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(345, 144);
            tableLayoutPanel1.TabIndex = 19;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(192, 0);
            label12.Name = "label12";
            label12.Size = new Size(17, 17);
            label12.TabIndex = 21;
            label12.Text = "...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(192, 30);
            label11.Name = "label11";
            label11.Size = new Size(17, 17);
            label11.TabIndex = 21;
            label11.Text = "...";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(192, 59);
            label10.Name = "label10";
            label10.Size = new Size(17, 17);
            label10.TabIndex = 21;
            label10.Text = "...";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(192, 117);
            label13.Name = "label13";
            label13.Size = new Size(17, 17);
            label13.TabIndex = 20;
            label13.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 117);
            label8.Name = "label8";
            label8.Size = new Size(43, 17);
            label8.TabIndex = 17;
            label8.Text = "Fecha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 87);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 17;
            label7.Text = "Recurso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 59);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 17;
            label6.Text = "Motivo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 30);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 17;
            label5.Text = "Destino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 17;
            label2.Text = "Origen";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(192, 87);
            label9.Name = "label9";
            label9.Size = new Size(17, 17);
            label9.TabIndex = 21;
            label9.Text = "...";
            // 
            // lblnombreDetalle
            // 
            lblnombreDetalle.AutoSize = true;
            lblnombreDetalle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnombreDetalle.ForeColor = Color.White;
            lblnombreDetalle.Location = new Point(22, 166);
            lblnombreDetalle.Name = "lblnombreDetalle";
            lblnombreDetalle.Size = new Size(116, 25);
            lblnombreDetalle.TabIndex = 12;
            lblnombreDetalle.Text = "Nombre... : ";
            lblnombreDetalle.Click += lblnombreDetalle_Click;
            // 
            // lblcodigoDetalle
            // 
            lblcodigoDetalle.AutoSize = true;
            lblcodigoDetalle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcodigoDetalle.ForeColor = Color.LightSeaGreen;
            lblcodigoDetalle.Location = new Point(22, 139);
            lblcodigoDetalle.Name = "lblcodigoDetalle";
            lblcodigoDetalle.Size = new Size(92, 17);
            lblcodigoDetalle.TabIndex = 10;
            lblcodigoDetalle.Text = "ORD-2026_001";
            // 
            // lblestadoDetalle
            // 
            lblestadoDetalle.AutoSize = true;
            lblestadoDetalle.BackColor = Color.FromArgb(26, 28, 44);
            lblestadoDetalle.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblestadoDetalle.ForeColor = Color.Gold;
            lblestadoDetalle.Location = new Point(22, 118);
            lblestadoDetalle.Name = "lblestadoDetalle";
            lblestadoDetalle.Size = new Size(71, 17);
            lblestadoDetalle.TabIndex = 18;
            lblestadoDetalle.Text = "Pendiente";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnxdetalles);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 85);
            panel2.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 38);
            label3.Name = "label3";
            label3.Size = new Size(85, 30);
            label3.TabIndex = 15;
            label3.Text = "Detalle ";
            label3.Click += label3_Click;
            // 
            // btnxdetalles
            // 
            btnxdetalles.FlatStyle = FlatStyle.Popup;
            btnxdetalles.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxdetalles.ForeColor = Color.White;
            btnxdetalles.Location = new Point(319, 28);
            btnxdetalles.Name = "btnxdetalles";
            btnxdetalles.Size = new Size(60, 34);
            btnxdetalles.TabIndex = 16;
            btnxdetalles.Text = "x";
            btnxdetalles.UseVisualStyleBackColor = true;
            // 
            // ucDerivacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 44);
            Controls.Add(panel4);
            Controls.Add(pnlderivacionesdatos);
            Name = "ucDerivacion";
            Size = new Size(1025, 686);
            Load += ucDerivacion_Load_1;
            pnltituloderivacion.ResumeLayout(false);
            pnltituloderivacion.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlderivacionesdatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvderivacionsucursales).EndInit();
            uiUserControl1.ResumeLayout(false);
            uiUserControl1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnltituloderivacion;
        private Panel panel1;
        private Label lblnumeroderivaciones;
        private Label label1;
        private Button btnNuevaDerivacion;
        private Panel pnlderivacionesdatos;
        private Panel panel4;
        private Panel panel5;
        private Sunny.UI.UIUserControl uiUserControl1;
        private Label label4;
        private Label lblOrigenderivacion;
        private Label lblfechaderivacion;
        private Label lblGMarcaderivacion;
        private Label lblmarcaderivacion;
        private Label lblfallaDerivacion;
        private Label lblmotivoderivación;
        private Label lblDestinoderivacion;
        private Label lblUsarioderivaci;
        private Label lbltipoderivacion;
        private Label lblcodigo;
        private Label label3;
        private Button btnxdetalles;
        private Panel panel2;
        private Label lblcodigoDetalle;
        private Label lblestadoDetalle;
        private Label lblnombreDetalle;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label13;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Panel panel3;
        private TextBox textBox1;
        private Label label14;
        private Sunny.UI.UIButton btnAcceder;
        private Sunny.UI.UIButton uiButton1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvderivacionsucursales;
    }
}
