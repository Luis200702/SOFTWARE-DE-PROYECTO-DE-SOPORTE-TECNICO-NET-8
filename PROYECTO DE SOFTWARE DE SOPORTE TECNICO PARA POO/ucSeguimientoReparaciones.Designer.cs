namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucSeguimientoReparaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSeguimientoReparaciones));
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlInformacion = new Panel();
            cmbEstado = new Sunny.UI.UIComboBox();
            txtBuscarOrden = new Sunny.UI.UITextBox();
            lblOrden = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
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
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1025, 54);
            pnlSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(147, 162, 183);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(342, 52);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Recepción de Dispositivos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.AutoSize = true;
            pnlInformacion.BackColor = Color.FromArgb(30, 41, 59);
            pnlInformacion.BorderStyle = BorderStyle.FixedSingle;
            pnlInformacion.Controls.Add(cmbEstado);
            pnlInformacion.Controls.Add(txtBuscarOrden);
            pnlInformacion.Controls.Add(lblOrden);
            pnlInformacion.Location = new Point(0, 54);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1025, 60);
            pnlInformacion.TabIndex = 2;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.Transparent;
            cmbEstado.DataSource = null;
            cmbEstado.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbEstado.FillColor = Color.FromArgb(41, 53, 72);
            cmbEstado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEstado.ForeColor = Color.White;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbEstado.Items.AddRange(new object[] { "Todos los estados", "Recibido", "En diagnóstico", "En reparación", "Listo", "Entregado" });
            cmbEstado.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbEstado.Location = new Point(345, 13);
            cmbEstado.Margin = new Padding(4, 5, 4, 5);
            cmbEstado.MinimumSize = new Size(63, 0);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Padding = new Padding(0, 0, 30, 2);
            cmbEstado.Radius = 12;
            cmbEstado.RectColor = Color.FromArgb(148, 163, 184);
            cmbEstado.Size = new Size(151, 30);
            cmbEstado.SymbolSize = 24;
            cmbEstado.TabIndex = 44;
            cmbEstado.TextAlignment = ContentAlignment.MiddleLeft;
            cmbEstado.Watermark = "";
            // 
            // txtBuscarOrden
            // 
            txtBuscarOrden.FillColor = Color.FromArgb(41, 53, 72);
            txtBuscarOrden.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarOrden.ForeColor = Color.White;
            txtBuscarOrden.Icon = Properties.Resources.TablerSearch;
            txtBuscarOrden.Location = new Point(35, 13);
            txtBuscarOrden.Margin = new Padding(4, 5, 4, 5);
            txtBuscarOrden.MinimumSize = new Size(1, 16);
            txtBuscarOrden.Name = "txtBuscarOrden";
            txtBuscarOrden.Padding = new Padding(5);
            txtBuscarOrden.Radius = 12;
            txtBuscarOrden.RectColor = Color.FromArgb(39, 53, 72);
            txtBuscarOrden.ShowText = false;
            txtBuscarOrden.Size = new Size(292, 30);
            txtBuscarOrden.TabIndex = 14;
            txtBuscarOrden.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscarOrden.Watermark = "Buscar orden, cliente...";
            // 
            // lblOrden
            // 
            lblOrden.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrden.ForeColor = Color.FromArgb(147, 162, 183);
            lblOrden.Location = new Point(896, 20);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(108, 23);
            lblOrden.TabIndex = 0;
            lblOrden.Text = "# órdenes";
            lblOrden.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(24, 35, 54);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1025, 509);
            dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 54);
            panel1.TabIndex = 4;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(147, 162, 183);
            label7.Location = new Point(923, 15);
            label7.Name = "label7";
            label7.Size = new Size(63, 23);
            label7.TabIndex = 7;
            label7.Text = "TIEMPO";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(147, 162, 183);
            label6.Location = new Point(773, 15);
            label6.Name = "label6";
            label6.Size = new Size(92, 23);
            label6.TabIndex = 6;
            label6.Text = "ENTRAGA EST.";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(147, 162, 183);
            label5.Location = new Point(636, 15);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 5;
            label5.Text = "INGRESO";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(147, 162, 183);
            label4.Location = new Point(515, 15);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 4;
            label4.Text = "ESTADO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(147, 162, 183);
            label3.Location = new Point(390, 15);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 3;
            label3.Text = "TÉCNICO";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(147, 162, 183);
            label2.Location = new Point(163, 15);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 2;
            label2.Text = "CLIENTE / DISPOSITIVO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(147, 162, 183);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 1;
            label1.Text = "ORDEN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucSeguimientoReparaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 35, 54);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlSuperior);
            Name = "ucSeguimientoReparaciones";
            Size = new Size(1025, 686);
            Load += ucSeguimientoReparaciones_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlInformacion;
        private Label lblOrden;
        private DataGridView dataGridView1;
        private TextBox txtNombre;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Sunny.UI.UITextBox txtBuscarOrden;
        private Sunny.UI.UIComboBox cmbEstado;
    }
}
