namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucDerivacion
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
            components = new System.ComponentModel.Container();
            pnltituloderivacion = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnNuevaDerivacion = new Sunny.UI.UIButton();
            lblnumeroderivaciones = new Label();
            pnlderivacionesdatos = new Panel();
            pnlNuevaDerivacion = new Panel();
            btnComprobante = new Sunny.UI.UIButton();
            uiComboBox2 = new Sunny.UI.UIComboBox();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            cmbAggSelecSucur = new Sunny.UI.UIComboBox();
            txtAggRecursosDeriv = new Sunny.UI.UITextBox();
            txtAgggDispositivoDeriv = new Sunny.UI.UITextBox();
            txtAggClienteDeriv = new Sunny.UI.UITextBox();
            txtAggCodigoImeiCeriv = new Sunny.UI.UITextBox();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            label21 = new Label();
            textBox2 = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label16 = new Label();
            label17 = new Label();
            label15 = new Label();
            label4 = new Label();
            dgvderivacionsucursales = new DataGridView();
            panel5 = new Panel();
            panel2 = new Panel();
            uiButton3 = new Sunny.UI.UIButton();
            label3 = new Label();
            pnlDetallesDerivaciones = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnRechazarDerivacion = new Sunny.UI.UIButton();
            btnAceptarDerivacion = new Sunny.UI.UIButton();
            textBox1 = new TextBox();
            label14 = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label13 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label9 = new Label();
            lblnombreDetalle = new Label();
            lblcodigoDetalle = new Label();
            lblestadoDetalle = new Label();
            panel4 = new Panel();
            uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip(components);
            pnltituloderivacion.SuspendLayout();
            panel1.SuspendLayout();
            pnlderivacionesdatos.SuspendLayout();
            pnlNuevaDerivacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvderivacionsucursales).BeginInit();
            panel2.SuspendLayout();
            pnlDetallesDerivaciones.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnltituloderivacion
            // 
            pnltituloderivacion.BackColor = Color.FromArgb(15, 23, 42);
            pnltituloderivacion.BorderStyle = BorderStyle.FixedSingle;
            pnltituloderivacion.Controls.Add(label1);
            pnltituloderivacion.Location = new Point(3, 3);
            pnltituloderivacion.Name = "pnltituloderivacion";
            pnltituloderivacion.Size = new Size(609, 59);
            pnltituloderivacion.TabIndex = 0;
            pnltituloderivacion.Paint += pnltituloderivacion_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 18);
            label1.Name = "label1";
            label1.Size = new Size(331, 32);
            label1.TabIndex = 0;
            label1.Text = "Derivación Entre Sucursales";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 23, 42);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnNuevaDerivacion);
            panel1.Controls.Add(lblnumeroderivaciones);
            panel1.Location = new Point(3, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 58);
            panel1.TabIndex = 1;
            panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // btnNuevaDerivacion
            // 
            btnNuevaDerivacion.FillColor = Color.FromArgb(45, 212, 191);
            btnNuevaDerivacion.FillColor2 = Color.FromArgb(45, 212, 191);
            btnNuevaDerivacion.Font = new Font("Segoe UI", 12F);
            btnNuevaDerivacion.Location = new Point(418, 6);
            btnNuevaDerivacion.MinimumSize = new Size(1, 1);
            btnNuevaDerivacion.Name = "btnNuevaDerivacion";
            btnNuevaDerivacion.RectColor = Color.Empty;
            btnNuevaDerivacion.RectDisableColor = Color.Empty;
            btnNuevaDerivacion.RectHoverColor = Color.FromArgb(45, 212, 191);
            btnNuevaDerivacion.RectPressColor = Color.FromArgb(45, 212, 191);
            btnNuevaDerivacion.RectSelectedColor = Color.FromArgb(45, 212, 191);
            btnNuevaDerivacion.Size = new Size(175, 36);
            btnNuevaDerivacion.TabIndex = 22;
            btnNuevaDerivacion.Text = "+ Nueva Derivación ";
            btnNuevaDerivacion.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnNuevaDerivacion.Click += btnNuevaDerivacion_Click_1;
            // 
            // lblnumeroderivaciones
            // 
            lblnumeroderivaciones.AutoSize = true;
            lblnumeroderivaciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnumeroderivaciones.ForeColor = Color.White;
            lblnumeroderivaciones.Location = new Point(44, 11);
            lblnumeroderivaciones.Name = "lblnumeroderivaciones";
            lblnumeroderivaciones.Size = new Size(120, 21);
            lblnumeroderivaciones.TabIndex = 0;
            lblnumeroderivaciones.Text = "3 Derivaciones ";
            lblnumeroderivaciones.Click += label1_Click;
            // 
            // pnlderivacionesdatos
            // 
            pnlderivacionesdatos.BackColor = Color.FromArgb(15, 23, 42);
            pnlderivacionesdatos.Controls.Add(pnlNuevaDerivacion);
            pnlderivacionesdatos.Controls.Add(dgvderivacionsucursales);
            pnlderivacionesdatos.Controls.Add(panel5);
            pnlderivacionesdatos.Controls.Add(pnltituloderivacion);
            pnlderivacionesdatos.Controls.Add(panel1);
            pnlderivacionesdatos.Dock = DockStyle.Left;
            pnlderivacionesdatos.Location = new Point(0, 0);
            pnlderivacionesdatos.Name = "pnlderivacionesdatos";
            pnlderivacionesdatos.Size = new Size(618, 686);
            pnlderivacionesdatos.TabIndex = 3;
            pnlderivacionesdatos.Paint += panel2_Paint;
            // 
            // pnlNuevaDerivacion
            // 
            pnlNuevaDerivacion.BackColor = Color.FromArgb(15, 23, 42);
            pnlNuevaDerivacion.BorderStyle = BorderStyle.FixedSingle;
            pnlNuevaDerivacion.Controls.Add(btnComprobante);
            pnlNuevaDerivacion.Controls.Add(uiComboBox2);
            pnlNuevaDerivacion.Controls.Add(uiComboBox1);
            pnlNuevaDerivacion.Controls.Add(cmbAggSelecSucur);
            pnlNuevaDerivacion.Controls.Add(txtAggRecursosDeriv);
            pnlNuevaDerivacion.Controls.Add(txtAgggDispositivoDeriv);
            pnlNuevaDerivacion.Controls.Add(txtAggClienteDeriv);
            pnlNuevaDerivacion.Controls.Add(txtAggCodigoImeiCeriv);
            pnlNuevaDerivacion.Controls.Add(uiButton2);
            pnlNuevaDerivacion.Controls.Add(uiButton1);
            pnlNuevaDerivacion.Controls.Add(label21);
            pnlNuevaDerivacion.Controls.Add(textBox2);
            pnlNuevaDerivacion.Controls.Add(label20);
            pnlNuevaDerivacion.Controls.Add(label19);
            pnlNuevaDerivacion.Controls.Add(label18);
            pnlNuevaDerivacion.Controls.Add(label16);
            pnlNuevaDerivacion.Controls.Add(label17);
            pnlNuevaDerivacion.Controls.Add(label15);
            pnlNuevaDerivacion.Controls.Add(label4);
            pnlNuevaDerivacion.Location = new Point(229, 14);
            pnlNuevaDerivacion.Name = "pnlNuevaDerivacion";
            pnlNuevaDerivacion.Size = new Size(383, 672);
            pnlNuevaDerivacion.TabIndex = 5;
            pnlNuevaDerivacion.Visible = false;
            pnlNuevaDerivacion.Paint += pnlNuevaDerivacion_Paint;
            // 
            // btnComprobante
            // 
            btnComprobante.BackColor = Color.Transparent;
            btnComprobante.FillColor = Color.FromArgb(22, 35, 52);
            btnComprobante.FillHoverColor = Color.Transparent;
            btnComprobante.FillPressColor = Color.FromArgb(0, 150, 137);
            btnComprobante.FillSelectedColor = Color.FromArgb(0, 150, 137);
            btnComprobante.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprobante.Location = new Point(349, 0);
            btnComprobante.MinimumSize = new Size(1, 1);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Radius = 12;
            btnComprobante.RectColor = Color.FromArgb(39, 53, 72);
            btnComprobante.RectHoverColor = Color.FromArgb(22, 35, 52);
            btnComprobante.RectPressColor = Color.FromArgb(0, 150, 137);
            btnComprobante.RectSelectedColor = Color.FromArgb(0, 150, 137);
            btnComprobante.Size = new Size(33, 32);
            btnComprobante.TabIndex = 36;
            btnComprobante.Text = "X";
            btnComprobante.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnComprobante.TipsForeColor = Color.Transparent;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // uiComboBox2
            // 
            uiComboBox2.BackColor = Color.Transparent;
            uiComboBox2.DataSource = null;
            uiComboBox2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            uiComboBox2.FillColor = Color.FromArgb(41, 53, 72);
            uiComboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiComboBox2.ForeColor = Color.White;
            uiComboBox2.ForeDisableColor = Color.FromArgb(80, 160, 255);
            uiComboBox2.FormattingEnabled = true;
            uiComboBox2.ItemForeColor = Color.FromArgb(80, 160, 255);
            uiComboBox2.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox2.Items.AddRange(new object[] { "Selecinar..", "Falta de repuesto ", "Falta de técnico especializado ", "Capacidad máxima ", "Solicitud del cliente ", "Otro" });
            uiComboBox2.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox2.Location = new Point(16, 390);
            uiComboBox2.Margin = new Padding(4, 5, 4, 5);
            uiComboBox2.MinimumSize = new Size(63, 0);
            uiComboBox2.Name = "uiComboBox2";
            uiComboBox2.Padding = new Padding(0, 0, 30, 2);
            uiComboBox2.Radius = 12;
            uiComboBox2.Size = new Size(357, 28);
            uiComboBox2.SymbolSize = 24;
            uiComboBox2.TabIndex = 59;
            uiComboBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox2.Watermark = "Seleccionar";
            // 
            // uiComboBox1
            // 
            uiComboBox1.BackColor = Color.Transparent;
            uiComboBox1.DataSource = null;
            uiComboBox1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            uiComboBox1.FillColor = Color.FromArgb(41, 53, 72);
            uiComboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiComboBox1.ForeColor = Color.White;
            uiComboBox1.ForeDisableColor = Color.FromArgb(80, 160, 255);
            uiComboBox1.FormattingEnabled = true;
            uiComboBox1.ItemForeColor = Color.FromArgb(80, 160, 255);
            uiComboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox1.Items.AddRange(new object[] { "Selecinar..", "Sucursal Centro ", "Sucursal Norte ", "Sucursal Sur " });
            uiComboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox1.Location = new Point(16, 333);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Radius = 12;
            uiComboBox1.Size = new Size(357, 28);
            uiComboBox1.SymbolSize = 24;
            uiComboBox1.TabIndex = 58;
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "Seleccionar";
            // 
            // cmbAggSelecSucur
            // 
            cmbAggSelecSucur.BackColor = Color.Transparent;
            cmbAggSelecSucur.DataSource = null;
            cmbAggSelecSucur.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbAggSelecSucur.FillColor = Color.FromArgb(41, 53, 72);
            cmbAggSelecSucur.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAggSelecSucur.ForeColor = Color.White;
            cmbAggSelecSucur.ForeDisableColor = Color.FromArgb(80, 160, 255);
            cmbAggSelecSucur.FormattingEnabled = true;
            cmbAggSelecSucur.ItemForeColor = Color.FromArgb(80, 160, 255);
            cmbAggSelecSucur.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbAggSelecSucur.Items.AddRange(new object[] { "Selecinar..", "Sucursal Centro ", "Sucursal Norte ", "Sucursal Sur " });
            cmbAggSelecSucur.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbAggSelecSucur.Location = new Point(16, 277);
            cmbAggSelecSucur.Margin = new Padding(4, 5, 4, 5);
            cmbAggSelecSucur.MinimumSize = new Size(63, 0);
            cmbAggSelecSucur.Name = "cmbAggSelecSucur";
            cmbAggSelecSucur.Padding = new Padding(0, 0, 30, 2);
            cmbAggSelecSucur.Radius = 12;
            cmbAggSelecSucur.Size = new Size(357, 28);
            cmbAggSelecSucur.SymbolSize = 24;
            cmbAggSelecSucur.TabIndex = 57;
            cmbAggSelecSucur.TextAlignment = ContentAlignment.MiddleLeft;
            cmbAggSelecSucur.Watermark = "Seleccionar";
            // 
            // txtAggRecursosDeriv
            // 
            txtAggRecursosDeriv.BackColor = Color.Transparent;
            txtAggRecursosDeriv.FillColor = Color.FromArgb(41, 53, 72);
            txtAggRecursosDeriv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAggRecursosDeriv.ForeColor = Color.White;
            txtAggRecursosDeriv.Location = new Point(16, 226);
            txtAggRecursosDeriv.Margin = new Padding(4, 5, 4, 5);
            txtAggRecursosDeriv.MaxLength = 255;
            txtAggRecursosDeriv.Minimum = 0D;
            txtAggRecursosDeriv.MinimumSize = new Size(1, 16);
            txtAggRecursosDeriv.Name = "txtAggRecursosDeriv";
            txtAggRecursosDeriv.Padding = new Padding(5);
            txtAggRecursosDeriv.Radius = 12;
            txtAggRecursosDeriv.ShowText = false;
            txtAggRecursosDeriv.Size = new Size(357, 29);
            txtAggRecursosDeriv.TabIndex = 55;
            txtAggRecursosDeriv.TextAlignment = ContentAlignment.MiddleLeft;
            txtAggRecursosDeriv.Watermark = "Ej. Pantalla AMOLED S22";
            // 
            // txtAgggDispositivoDeriv
            // 
            txtAgggDispositivoDeriv.BackColor = Color.Transparent;
            txtAgggDispositivoDeriv.FillColor = Color.FromArgb(41, 53, 72);
            txtAgggDispositivoDeriv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAgggDispositivoDeriv.ForeColor = Color.White;
            txtAgggDispositivoDeriv.Location = new Point(16, 167);
            txtAgggDispositivoDeriv.Margin = new Padding(4, 5, 4, 5);
            txtAgggDispositivoDeriv.MaxLength = 255;
            txtAgggDispositivoDeriv.Minimum = 0D;
            txtAgggDispositivoDeriv.MinimumSize = new Size(1, 16);
            txtAgggDispositivoDeriv.Name = "txtAgggDispositivoDeriv";
            txtAgggDispositivoDeriv.Padding = new Padding(5);
            txtAgggDispositivoDeriv.Radius = 12;
            txtAgggDispositivoDeriv.ShowText = false;
            txtAgggDispositivoDeriv.Size = new Size(357, 29);
            txtAgggDispositivoDeriv.TabIndex = 54;
            txtAgggDispositivoDeriv.TextAlignment = ContentAlignment.MiddleLeft;
            txtAgggDispositivoDeriv.Watermark = "Marca y modelo";
            // 
            // txtAggClienteDeriv
            // 
            txtAggClienteDeriv.BackColor = Color.Transparent;
            txtAggClienteDeriv.FillColor = Color.FromArgb(41, 53, 72);
            txtAggClienteDeriv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAggClienteDeriv.ForeColor = Color.White;
            txtAggClienteDeriv.Location = new Point(16, 107);
            txtAggClienteDeriv.Margin = new Padding(4, 5, 4, 5);
            txtAggClienteDeriv.MaxLength = 255;
            txtAggClienteDeriv.Minimum = 0D;
            txtAggClienteDeriv.MinimumSize = new Size(1, 16);
            txtAggClienteDeriv.Name = "txtAggClienteDeriv";
            txtAggClienteDeriv.Padding = new Padding(5);
            txtAggClienteDeriv.Radius = 12;
            txtAggClienteDeriv.ShowText = false;
            txtAggClienteDeriv.Size = new Size(357, 29);
            txtAggClienteDeriv.TabIndex = 53;
            txtAggClienteDeriv.TextAlignment = ContentAlignment.MiddleLeft;
            txtAggClienteDeriv.Watermark = "Nombre";
            // 
            // txtAggCodigoImeiCeriv
            // 
            txtAggCodigoImeiCeriv.BackColor = Color.Transparent;
            txtAggCodigoImeiCeriv.FillColor = Color.FromArgb(41, 53, 72);
            txtAggCodigoImeiCeriv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAggCodigoImeiCeriv.ForeColor = Color.White;
            txtAggCodigoImeiCeriv.Location = new Point(16, 51);
            txtAggCodigoImeiCeriv.Margin = new Padding(4, 5, 4, 5);
            txtAggCodigoImeiCeriv.MaxLength = 255;
            txtAggCodigoImeiCeriv.Minimum = 0D;
            txtAggCodigoImeiCeriv.MinimumSize = new Size(1, 16);
            txtAggCodigoImeiCeriv.Name = "txtAggCodigoImeiCeriv";
            txtAggCodigoImeiCeriv.Padding = new Padding(5);
            txtAggCodigoImeiCeriv.Radius = 12;
            txtAggCodigoImeiCeriv.ShowText = false;
            txtAggCodigoImeiCeriv.Size = new Size(357, 29);
            txtAggCodigoImeiCeriv.TabIndex = 52;
            txtAggCodigoImeiCeriv.TextAlignment = ContentAlignment.MiddleLeft;
            txtAggCodigoImeiCeriv.Watermark = "xxxxxxxxxx";
            // 
            // uiButton2
            // 
            uiButton2.BackColor = Color.Transparent;
            uiButton2.FillColor = Color.Brown;
            uiButton2.FillColor2 = Color.FromArgb(255, 128, 128);
            uiButton2.FillHoverColor = Color.FromArgb(255, 128, 128);
            uiButton2.FillPressColor = Color.FromArgb(255, 128, 128);
            uiButton2.FillSelectedColor = Color.FromArgb(255, 128, 128);
            uiButton2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiButton2.Location = new Point(217, 587);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Radius = 12;
            uiButton2.RectColor = Color.FromArgb(255, 128, 128);
            uiButton2.RectDisableColor = Color.FromArgb(255, 128, 128);
            uiButton2.RectHoverColor = Color.FromArgb(255, 128, 128);
            uiButton2.RectPressColor = Color.FromArgb(255, 128, 128);
            uiButton2.RectSelectedColor = Color.FromArgb(255, 128, 128);
            uiButton2.Size = new Size(119, 32);
            uiButton2.TabIndex = 50;
            uiButton2.Text = "Rechazar";
            uiButton2.TipsFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiButton2.TipsForeColor = Color.Black;
            // 
            // uiButton1
            // 
            uiButton1.BackColor = Color.Transparent;
            uiButton1.FillColor = Color.FromArgb(0, 110, 0);
            uiButton1.FillColor2 = Color.FromArgb(128, 255, 128);
            uiButton1.FillHoverColor = Color.FromArgb(128, 255, 128);
            uiButton1.FillPressColor = Color.FromArgb(128, 255, 128);
            uiButton1.FillSelectedColor = Color.FromArgb(128, 255, 128);
            uiButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiButton1.Location = new Point(43, 587);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Radius = 12;
            uiButton1.RectColor = Color.FromArgb(128, 255, 128);
            uiButton1.RectHoverColor = Color.FromArgb(128, 255, 128);
            uiButton1.RectPressColor = Color.FromArgb(128, 255, 128);
            uiButton1.RectSelectedColor = Color.FromArgb(128, 255, 128);
            uiButton1.Size = new Size(119, 32);
            uiButton1.TabIndex = 49;
            uiButton1.Text = "Aceptar";
            uiButton1.TipsFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiButton1.TipsForeColor = Color.Black;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(13, 310);
            label21.Name = "label21";
            label21.Size = new Size(193, 25);
            label21.TabIndex = 47;
            label21.Text = "Sucursal que deriva : ";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(26, 25, 30);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(13, 446);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Observaciones...";
            textBox2.Size = new Size(360, 119);
            textBox2.TabIndex = 46;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(10, 419);
            label20.Name = "label20";
            label20.Size = new Size(152, 25);
            label20.TabIndex = 45;
            label20.Text = "Observaciones : ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(10, 366);
            label19.Name = "label19";
            label19.Size = new Size(89, 25);
            label19.TabIndex = 42;
            label19.Text = "Motivo : ";
            label19.Click += label19_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(11, 254);
            label18.Name = "label18";
            label18.Size = new Size(193, 25);
            label18.TabIndex = 41;
            label18.Text = "Sucursal que deriva : ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(9, 201);
            label16.Name = "label16";
            label16.Size = new Size(196, 25);
            label16.TabIndex = 40;
            label16.Text = "Recursos necesarios : ";
            label16.Click += label16_Click_1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(10, 141);
            label17.Name = "label17";
            label17.Size = new Size(122, 25);
            label17.TabIndex = 36;
            label17.Text = "Dispositivo : ";
            label17.Click += label17_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(10, 84);
            label15.Name = "label15";
            label15.Size = new Size(87, 25);
            label15.TabIndex = 32;
            label15.Text = "Cliente : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(8, 26);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 18;
            label4.Text = "Código IMEI : ";
            label4.Click += label4_Click_1;
            // 
            // dgvderivacionsucursales
            // 
            dgvderivacionsucursales.AllowUserToAddRows = false;
            dgvderivacionsucursales.AllowUserToDeleteRows = false;
            dgvderivacionsucursales.BackgroundColor = Color.FromArgb(15, 23, 42);
            dgvderivacionsucursales.BorderStyle = BorderStyle.Fixed3D;
            dgvderivacionsucursales.CausesValidation = false;
            dgvderivacionsucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvderivacionsucursales.GridColor = Color.FromArgb(15, 23, 42);
            dgvderivacionsucursales.Location = new Point(3, 118);
            dgvderivacionsucursales.Name = "dgvderivacionsucursales";
            dgvderivacionsucursales.ReadOnly = true;
            dgvderivacionsucursales.Size = new Size(609, 157);
            dgvderivacionsucursales.TabIndex = 4;
            dgvderivacionsucursales.CellClick += dataGridView1_CellContentClick;
            dgvderivacionsucursales.CellContentClick += dataGridView1_CellContentClick;
            dgvderivacionsucursales.CellPainting += dataGridView1_CellPainting;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(26, 35, 46);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(612, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(6, 686);
            panel5.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 23, 42);
            panel2.Controls.Add(uiButton3);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(618, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 75);
            panel2.TabIndex = 26;
            // 
            // uiButton3
            // 
            uiButton3.BackColor = Color.Transparent;
            uiButton3.FillColor = Color.FromArgb(22, 35, 52);
            uiButton3.FillHoverColor = Color.Transparent;
            uiButton3.FillPressColor = Color.FromArgb(0, 150, 137);
            uiButton3.FillSelectedColor = Color.FromArgb(0, 150, 137);
            uiButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiButton3.Location = new Point(356, 15);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Radius = 12;
            uiButton3.RectColor = Color.FromArgb(39, 53, 72);
            uiButton3.RectHoverColor = Color.FromArgb(22, 35, 52);
            uiButton3.RectPressColor = Color.FromArgb(0, 150, 137);
            uiButton3.RectSelectedColor = Color.FromArgb(0, 150, 137);
            uiButton3.Size = new Size(33, 32);
            uiButton3.TabIndex = 37;
            uiButton3.Text = "X";
            uiButton3.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton3.TipsForeColor = Color.Transparent;
            uiButton3.Click += uiButton3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, 17);
            label3.Name = "label3";
            label3.Size = new Size(85, 30);
            label3.TabIndex = 28;
            label3.Text = "Detalle ";
            // 
            // pnlDetallesDerivaciones
            // 
            pnlDetallesDerivaciones.BackColor = Color.FromArgb(15, 23, 42);
            pnlDetallesDerivaciones.Controls.Add(tableLayoutPanel2);
            pnlDetallesDerivaciones.Controls.Add(textBox1);
            pnlDetallesDerivaciones.Controls.Add(label14);
            pnlDetallesDerivaciones.Controls.Add(panel3);
            pnlDetallesDerivaciones.Controls.Add(tableLayoutPanel1);
            pnlDetallesDerivaciones.Controls.Add(lblnombreDetalle);
            pnlDetallesDerivaciones.Controls.Add(lblcodigoDetalle);
            pnlDetallesDerivaciones.Controls.Add(lblestadoDetalle);
            pnlDetallesDerivaciones.ForeColor = Color.FromArgb(15, 23, 42);
            pnlDetallesDerivaciones.Location = new Point(618, 84);
            pnlDetallesDerivaciones.Name = "pnlDetallesDerivaciones";
            pnlDetallesDerivaciones.Size = new Size(404, 602);
            pnlDetallesDerivaciones.TabIndex = 27;
            pnlDetallesDerivaciones.Visible = false;
            pnlDetallesDerivaciones.Paint += panel4_Paint_1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnRechazarDerivacion, 1, 0);
            tableLayoutPanel2.Controls.Add(btnAceptarDerivacion, 0, 0);
            tableLayoutPanel2.Location = new Point(29, 448);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(348, 52);
            tableLayoutPanel2.TabIndex = 35;
            // 
            // btnRechazarDerivacion
            // 
            btnRechazarDerivacion.BackColor = Color.Transparent;
            btnRechazarDerivacion.FillColor = Color.Brown;
            btnRechazarDerivacion.FillColor2 = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.FillHoverColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.FillPressColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.FillSelectedColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRechazarDerivacion.Location = new Point(177, 3);
            btnRechazarDerivacion.MinimumSize = new Size(1, 1);
            btnRechazarDerivacion.Name = "btnRechazarDerivacion";
            btnRechazarDerivacion.Radius = 12;
            btnRechazarDerivacion.RectColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.RectDisableColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.RectHoverColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.RectPressColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.RectSelectedColor = Color.FromArgb(255, 128, 128);
            btnRechazarDerivacion.Size = new Size(154, 36);
            btnRechazarDerivacion.TabIndex = 24;
            btnRechazarDerivacion.Text = "Rechazar";
            btnRechazarDerivacion.TipsFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechazarDerivacion.TipsForeColor = Color.Black;
            // 
            // btnAceptarDerivacion
            // 
            btnAceptarDerivacion.BackColor = Color.Transparent;
            btnAceptarDerivacion.FillColor = Color.FromArgb(0, 110, 0);
            btnAceptarDerivacion.FillColor2 = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.FillHoverColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.FillPressColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.FillSelectedColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptarDerivacion.Location = new Point(3, 3);
            btnAceptarDerivacion.MinimumSize = new Size(1, 1);
            btnAceptarDerivacion.Name = "btnAceptarDerivacion";
            btnAceptarDerivacion.Radius = 12;
            btnAceptarDerivacion.RectColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.RectHoverColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.RectPressColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.RectSelectedColor = Color.FromArgb(128, 255, 128);
            btnAceptarDerivacion.Size = new Size(154, 36);
            btnAceptarDerivacion.TabIndex = 23;
            btnAceptarDerivacion.Text = "Aceptar";
            btnAceptarDerivacion.TipsFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptarDerivacion.TipsForeColor = Color.Black;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(26, 25, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(48, 302);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Observaciones...";
            textBox1.Size = new Size(317, 119);
            textBox1.TabIndex = 34;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(20, 270);
            label14.Name = "label14";
            label14.Size = new Size(203, 17);
            label14.TabIndex = 33;
            label14.Text = "Repuesta de la sucursal destino ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 35, 46);
            panel3.Location = new Point(-2, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(407, 6);
            panel3.TabIndex = 32;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.Controls.Add(label12, 1, 0);
            tableLayoutPanel1.Controls.Add(label11, 1, 1);
            tableLayoutPanel1.Controls.Add(label10, 1, 2);
            tableLayoutPanel1.Controls.Add(label13, 1, 4);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label9, 1, 3);
            tableLayoutPanel1.Location = new Point(20, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(345, 144);
            tableLayoutPanel1.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(192, 0);
            label12.Name = "label12";
            label12.Size = new Size(17, 17);
            label12.TabIndex = 21;
            label12.Text = "...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(192, 30);
            label11.Name = "label11";
            label11.Size = new Size(17, 17);
            label11.TabIndex = 21;
            label11.Text = "...";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(192, 59);
            label10.Name = "label10";
            label10.Size = new Size(17, 17);
            label10.TabIndex = 21;
            label10.Text = "...";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(192, 117);
            label13.Name = "label13";
            label13.Size = new Size(17, 17);
            label13.TabIndex = 20;
            label13.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 117);
            label8.Name = "label8";
            label8.Size = new Size(43, 17);
            label8.TabIndex = 17;
            label8.Text = "Fecha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 87);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 17;
            label7.Text = "Recurso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 59);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 17;
            label6.Text = "Motivo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 30);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 17;
            label5.Text = "Destino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 17;
            label2.Text = "Origen";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(192, 87);
            label9.Name = "label9";
            label9.Size = new Size(17, 17);
            label9.TabIndex = 21;
            label9.Text = "...";
            // 
            // lblnombreDetalle
            // 
            lblnombreDetalle.AutoSize = true;
            lblnombreDetalle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnombreDetalle.ForeColor = Color.White;
            lblnombreDetalle.Location = new Point(20, 62);
            lblnombreDetalle.Name = "lblnombreDetalle";
            lblnombreDetalle.Size = new Size(116, 25);
            lblnombreDetalle.TabIndex = 27;
            lblnombreDetalle.Text = "Nombre... : ";
            // 
            // lblcodigoDetalle
            // 
            lblcodigoDetalle.AutoSize = true;
            lblcodigoDetalle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcodigoDetalle.ForeColor = Color.LightSeaGreen;
            lblcodigoDetalle.Location = new Point(20, 35);
            lblcodigoDetalle.Name = "lblcodigoDetalle";
            lblcodigoDetalle.Size = new Size(92, 17);
            lblcodigoDetalle.TabIndex = 26;
            lblcodigoDetalle.Text = "ORD-2026_001";
            // 
            // lblestadoDetalle
            // 
            lblestadoDetalle.AutoSize = true;
            lblestadoDetalle.BackColor = Color.FromArgb(26, 28, 44);
            lblestadoDetalle.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblestadoDetalle.ForeColor = Color.Gold;
            lblestadoDetalle.Location = new Point(20, 14);
            lblestadoDetalle.Name = "lblestadoDetalle";
            lblestadoDetalle.Size = new Size(71, 17);
            lblestadoDetalle.TabIndex = 30;
            lblestadoDetalle.Text = "Pendiente";
            lblestadoDetalle.Click += lblestadoDetalle_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(26, 35, 46);
            panel4.Location = new Point(616, 78);
            panel4.Name = "panel4";
            panel4.Size = new Size(407, 6);
            panel4.TabIndex = 36;
            // 
            // uiContextMenuStrip1
            // 
            uiContextMenuStrip1.BackColor = Color.FromArgb(243, 249, 255);
            uiContextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12F);
            uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            uiContextMenuStrip1.Size = new Size(61, 4);
            // 
            // ucDerivacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(pnlDetallesDerivaciones);
            Controls.Add(pnlderivacionesdatos);
            Name = "ucDerivacion";
            Size = new Size(1025, 686);
            Load += ucDerivacion_Load_1;
            pnltituloderivacion.ResumeLayout(false);
            pnltituloderivacion.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlderivacionesdatos.ResumeLayout(false);
            pnlNuevaDerivacion.ResumeLayout(false);
            pnlNuevaDerivacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvderivacionsucursales).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlDetallesDerivaciones.ResumeLayout(false);
            pnlDetallesDerivaciones.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnltituloderivacion;
        private Panel panel1;
        private Label lblnumeroderivaciones;
        private Label label1;
        private Panel pnlderivacionesdatos;
        private Panel panel5;
        private DataGridView dgvderivacionsucursales;
        private Panel panel2;
        private Panel pnlDetallesDerivaciones;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UIButton btnRechazarDerivacion;
        private Sunny.UI.UIButton btnAceptarDerivacion;
        private TextBox textBox1;
        private Label label14;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label13;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label9;
        private Label lblnombreDetalle;
        private Label lblcodigoDetalle;
        private Label lblestadoDetalle;
        private Sunny.UI.UIButton btnNuevaDerivacion;
        private Panel panel4;
        private Panel pnlNuevaDerivacion;
        private Label label4;
        private Label label15;
        private Label label17;
        private Label label19;
        private Label label18;
        private Label label16;
        private TextBox textBox2;
        private Label label20;
        private Label label21;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox txtAggCodigoImeiCeriv;
        private Sunny.UI.UITextBox txtAggRecursosDeriv;
        private Sunny.UI.UITextBox txtAgggDispositivoDeriv;
        private Sunny.UI.UITextBox txtAggClienteDeriv;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private Sunny.UI.UIComboBox cmbAggSelecSucur;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIComboBox uiComboBox2;
        private Sunny.UI.UIButton btnComprobante;
        private Sunny.UI.UIButton uiButton3;
    }
}
