using Microsoft.Data.SqlClient;
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
    public partial class ucSeguimientoReparaciones : UserControl
    {
        public ucSeguimientoReparaciones()
        {
            InitializeComponent();

        }

        private void ucSeguimientoReparaciones_Load(object sender, EventArgs e)
        {
            if (cmbEstado.Items.Count > 0)
                cmbEstado.SelectedIndex = 0;

            // 2. Cargar los datos por defecto al abrir la pantalla
            CargarSeguimiento();
        }

        private void CargarSeguimiento(string filtroBusqueda = "", string filtroEstado = "Todos")
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    string query = @"SELECT 
                                        o.numero_orden AS Orden,
                                        c.nombre + ' - ' + d.marca + ' ' + d.modelo AS Cliente_Dispositivo,
                                        u.Nombre AS Tecnico,
                                        o.estado AS Estado,
                                        o.fecha_ingreso AS Ingreso,
                                        o.fecha_estimada_entrega AS Entrega,
                                        DATEDIFF(day, o.fecha_ingreso, GETDATE()) AS Tiempo
                                    FROM ordenes o
                                    INNER JOIN clientes c ON o.cliente_id = c.id
                                    INNER JOIN dispositivos d ON o.dispositivo_id = d.id
                                    INNER JOIN Usuarios u ON o.tecnico_id = u.Id
                                    WHERE (@busqueda = '' OR o.numero_orden LIKE '%' + @busqueda + '%' OR c.nombre LIKE '%' + @busqueda + '%')
                                      AND (@estado = 'Todos' OR o.estado = @estado)";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", filtroBusqueda);
                        cmd.Parameters.AddWithValue("@estado", filtroEstado);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);


                        // Asegúrate de que el control no cree columnas automáticamente
                        dgvSeguimiento.AutoGenerateColumns = false;

                        dgvSeguimiento.Columns[0].DataPropertyName = "Orden";      // Columna 1: ORDEN
                        dgvSeguimiento.Columns[1].DataPropertyName = "Cliente_Dispositivo";    // Columna 2: CLIENTE \ DISPOSITIVO
                        dgvSeguimiento.Columns[2].DataPropertyName = "Tecnico";    // Columna 3: TÉCNICO
                        dgvSeguimiento.Columns[3].DataPropertyName = "Estado";     // Columna 4: ESTADO
                        dgvSeguimiento.Columns[4].DataPropertyName = "Ingreso";    // Columna 5: INGRESO
                        dgvSeguimiento.Columns[5].DataPropertyName = "Entrega"; // Columna 6: ENTREGA ESTIMADA
                        dgvSeguimiento.Columns[6].DataPropertyName = "Tiempo";     // Columna 7: TIEMPO

                        dgvSeguimiento.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el seguimiento de reparaciones: " + ex.Message);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        // Evento para el buscador de texto en tiempo real
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string estado = cmbEstado.SelectedItem?.ToString() ?? "Todos";
            // Asegúrate de que tu caja de texto de búsqueda se llame txtBuscar o cámbiale el nombre aquí
            // CargarSeguimiento(txtBuscar.Text.Trim(), estado);
        }

        // Evento para el ComboBox de estados
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cmbEstado.SelectedItem?.ToString() ?? "Todos";
            // CargarSeguimiento(txtBuscar.Text.Trim(), estado);
        }

        private void txtBuscarOrden_TextChanged(object sender, EventArgs e)
        {
            // Obtener el estado seleccionado, si es "Todos los estados" enviamos "Todos"
            string estado = cmbEstado.Text == "Todos los estados" ? "Todos" : cmbEstado.Text;

            // Llamar al método de carga con los filtros actuales
            CargarSeguimiento(txtBuscarOrden.Text.Trim(), estado);
        }

        private void cmbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string estado = cmbEstado.Text == "Todos los estados" ? "Todos" : cmbEstado.Text;

            // Llamar al método de carga con los filtros actuales
            CargarSeguimiento(txtBuscarOrden.Text.Trim(), estado);
        }

        private void dgvSeguimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvSeguimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


