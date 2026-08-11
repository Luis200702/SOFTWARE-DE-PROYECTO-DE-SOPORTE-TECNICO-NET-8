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
    public partial class ucGestionUsuarios : UserControl
    {
        public ucGestionUsuarios()
        {
            InitializeComponent();
        }

        private void ucGestionUsuarios_Load(object sender, EventArgs e)
        {
            Conexion_Base_de_Datos conexion = new Conexion_Base_de_Datos();
            DataTable dt = conexion.obtenerUsuarios();

            dgvUsuarios.Rows.Clear(); // Limpia las filas anteriores

            foreach (DataRow fila in dt.Rows)
            {
                dgvUsuarios.Rows.Add(
                    fila["Nombre"].ToString(),
                    fila["Usuario"].ToString(),
                    fila["Perfil"].ToString(),
                    fila["Sucursal"].ToString()
                );
            }
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvUsuarios.ClearSelection();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "Editar")
            {


                string nombre = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                string usuario = dgvUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                string perfil = dgvUsuarios.Rows[e.RowIndex].Cells["Perfil"].Value.ToString();
                string sucursal = dgvUsuarios.Rows[e.RowIndex].Cells["Sucursal"].Value.ToString();


                frmEditarUsuarios frmEditar = new frmEditarUsuarios(nombre, usuario, perfil, sucursal);
                frmEditar.ShowDialog();


            }
        }

        private void btnNuevoTecnico_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario frm = new frmAgregarUsuario();
            frm.ShowDialog();
        }

        private void dgvUsuarios_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
            {
                using (SolidBrush accentBrush = new SolidBrush(Color.FromArgb(0, 210, 160)))
                {
                    e.Graphics.FillRectangle(accentBrush, e.RowBounds.Left, e.RowBounds.Top, 4, e.RowBounds.Height);
                }
            }
        }
    }
}
