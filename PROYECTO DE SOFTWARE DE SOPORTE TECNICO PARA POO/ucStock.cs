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
            cmbCategorias.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucStock_Load(object sender, EventArgs e)
        {

        }

        private void dgv4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAlertas_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoRepuesto_Click(object sender, EventArgs e)
        {
            int fila = dgv4.Rows.Add();

            dgv4.CurrentCell = dgv4.Rows[fila].Cells[0];
            dgv4.BeginEdit(true);
            frmAggStock frm = new frmAggStock();
            frm.ShowDialog();

        }

        private void dgv4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv4.Columns[e.ColumnIndex].Name == "Editar")
            {
                var fila = dgv4.Rows[e.RowIndex];

                //string Nombre = fila.Cells["NOMBRE"].Value?.ToString();
                //string Categoria = fila.Cells["CATEGORIA"].Value?.ToString();

                // Abrir el formulario de edición pasando esos datos
                frmEditarStock frmEditar = new frmEditarStock();
                if (frmEditar.ShowDialog() == DialogResult.OK)
                {
                    //fila.Cells["NOMBRE"].Value = frmEditar.NuevoNombre;
                    //fila.Cells["CATEGORIA"].Value = frmEditar.NuevaCategoria;
                }
            }
        }

    }
}
