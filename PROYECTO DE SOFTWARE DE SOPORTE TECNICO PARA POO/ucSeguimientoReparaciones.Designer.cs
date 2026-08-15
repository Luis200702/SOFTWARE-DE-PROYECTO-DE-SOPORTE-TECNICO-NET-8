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
            pnlContenedor = new Panel();
            pnldgv = new Panel();
            dgvSeguimiento = new DataGridView();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            pnlContenedor.SuspendLayout();
            pnldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeguimiento).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.FromArgb(30, 41, 59);
            pnlSuperior.BorderStyle = BorderStyle.FixedSingle;
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.MaximumSize = new Size(1125, 54);
            pnlSuperior.MinimumSize = new Size(1125, 54);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1125, 54);
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
            lblTitulo.Text = "       Seguimiento de Reparaciones";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.AutoSize = true;
            pnlInformacion.BackColor = Color.FromArgb(30, 41, 59);
            pnlInformacion.BorderStyle = BorderStyle.FixedSingle;
            pnlInformacion.Controls.Add(cmbEstado);
            pnlInformacion.Controls.Add(txtBuscarOrden);
            pnlInformacion.Controls.Add(lblOrden);
            pnlInformacion.Location = new Point(0, 54);
            pnlInformacion.MaximumSize = new Size(1125, 60);
            pnlInformacion.MinimumSize = new Size(1125, 60);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1125, 60);
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
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged_1;
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
            txtBuscarOrden.TextChanged += txtBuscarOrden_TextChanged;
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
            // pnlContenedor
            // 
            pnlContenedor.Controls.Add(pnldgv);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 0);
            pnlContenedor.MaximumSize = new Size(1125, 705);
            pnlContenedor.MinimumSize = new Size(1125, 705);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1125, 705);
            pnlContenedor.TabIndex = 4;
            // 
            // pnldgv
            // 
            pnldgv.Controls.Add(dgvSeguimiento);
            pnldgv.Location = new Point(0, 60);
            pnldgv.Name = "pnldgv";
            pnldgv.Size = new Size(1125, 647);
            pnldgv.TabIndex = 4;
            // 
            // dgvSeguimiento
            // 
            dgvSeguimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeguimiento.Location = new Point(0, 55);
            dgvSeguimiento.Name = "dgvSeguimiento";
            dgvSeguimiento.Size = new Size(1125, 649);
            dgvSeguimiento.TabIndex = 4;
            dgvSeguimiento.CellDoubleClick += dgvNuevo_CellDoubleClick;
            dgvSeguimiento.CellFormatting += dgvNuevo_CellFormatting;
            dgvSeguimiento.CellPainting += dgvNuevo_CellPainting;
            // 
            // ucSeguimientoReparaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlInformacion);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlContenedor);
            Name = "ucSeguimientoReparaciones";
            Size = new Size(1125, 764);
            Load += ucSeguimientoReparaciones_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInformacion.ResumeLayout(false);
            pnlContenedor.ResumeLayout(false);
            pnldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSeguimiento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlInformacion;
        private Label lblOrden;
        private TextBox txtNombre;
        private Sunny.UI.UITextBox txtBuscarOrden;
        private Sunny.UI.UIComboBox cmbEstado;
        private DataGridView dgvSeguimiento;
        private DataGridViewTextBoxColumn Orden;
        private DataGridViewTextBoxColumn Cliente_Dispositivo;
        private DataGridViewTextBoxColumn Tecnico;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Ingreso;
        private DataGridViewTextBoxColumn Entrega;
        private DataGridViewTextBoxColumn Tiempo;
        private Panel pnlContenedor;
        private Panel pnldgv;
    }
}
