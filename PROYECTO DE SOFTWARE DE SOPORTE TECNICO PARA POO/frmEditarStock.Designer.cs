namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class frmEditarStock
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
            lblCosto = new Label();
            lblStock = new Label();
            lblCategoria = new Label();
            lblProveedor = new Label();
            lblCompatibilidad = new Label();
            lblNombre = new Label();
            cmbCategoria = new Sunny.UI.UIComboBox();
            cmbProveedor = new Sunny.UI.UIComboBox();
            txtCosto = new Sunny.UI.UITextBox();
            txtStock = new Sunny.UI.UITextBox();
            txtCompatible = new Sunny.UI.UITextBox();
            txtNombre = new Sunny.UI.UITextBox();
            btnAgg = new Sunny.UI.UIButton();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            lblEstado = new Label();
            SuspendLayout();
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(183, 394);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(112, 20);
            lblCosto.TabIndex = 71;
            lblCosto.Text = "Precio de Venta";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(50, 394);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(69, 20);
            lblStock.TabIndex = 70;
            lblStock.Text = "Cantidad";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(259, 287);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 69;
            lblCategoria.Text = "Categoria";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(14, 287);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(77, 20);
            lblProveedor.TabIndex = 68;
            lblProveedor.Text = "Proveedor";
            // 
            // lblCompatibilidad
            // 
            lblCompatibilidad.AutoSize = true;
            lblCompatibilidad.Location = new Point(23, 153);
            lblCompatibilidad.Name = "lblCompatibilidad";
            lblCompatibilidad.Size = new Size(113, 20);
            lblCompatibilidad.TabIndex = 67;
            lblCompatibilidad.Text = "Compatibilidad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(153, 20);
            lblNombre.TabIndex = 66;
            lblNombre.Text = "Nombre del Producto";
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
            cmbCategoria.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbCategoria.Location = new Point(259, 314);
            cmbCategoria.Margin = new Padding(5, 7, 5, 7);
            cmbCategoria.MinimumSize = new Size(72, 0);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Padding = new Padding(0, 0, 34, 3);
            cmbCategoria.Radius = 12;
            cmbCategoria.RectColor = Color.FromArgb(148, 163, 184);
            cmbCategoria.Size = new Size(229, 47);
            cmbCategoria.SymbolSize = 24;
            cmbCategoria.TabIndex = 61;
            cmbCategoria.Text = "Seleccionar Categoria";
            cmbCategoria.TextAlignment = ContentAlignment.MiddleLeft;
            cmbCategoria.Watermark = "";
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.Transparent;
            cmbProveedor.DataSource = null;
            cmbProveedor.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbProveedor.FillColor = Color.FromArgb(41, 53, 72);
            cmbProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProveedor.ForeColor = Color.White;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbProveedor.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbProveedor.Location = new Point(14, 314);
            cmbProveedor.Margin = new Padding(5, 7, 5, 7);
            cmbProveedor.MinimumSize = new Size(72, 0);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Padding = new Padding(0, 0, 34, 3);
            cmbProveedor.Radius = 12;
            cmbProveedor.RectColor = Color.FromArgb(148, 163, 184);
            cmbProveedor.Size = new Size(235, 47);
            cmbProveedor.SymbolSize = 24;
            cmbProveedor.TabIndex = 60;
            cmbProveedor.Text = "Seleccionar Proveedor";
            cmbProveedor.TextAlignment = ContentAlignment.MiddleLeft;
            cmbProveedor.Watermark = "";
            // 
            // txtCosto
            // 
            txtCosto.FillColor = Color.FromArgb(41, 53, 72);
            txtCosto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCosto.ForeColor = Color.White;
            txtCosto.Location = new Point(179, 421);
            txtCosto.Margin = new Padding(5, 7, 5, 7);
            txtCosto.MaxLength = 255;
            txtCosto.Minimum = 0D;
            txtCosto.MinimumSize = new Size(1, 21);
            txtCosto.Name = "txtCosto";
            txtCosto.Padding = new Padding(6, 7, 6, 7);
            txtCosto.Radius = 12;
            txtCosto.RectColor = Color.FromArgb(39, 53, 72);
            txtCosto.ShowText = false;
            txtCosto.Size = new Size(135, 50);
            txtCosto.TabIndex = 65;
            txtCosto.TextAlignment = ContentAlignment.MiddleLeft;
            txtCosto.Watermark = "Costo...";
            // 
            // txtStock
            // 
            txtStock.FillColor = Color.FromArgb(41, 53, 72);
            txtStock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.ForeColor = Color.White;
            txtStock.Location = new Point(14, 421);
            txtStock.Margin = new Padding(5, 7, 5, 7);
            txtStock.MaxLength = 255;
            txtStock.Minimum = 0D;
            txtStock.MinimumSize = new Size(1, 21);
            txtStock.Name = "txtStock";
            txtStock.Padding = new Padding(6, 7, 6, 7);
            txtStock.Radius = 12;
            txtStock.RectColor = Color.FromArgb(39, 53, 72);
            txtStock.ShowText = false;
            txtStock.Size = new Size(135, 50);
            txtStock.TabIndex = 64;
            txtStock.TextAlignment = ContentAlignment.MiddleLeft;
            txtStock.Watermark = "Stock...";
            // 
            // txtCompatible
            // 
            txtCompatible.FillColor = Color.FromArgb(41, 53, 72);
            txtCompatible.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCompatible.ForeColor = Color.White;
            txtCompatible.Location = new Point(23, 180);
            txtCompatible.Margin = new Padding(5, 7, 5, 7);
            txtCompatible.MaxLength = 255;
            txtCompatible.Minimum = 0D;
            txtCompatible.MinimumSize = new Size(1, 21);
            txtCompatible.Name = "txtCompatible";
            txtCompatible.Padding = new Padding(6, 7, 6, 7);
            txtCompatible.Radius = 12;
            txtCompatible.RectColor = Color.FromArgb(39, 53, 72);
            txtCompatible.ShowText = false;
            txtCompatible.Size = new Size(441, 82);
            txtCompatible.TabIndex = 63;
            txtCompatible.TextAlignment = ContentAlignment.TopLeft;
            txtCompatible.Watermark = "Compatible...";
            // 
            // txtNombre
            // 
            txtNombre.FillColor = Color.FromArgb(41, 53, 72);
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(23, 72);
            txtNombre.Margin = new Padding(5, 7, 5, 7);
            txtNombre.MaxLength = 255;
            txtNombre.Minimum = 0D;
            txtNombre.MinimumSize = new Size(1, 21);
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(6, 7, 6, 7);
            txtNombre.Radius = 12;
            txtNombre.RectColor = Color.FromArgb(39, 53, 72);
            txtNombre.ShowText = false;
            txtNombre.Size = new Size(441, 63);
            txtNombre.TabIndex = 62;
            txtNombre.TextAlignment = ContentAlignment.MiddleLeft;
            txtNombre.Watermark = "Producto....";
            // 
            // btnAgg
            // 
            btnAgg.BackColor = Color.Transparent;
            btnAgg.FillColor = Color.FromArgb(0, 150, 137);
            btnAgg.FillHoverColor = Color.Transparent;
            btnAgg.FillPressColor = Color.FromArgb(0, 150, 137);
            btnAgg.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgg.Location = new Point(164, 513);
            btnAgg.Margin = new Padding(3, 4, 3, 4);
            btnAgg.MinimumSize = new Size(1, 1);
            btnAgg.Name = "btnAgg";
            btnAgg.Radius = 12;
            btnAgg.RectColor = Color.FromArgb(39, 53, 72);
            btnAgg.RectHoverColor = Color.Transparent;
            btnAgg.RectPressColor = Color.FromArgb(0, 150, 137);
            btnAgg.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgg.Size = new Size(150, 52);
            btnAgg.TabIndex = 59;
            btnAgg.Text = "Registrar Entrega";
            btnAgg.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAgg.TipsForeColor = Color.Transparent;
            // 
            // uiComboBox1
            // 
            uiComboBox1.BackColor = Color.Transparent;
            uiComboBox1.DataSource = null;
            uiComboBox1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            uiComboBox1.FillColor = Color.FromArgb(41, 53, 72);
            uiComboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiComboBox1.ForeColor = Color.White;
            uiComboBox1.FormattingEnabled = true;
            uiComboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox1.Location = new Point(341, 421);
            uiComboBox1.Margin = new Padding(5, 7, 5, 7);
            uiComboBox1.MinimumSize = new Size(72, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 34, 3);
            uiComboBox1.Radius = 12;
            uiComboBox1.RectColor = Color.FromArgb(148, 163, 184);
            uiComboBox1.Size = new Size(135, 50);
            uiComboBox1.SymbolSize = 24;
            uiComboBox1.TabIndex = 62;
            uiComboBox1.Text = "Estado...";
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(341, 394);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 72;
            lblEstado.Text = "Estado";
            // 
            // frmEditarStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(502, 599);
            Controls.Add(lblEstado);
            Controls.Add(uiComboBox1);
            Controls.Add(lblCosto);
            Controls.Add(lblStock);
            Controls.Add(lblCategoria);
            Controls.Add(lblProveedor);
            Controls.Add(lblCompatibilidad);
            Controls.Add(lblNombre);
            Controls.Add(cmbCategoria);
            Controls.Add(cmbProveedor);
            Controls.Add(txtCosto);
            Controls.Add(txtStock);
            Controls.Add(txtCompatible);
            Controls.Add(txtNombre);
            Controls.Add(btnAgg);
            Name = "frmEditarStock";
            Text = "frmEditarStock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCosto;
        private Label lblStock;
        private Label lblCategoria;
        private Label lblProveedor;
        private Label lblCompatibilidad;
        private Label lblNombre;
        private Sunny.UI.UIComboBox cmbCategoria;
        private Sunny.UI.UIComboBox cmbProveedor;
        private Sunny.UI.UITextBox txtCosto;
        private Sunny.UI.UITextBox txtStock;
        private Sunny.UI.UITextBox txtCompatible;
        private Sunny.UI.UITextBox txtNombre;
        private Sunny.UI.UIButton btnAgg;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Label lblEstado;
    }
}