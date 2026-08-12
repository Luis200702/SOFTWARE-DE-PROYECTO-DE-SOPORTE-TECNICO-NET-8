namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class frmDeleteStock
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
            pnlFondo = new Sunny.UI.UIPanel();
            btnCancelar = new Sunny.UI.UIButton();
            btnAgg = new Sunny.UI.UIButton();
            pnlStockResultante = new Sunny.UI.UIPanel();
            lblStockR = new Label();
            lblStockRedultante = new Label();
            pnlStockActual = new Sunny.UI.UIPanel();
            llbStockA = new Label();
            lblstockActual = new Label();
            udoDel = new Sunny.UI.UIUpDownTextBox();
            lblReducir = new Label();
            lblProducto = new Label();
            lblTitulo = new Label();
            pnlFondo.SuspendLayout();
            pnlStockResultante.SuspendLayout();
            pnlStockActual.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFondo
            // 
            pnlFondo.Controls.Add(btnCancelar);
            pnlFondo.Controls.Add(btnAgg);
            pnlFondo.Font = new Font("Microsoft Sans Serif", 12F);
            pnlFondo.Location = new Point(-9, 437);
            pnlFondo.Margin = new Padding(4, 5, 4, 5);
            pnlFondo.MinimumSize = new Size(1, 1);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Radius = 12;
            pnlFondo.Size = new Size(517, 110);
            pnlFondo.TabIndex = 87;
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
            btnCancelar.Location = new Point(167, 24);
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
            btnAgg.Location = new Point(337, 24);
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
            // pnlStockResultante
            // 
            pnlStockResultante.Controls.Add(lblStockR);
            pnlStockResultante.Controls.Add(lblStockRedultante);
            pnlStockResultante.Font = new Font("Microsoft Sans Serif", 12F);
            pnlStockResultante.Location = new Point(19, 345);
            pnlStockResultante.Margin = new Padding(4, 5, 4, 5);
            pnlStockResultante.MinimumSize = new Size(1, 1);
            pnlStockResultante.Name = "pnlStockResultante";
            pnlStockResultante.Radius = 12;
            pnlStockResultante.Size = new Size(445, 58);
            pnlStockResultante.TabIndex = 86;
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
            // pnlStockActual
            // 
            pnlStockActual.Controls.Add(llbStockA);
            pnlStockActual.Controls.Add(lblstockActual);
            pnlStockActual.Font = new Font("Microsoft Sans Serif", 12F);
            pnlStockActual.Location = new Point(19, 259);
            pnlStockActual.Margin = new Padding(4, 5, 4, 5);
            pnlStockActual.MinimumSize = new Size(1, 1);
            pnlStockActual.Name = "pnlStockActual";
            pnlStockActual.Radius = 12;
            pnlStockActual.Size = new Size(445, 58);
            pnlStockActual.TabIndex = 85;
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
            // udoDel
            // 
            udoDel.CanEmpty = true;
            udoDel.DoubleStep = 1D;
            udoDel.DoubleValue = 1D;
            udoDel.Font = new Font("Microsoft Sans Serif", 12F);
            udoDel.IntValue = 1;
            udoDel.Location = new Point(19, 181);
            udoDel.Margin = new Padding(4, 5, 4, 5);
            udoDel.Minimum = 1D;
            udoDel.MinimumSize = new Size(1, 16);
            udoDel.Name = "udoDel";
            udoDel.Padding = new Padding(5);
            udoDel.Radius = 12;
            udoDel.ShowText = false;
            udoDel.Size = new Size(445, 47);
            udoDel.TabIndex = 84;
            udoDel.Text = "1";
            udoDel.TextAlignment = ContentAlignment.MiddleLeft;
            udoDel.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            udoDel.Watermark = "";
            // 
            // lblReducir
            // 
            lblReducir.AutoSize = true;
            lblReducir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReducir.Location = new Point(19, 148);
            lblReducir.Name = "lblReducir";
            lblReducir.Size = new Size(176, 28);
            lblReducir.TabIndex = 83;
            lblReducir.Text = "Cantidad a Reducir";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(19, 94);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(202, 31);
            lblProducto.TabIndex = 82;
            lblProducto.Text = "nombre producrto";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(143, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(207, 38);
            lblTitulo.TabIndex = 81;
            lblTitulo.Text = "Registrar Salida";
            // 
            // frmDeleteStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(499, 541);
            Controls.Add(pnlFondo);
            Controls.Add(pnlStockResultante);
            Controls.Add(pnlStockActual);
            Controls.Add(udoDel);
            Controls.Add(lblReducir);
            Controls.Add(lblProducto);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDeleteStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDeleteStock";
            pnlFondo.ResumeLayout(false);
            pnlStockResultante.ResumeLayout(false);
            pnlStockResultante.PerformLayout();
            pnlStockActual.ResumeLayout(false);
            pnlStockActual.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIPanel pnlFondo;
        private Sunny.UI.UIButton btnCancelar;
        private Sunny.UI.UIButton btnAgg;
        private Sunny.UI.UIPanel pnlStockResultante;
        private Label lblStockR;
        private Label lblStockRedultante;
        private Sunny.UI.UIPanel pnlStockActual;
        private Label llbStockA;
        private Label lblstockActual;
        private Sunny.UI.UIUpDownTextBox udoDel;
        private Label lblReducir;
        private Label lblProducto;
        private Label lblTitulo;
    }
}