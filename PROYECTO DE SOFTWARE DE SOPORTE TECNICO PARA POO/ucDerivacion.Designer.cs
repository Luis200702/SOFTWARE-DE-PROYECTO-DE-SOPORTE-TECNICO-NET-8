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
            components = new System.ComponentModel.Container();
            dgvderivacionsucursales = new DataGridView();
            panel2 = new Panel();
            uiButton3 = new Sunny.UI.UIButton();
            label3 = new Label();
            pnlDetallesDerivaciones = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnRechazarDerivacion = new Sunny.UI.UIButton();
            btnAceptarDerivacion = new Sunny.UI.UIButton();
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
            uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip(components);
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlInformacion = new Panel();
            label15 = new Label();
            label4 = new Label();
            btnBuscar = new Sunny.UI.UIButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvderivacionsucursales).BeginInit();
            panel2.SuspendLayout();
            pnlDetallesDerivaciones.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            SuspendLayout();
            // 
            // dgvderivacionsucursales
            // 
            dgvderivacionsucursales.AllowUserToAddRows = false;
            dgvderivacionsucursales.AllowUserToDeleteRows = false;
            dgvderivacionsucursales.BackgroundColor = Color.FromArgb(15, 23, 42);
            dgvderivacionsucursales.CausesValidation = false;
            dgvderivacionsucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvderivacionsucursales.GridColor = Color.FromArgb(15, 23, 42);
            dgvderivacionsucursales.Location = new Point(-7, 118);
            dgvderivacionsucursales.Name = "dgvderivacionsucursales";
            dgvderivacionsucursales.ReadOnly = true;
            dgvderivacionsucursales.Size = new Size(609, 646);
            dgvderivacionsucursales.TabIndex = 4;
            dgvderivacionsucursales.CellPainting += dgvderivacionsucursales_CellPainting;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 23, 42);
            panel2.Controls.Add(uiButton3);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(602, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(523, 75);
            panel2.TabIndex = 26;
            // 
            // uiButton3
            // 
            uiButton3.BackColor = Color.Transparent;
            uiButton3.FillColor = Color.FromArgb(22, 35, 52);
            uiButton3.FillHoverColor = Color.Transparent;
            uiButton3.FillPressColor = Color.FromArgb(0, 150, 137);
            uiButton3.FillSelectedColor = Color.FromArgb(0, 150, 137);
            uiButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiButton3.Location = new Point(356, 15);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Radius = 12;
            uiButton3.RectColor = Color.FromArgb(39, 53, 72);
            uiButton3.RectHoverColor = Color.FromArgb(22, 35, 52);
            uiButton3.RectPressColor = Color.FromArgb(0, 150, 137);
            uiButton3.RectSelectedColor = Color.FromArgb(0, 150, 137);
            uiButton3.Size = new Size(33, 32);
            uiButton3.TabIndex = 37;
            uiButton3.Text = "X";
            uiButton3.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton3.TipsForeColor = Color.Transparent;
            uiButton3.Click += uiButton3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 26);
            label3.Name = "label3";
            label3.Size = new Size(85, 30);
            label3.TabIndex = 28;
            label3.Text = "Detalle ";
            // 
            // pnlDetallesDerivaciones
            // 
            pnlDetallesDerivaciones.BackColor = Color.FromArgb(15, 23, 42);
            pnlDetallesDerivaciones.Controls.Add(tableLayoutPanel2);
            pnlDetallesDerivaciones.Controls.Add(textBox1);
            pnlDetallesDerivaciones.Controls.Add(label14);
            pnlDetallesDerivaciones.Controls.Add(panel3);
            pnlDetallesDerivaciones.Controls.Add(tableLayoutPanel1);
            pnlDetallesDerivaciones.Controls.Add(lblnombreDetalle);
            pnlDetallesDerivaciones.Controls.Add(lblcodigoDetalle);
            pnlDetallesDerivaciones.Controls.Add(lblestadoDetalle);
            pnlDetallesDerivaciones.ForeColor = Color.FromArgb(15, 23, 42);
            pnlDetallesDerivaciones.Location = new Point(602, 192);
            pnlDetallesDerivaciones.Name = "pnlDetallesDerivaciones";
            pnlDetallesDerivaciones.Size = new Size(523, 602);
            pnlDetallesDerivaciones.TabIndex = 27;
            pnlDetallesDerivaciones.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnRechazarDerivacion, 1, 0);
            tableLayoutPanel2.Controls.Add(btnAceptarDerivacion, 0, 0);
            tableLayoutPanel2.Location = new Point(95, 448);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(348, 52);
            tableLayoutPanel2.TabIndex = 35;
            // 
            // btnRechazarDerivacion
            // 
            btnRechazarDerivacion.BackColor = Color.Transparent;
            btnRechazarDerivacion.FillColor = Color.Brown;
            btnRechazarDerivacion.FillColor2 = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.FillHoverColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.FillPressColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.FillSelectedColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRechazarDerivacion.Location = new Point(177, 3);
            btnRechazarDerivacion.MinimumSize = new Size(1, 1);
            btnRechazarDerivacion.Name = "btnRechazarDerivacion";
            btnRechazarDerivacion.Radius = 12;
            btnRechazarDerivacion.RectColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.RectDisableColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.RectHoverColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.RectPressColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.RectSelectedColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.Size = new Size(154, 36);
            btnRechazarDerivacion.TabIndex = 24;
            btnRechazarDerivacion.Text = "Rechazar";
            btnRechazarDerivacion.TipsFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechazarDerivacion.TipsForeColor = Color.Black;
            // 
            // btnAceptarDerivacion
            // 
            btnAceptarDerivacion.BackColor = Color.Transparent;
            btnAceptarDerivacion.FillColor = Color.FromArgb(0, 110, 0);
            btnAceptarDerivacion.FillColor2 = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.FillHoverColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.FillPressColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.FillSelectedColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptarDerivacion.Location = new Point(3, 3);
            btnAceptarDerivacion.MinimumSize = new Size(1, 1);
            btnAceptarDerivacion.Name = "btnAceptarDerivacion";
            btnAceptarDerivacion.Radius = 12;
            btnAceptarDerivacion.RectColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.RectHoverColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.RectPressColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.RectSelectedColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.Size = new Size(154, 36);
            btnAceptarDerivacion.TabIndex = 23;
            btnAceptarDerivacion.Text = "Aceptar";
            btnAceptarDerivacion.TipsFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptarDerivacion.TipsForeColor = Color.Black;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(26, 25, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(108, 302);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Observaciones...";
            textBox1.Size = new Size(317, 119);
            textBox1.TabIndex = 34;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(20, 270);
            label14.Name = "label14";
            label14.Size = new Size(203, 17);
            label14.TabIndex = 33;
            label14.Text = "Repuesta de la sucursal destino ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 35, 46);
            panel3.Location = new Point(-2, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(527, 10);
            panel3.TabIndex = 32;
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
            tableLayoutPanel1.Location = new Point(20, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(345, 144);
            tableLayoutPanel1.TabIndex = 31;
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
            lblnombreDetalle.Location = new Point(20, 62);
            lblnombreDetalle.Name = "lblnombreDetalle";
            lblnombreDetalle.Size = new Size(116, 25);
            lblnombreDetalle.TabIndex = 27;
            lblnombreDetalle.Text = "Nombre... : ";
            // 
            // lblcodigoDetalle
            // 
            lblcodigoDetalle.AutoSize = true;
            lblcodigoDetalle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcodigoDetalle.ForeColor = Color.LightSeaGreen;
            lblcodigoDetalle.Location = new Point(20, 35);
            lblcodigoDetalle.Name = "lblcodigoDetalle";
            lblcodigoDetalle.Size = new Size(92, 17);
            lblcodigoDetalle.TabIndex = 26;
            lblcodigoDetalle.Text = "ORD-2026_001";
            // 
            // lblestadoDetalle
            // 
            lblestadoDetalle.AutoSize = true;
            lblestadoDetalle.BackColor = Color.FromArgb(26, 28, 44);
            lblestadoDetalle.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblestadoDetalle.ForeColor = Color.Gold;
            lblestadoDetalle.Location = new Point(20, 14);
            lblestadoDetalle.Name = "lblestadoDetalle";
            lblestadoDetalle.Size = new Size(71, 17);
            lblestadoDetalle.TabIndex = 30;
            lblestadoDetalle.Text = "Pendiente";
            // 
            // uiContextMenuStrip1
            // 
            uiContextMenuStrip1.BackColor = Color.FromArgb(243, 249, 255);
            uiContextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12F);
            uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            uiContextMenuStrip1.Size = new Size(61, 4);
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.White;
            pnlSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(-8, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1140, 59);
            pnlSuperior.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(34, 13);
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
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(376, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Derivación entre Sucursales";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.BackColor = Color.White;
            pnlInformacion.Controls.Add(label15);
            pnlInformacion.Controls.Add(label4);
            pnlInformacion.Controls.Add(btnBuscar);
            pnlInformacion.ForeColor = Color.White;
            pnlInformacion.Location = new Point(0, 59);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1125, 59);
            pnlInformacion.TabIndex = 38;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(75, 16);
            label15.Name = "label15";
            label15.Size = new Size(26, 28);
            label15.TabIndex = 22;
            label15.Text = "x";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(95, 16);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 21;
            label4.Text = "derivaciones";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            btnBuscar.FillColor = Color.FromArgb(0, 150, 137);
            btnBuscar.Font = new Font("Microsoft Sans Serif", 12F);
            btnBuscar.Location = new Point(954, 13);
            btnBuscar.MinimumSize = new Size(1, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Radius = 12;
            btnBuscar.RectColor = Color.FromArgb(0, 150, 137);
            btnBuscar.Size = new Size(157, 31);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "+ Nueva derivación";
            btnBuscar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(415, 492);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 39;
            label1.Text = "Selecciona una derivación";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Visible = false;
            // 
            // ucDerivacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(dgvderivacionsucursales);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlSuperior);
            Controls.Add(panel2);
            Controls.Add(pnlDetallesDerivaciones);
            Name = "ucDerivacion";
            Size = new Size(1125, 764);
            ((System.ComponentModel.ISupportInitialize)dgvderivacionsucursales).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlDetallesDerivaciones.ResumeLayout(false);
            pnlDetallesDerivaciones.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInformacion.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvderivacionsucursales;
        private Panel panel2;
        private Panel pnlDetallesDerivaciones;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UIButton btnRechazarDerivacion;
        private Sunny.UI.UIButton btnAceptarDerivacion;
        private TextBox textBox1;
        private Label label14;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label13;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label9;
        private Label lblnombreDetalle;
        private Label lblcodigoDetalle;
        private Label lblestadoDetalle;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private Sunny.UI.UIButton uiButton3;
        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlInformacion;
        private Sunny.UI.UIButton btnBuscar;
        private Label label4;
        private Label label15;
        private Label label1;
    }
}
