namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class frmAggStock
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
            txtCompatible = new Sunny.UI.UITextBox();
            txtNombre = new Sunny.UI.UITextBox();
            txtStock = new Sunny.UI.UITextBox();
            txtCosto = new Sunny.UI.UITextBox();
            cmbProveedor = new Sunny.UI.UIComboBox();
            cmbCategoria = new Sunny.UI.UIComboBox();
            lblNombre = new Label();
            lblCompatibilidad = new Label();
            lblProveedor = new Label();
            lblCategoria = new Label();
            lblStock = new Label();
            lblCosto = new Label();
            btnAgg = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // txtCompatible
            // 
            txtCompatible.FillColor = Color.FromArgb(41, 53, 72);
            txtCompatible.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCompatible.ForeColor = Color.White;
            txtCompatible.Location = new Point(23, 176);
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
            txtCompatible.TabIndex = 47;
            txtCompatible.TextAlignment = ContentAlignment.TopLeft;
            txtCompatible.Watermark = "Compatible...";
            txtCompatible.TextChanged += txtCompatible_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.FillColor = Color.FromArgb(41, 53, 72);
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(23, 68);
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
            txtNombre.TabIndex = 46;
            txtNombre.TextAlignment = ContentAlignment.MiddleLeft;
            txtNombre.Watermark = "Producto....";
            // 
            // txtStock
            // 
            txtStock.FillColor = Color.FromArgb(41, 53, 72);
            txtStock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.ForeColor = Color.White;
            txtStock.Location = new Point(50, 417);
            txtStock.Margin = new Padding(5, 7, 5, 7);
            txtStock.MaxLength = 255;
            txtStock.Minimum = 0D;
            txtStock.MinimumSize = new Size(1, 21);
            txtStock.Name = "txtStock";
            txtStock.Padding = new Padding(6, 7, 6, 7);
            txtStock.Radius = 12;
            txtStock.RectColor = Color.FromArgb(39, 53, 72);
            txtStock.ShowText = false;
            txtStock.Size = new Size(172, 50);
            txtStock.TabIndex = 51;
            txtStock.TextAlignment = ContentAlignment.MiddleLeft;
            txtStock.Watermark = "Stock...";
            // 
            // txtCosto
            // 
            txtCosto.FillColor = Color.FromArgb(41, 53, 72);
            txtCosto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCosto.ForeColor = Color.White;
            txtCosto.Location = new Point(279, 417);
            txtCosto.Margin = new Padding(5, 7, 5, 7);
            txtCosto.MaxLength = 255;
            txtCosto.Minimum = 0D;
            txtCosto.MinimumSize = new Size(1, 21);
            txtCosto.Name = "txtCosto";
            txtCosto.Padding = new Padding(6, 7, 6, 7);
            txtCosto.Radius = 12;
            txtCosto.RectColor = Color.FromArgb(39, 53, 72);
            txtCosto.ShowText = false;
            txtCosto.Size = new Size(172, 50);
            txtCosto.TabIndex = 52;
            txtCosto.TextAlignment = ContentAlignment.MiddleLeft;
            txtCosto.Watermark = "Costo...";
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
            cmbProveedor.Location = new Point(14, 310);
            cmbProveedor.Margin = new Padding(5, 7, 5, 7);
            cmbProveedor.MinimumSize = new Size(72, 0);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Padding = new Padding(0, 0, 34, 3);
            cmbProveedor.Radius = 12;
            cmbProveedor.RectColor = Color.FromArgb(148, 163, 184);
            cmbProveedor.Size = new Size(235, 47);
            cmbProveedor.SymbolSize = 24;
            cmbProveedor.TabIndex = 40;
            cmbProveedor.Text = "Seleccionar Proveedor";
            cmbProveedor.TextAlignment = ContentAlignment.MiddleLeft;
            cmbProveedor.Watermark = "";
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
            cmbCategoria.Location = new Point(259, 310);
            cmbCategoria.Margin = new Padding(5, 7, 5, 7);
            cmbCategoria.MinimumSize = new Size(72, 0);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Padding = new Padding(0, 0, 34, 3);
            cmbCategoria.Radius = 12;
            cmbCategoria.RectColor = Color.FromArgb(148, 163, 184);
            cmbCategoria.Size = new Size(229, 47);
            cmbCategoria.SymbolSize = 24;
            cmbCategoria.TabIndex = 41;
            cmbCategoria.Text = "Seleccionar Categoria";
            cmbCategoria.TextAlignment = ContentAlignment.MiddleLeft;
            cmbCategoria.Watermark = "";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(153, 20);
            lblNombre.TabIndex = 53;
            lblNombre.Text = "Nombre del Producto";
            // 
            // lblCompatibilidad
            // 
            lblCompatibilidad.AutoSize = true;
            lblCompatibilidad.Location = new Point(23, 149);
            lblCompatibilidad.Name = "lblCompatibilidad";
            lblCompatibilidad.Size = new Size(113, 20);
            lblCompatibilidad.TabIndex = 54;
            lblCompatibilidad.Text = "Compatibilidad";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(14, 283);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(77, 20);
            lblProveedor.TabIndex = 55;
            lblProveedor.Text = "Proveedor";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(259, 283);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 56;
            lblCategoria.Text = "Categoria";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(50, 390);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(69, 20);
            lblStock.TabIndex = 57;
            lblStock.Text = "Cantidad";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(279, 390);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(112, 20);
            lblCosto.TabIndex = 58;
            lblCosto.Text = "Precio de Venta";
            // 
            // btnAgg
            // 
            btnAgg.BackColor = Color.Transparent;
            btnAgg.FillColor = Color.FromArgb(0, 150, 137);
            btnAgg.FillHoverColor = Color.Transparent;
            btnAgg.FillPressColor = Color.FromArgb(0, 150, 137);
            btnAgg.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgg.Location = new Point(165, 504);
            btnAgg.Margin = new Padding(3, 4, 3, 4);
            btnAgg.MinimumSize = new Size(1, 1);
            btnAgg.Name = "btnAgg";
            btnAgg.Radius = 12;
            btnAgg.RectColor = Color.FromArgb(39, 53, 72);
            btnAgg.RectHoverColor = Color.Transparent;
            btnAgg.RectPressColor = Color.FromArgb(0, 150, 137);
            btnAgg.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgg.Size = new Size(150, 52);
            btnAgg.TabIndex = 60;
            btnAgg.Text = "Registrar Entrega";
            btnAgg.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAgg.TipsForeColor = Color.Transparent;
            // 
            // frmAggStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(502, 599);
            Controls.Add(btnAgg);
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
            Name = "frmAggStock";
            Text = "frmAggStock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UITextBox txtCompatible;
        private Sunny.UI.UITextBox txtNombre;
        private Sunny.UI.UITextBox txtStock;
        private Sunny.UI.UITextBox txtCosto;
        private Sunny.UI.UIComboBox cmbProveedor;
        private Sunny.UI.UIComboBox cmbCategoria;
        private Label lblNombre;
        private Label lblCompatibilidad;
        private Label lblProveedor;
        private Label lblCategoria;
        private Label lblStock;
        private Label lblCosto;
        private Sunny.UI.UIButton btnAgg;
    }
}