using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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

            // Llamamos a la función al iniciar el UserControl
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Fíjate en la última línea: ahora filtramos por el texto de la sucursal
            string query = @"
                SELECT 
                    R.NombreRepuesto AS Nombre, 
                    R.Categoria AS Categoria, 
                    R.Compatibilidad AS Compatible, 
                    CONCAT(I.StockActual, ' / ', I.StockMinimo) AS Stock, 
                    R.PrecioCosto AS Costo, 
                    R.PrecioVenta AS Venta, 
                    R.Proveedor AS Proveedor,
                    CASE 
                        WHEN I.StockActual = 0 THEN 'Sin stock'
                        WHEN I.StockActual <= I.StockMinimo THEN 'Stock mínimo'
                        ELSE 'Normal'
                    END AS Estado
                FROM Repuestos R
                INNER JOIN InventarioSucursal I ON R.IdRepuesto = I.IdRepuesto
                WHERE I.Sucursal = 'Matriz Quevedo'"; // <-- ¡AQUÍ ESTÁ EL CAMBIO!

            // 1. Instanciamos tu clase de conexión
            Conexion_Base_de_Datos conexionBD = new Conexion_Base_de_Datos();

            try
            {
                // 2. Verificamos si la conexión se abre correctamente con tu método
                if (conexionBD.abrirConexion())
                {
                    // 3. Usamos la variable oCon de tu clase
                    SqlDataAdapter da = new SqlDataAdapter(query, conexionBD.oCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Mantenemos esto en false para que se respete tu diseño visual
                    dgvControl.AutoGenerateColumns = false;

                    dgvControl.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    dgvControl.DefaultCellStyle.BackColor = System.Drawing.Color.White;

                    // Vinculamos cada columna visual (de izquierda a derecha, empezando desde el 0) 
                    // con el nombre exacto de la columna que viene de la base de datos:
                    dgvControl.Columns[0].DataPropertyName = "Nombre";      // Primera columna
                    dgvControl.Columns[1].DataPropertyName = "Categoria";   // Segunda columna
                    dgvControl.Columns[2].DataPropertyName = "Compatible";  // Tercera columna
                    dgvControl.Columns[3].DataPropertyName = "Stock";       // Cuarta columna
                    dgvControl.Columns[4].DataPropertyName = "Costo";       // Quinta columna
                    dgvControl.Columns[5].DataPropertyName = "Venta";       // Sexta columna
                    dgvControl.Columns[6].DataPropertyName = "Proveedor";   // Séptima columna
                    dgvControl.Columns[7].DataPropertyName = "Estado";      // Octava columna

                    dgvControl.DataSource = dt;

                    dgvControl.Refresh();
                    dgvControl.Update();
                }
                else
                {
                    MessageBox.Show("No se pudo establecer conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoRepuesto_Click(object sender, EventArgs e)
        {
            // ¡Llamamos al formulario largo!
            frmRegistrarEntrega frm = new frmRegistrarEntrega();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Recargar los datos si se agregó el repuesto
                CargarDatos();
            }
        }

       

        private void dgv4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}