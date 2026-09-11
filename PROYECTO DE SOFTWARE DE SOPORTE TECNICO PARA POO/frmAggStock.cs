using Microsoft.Data.SqlClient;
using System.Data;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmAggStock : Form
    {
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();
        private int idRepuestoActual;
        private int idSucursalActual;
        private int stockActual = 0;

        public frmAggStock(int idRepuesto, int idSucursal, string nombreRepuesto, string nombreSucursal)
        {
            InitializeComponent();

            idRepuestoActual = idRepuesto;
            idSucursalActual = idSucursal;

            lblProducto.Text = $"{nombreRepuesto} ({nombreSucursal})";
        }

        private void frmAggStock_Load(object sender, EventArgs e)
        {
            CargarStockActual();
        }

  
        private void CargarStockActual()
        {
            DataTable dt = oCon.retornarRegistrosUsuarios("select StockActual " + "from InventarioSucursal " + "where IdRepuesto = " + idRepuestoActual +" and IdSucursal = " + idSucursalActual);

            if (dt != null && dt.Rows.Count > 0)
            {
                stockActual = Convert.ToInt32(
                    dt.Rows[0]["StockActual"]);

                llbStockA.Text = stockActual.ToString();
            }
            else
            {
                stockActual = 0;
                llbStockA.Text = "0";
            }

            CalcularStockResultante();
        }

        private void udoAgg_TextChanged(object sender, EventArgs e)
        {
            CalcularStockResultante();
        }

        private void CalcularStockResultante()
        {
            int cantidadAgregar = 0;

            // Si el texto es un número válido, lo sumamos al stock actual
            if (int.TryParse(udoAgg.Text, out cantidadAgregar))
            {
                // Si el control del resultado se llama diferente, cambia "lblStockResultante" por tu nombre real
                lblStockResultante.Text = (stockActual + cantidadAgregar).ToString();
            }
            else
            {
                lblStockResultante.Text = "-----";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int cantidadAgregar = 0;

            if (!int.TryParse(udoAgg.Text, out cantidadAgregar) || cantidadAgregar <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                udoAgg.Focus();
                return;
            }


            if (oCon.actualizarDatos("InventarioSucursal", "StockActual = StockActual + " + cantidadAgregar, "IdRepuesto = " + idRepuestoActual +" and IdSucursal = " + idSucursalActual))
            {
                MessageBox.Show(
                    "Stock actualizado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "No se pudo actualizar el stock.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtCompatible_TextChanged(object sender, EventArgs e) { }
        private void lblProducto_Click(object sender, EventArgs e) { }
        private void llbStockA_Click(object sender, EventArgs e) { }
        private void lblAgregar_Click(object sender, EventArgs e) { }
    }
}