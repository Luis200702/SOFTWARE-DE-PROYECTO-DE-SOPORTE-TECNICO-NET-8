using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucVentaDispositivos : UserControl
    {
        public ucVentaDispositivos()
        {
            InitializeComponent();
            dgvVentas.AutoGenerateColumns = false;
            CargarVentas(); // Carga la tabla al abrir el UserControl
        }

        // Método para cargar y mostrar las ventas en el DataGridView
        public void CargarVentas(string filtro = "")
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string query = "SELECT * FROM VentasDirectas";

                    // Filtramos según los campos reales de tu tabla VentasDirectas
                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        query += " WHERE NombreCliente LIKE @filtro OR CedulaCliente LIKE @filtro OR MarcaNuevo LIKE @filtro OR ModeloNuevo LIKE @filtro";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro))
                        {
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro.Trim() + "%");
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Asignamos los datos a tu DataGridView (asegúrate de que se llame dgvVentas)
                        dgvVentas.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        // Botón "+ Nueva venta" que abre el formulario independiente
        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            frmNuevaVenta formRegistro = new frmNuevaVenta();
            formRegistro.ShowDialog(); // Abre el formulario de registro de forma modal

            // Al cerrarse el formulario, actualizamos la tabla automáticamente
            CargarVentas();
        }

        // Barra de búsqueda en tiempo real (asegúrate de que tu TextBox se llame txtBuscar)
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarVentas(txtBuscar.Text);
        }
    }
}