using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucHistorialClientes : UserControl
    {
        public ucHistorialClientes()
        {
            InitializeComponent();
        }

        private void ucHistorialClientes_Load(object sender, EventArgs e)
        {

            // Configuramos la tabla izquierda para que acepte saltos de línea
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        // EVENTO: Botón de buscar cliente en el panel izquierdo
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string valorBusqueda = txtBuscar.Text.Trim();
            CargarListaClientes(valorBusqueda);
        }

        private void CargarListaClientes(string busqueda)
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // Consulta actualizada: Ahora busca por nombre, cédula/pasaporte o correo
                    string query = @"
            SELECT 
                C.id, 
                C.nombre + CHAR(13) + CHAR(10) + 
                ISNULL(C.telefono, 'Sin teléfono') + CHAR(13) + CHAR(10) + 
                CAST(COUNT(O.id) AS VARCHAR) + ' órdenes' AS InfoCliente,
                C.nombre,
                C.telefono,
                C.correo
            FROM Clientes C
            LEFT JOIN ordenes O ON C.id = O.cliente_id
            WHERE C.nombre LIKE '%' + @busqueda + '%' 
               OR C.cedula_pasaporte LIKE '%' + @busqueda + '%'
               OR C.correo LIKE '%' + @busqueda + '%'
            GROUP BY C.id, C.nombre, C.telefono, C.correo
            ORDER BY C.nombre";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", busqueda);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvClientes.AutoGenerateColumns = false;

                        // Si no has creado la columna en el diseñador, créala dinámicamente
                        if (dgvClientes.Columns.Count == 0)
                        {
                            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
                            {
                                DataPropertyName = "InfoCliente",
                                HeaderText = "Clientes",
                                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                            });
                        }
                        else
                        {
                            dgvClientes.Columns[0].DataPropertyName = "InfoCliente";
                        }

                        dgvClientes.DataSource = dt;
                        dgvClientes.ClearSelection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        // EVENTO: Al hacer clic en un cliente de la lista izquierda
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Evitamos que falle si haces clic en los encabezados
                if (e.RowIndex >= 0)
                {
                    // Extraemos los datos ocultos del DataTable asociado a la fila seleccionada
                    DataRowView filaSeleccionada = (DataRowView)dgvClientes.Rows[e.RowIndex].DataBoundItem;

                    if (filaSeleccionada == null) return;

                    int idCliente = Convert.ToInt32(filaSeleccionada["id"]);
                    string nombre = filaSeleccionada["nombre"].ToString();
                    string telefono = filaSeleccionada["telefono"].ToString();
                    string correo = filaSeleccionada["correo"].ToString();

                    // Mostramos los datos básicos (¡Asegúrate de tener estos Labels en el diseñador!)
                    lblNombreCompleto.Text = nombre;
                    lblContacto.Text = $"{telefono} • {correo}";

                    // Aseguramos que el panel del historial esté al frente
                    pnlHistorial.Visible = true;
                    pnlHistorial.BringToFront();

                    // Cargamos la tabla grande de la derecha
                    CargarHistorialOrdenes(idCliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al cargar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHistorialOrdenes(int idCliente)
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // Consulta que trae todo el detalle de las órdenes
                    string query = @"
            SELECT 
                O.numero_orden AS Orden,
                O.fecha_ingreso AS Fecha,
                D.marca + ' ' + D.modelo AS Dispositivo,
                ISNULL(O.descripcion_problema, 'Reparación general') AS Reparacion,
                ISNULL(O.costo_estimado, 0) AS Costo,
                O.estado AS Estado,
                U.Nombre AS Tecnico
            FROM ordenes O
            INNER JOIN dispositivos D ON O.dispositivo_id = D.id
            INNER JOIN Usuarios U ON O.tecnico_id = U.Id
            WHERE O.cliente_id = @idCliente
            ORDER BY O.fecha_ingreso DESC";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // 1. Evitamos que Visual Studio invente columnas extra
                        dgvHistorialOrdenes.AutoGenerateColumns = false;

                        // 2. Vinculamos la información a TUS columnas predeterminadas
                        if (dgvHistorialOrdenes.Columns.Count > 0)
                        {
                            dgvHistorialOrdenes.Columns[0].DataPropertyName = "Orden";
                            dgvHistorialOrdenes.Columns[1].DataPropertyName = "Fecha";
                            dgvHistorialOrdenes.Columns[2].DataPropertyName = "Dispositivo";
                            dgvHistorialOrdenes.Columns[3].DataPropertyName = "Reparacion";
                            dgvHistorialOrdenes.Columns[4].DataPropertyName = "Costo";
                            dgvHistorialOrdenes.Columns[5].DataPropertyName = "Estado";
                            dgvHistorialOrdenes.Columns[6].DataPropertyName = "Tecnico";
                        }

                        dgvHistorialOrdenes.DataSource = dt;

                        // Actualizamos las estadísticas superiores derechas
                        lblTotalVisitas.Text = dt.Rows.Count.ToString();

                        // Calculamos la suma de la columna costo para mostrar el "Total Gastado"
                        decimal totalGastado = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            totalGastado += Convert.ToDecimal(row["Costo"]);
                        }
                        lblTotalGastado.Text = $"${totalGastado:0.00}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el historial del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }

            dgvHistorialOrdenes.ClearSelection();
        }
    }
}