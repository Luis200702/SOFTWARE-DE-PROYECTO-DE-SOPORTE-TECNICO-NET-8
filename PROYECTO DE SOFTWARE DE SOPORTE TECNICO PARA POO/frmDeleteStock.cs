using FontAwesome.Sharp;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmDeleteStock : Form
    {
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();
        private int idRepuestoActual;
        private int idSucursalActual;
        private int stockActual = 0;

        public frmDeleteStock(int idRepuesto, int idSucursal, string nombreRepuesto, string nombreSucursal)
        {
            InitializeComponent();

            idRepuestoActual = idRepuesto;
            idSucursalActual = idSucursal;

            lblProducto.Text = $"{nombreRepuesto} ({nombreSucursal})";
        }

        private void frmDeleteStock_Load(object sender, EventArgs e)
        {
            CargarStockActual();
        }

       
        private void CargarStockActual()
        {
            DataTable dt = oCon.retornarRegistrosUsuarios("select StockActual " + "from InventarioSucursal " + "where IdRepuesto = " + idRepuestoActual + " and IdSucursal = " + idSucursalActual);

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
            int cantidadReducir = 0;

            if (int.TryParse(udoAgg.Text, out cantidadReducir))
            {
                int stockFinal = stockActual - cantidadReducir;
                lblStockResultante.Text = stockFinal.ToString();

                if (stockFinal < 0)
                    lblStockResultante.ForeColor = System.Drawing.Color.Red;
                else
                    lblStockResultante.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                lblStockResultante.Text = "-----";
                lblStockResultante.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int cantidadReducir = 0;

            if (!int.TryParse(udoAgg.Text, out cantidadReducir) || cantidadReducir <= 0)
            {
                MessageBox.Show(
                    "Por favor, ingresa una cantidad válida mayor a 0.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                udoAgg.Focus();
                return;
            }

            if (cantidadReducir > stockActual)
            {
                MessageBox.Show(
                    "No puedes registrar una salida mayor a la cantidad que tienes actualmente en inventario.",
                    "Stock Insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                udoAgg.Focus();
                return;
            }

            if (oCon.actualizarDatos(
                "inventariosucursal",
                "stockactual = stockactual - " + cantidadReducir,
                "idrepuesto = " + idRepuestoActual +
                " and idsucursal = " + idSucursalActual))
            {
                MessageBox.Show(
                    "Stock reducido correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "No se pudo reducir el stock.",
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
    }
}