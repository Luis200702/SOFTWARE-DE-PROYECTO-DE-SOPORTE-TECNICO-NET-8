namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class ucConfiguracion
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
            pnlSuperior = new Panel();
            label16 = new Label();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            lblTitulo = new Label();
            pnlSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSuperior.AutoSize = true;
            pnlSuperior.BackColor = Color.FromArgb(243, 246, 250);
            pnlSuperior.Controls.Add(label16);
            pnlSuperior.Controls.Add(uiSymbolLabel1);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1236, 88);
            pnlSuperior.TabIndex = 39;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(70, 86, 103);
            label16.Location = new Point(93, 47);
            label16.Name = "label16";
            label16.Size = new Size(331, 20);
            label16.TabIndex = 62;
            label16.Text = "Administra los parametros generales del sistema";
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolLabel1.Location = new Point(25, 6);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(62, 48);
            uiSymbolLabel1.Symbol = 61568;
            uiSymbolLabel1.SymbolColor = Color.FromArgb(0, 165, 155);
            uiSymbolLabel1.SymbolSize = 40;
            uiSymbolLabel1.TabIndex = 39;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(24, 43, 62);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(359, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Configuración";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSuperior);
            Name = "ucConfiguracion";
            Size = new Size(1123, 832);
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private Label label16;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Label lblTitulo;
    }
}
