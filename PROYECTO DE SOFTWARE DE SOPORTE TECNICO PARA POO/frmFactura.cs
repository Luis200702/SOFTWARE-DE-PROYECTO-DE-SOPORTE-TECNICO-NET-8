using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmFactura : Form
    {
        private Bitmap? facturaBitmap;
        private PrintDocument documentoImpresion = new PrintDocument();
        public frmFactura()
        {
            InitializeComponent();
            documentoImpresion.PrintPage += DocumentoImpresion_PrintPage;
        }
        public frmFactura(
      string numeroFactura,
      string orden,
      string cedula,
      string nombre,
      string telefono,
      string dispositivo,
      string tecnico,
      string formaPago,
      List<DetalleFactura> detalles,
      decimal total)
        {
            InitializeComponent();
            documentoImpresion.PrintPage += DocumentoImpresion_PrintPage;
            ConfigurarDataGridView();

            lblNumeroFactura.Text = numeroFactura;
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblOrden.Text = orden;

            lblCedula.Text = cedula;
            lblNombre.Text = nombre;
            lblTelefono.Text = telefono;

            lblDispositivo.Text = dispositivo;
            lblTecnico.Text = tecnico;

            lblFormaPago.Text = formaPago;

            CargarDetalles(detalles, total);
        }
        private void ConfigurarDataGridView()
        {
            dgvDetalleFactura.Columns.Clear();

            dgvDetalleFactura.Columns.Add("Descripcion", "Descripción");
            dgvDetalleFactura.Columns.Add("Valor", "Valor");

            dgvDetalleFactura.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetalleFactura.ReadOnly = true;
            dgvDetalleFactura.AllowUserToAddRows = false;
            dgvDetalleFactura.AllowUserToDeleteRows = false;
            dgvDetalleFactura.RowHeadersVisible = false;
        }
        private void CargarDetalles(
        List<DetalleFactura> detalles,
        decimal total)
        {
            dgvDetalleFactura.Rows.Clear();

            foreach (DetalleFactura detalle in detalles)
            {
                dgvDetalleFactura.Rows.Add(
                    detalle.Descripcion,
                    detalle.Valor
                );
            }

            dgvDetalleFactura.Rows.Add(
                "TOTAL",
                "$" + total.ToString("F2")
            );
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTrabajoRealizado_Click(object sender, EventArgs e)
        {

        }
        private void CapturarFactura()
        {
            facturaBitmap = new Bitmap(
                pnlFactura.Width,
                pnlFactura.Height
            );

            pnlFactura.DrawToBitmap(
                facturaBitmap,
                new Rectangle(
                    0,
                    0,
                    pnlFactura.Width,
                    pnlFactura.Height
                )
            );
        }
        private void DocumentoImpresion_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (facturaBitmap == null)
                return;

            Rectangle areaImpresion = e.MarginBounds;

            float proporcion = Math.Min(
                (float)areaImpresion.Width / facturaBitmap.Width,
                (float)areaImpresion.Height / facturaBitmap.Height
            );

            int ancho = (int)(facturaBitmap.Width * proporcion);
            int alto = (int)(facturaBitmap.Height * proporcion);

            e.Graphics.DrawImage(
                facturaBitmap,
                areaImpresion.Left,
                areaImpresion.Top,
                ancho,
                alto
            );
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CapturarFactura();

            using (PrintDialog dialogo = new PrintDialog())
            {
                dialogo.Document = documentoImpresion;

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    documentoImpresion.Print();
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            CapturarFactura();

            using (SaveFileDialog guardar = new SaveFileDialog())
            {
                guardar.Filter = "Archivo PDF|*.pdf";
                guardar.Title = "Guardar factura";
                guardar.FileName = lblNumeroFactura.Text + ".pdf";

                if (guardar.ShowDialog() != DialogResult.OK)
                    return;

                documentoImpresion.PrinterSettings.PrinterName =
                    "Microsoft Print to PDF";

                documentoImpresion.PrinterSettings.PrintToFile = true;

                documentoImpresion.PrinterSettings.PrintFileName =
                    guardar.FileName;

                documentoImpresion.Print();

                MessageBox.Show(
                    "La factura fue guardada correctamente.",
                    "Factura",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void airSeparator2_Click(object sender, EventArgs e)
        {

        }
    }
}
