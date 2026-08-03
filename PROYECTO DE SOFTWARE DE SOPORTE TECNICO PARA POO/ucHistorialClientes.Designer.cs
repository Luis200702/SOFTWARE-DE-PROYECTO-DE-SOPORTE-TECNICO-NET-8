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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            uibuscarcliente = new Sunny.UI.UIButton();
            txtBuscarCliente = new Sunny.UI.UITextBox();
            panel3 = new Panel();
            uibreautilizar = new Sunny.UI.UIButton();
            lblvalor = new Label();
            label7 = new Label();
            label6 = new Label();
            lblnvisitas = new Label();
            lblcorreo = new Label();
            lbltelefono = new Label();
            lblNombre = new Label();
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
            panel1.Controls.Add(uibuscarcliente);
            panel1.Controls.Add(txtBuscarCliente);
            panel1.Location = new Point(3, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 109);
            panel1.TabIndex = 2;
            // 
            // uibuscarcliente
            // 
            uibuscarcliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uibuscarcliente.FillColor = Color.FromArgb(20, 184, 166);
            uibuscarcliente.FillColor2 = Color.FromArgb(20, 184, 166);
            uibuscarcliente.FillDisableColor = Color.Empty;
            uibuscarcliente.Font = new Font("Segoe UI", 12F);
            uibuscarcliente.Location = new Point(27, 54);
            uibuscarcliente.MinimumSize = new Size(1, 1);
            uibuscarcliente.Name = "uibuscarcliente";
            uibuscarcliente.RectColor = Color.Empty;
            uibuscarcliente.RectPressColor = Color.FromArgb(20, 184, 166);
            uibuscarcliente.RectSelectedColor = Color.FromArgb(20, 184, 166);
            uibuscarcliente.Size = new Size(246, 36);
            uibuscarcliente.TabIndex = 20;
            uibuscarcliente.Text = "Buscar Cliente";
            uibuscarcliente.TipsFont = new Font("Microsoft Sans Serif", 9F);
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
            panel3.Controls.Add(uibreautilizar);
            panel3.Controls.Add(lblvalor);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblnvisitas);
            panel3.Controls.Add(lblcorreo);
            panel3.Controls.Add(lbltelefono);
            panel3.Controls.Add(lblNombre);
            panel3.Location = new Point(-1, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(870, 107);
            panel3.TabIndex = 3;
            // 
            // uibreautilizar
            // 
            uibreautilizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uibreautilizar.FillColor = Color.FromArgb(45, 212, 191);
            uibreautilizar.FillColor2 = Color.FromArgb(45, 212, 191);
            uibreautilizar.Font = new Font("Segoe UI", 12F);
            uibreautilizar.Location = new Point(718, 39);
            uibreautilizar.MinimumSize = new Size(1, 1);
            uibreautilizar.Name = "uibreautilizar";
            uibreautilizar.RectColor = Color.Empty;
            uibreautilizar.RectDisableColor = Color.Empty;
            uibreautilizar.RectHoverColor = Color.FromArgb(45, 212, 191);
            uibreautilizar.RectPressColor = Color.FromArgb(45, 212, 191);
            uibreautilizar.RectSelectedColor = Color.FromArgb(45, 212, 191);
            uibreautilizar.Size = new Size(131, 36);
            uibreautilizar.TabIndex = 21;
            uibreautilizar.Text = "Reautilizar datos";
            uibreautilizar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // lblvalor
            // 
            lblvalor.AutoSize = true;
            lblvalor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblvalor.ForeColor = Color.FromArgb(45, 212, 191);
            lblvalor.Location = new Point(640, 39);
            lblvalor.Name = "lblvalor";
            lblvalor.Size = new Size(50, 21);
            lblvalor.TabIndex = 6;
            lblvalor.Text = "$ ###";
            lblvalor.Click += label8_Click;
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
            // lblnvisitas
            // 
            lblnvisitas.AutoSize = true;
            lblnvisitas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnvisitas.ForeColor = Color.White;
            lblnvisitas.Location = new Point(593, 39);
            lblnvisitas.Name = "lblnvisitas";
            lblnvisitas.Size = new Size(19, 21);
            lblnvisitas.TabIndex = 3;
            lblnvisitas.Text = "#";
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.ForeColor = Color.FromArgb(148, 163, 184);
            lblcorreo.Location = new Point(96, 73);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(75, 15);
            lblcorreo.TabIndex = 2;
            lblcorreo.Text = "@gmail.com";
            lblcorreo.Click += label4_Click;
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.ForeColor = Color.FromArgb(148, 163, 184);
            lbltelefono.Location = new Point(20, 73);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(70, 15);
            lbltelefono.TabIndex = 1;
            lbltelefono.Text = "#########";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(20, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Coral;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Orden, Fecha, Dispositivo, Reparacion, Costo, Estado, Tecnico });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(15, 23, 43);
            dataGridViewCellStyle7.SelectionForeColor = Color.GhostWhite;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(3, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(866, 592);
            dataGridView1.TabIndex = 0;
            // 
            // Orden
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(15, 23, 42);
            Orden.DefaultCellStyle = dataGridViewCellStyle6;
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
        private Sunny.UI.UIButton uibuscarcliente;
        private Panel panel3;
        private Label lbltelefono;
        private Label lblNombre;
        private Label lblvalor;
        private Label label7;
        private Label label6;
        private Label lblnvisitas;
        private Label lblcorreo;
        private Sunny.UI.UIButton uibreautilizar;
    }
}
