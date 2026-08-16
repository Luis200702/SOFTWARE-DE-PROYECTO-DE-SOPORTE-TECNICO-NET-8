namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class frmRegistrarEntrega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblModeloCompatible = new Label();
            txtCantidadInicial = new Sunny.UI.UITextBox();
            btnCancelar = new Sunny.UI.UIButton();
            btnGuardarCambios = new Sunny.UI.UIButton();
            cmbCategoria = new Sunny.UI.UIComboBox();
            txtMarca = new Sunny.UI.UITextBox();
            txtNombre = new Sunny.UI.UITextBox();
            lblPrecio = new Label();
            lblStockMinimo = new Label();
            lblCategoria = new Label();
            lblNombre = new Label();
            lblEditar = new Label();
            lblMarca = new Label();
            txtModelo = new Sunny.UI.UITextBox();
            label1 = new Label();
            txtStockMinimo = new Sunny.UI.UITextBox();
            txtPrecioCosto = new Sunny.UI.UITextBox();
            txtPrecioVenta = new Sunny.UI.UITextBox();
            lblPrecioVenta = new Label();
            txtProveedor = new Sunny.UI.UITextBox();
            lblProveedor = new Label();
            SuspendLayout();
            // 
            // lblModeloCompatible
            // 
            lblModeloCompatible.AutoSize = true;
            lblModeloCompatible.Location = new Point(28, 217);
            lblModeloCompatible.Name = "lblModeloCompatible";
            lblModeloCompatible.Size = new Size(113, 15);
            lblModeloCompatible.TabIndex = 43;
            lblModeloCompatible.Text = "Modelo Compatible";
            // 
            // txtCantidadInicial
            // 
            txtCantidadInicial.FillColor = Color.FromArgb(41, 53, 72);
            txtCantidadInicial.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidadInicial.ForeColor = Color.White;
            txtCantidadInicial.Location = new Point(242, 237);
            txtCantidadInicial.Margin = new Padding(4, 5, 4, 5);
            txtCantidadInicial.MaxLength = 255;
            txtCantidadInicial.Minimum = 0D;
            txtCantidadInicial.MinimumSize = new Size(1, 16);
            txtCantidadInicial.Name = "txtCantidadInicial";
            txtCantidadInicial.Padding = new Padding(5);
            txtCantidadInicial.Radius = 12;
            txtCantidadInicial.RectColor = Color.FromArgb(39, 53, 72);
            txtCantidadInicial.ShowText = false;
            txtCantidadInicial.Size = new Size(213, 46);
            txtCantidadInicial.TabIndex = 42;
            txtCantidadInicial.Text = "0";
            txtCantidadInicial.TextAlignment = ContentAlignment.MiddleLeft;
            txtCantidadInicial.Watermark = "";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.FillColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(119, 526);
            btnCancelar.MinimumSize = new Size(1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Radius = 3;
            btnCancelar.RectColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Size = new Size(117, 30);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarCambios.FillColor = Color.FromArgb(0, 150, 137);
            btnGuardarCambios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCambios.Location = new Point(242, 526);
            btnGuardarCambios.MinimumSize = new Size(1, 1);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Radius = 3;
            btnGuardarCambios.RectColor = Color.FromArgb(0, 150, 137);
            btnGuardarCambios.Size = new Size(117, 30);
            btnGuardarCambios.TabIndex = 40;
            btnGuardarCambios.Text = "Agregar";
            btnGuardarCambios.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.Transparent;
            cmbCategoria.DataSource = null;
            cmbCategoria.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbCategoria.FillColor = Color.FromArgb(41, 53, 72);
            cmbCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.ForeColor = Color.White;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbCategoria.Items.AddRange(new object[] { "Pantalla", "Bateria", "Conector", "Placa", "Cámara", "Bóton", "Tapa", "Parlante", "Micrófono", "Otro" });
            cmbCategoria.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbCategoria.Location = new Point(28, 166);
            cmbCategoria.Margin = new Padding(4, 5, 4, 5);
            cmbCategoria.MinimumSize = new Size(63, 0);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Padding = new Padding(0, 0, 30, 2);
            cmbCategoria.Radius = 12;
            cmbCategoria.RectColor = Color.FromArgb(148, 163, 184);
            cmbCategoria.Size = new Size(208, 46);
            cmbCategoria.SymbolSize = 24;
            cmbCategoria.TabIndex = 39;
            cmbCategoria.TextAlignment = ContentAlignment.MiddleLeft;
            cmbCategoria.Watermark = "";
            // 
            // txtMarca
            // 
            txtMarca.FillColor = Color.FromArgb(41, 53, 72);
            txtMarca.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMarca.ForeColor = Color.White;
            txtMarca.Location = new Point(242, 166);
            txtMarca.Margin = new Padding(4, 5, 4, 5);
            txtMarca.MaxLength = 255;
            txtMarca.Minimum = 0D;
            txtMarca.MinimumSize = new Size(1, 16);
            txtMarca.Name = "txtMarca";
            txtMarca.Padding = new Padding(5);
            txtMarca.Radius = 12;
            txtMarca.RectColor = Color.FromArgb(39, 53, 72);
            txtMarca.ShowText = false;
            txtMarca.Size = new Size(213, 46);
            txtMarca.TabIndex = 38;
            txtMarca.TextAlignment = ContentAlignment.MiddleLeft;
            txtMarca.Watermark = "Usuario";
            // 
            // txtNombre
            // 
            txtNombre.FillColor = Color.FromArgb(41, 53, 72);
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(28, 92);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 255;
            txtNombre.Minimum = 0D;
            txtNombre.MinimumSize = new Size(1, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(5);
            txtNombre.Radius = 12;
            txtNombre.RectColor = Color.FromArgb(39, 53, 72);
            txtNombre.ShowText = false;
            txtNombre.Size = new Size(429, 46);
            txtNombre.TabIndex = 37;
            txtNombre.TextAlignment = ContentAlignment.MiddleLeft;
            txtNombre.Watermark = "Modelo del repuesto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(242, 288);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(89, 15);
            lblPrecio.TabIndex = 34;
            lblPrecio.Text = "Precio costo ($)";
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Location = new Point(28, 288);
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new Size(81, 15);
            lblStockMinimo.TabIndex = 33;
            lblStockMinimo.Text = "Stock minimo";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(27, 143);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 32;
            lblCategoria.Text = "Categoria";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 72);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 31;
            lblNombre.Text = "Nombre ";
            // 
            // lblEditar
            // 
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditar.Location = new Point(144, 25);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(187, 36);
            lblEditar.TabIndex = 30;
            lblEditar.Text = "Nuevo Repuesto";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(242, 146);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 44;
            lblMarca.Text = "Marca";
            // 
            // txtModelo
            // 
            txtModelo.FillColor = Color.FromArgb(41, 53, 72);
            txtModelo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModelo.ForeColor = Color.White;
            txtModelo.Location = new Point(28, 237);
            txtModelo.Margin = new Padding(4, 5, 4, 5);
            txtModelo.MaxLength = 255;
            txtModelo.Minimum = 0D;
            txtModelo.MinimumSize = new Size(1, 16);
            txtModelo.Name = "txtModelo";
            txtModelo.Padding = new Padding(5);
            txtModelo.Radius = 12;
            txtModelo.RectColor = Color.FromArgb(39, 53, 72);
            txtModelo.ShowText = false;
            txtModelo.Size = new Size(208, 46);
            txtModelo.TabIndex = 45;
            txtModelo.TextAlignment = ContentAlignment.MiddleLeft;
            txtModelo.Watermark = "Ej. Galaxy S22";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 217);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 46;
            label1.Text = "Cantidad inicial";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.FillColor = Color.FromArgb(41, 53, 72);
            txtStockMinimo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockMinimo.ForeColor = Color.White;
            txtStockMinimo.Location = new Point(27, 308);
            txtStockMinimo.Margin = new Padding(4, 5, 4, 5);
            txtStockMinimo.MaxLength = 255;
            txtStockMinimo.Minimum = 0D;
            txtStockMinimo.MinimumSize = new Size(1, 16);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Padding = new Padding(5);
            txtStockMinimo.Radius = 12;
            txtStockMinimo.RectColor = Color.FromArgb(39, 53, 72);
            txtStockMinimo.ShowText = false;
            txtStockMinimo.Size = new Size(209, 46);
            txtStockMinimo.TabIndex = 47;
            txtStockMinimo.Text = "0";
            txtStockMinimo.TextAlignment = ContentAlignment.MiddleLeft;
            txtStockMinimo.Watermark = "";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.FillColor = Color.FromArgb(41, 53, 72);
            txtPrecioCosto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioCosto.ForeColor = Color.White;
            txtPrecioCosto.Location = new Point(242, 308);
            txtPrecioCosto.Margin = new Padding(4, 5, 4, 5);
            txtPrecioCosto.MaxLength = 255;
            txtPrecioCosto.Minimum = 0D;
            txtPrecioCosto.MinimumSize = new Size(1, 16);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Padding = new Padding(5);
            txtPrecioCosto.Radius = 12;
            txtPrecioCosto.RectColor = Color.FromArgb(39, 53, 72);
            txtPrecioCosto.ShowText = false;
            txtPrecioCosto.Size = new Size(213, 46);
            txtPrecioCosto.TabIndex = 48;
            txtPrecioCosto.Text = "0";
            txtPrecioCosto.TextAlignment = ContentAlignment.MiddleLeft;
            txtPrecioCosto.Watermark = "";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.FillColor = Color.FromArgb(41, 53, 72);
            txtPrecioVenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioVenta.ForeColor = Color.White;
            txtPrecioVenta.Location = new Point(28, 379);
            txtPrecioVenta.Margin = new Padding(4, 5, 4, 5);
            txtPrecioVenta.MaxLength = 255;
            txtPrecioVenta.Minimum = 0D;
            txtPrecioVenta.MinimumSize = new Size(1, 16);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Padding = new Padding(5);
            txtPrecioVenta.Radius = 12;
            txtPrecioVenta.RectColor = Color.FromArgb(39, 53, 72);
            txtPrecioVenta.ShowText = false;
            txtPrecioVenta.Size = new Size(208, 46);
            txtPrecioVenta.TabIndex = 49;
            txtPrecioVenta.Text = "0";
            txtPrecioVenta.TextAlignment = ContentAlignment.MiddleLeft;
            txtPrecioVenta.Watermark = "";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(27, 359);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(93, 15);
            lblPrecioVenta.TabIndex = 50;
            lblPrecioVenta.Text = "Precio a la venta";
            // 
            // txtProveedor
            // 
            txtProveedor.FillColor = Color.FromArgb(41, 53, 72);
            txtProveedor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProveedor.ForeColor = Color.White;
            txtProveedor.Location = new Point(28, 448);
            txtProveedor.Margin = new Padding(4, 5, 4, 5);
            txtProveedor.MaxLength = 255;
            txtProveedor.Minimum = 0D;
            txtProveedor.MinimumSize = new Size(1, 16);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Padding = new Padding(5);
            txtProveedor.Radius = 12;
            txtProveedor.RectColor = Color.FromArgb(39, 53, 72);
            txtProveedor.ShowText = false;
            txtProveedor.Size = new Size(429, 46);
            txtProveedor.TabIndex = 51;
            txtProveedor.TextAlignment = ContentAlignment.MiddleLeft;
            txtProveedor.Watermark = "Nombre del proveedor";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(28, 428);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(127, 15);
            lblProveedor.TabIndex = 52;
            lblProveedor.Text = "Nombre del proveedor";
            // 
            // frmRegistrarEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 199, 189);
            ClientSize = new Size(488, 568);
            Controls.Add(lblProveedor);
            Controls.Add(txtProveedor);
            Controls.Add(lblPrecioVenta);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCosto);
            Controls.Add(txtStockMinimo);
            Controls.Add(label1);
            Controls.Add(txtModelo);
            Controls.Add(lblMarca);
            Controls.Add(lblModeloCompatible);
            Controls.Add(txtCantidadInicial);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(cmbCategoria);
            Controls.Add(txtMarca);
            Controls.Add(txtNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblStockMinimo);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombre);
            Controls.Add(lblEditar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistrarEntrega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegistrarEntrega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModeloCompatible;
        private Sunny.UI.UITextBox txtCantidadInicial;
        private Sunny.UI.UIButton btnCancelar;
        private Sunny.UI.UIButton btnGuardarCambios;
        private Sunny.UI.UIComboBox cmbCategoria;
        private Sunny.UI.UITextBox txtMarca;
        private Sunny.UI.UITextBox txtNombre;
        private Sunny.UI.UIButton btnTecnico;
        private Sunny.UI.UIButton btnAdministrador;
        private Label lblPrecio;
        private Label lblStockMinimo;
        private Label lblCategoria;
        private Label lblNombre;
        private Label lblEditar;
        private Label lblMarca;
        private Sunny.UI.UITextBox txtModelo;
        private Label label1;
        private Sunny.UI.UITextBox txtStockMinimo;
        private Sunny.UI.UITextBox txtPrecioCosto;
        private Sunny.UI.UITextBox txtPrecioVenta;
        private Label lblPrecioVenta;
        private Sunny.UI.UITextBox txtProveedor;
        private Label lblProveedor;
    }
}