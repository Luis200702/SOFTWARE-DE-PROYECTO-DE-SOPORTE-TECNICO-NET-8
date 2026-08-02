using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucStock : UserControl
    {
        public ucStock()
        {
            InitializeComponent();
            cmbCategorias.Text = "Todas las categorías";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucStock_Load(object sender, EventArgs e)
        {

            DataGridViewComboBoxColumn Categoria = (DataGridViewComboBoxColumn)dgv4.Columns["CATEGORIA"];

            Categoria.Items.Add("Teléfonos");
            Categoria.Items.Add("Computadoras");
            Categoria.Items.Add("Repuestos");
            Categoria.Items.Add("Accesorios");

            DataGridViewComboBoxColumn Proveedor = (DataGridViewComboBoxColumn)dgv4.Columns["PROVEEDOR"];

            Proveedor.Items.Add("Xiaomi");
            Proveedor.Items.Add("Samsung");
            Proveedor.Items.Add("HP");
            Proveedor.Items.Add("Dell");
            Proveedor.Items.Add("Lenovo");
            Proveedor.Items.Add("ASUS");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int fila = dgv4.Rows.Add();

            dgv4.CurrentCell = dgv4.Rows[fila].Cells[0];
            dgv4.BeginEdit(true);
        }

        private void dgv4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv4.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    dgv4.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnAlertas_Click(object sender, EventArgs e)
        {

        }
    }
}
