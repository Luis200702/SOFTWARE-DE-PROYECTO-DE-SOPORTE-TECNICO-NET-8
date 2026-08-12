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
            lblTitulo = new Label();
            lblProducto = new Label();
            lblAgregar = new Label();
            udoAgg = new Sunny.UI.UIUpDownTextBox();
            pnlStockActual = new Sunny.UI.UIPanel();
            llbStockA = new Label();
            lblstockActual = new Label();
            pnlStockResultante = new Sunny.UI.UIPanel();
            lblStockR = new Label();
            lblStockRedultante = new Label();
            pnlFondo = new Sunny.UI.UIPanel();
            btnCancelar = new Sunny.UI.UIButton();
            btnAgg = new Sunny.UI.UIButton();
            pnlStockActual.SuspendLayout();
            pnlStockResultante.SuspendLayout();
            pnlFondo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(130, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(235, 38);
            lblTitulo.TabIndex = 53;
            lblTitulo.Text = "Registrar Entrada ";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(23, 85);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(202, 31);
            lblProducto.TabIndex = 54;
            lblProducto.Text = "nombre producrto";
            lblProducto.Click += lblProducto_Click;
            // 
            // lblAgregar
            // 
            lblAgregar.AutoSize = true;
            lblAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgregar.Location = new Point(23, 149);
            lblAgregar.Name = "lblAgregar";
            lblAgregar.Size = new Size(182, 28);
            lblAgregar.TabIndex = 55;
            lblAgregar.Text = "Cantidad a Agregar";
            lblAgregar.Click += lblAgregar_Click;
            // 
            // udoAgg
            // 
            udoAgg.CanEmpty = true;
            udoAgg.DoubleStep = 1D;
            udoAgg.DoubleValue = 1D;
            udoAgg.Font = new Font("Microsoft Sans Serif", 12F);
            udoAgg.IntValue = 1;
            udoAgg.Location = new Point(23, 182);
            udoAgg.Margin = new Padding(4, 5, 4, 5);
            udoAgg.Minimum = 1D;
            udoAgg.MinimumSize = new Size(1, 16);
            udoAgg.Name = "udoAgg";
            udoAgg.Padding = new Padding(5);
            udoAgg.Radius = 12;
            udoAgg.ShowText = false;
            udoAgg.Size = new Size(445, 47);
            udoAgg.TabIndex = 69;
            udoAgg.Text = "1";
            udoAgg.TextAlignment = ContentAlignment.MiddleLeft;
            udoAgg.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            udoAgg.Watermark = "";
            // 
            // pnlStockActual
            // 
            pnlStockActual.Controls.Add(llbStockA);
            pnlStockActual.Controls.Add(lblstockActual);
            pnlStockActual.Font = new Font("Microsoft Sans Serif", 12F);
            pnlStockActual.Location = new Point(23, 265);
            pnlStockActual.Margin = new Padding(4, 5, 4, 5);
            pnlStockActual.MinimumSize = new Size(1, 1);
            pnlStockActual.Name = "pnlStockActual";
            pnlStockActual.Radius = 12;
            pnlStockActual.Size = new Size(445, 58);
            pnlStockActual.TabIndex = 70;
            pnlStockActual.Text = null;
            pnlStockActual.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // llbStockA
            // 
            llbStockA.AutoSize = true;
            llbStockA.BackColor = Color.Transparent;
            llbStockA.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbStockA.Location = new Point(392, 13);
            llbStockA.Name = "llbStockA";
            llbStockA.Size = new Size(26, 31);
            llbStockA.TabIndex = 74;
            llbStockA.Text = "1";
            llbStockA.Click += llbStockA_Click;
            // 
            // lblstockActual
            // 
            lblstockActual.AutoSize = true;
            lblstockActual.BackColor = Color.Transparent;
            lblstockActual.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblstockActual.Location = new Point(15, 13);
            lblstockActual.Name = "lblstockActual";
            lblstockActual.Size = new Size(139, 31);
            lblstockActual.TabIndex = 73;
            lblstockActual.Text = "Stock Actual";
            // 
            // pnlStockResultante
            // 
            pnlStockResultante.Controls.Add(lblStockR);
            pnlStockResultante.Controls.Add(lblStockRedultante);
            pnlStockResultante.Font = new Font("Microsoft Sans Serif", 12F);
            pnlStockResultante.Location = new Point(23, 347);
            pnlStockResultante.Margin = new Padding(4, 5, 4, 5);
            pnlStockResultante.MinimumSize = new Size(1, 1);
            pnlStockResultante.Name = "pnlStockResultante";
            pnlStockResultante.Radius = 12;
            pnlStockResultante.Size = new Size(445, 58);
            pnlStockResultante.TabIndex = 71;
            pnlStockResultante.Text = null;
            pnlStockResultante.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblStockR
            // 
            lblStockR.AutoSize = true;
            lblStockR.BackColor = Color.Transparent;
            lblStockR.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockR.Location = new Point(369, 14);
            lblStockR.Name = "lblStockR";
            lblStockR.Size = new Size(59, 31);
            lblStockR.TabIndex = 75;
            lblStockR.Text = "-----";
            // 
            // lblStockRedultante
            // 
            lblStockRedultante.AutoSize = true;
            lblStockRedultante.BackColor = Color.Transparent;
            lblStockRedultante.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockRedultante.Location = new Point(15, 14);
            lblStockRedultante.Name = "lblStockRedultante";
            lblStockRedultante.Size = new Size(181, 31);
            lblStockRedultante.TabIndex = 74;
            lblStockRedultante.Text = "Stock Resultante";
            // 
            // pnlFondo
            // 
            pnlFondo.Controls.Add(btnCancelar);
            pnlFondo.Controls.Add(btnAgg);
            pnlFondo.Font = new Font("Microsoft Sans Serif", 12F);
            pnlFondo.Location = new Point(-5, 445);
            pnlFondo.Margin = new Padding(4, 5, 4, 5);
            pnlFondo.MinimumSize = new Size(1, 1);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Radius = 12;
            pnlFondo.Size = new Size(517, 131);
            pnlFondo.TabIndex = 80;
            pnlFondo.Text = null;
            pnlFondo.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FillColor = Color.FromArgb(0, 150, 137);
            btnCancelar.FillHoverColor = Color.Transparent;
            btnCancelar.FillPressColor = Color.FromArgb(0, 150, 137);
            btnCancelar.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(168, 23);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.MinimumSize = new Size(1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Radius = 12;
            btnCancelar.RectColor = Color.FromArgb(39, 53, 72);
            btnCancelar.RectHoverColor = Color.Transparent;
            btnCancelar.RectPressColor = Color.FromArgb(0, 150, 137);
            btnCancelar.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Size = new Size(150, 52);
            btnCancelar.TabIndex = 72;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCancelar.TipsForeColor = Color.Transparent;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgg
            // 
            btnAgg.BackColor = Color.Transparent;
            btnAgg.FillColor = Color.FromArgb(0, 150, 137);
            btnAgg.FillHoverColor = Color.Transparent;
            btnAgg.FillPressColor = Color.FromArgb(0, 150, 137);
            btnAgg.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnAgg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgg.Location = new Point(333, 23);
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
            btnAgg.Text = "Confirmar";
            btnAgg.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAgg.TipsForeColor = Color.Transparent;
            // 
            // frmAggStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(499, 541);
            Controls.Add(pnlFondo);
            Controls.Add(pnlStockResultante);
            Controls.Add(pnlStockActual);
            Controls.Add(udoAgg);
            Controls.Add(lblAgregar);
            Controls.Add(lblProducto);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAggStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAggStock";
            Load += frmAggStock_Load;
            pnlStockActual.ResumeLayout(false);
            pnlStockActual.PerformLayout();
            pnlStockResultante.ResumeLayout(false);
            pnlStockResultante.PerformLayout();
            pnlFondo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label lblProducto;
        private Label lblAgregar;
        private Sunny.UI.UIUpDownTextBox udoAgg;
        private Sunny.UI.UIPanel pnlStockActual;
        private Label lblstockActual;
        private Sunny.UI.UIPanel pnlStockResultante;
        private Label lblStockRedultante;
        private Label llbStockA;
        private Label lblStockR;
        private Sunny.UI.UIPanel pnlFondo;
        private Sunny.UI.UIButton btnCancelar;
        private Sunny.UI.UIButton btnAgg;
    }
}