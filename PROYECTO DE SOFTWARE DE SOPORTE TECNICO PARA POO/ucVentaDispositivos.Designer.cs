namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucVentaDispositivos
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlInformacion = new Panel();
            lblVentas = new Label();
            label1 = new Label();
            btnNuevaVenta = new Sunny.UI.UIButton();
            txtBuscar = new Sunny.UI.UITextBox();
            dgvVentas = new DataGridView();
            Venta = new DataGridViewTextBoxColumn();
            Dispositivo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Comprador = new DataGridViewTextBoxColumn();
            Pago = new DataGridViewTextBoxColumn();
            Garantia = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            btnComprobante = new DataGridViewButtonColumn();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
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
            pnlSuperior.Location = new Point(-7, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1140, 59);
            pnlSuperior.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MdiCartVariant;
            pictureBox1.Location = new Point(31, 12);
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
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(313, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Venta de Dispositivos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformacion
            // 
            pnlInformacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInformacion.BackColor = Color.FromArgb(30, 41, 59);
            pnlInformacion.Controls.Add(lblVentas);
            pnlInformacion.Controls.Add(label1);
            pnlInformacion.Controls.Add(btnNuevaVenta);
            pnlInformacion.Controls.Add(txtBuscar);
            pnlInformacion.Location = new Point(0, 59);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(1125, 59);
            pnlInformacion.TabIndex = 3;
            // 
            // lblVentas
            // 
            lblVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentas.ForeColor = Color.White;
            lblVentas.Location = new Point(877, 13);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(27, 31);
            lblVentas.TabIndex = 22;
            lblVentas.Text = "x";
            lblVentas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(901, 14);
            label1.Name = "label1";
            label1.Size = new Size(72, 31);
            label1.TabIndex = 21;
            label1.Text = "ventas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.FillColor = Color.FromArgb(0, 150, 137);
            btnNuevaVenta.Font = new Font("Microsoft Sans Serif", 12F);
            btnNuevaVenta.Location = new Point(979, 14);
            btnNuevaVenta.MinimumSize = new Size(1, 1);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Radius = 12;
            btnNuevaVenta.RectColor = Color.FromArgb(0, 150, 137);
            btnNuevaVenta.Size = new Size(129, 31);
            btnNuevaVenta.TabIndex = 20;
            btnNuevaVenta.Text = "Nueva Venta";
            btnNuevaVenta.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnNuevaVenta.Click += btnNuevaVenta_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.FillColor = Color.FromArgb(41, 53, 72);
            txtBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Icon = Properties.Resources.TablerSearch;
            txtBuscar.Location = new Point(29, 14);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.MinimumSize = new Size(1, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(5);
            txtBuscar.Radius = 12;
            txtBuscar.RectColor = Color.FromArgb(39, 53, 72);
            txtBuscar.ShowText = false;
            txtBuscar.Size = new Size(295, 30);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextAlignment = ContentAlignment.MiddleLeft;
            txtBuscar.Watermark = "Buscar dispositivo o comprador";
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeColumns = false;
            dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.ColumnHeadersHeight = 40;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Venta, Dispositivo, Estado, Precio, Comprador, Pago, Garantia, Fecha, btnComprobante });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.GridColor = SystemColors.ActiveCaption;
            dgvVentas.Location = new Point(0, 118);
            dgvVentas.MaximumSize = new Size(1125, 641);
            dgvVentas.MinimumSize = new Size(1125, 641);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvVentas.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvVentas.RowTemplate.Height = 30;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(1125, 641);
            dgvVentas.TabIndex = 4;
            // 
            // Venta
            // 
            Venta.DataPropertyName = "TipoVenta";
            Venta.HeaderText = "TIPO";
            Venta.Name = "Venta";
            Venta.ReadOnly = true;
            // 
            // Dispositivo
            // 
            Dispositivo.DataPropertyName = "MarcaNuevo";
            Dispositivo.HeaderText = "DISPOSITIVO";
            Dispositivo.Name = "Dispositivo";
            Dispositivo.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "EstadoEquipo";
            Estado.HeaderText = "ESTADO";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "PrecioOriginal";
            Precio.HeaderText = "PRECIO";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Comprador
            // 
            Comprador.DataPropertyName = "NombreCliente";
            Comprador.HeaderText = "COMPRADOR";
            Comprador.Name = "Comprador";
            Comprador.ReadOnly = true;
            // 
            // Pago
            // 
            Pago.DataPropertyName = "FormaPago";
            Pago.HeaderText = "PAGO";
            Pago.Name = "Pago";
            Pago.ReadOnly = true;
            // 
            // Garantia
            // 
            Garantia.DataPropertyName = "GarantiaOfrecida";
            Garantia.HeaderText = "GARANTIA";
            Garantia.Name = "Garantia";
            Garantia.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "FechaVenta";
            Fecha.HeaderText = "FECHA";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // btnComprobante
            // 
            btnComprobante.HeaderText = "";
            btnComprobante.Name = "btnComprobante";
            // 
            // ucVentaDispositivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            Controls.Add(dgvVentas);
            Controls.Add(pnlInformacion);
            Controls.Add(pnlSuperior);
            Name = "ucVentaDispositivos";
            Size = new Size(1125, 764);
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Panel pnlInformacion;
        private Sunny.UI.UIButton btnNuevaVenta;
        private Sunny.UI.UITextBox txtBuscar;
        private DataGridView dgvVentas;
        private Label label1;
        private Label lblVentas;
        private DataGridViewTextBoxColumn Venta;
        private DataGridViewTextBoxColumn Dispositivo;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Comprador;
        private DataGridViewTextBoxColumn Pago;
        private DataGridViewTextBoxColumn Garantia;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewButtonColumn btnComprobante;
    }
}
