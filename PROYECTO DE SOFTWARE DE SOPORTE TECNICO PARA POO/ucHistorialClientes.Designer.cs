namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucHistorialClientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            uiButton1 = new Sunny.UI.UIButton();
            txtBuscarCliente = new Sunny.UI.UITextBox();
            panel3 = new Panel();
            uiButton2 = new Sunny.UI.UIButton();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Orden = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Dispositivo = new DataGridViewTextBoxColumn();
            Reparacion = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Tecnico = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.BackColor = Color.FromArgb(20, 184, 166);
            materialButton1.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            materialButton1.Depth = 0;
            materialButton1.FlatAppearance.BorderColor = Color.FromArgb(20, 184, 166);
            materialButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialButton1.ForeColor = Color.White;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = Properties.Resources.buqueda_blanca;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default;
            materialButton1.Location = new Point(25, 48);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(254, 36);
            materialButton1.TabIndex = 1;
            materialButton1.Text = "Buscar Cliente";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = true;
            materialButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(23, 32, 50);
            pictureBox1.Image = Properties.Resources.tictoc;
            pictureBox1.Location = new Point(16, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(23, 32, 50);
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 12);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 2;
            label1.Text = "Historial de Equipos por Cliente";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoScroll = true;
            panel4.AutoSize = true;
            panel4.BackColor = Color.FromArgb(23, 32, 50);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(0, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1173, 37);
            panel4.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.BackColor = Color.FromArgb(15, 23, 42);
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 41);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            splitContainer1.Panel1.ForeColor = Color.Turquoise;
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1173, 705);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(uiButton1);
            panel1.Controls.Add(txtBuscarCliente);
            panel1.Location = new Point(3, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 109);
            panel1.TabIndex = 2;
            // 
            // uiButton1
            // 
            uiButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uiButton1.FillColor = Color.FromArgb(20, 184, 166);
            uiButton1.FillColor2 = Color.FromArgb(20, 184, 166);
            uiButton1.FillDisableColor = Color.Empty;
            uiButton1.Font = new Font("Segoe UI", 12F);
            uiButton1.Location = new Point(27, 54);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.Empty;
            uiButton1.RectPressColor = Color.FromArgb(20, 184, 166);
            uiButton1.RectSelectedColor = Color.FromArgb(20, 184, 166);
            uiButton1.Size = new Size(246, 36);
            uiButton1.TabIndex = 20;
            uiButton1.Text = "Buscar Cliente";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.BackColor = Color.Transparent;
            txtBuscarCliente.FillColor = Color.FromArgb(41, 53, 72);
            txtBuscarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarCliente.ForeColor = Color.White;
            txtBuscarCliente.Location = new Point(6, 5);
            txtBuscarCliente.Margin = new Padding(4, 5, 4, 5);
            txtBuscarCliente.MaxLength = 255;
            txtBuscarCliente.Minimum = 0D;
            txtBuscarCliente.MinimumSize = new Size(1, 16);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Padding = new Padding(5);
            txtBuscarCliente.Radius = 12;
            txtBuscarCliente.ShowText = false;
            txtBuscarCliente.Size = new Size(287, 41);
            txtBuscarCliente.TabIndex = 19;
            txtBuscarCliente.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscarCliente.Watermark = "Nombre, teléfono o correo";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.AutoSize = true;
            panel3.BackColor = Color.FromArgb(23, 32, 50);
            panel3.Controls.Add(uiButton2);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(-1, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(870, 107);
            panel3.TabIndex = 3;
            // 
            // uiButton2
            // 
            uiButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uiButton2.FillColor = Color.FromArgb(45, 212, 191);
            uiButton2.FillColor2 = Color.FromArgb(45, 212, 191);
            uiButton2.Font = new Font("Segoe UI", 12F);
            uiButton2.Location = new Point(718, 39);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.RectColor = Color.Empty;
            uiButton2.RectDisableColor = Color.Empty;
            uiButton2.RectHoverColor = Color.FromArgb(45, 212, 191);
            uiButton2.RectPressColor = Color.FromArgb(45, 212, 191);
            uiButton2.RectSelectedColor = Color.FromArgb(45, 212, 191);
            uiButton2.Size = new Size(131, 36);
            uiButton2.TabIndex = 21;
            uiButton2.Text = "Reautilizar datos";
            uiButton2.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(45, 212, 191);
            label8.Location = new Point(640, 39);
            label8.Name = "label8";
            label8.Size = new Size(50, 21);
            label8.TabIndex = 6;
            label8.Text = "$ ###";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(148, 163, 184);
            label7.Location = new Point(649, 73);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 5;
            label7.Text = "total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(148, 163, 184);
            label6.Location = new Point(582, 73);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 4;
            label6.Text = "visitas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(593, 39);
            label5.Name = "label5";
            label5.Size = new Size(19, 21);
            label5.TabIndex = 3;
            label5.Text = "#";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(148, 163, 184);
            label4.Location = new Point(96, 73);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 2;
            label4.Text = "@gmail.com";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(148, 163, 184);
            label3.Location = new Point(20, 73);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 1;
            label3.Text = "#########";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 39);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Coral;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Orden, Fecha, Dispositivo, Reparacion, Costo, Estado, Tecnico });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(15, 23, 43);
            dataGridViewCellStyle3.SelectionForeColor = Color.GhostWhite;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(3, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(866, 592);
            dataGridView1.TabIndex = 0;
            // 
            // Orden
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(15, 23, 42);
            Orden.DefaultCellStyle = dataGridViewCellStyle2;
            Orden.HeaderText = "ORDEN";
            Orden.Name = "Orden";
            Orden.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "FECHA";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Dispositivo
            // 
            Dispositivo.HeaderText = "DISPOSITIVO";
            Dispositivo.Name = "Dispositivo";
            Dispositivo.ReadOnly = true;
            // 
            // Reparacion
            // 
            Reparacion.HeaderText = "REPARACIÓN";
            Reparacion.Name = "Reparacion";
            Reparacion.ReadOnly = true;
            // 
            // Costo
            // 
            Costo.HeaderText = "COSTO";
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "ESTADO";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Tecnico
            // 
            Tecnico.HeaderText = "TÉCNICO";
            Tecnico.Name = "Tecnico";
            Tecnico.ReadOnly = true;
            // 
            // ucHistorialClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            Controls.Add(panel4);
            Controls.Add(splitContainer1);
            Name = "ucHistorialClientes";
            Size = new Size(1173, 749);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;                 private Panel panel4;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Orden;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Dispositivo;
        private DataGridViewTextBoxColumn Reparacion;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Tecnico;
        private Sunny.UI.UITextBox txtContraseña;
        private Sunny.UI.UIButton btnAcceder;
        private Sunny.UI.UITextBox txtBuscarCliente;
        private Sunny.UI.UIButton uiButton1;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Sunny.UI.UIButton uiButton2;
    }
}
