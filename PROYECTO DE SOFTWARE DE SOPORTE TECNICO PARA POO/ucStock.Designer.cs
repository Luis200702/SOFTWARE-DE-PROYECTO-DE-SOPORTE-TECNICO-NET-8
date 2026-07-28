namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucStock
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
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            btnAgregar = new Button();
            pictureBox3 = new PictureBox();
            btnAlertas = new Button();
            cmbCategorias = new ComboBox();
            txtBuscar = new TextBox();
            pictureBox2 = new PictureBox();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            pnlSuperior.Location = new Point(-8, -11);
            pnlSuperior.Margin = new Padding(3, 4, 3, 4);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1190, 94);
            pnlSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MaterialSymbolsInventory__1_;
            pictureBox1.Location = new Point(24, 27);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(147, 162, 183);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(328, 92);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Control de Stock";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnAlertas);
            panel1.Controls.Add(cmbCategorias);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-8, 76);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 72);
            panel1.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.WeuiAdd2Outlined;
            pictureBox4.Location = new Point(1019, 18);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkCyan;
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.FromArgb(147, 162, 183);
            btnAgregar.Location = new Point(1066, 18);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.RightToLeft = RightToLeft.No;
            btnAgregar.Size = new Size(98, 41);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.MdiAlertCircleOutline__1_;
            pictureBox3.Location = new Point(766, 18);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnAlertas
            // 
            btnAlertas.BackColor = Color.FromArgb(30, 41, 59);
            btnAlertas.BackgroundImageLayout = ImageLayout.Stretch;
            btnAlertas.FlatStyle = FlatStyle.Flat;
            btnAlertas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlertas.ForeColor = Color.FromArgb(147, 162, 183);
            btnAlertas.Location = new Point(813, 18);
            btnAlertas.Name = "btnAlertas";
            btnAlertas.RightToLeft = RightToLeft.No;
            btnAlertas.Size = new Size(98, 41);
            btnAlertas.TabIndex = 3;
            btnAlertas.Text = "Alertas";
            btnAlertas.UseVisualStyleBackColor = false;
            // 
            // cmbCategorias
            // 
            cmbCategorias.BackColor = Color.FromArgb(30, 41, 59);
            cmbCategorias.FlatStyle = FlatStyle.Flat;
            cmbCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCategorias.ForeColor = Color.FromArgb(147, 162, 183);
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(502, 18);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(211, 36);
            cmbCategorias.TabIndex = 2;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(30, 41, 59);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.FromArgb(147, 162, 183);
            txtBuscar.Location = new Point(71, 18);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(404, 36);
            txtBuscar.TabIndex = 1;
            txtBuscar.Text = "Buscar";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.TablerSearch;
            pictureBox2.Location = new Point(24, 14);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // ucStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 35, 54);
            Controls.Add(pnlSuperior);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucStock";
            Size = new Size(1171, 915);
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox txtBuscar;
        private ComboBox cmbCategorias;
        private Button btnAlertas;
        private PictureBox pictureBox4;
        private Button btnAgregar;
        private PictureBox pictureBox3;
    }
}
