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
            ibbuscarcliente = new FontAwesome.Sharp.IconButton();
            txtBucar = new TextBox();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            panel1 = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ibbuscarcliente
            // 
            ibbuscarcliente.BackColor = Color.FromArgb(20, 184, 166);
            ibbuscarcliente.BackgroundImageLayout = ImageLayout.Zoom;
            ibbuscarcliente.FlatAppearance.BorderSize = 0;
            ibbuscarcliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibbuscarcliente.ForeColor = Color.White;
            ibbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.None;
            ibbuscarcliente.IconColor = Color.White;
            ibbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibbuscarcliente.IconSize = 30;
            ibbuscarcliente.ImageAlign = ContentAlignment.TopRight;
            ibbuscarcliente.Location = new Point(16, 45);
            ibbuscarcliente.Name = "ibbuscarcliente";
            ibbuscarcliente.Size = new Size(266, 40);
            ibbuscarcliente.TabIndex = 1;
            ibbuscarcliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibbuscarcliente.UseVisualStyleBackColor = false;
            ibbuscarcliente.Click += ibbuscarcliente_Click;
            // 
            // txtBucar
            // 
            txtBucar.BackColor = Color.FromArgb(51, 65, 85);
            txtBucar.BorderStyle = BorderStyle.FixedSingle;
            txtBucar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBucar.Location = new Point(16, 3);
            txtBucar.Multiline = true;
            txtBucar.Name = "txtBucar";
            txtBucar.PlaceholderText = "Nombre, número o correo";
            txtBucar.Size = new Size(266, 36);
            txtBucar.TabIndex = 0;
            txtBucar.TextAlign = HorizontalAlignment.Center;
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
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            splitContainer1.Panel1.ForeColor = Color.White;
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1173, 705);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 200);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // panel1
            // 
            panel1.Controls.Add(ibbuscarcliente);
            panel1.Controls.Add(txtBucar);
            panel1.Location = new Point(3, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 109);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(15, 23, 42);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Orden, Fecha, Dispositivo, Reparacion, Costo, Estado, Tecnico });
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(3, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(866, 592);
            dataGridView1.TabIndex = 0;
            // 
            // Orden
            // 
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
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private TextBox txtBucar;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;         private FontAwesome.Sharp.IconButton ibbuscarcliente;
        private Panel panel4;
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
        private Label label2;
    }
}
