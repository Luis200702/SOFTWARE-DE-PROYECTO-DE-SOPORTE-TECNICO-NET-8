namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class frmComprobante_Pago
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
            pnlCarga = new Sunny.UI.UIPanel();
            pnlAdvertencia = new Sunny.UI.UIPanel();
            lblAlerta = new Sunny.UI.UISymbolLabel();
            btnCancelar = new Sunny.UI.UIButton();
            btnAdjuntar = new Sunny.UI.UIButton();
            lblEditar = new Label();
            label1 = new Label();
            pnlAdvertencia.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCarga
            // 
            pnlCarga.Font = new Font("Microsoft Sans Serif", 12F);
            pnlCarga.Location = new Point(63, 179);
            pnlCarga.Margin = new Padding(4, 5, 4, 5);
            pnlCarga.MinimumSize = new Size(1, 1);
            pnlCarga.Name = "pnlCarga";
            pnlCarga.Radius = 12;
            pnlCarga.Size = new Size(391, 245);
            pnlCarga.TabIndex = 0;
            pnlCarga.Text = null;
            pnlCarga.TextAlignment = ContentAlignment.MiddleCenter;
            pnlCarga.Click += PnlCarga_Click;
            pnlCarga.DragDrop += PnlCarga_DragDrop;
            pnlCarga.DragEnter += PnlCarga_DragEnter;
            pnlCarga.Paint += PnlCarga_Paint;
            // 
            // pnlAdvertencia
            // 
            pnlAdvertencia.Controls.Add(lblAlerta);
            pnlAdvertencia.FillColor = Color.FromArgb(255, 250, 235);
            pnlAdvertencia.Font = new Font("Microsoft Sans Serif", 12F);
            pnlAdvertencia.ForeColor = Color.FromArgb(210, 120, 30);
            pnlAdvertencia.Location = new Point(63, 443);
            pnlAdvertencia.Margin = new Padding(4, 5, 4, 5);
            pnlAdvertencia.MinimumSize = new Size(1, 1);
            pnlAdvertencia.Name = "pnlAdvertencia";
            pnlAdvertencia.Radius = 12;
            pnlAdvertencia.RectColor = Color.FromArgb(250, 210, 130);
            pnlAdvertencia.Size = new Size(393, 80);
            pnlAdvertencia.TabIndex = 1;
            pnlAdvertencia.Text = null;
            pnlAdvertencia.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblAlerta
            // 
            lblAlerta.BackColor = Color.Transparent;
            lblAlerta.Dock = DockStyle.Fill;
            lblAlerta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlerta.ForeColor = Color.FromArgb(210, 120, 30);
            lblAlerta.Location = new Point(0, 0);
            lblAlerta.MinimumSize = new Size(1, 1);
            lblAlerta.Name = "lblAlerta";
            lblAlerta.Padding = new Padding(10, 0, 0, 0);
            lblAlerta.Size = new Size(393, 80);
            lblAlerta.Symbol = 61553;
            lblAlerta.SymbolColor = Color.FromArgb(210, 120, 30);
            lblAlerta.SymbolOffset = new Point(-3, 0);
            lblAlerta.TabIndex = 0;
            lblAlerta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.FillColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(134, 545);
            btnCancelar.MinimumSize = new Size(1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Radius = 12;
            btnCancelar.RectColor = Color.FromArgb(0, 150, 137);
            btnCancelar.Size = new Size(117, 30);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdjuntar
            // 
            btnAdjuntar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdjuntar.FillColor = Color.FromArgb(0, 150, 137);
            btnAdjuntar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdjuntar.Location = new Point(257, 545);
            btnAdjuntar.MinimumSize = new Size(1, 1);
            btnAdjuntar.Name = "btnAdjuntar";
            btnAdjuntar.Radius = 12;
            btnAdjuntar.RectColor = Color.FromArgb(0, 150, 137);
            btnAdjuntar.Size = new Size(117, 30);
            btnAdjuntar.TabIndex = 28;
            btnAdjuntar.Text = "Adjuntar";
            btnAdjuntar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdjuntar.Click += btnAdjuntar_Click;
            // 
            // lblEditar
            // 
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditar.Location = new Point(92, 26);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(319, 36);
            lblEditar.TabIndex = 31;
            lblEditar.Text = "Comprobante de transferencia";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 62);
            label1.Name = "label1";
            label1.Size = new Size(322, 36);
            label1.TabIndex = 32;
            label1.Text = "Adjunta la captura o imagen del comprobante";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmComprobante_Pago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 607);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(lblEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdjuntar);
            Controls.Add(pnlAdvertencia);
            Controls.Add(pnlCarga);
            MaximizeBox = false;
            Name = "frmComprobante_Pago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Comprobante";
            pnlAdvertencia.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel pnlCarga;
        private Sunny.UI.UIPanel pnlAdvertencia;
        private Sunny.UI.UIButton btnCancelar;
        private Sunny.UI.UIButton btnAdjuntar;
        private Label lblEditar;
        private Label label1;
        private Sunny.UI.UISymbolLabel lblAlerta;
    }
}