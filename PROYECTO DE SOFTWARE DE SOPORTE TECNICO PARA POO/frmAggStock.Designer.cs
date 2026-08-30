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
            lblProducto = new Label();
            lblAgregar = new Label();
            udoAgg = new Sunny.UI.UIUpDownTextBox();
            llbStockA = new Label();
            lblstockActual = new Label();
            pnlStockResultante = new Sunny.UI.UIPanel();
            uiAvatar3 = new Sunny.UI.UIAvatar();
            lblStockResultante = new Label();
            lblStockRedultante = new Label();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            lblCliente = new Label();
            pnlDatosCliente = new Sunny.UI.UIPanel();
            pnlStockActual = new Sunny.UI.UIPanel();
            uiAvatar2 = new Sunny.UI.UIAvatar();
            btnAgg = new Sunny.UI.UISymbolButton();
            btnCancelar = new Sunny.UI.UISymbolButton();
            pnlStockResultante.SuspendLayout();
            pnlDatosCliente.SuspendLayout();
            pnlStockActual.SuspendLayout();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.ForeColor = Color.FromArgb(24, 43, 62);
            lblProducto.Location = new Point(63, 15);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(193, 25);
            lblProducto.TabIndex = 54;
            lblProducto.Text = "nombre del producto";
            lblProducto.Click += lblProducto_Click;
            // 
            // lblAgregar
            // 
            lblAgregar.AutoSize = true;
            lblAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgregar.ForeColor = Color.FromArgb(0, 125, 117);
            lblAgregar.Location = new Point(16, 56);
            lblAgregar.Name = "lblAgregar";
            lblAgregar.Size = new Size(144, 21);
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
            udoAgg.ForeColor = Color.FromArgb(24, 43, 62);
            udoAgg.IntValue = 1;
            udoAgg.Location = new Point(18, 81);
            udoAgg.Margin = new Padding(4);
            udoAgg.Minimum = 1D;
            udoAgg.MinimumSize = new Size(1, 12);
            udoAgg.Name = "udoAgg";
            udoAgg.Padding = new Padding(4);
            udoAgg.Radius = 12;
            udoAgg.RectColor = Color.FromArgb(90, 180, 175);
            udoAgg.RectDisableColor = Color.FromArgb(0, 165, 155);
            udoAgg.RectReadOnlyColor = Color.FromArgb(0, 165, 155);
            udoAgg.ShowText = false;
            udoAgg.Size = new Size(500, 35);
            udoAgg.TabIndex = 69;
            udoAgg.Text = "1";
            udoAgg.TextAlignment = ContentAlignment.MiddleLeft;
            udoAgg.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            udoAgg.Watermark = "";
            udoAgg.TextChanged += udoAgg_TextChanged;
            // 
            // llbStockA
            // 
            llbStockA.AutoSize = true;
            llbStockA.BackColor = Color.Transparent;
            llbStockA.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            llbStockA.ForeColor = Color.FromArgb(0, 145, 137);
            llbStockA.Location = new Point(436, 12);
            llbStockA.Name = "llbStockA";
            llbStockA.Size = new Size(52, 25);
            llbStockA.TabIndex = 74;
            llbStockA.Text = "-----";
            llbStockA.Click += llbStockA_Click;
            // 
            // lblstockActual
            // 
            lblstockActual.AutoSize = true;
            lblstockActual.BackColor = Color.Transparent;
            lblstockActual.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblstockActual.ForeColor = Color.FromArgb(24, 43, 62);
            lblstockActual.Location = new Point(45, 10);
            lblstockActual.Name = "lblstockActual";
            lblstockActual.Size = new Size(101, 21);
            lblstockActual.TabIndex = 73;
            lblstockActual.Text = "Stock Actual";
            // 
            // pnlStockResultante
            // 
            pnlStockResultante.Controls.Add(uiAvatar3);
            pnlStockResultante.Controls.Add(lblStockResultante);
            pnlStockResultante.Controls.Add(lblStockRedultante);
            pnlStockResultante.FillColor = Color.FromArgb(240, 247, 255);
            pnlStockResultante.Font = new Font("Microsoft Sans Serif", 12F);
            pnlStockResultante.Location = new Point(18, 185);
            pnlStockResultante.Margin = new Padding(4);
            pnlStockResultante.MinimumSize = new Size(1, 1);
            pnlStockResultante.Name = "pnlStockResultante";
            pnlStockResultante.Radius = 12;
            pnlStockResultante.RectColor = Color.FromArgb(220, 226, 232);
            pnlStockResultante.Size = new Size(500, 44);
            pnlStockResultante.TabIndex = 71;
            pnlStockResultante.Text = null;
            pnlStockResultante.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiAvatar3
            // 
            uiAvatar3.FillColor = Color.FromArgb(220, 243, 241);
            uiAvatar3.Font = new Font("Microsoft Sans Serif", 12F);
            uiAvatar3.ForeColor = Color.FromArgb(0, 165, 155);
            uiAvatar3.Location = new Point(13, 8);
            uiAvatar3.MinimumSize = new Size(1, 1);
            uiAvatar3.Name = "uiAvatar3";
            uiAvatar3.Size = new Size(26, 29);
            uiAvatar3.Symbol = 61538;
            uiAvatar3.SymbolSize = 25;
            uiAvatar3.TabIndex = 93;
            uiAvatar3.Text = "uiAvatar3";
            // 
            // lblStockResultante
            // 
            lblStockResultante.AutoSize = true;
            lblStockResultante.BackColor = Color.Transparent;
            lblStockResultante.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockResultante.ForeColor = Color.FromArgb(30, 110, 180);
            lblStockResultante.Location = new Point(436, 8);
            lblStockResultante.Name = "lblStockResultante";
            lblStockResultante.Size = new Size(52, 25);
            lblStockResultante.TabIndex = 75;
            lblStockResultante.Text = "-----";
            lblStockResultante.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblStockRedultante
            // 
            lblStockRedultante.AutoSize = true;
            lblStockRedultante.BackColor = Color.Transparent;
            lblStockRedultante.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockRedultante.ForeColor = Color.FromArgb(24, 43, 62);
            lblStockRedultante.Location = new Point(45, 12);
            lblStockRedultante.Name = "lblStockRedultante";
            lblStockRedultante.Size = new Size(132, 21);
            lblStockRedultante.TabIndex = 74;
            lblStockRedultante.Text = "Stock Resultante";
            // 
            // uiAvatar1
            // 
            uiAvatar1.FillColor = Color.FromArgb(232, 248, 247);
            uiAvatar1.Font = new Font("Microsoft Sans Serif", 12F);
            uiAvatar1.ForeColor = Color.FromArgb(0, 165, 155);
            uiAvatar1.Location = new Point(29, 12);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Size = new Size(60, 60);
            uiAvatar1.Symbol = 61637;
            uiAvatar1.TabIndex = 89;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblCliente.ForeColor = Color.FromArgb(24, 43, 62);
            lblCliente.Location = new Point(95, 32);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(166, 25);
            lblCliente.TabIndex = 90;
            lblCliente.Text = "Registrar entrada";
            // 
            // pnlDatosCliente
            // 
            pnlDatosCliente.BackColor = Color.Transparent;
            pnlDatosCliente.Controls.Add(btnCancelar);
            pnlDatosCliente.Controls.Add(btnAgg);
            pnlDatosCliente.Controls.Add(pnlStockActual);
            pnlDatosCliente.Controls.Add(lblProducto);
            pnlDatosCliente.Controls.Add(lblAgregar);
            pnlDatosCliente.Controls.Add(udoAgg);
            pnlDatosCliente.Controls.Add(pnlStockResultante);
            pnlDatosCliente.FillColor = Color.White;
            pnlDatosCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlDatosCliente.ForeColor = Color.Black;
            pnlDatosCliente.Location = new Point(13, 75);
            pnlDatosCliente.Margin = new Padding(4, 5, 4, 5);
            pnlDatosCliente.MinimumSize = new Size(1, 1);
            pnlDatosCliente.Name = "pnlDatosCliente";
            pnlDatosCliente.Radius = 12;
            pnlDatosCliente.RectColor = Color.FromArgb(221, 227, 233);
            pnlDatosCliente.Size = new Size(532, 307);
            pnlDatosCliente.TabIndex = 91;
            pnlDatosCliente.Text = null;
            pnlDatosCliente.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlStockActual
            // 
            pnlStockActual.Controls.Add(uiAvatar2);
            pnlStockActual.Controls.Add(llbStockA);
            pnlStockActual.Controls.Add(lblstockActual);
            pnlStockActual.FillColor = Color.FromArgb(232, 248, 247);
            pnlStockActual.Font = new Font("Microsoft Sans Serif", 12F);
            pnlStockActual.Location = new Point(18, 133);
            pnlStockActual.Margin = new Padding(4);
            pnlStockActual.MinimumSize = new Size(1, 1);
            pnlStockActual.Name = "pnlStockActual";
            pnlStockActual.Radius = 12;
            pnlStockActual.RectColor = Color.FromArgb(220, 226, 232);
            pnlStockActual.Size = new Size(500, 44);
            pnlStockActual.TabIndex = 73;
            pnlStockActual.Text = null;
            pnlStockActual.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiAvatar2
            // 
            uiAvatar2.FillColor = Color.FromArgb(220, 243, 241);
            uiAvatar2.Font = new Font("Microsoft Sans Serif", 12F);
            uiAvatar2.ForeColor = Color.FromArgb(0, 165, 155);
            uiAvatar2.Location = new Point(13, 8);
            uiAvatar2.MinimumSize = new Size(1, 1);
            uiAvatar2.Name = "uiAvatar2";
            uiAvatar2.Size = new Size(26, 29);
            uiAvatar2.Symbol = 61831;
            uiAvatar2.SymbolSize = 25;
            uiAvatar2.TabIndex = 92;
            uiAvatar2.Text = "uiAvatar2";
            // 
            // btnAgg
            // 
            btnAgg.FillColor = Color.FromArgb(0, 165, 155);
            btnAgg.FillHoverColor = Color.FromArgb(0, 145, 137);
            btnAgg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgg.Location = new Point(280, 253);
            btnAgg.MinimumSize = new Size(1, 1);
            btnAgg.Name = "btnAgg";
            btnAgg.Radius = 12;
            btnAgg.RectColor = Color.FromArgb(0, 165, 155);
            btnAgg.RectHoverColor = Color.FromArgb(0, 145, 137);
            btnAgg.Size = new Size(155, 38);
            btnAgg.Symbol = 61533;
            btnAgg.TabIndex = 74;
            btnAgg.Text = "Confirmar";
            btnAgg.TipsFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgg.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FillColor = Color.White;
            btnCancelar.FillHoverColor = Color.FromArgb(243, 246, 250);
            btnCancelar.FillPressColor = Color.FromArgb(232, 237, 242);
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(70, 86, 103);
            btnCancelar.ForeHoverColor = Color.FromArgb(24, 43, 62);
            btnCancelar.ForePressColor = Color.FromArgb(24, 43, 62);
            btnCancelar.Location = new Point(119, 253);
            btnCancelar.MinimumSize = new Size(1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Radius = 12;
            btnCancelar.RectColor = Color.FromArgb(180, 190, 200);
            btnCancelar.RectHoverColor = Color.FromArgb(145, 158, 172);
            btnCancelar.Size = new Size(155, 38);
            btnCancelar.Symbol = 61453;
            btnCancelar.SymbolColor = Color.FromArgb(70, 86, 103);
            btnCancelar.TabIndex = 75;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TipsFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmAggStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            ClientSize = new Size(558, 392);
            Controls.Add(pnlDatosCliente);
            Controls.Add(lblCliente);
            Controls.Add(uiAvatar1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAggStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAggStock";
            Load += frmAggStock_Load;
            pnlStockResultante.ResumeLayout(false);
            pnlStockResultante.PerformLayout();
            pnlDatosCliente.ResumeLayout(false);
            pnlDatosCliente.PerformLayout();
            pnlStockActual.ResumeLayout(false);
            pnlStockActual.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProducto;
        private Label lblAgregar;
        private Sunny.UI.UIUpDownTextBox udoAgg;
        private Label lblstockActual;
        private Sunny.UI.UIPanel pnlStockResultante;
        private Label lblStockRedultante;
        private Label llbStockA;
        private Label lblStockResultante;
        private Sunny.UI.UIPanel pnlFondo;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Label lblCliente;
        private Sunny.UI.UIPanel pnlDatosCliente;
        private Sunny.UI.UIPanel pnlStockActual;
        private Sunny.UI.UIAvatar uiAvatar2;
        private Sunny.UI.UIAvatar uiAvatar3;
        private Sunny.UI.UISymbolButton btnCancelar;
        private Sunny.UI.UISymbolButton btnAgg;
    }
}