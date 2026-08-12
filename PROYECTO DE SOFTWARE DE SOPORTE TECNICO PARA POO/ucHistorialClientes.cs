using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucHistorialClientes : UserControl
    {
        // PALETA DE COLORES
        private readonly Color PaleyGray =
            ColorTranslator.FromHtml("#EBEFF0");

        private readonly Color Stone =
            ColorTranslator.FromHtml("#C6C7BD");

        private readonly Color Graphite =
            ColorTranslator.FromHtml("#676A70");

        private readonly Color SlateBlue =
            ColorTranslator.FromHtml("#4B5C6C");

        private readonly Color MidnightBlue =
            ColorTranslator.FromHtml("#1C2B3C");
        public ucHistorialClientes()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            
        }

        private void ucHistorialClientes_Load(object sender, EventArgs e)
        {

            // Configuramos la tabla izquierda para que acepte saltos de línea
            // Configuración inicial de las tablas
            dgvClientes.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;

            dgvClientes.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            //Aplicamos diseño
            AplicarDiseño();
            // Configurar tablas
            ConfigurarTablaClientes();
            ConfigurarTablaHistorial();

            // Estado inicial
            pnlHistorial.Visible = false;
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
                if (e.RowIndex < 0)
                    return;

                dgvClientes.ClearSelection();
                dgvClientes.Rows[e.RowIndex].Selected = true;

                DataRowView filaSeleccionada =
                    (DataRowView)dgvClientes.Rows[e.RowIndex].DataBoundItem;

                if (filaSeleccionada == null)
                    return;

                int idCliente =
                    Convert.ToInt32(filaSeleccionada["id"]);

                string nombre =
                    filaSeleccionada["nombre"].ToString();

                string telefono =
                    filaSeleccionada["telefono"].ToString();

                string correo =
                    filaSeleccionada["correo"].ToString();

                lblNombreCompleto.Text = nombre;

                lblContacto.Text =
                    $"{telefono} • {correo}";

                pnlHistorial.Visible = true;
                pnlHistorial.BringToFront();

                CargarHistorialOrdenes(idCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Hubo un problema al cargar el cliente: "
                    + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
        private void ConfigurarTablaClientes()
        {
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;

            dgvClientes.EnableHeadersVisualStyles = false;

            // Encabezado
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = SlateBlue;
            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvClientes.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            // Celdas normales
            dgvClientes.DefaultCellStyle.BackColor = Color.White;
            dgvClientes.DefaultCellStyle.ForeColor = MidnightBlue;

            // IMPORTANTE:
            // Color cuando seleccionas un cliente
            dgvClientes.DefaultCellStyle.SelectionBackColor = SlateBlue;
            dgvClientes.DefaultCellStyle.SelectionForeColor = Color.White;

            // Líneas
            dgvClientes.GridColor = PaleyGray;

            // Sin bordes de selección raros
            dgvClientes.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvClientes.RowHeadersVisible = false;

            dgvClientes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvClientes.MultiSelect = false;

            dgvClientes.AllowUserToAddRows = false;

            dgvClientes.AllowUserToResizeRows = false;

            dgvClientes.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;

            dgvClientes.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
        }
        private void ConfigurarTablaHistorial()
        {
            dgvHistorialOrdenes.BackgroundColor = Color.White;
            dgvHistorialOrdenes.BorderStyle = BorderStyle.None;

            dgvHistorialOrdenes.EnableHeadersVisualStyles = false;

            // Encabezado
            dgvHistorialOrdenes.ColumnHeadersDefaultCellStyle.BackColor =
                SlateBlue;

            dgvHistorialOrdenes.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvHistorialOrdenes.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            // Celdas
            dgvHistorialOrdenes.DefaultCellStyle.BackColor =
                Color.White;

            dgvHistorialOrdenes.DefaultCellStyle.ForeColor =
                MidnightBlue;

            // Selección
            dgvHistorialOrdenes.DefaultCellStyle.SelectionBackColor =
                Stone;

            dgvHistorialOrdenes.DefaultCellStyle.SelectionForeColor =
                MidnightBlue;

            dgvHistorialOrdenes.GridColor = PaleyGray;

            dgvHistorialOrdenes.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvHistorialOrdenes.RowHeadersVisible = false;

            dgvHistorialOrdenes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHistorialOrdenes.MultiSelect = false;

            dgvHistorialOrdenes.AllowUserToAddRows = false;
        }
        private void ConfigurarEstiloTabla(DataGridView tabla, Color colorEncabezado)
        {
            tabla.BackgroundColor = Color.White;

            tabla.BorderStyle = BorderStyle.None;

            tabla.EnableHeadersVisualStyles = false;

            tabla.AllowUserToAddRows = false;

            tabla.AllowUserToResizeRows = false;

            tabla.RowHeadersVisible = false;

            tabla.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            tabla.MultiSelect = false;

            // ENCABEZADO
            tabla.ColumnHeadersDefaultCellStyle.BackColor =
                colorEncabezado;

            tabla.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            tabla.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            tabla.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            tabla.ColumnHeadersHeight = 40;

            // CELDAS
            tabla.DefaultCellStyle.BackColor =
                Color.White;

            tabla.DefaultCellStyle.ForeColor =
                MidnightBlue;

            tabla.DefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Regular
                );

            tabla.DefaultCellStyle.SelectionBackColor =
                Stone;

            tabla.DefaultCellStyle.SelectionForeColor =
                MidnightBlue;

            tabla.DefaultCellStyle.Padding =
                new Padding(5);

            // LÍNEAS
            tabla.GridColor = PaleyGray;

            tabla.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;
        }
        private void AplicarDiseño()
        {
            // ==========================================
            // FONDO GENERAL
            // ==========================================

            this.BackColor = PaleyGray;


            // ==========================================
            // PANEL IZQUIERDO
            // ==========================================

            if (pnlIzquierdo != null)
            {
                pnlIzquierdo.BackColor = MidnightBlue;
            }


            // ==========================================
            // PANEL SUPERIOR
            // ==========================================

            if (pnlSuperior != null)
            {
                pnlSuperior.BackColor = Color.White;
            }


            // ==========================================
            // TÍTULO
            // ==========================================

            if (lblTitulo != null)
            {
                lblTitulo.ForeColor = MidnightBlue;

                lblTitulo.Font = new Font(
                    "Segoe UI",
                    14,
                    FontStyle.Bold
                );
            }


            // ==========================================
            // BUSCADOR
            // ==========================================

            if (txtBuscar != null)
            {
                txtBuscar.BackColor = MidnightBlue;
                txtBuscar.ForeColor = Color.White;

                txtBuscar.Font = new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Regular
                );
            }

            // ==========================================
            // PANEL SUPERIOR DEL CLIENTE
            // ==========================================

            if (pnlSuperiorCliente != null)
            {
                pnlSuperiorCliente.BackColor = Color.White;
            }


            // ==========================================
            // NOMBRE DEL CLIENTE
            // ==========================================

            if (lblNombreCompleto != null)
            {
                lblNombreCompleto.ForeColor =
                    MidnightBlue;

                lblNombreCompleto.Font = new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold
                );
            }


            // ==========================================
            // TELÉFONO / CORREO
            // ==========================================

            if (lblContacto != null)
            {
                lblContacto.ForeColor = Graphite;

                lblContacto.Font = new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Regular
                );
            }


            // ==========================================
            // TOTAL VISITAS
            // ==========================================

            if (lblTotalVisitas != null)
            {
                lblTotalVisitas.ForeColor =
                    MidnightBlue;

                lblTotalVisitas.Font = new Font(
                    "Segoe UI",
                    12,
                    FontStyle.Bold
                );
            }


            // ==========================================
            // TOTAL GASTADO
            // ==========================================

            if (lblTotalGastado != null)
            {
                lblTotalGastado.ForeColor =
                    MidnightBlue;

                lblTotalGastado.Font = new Font(
                    "Segoe UI",
                    12,
                    FontStyle.Bold
                );
            }


            // ==========================================
            // PANEL DEL HISTORIAL
            // ==========================================

            if (pnlHistorial != null)
            {
                pnlHistorial.BackColor = Color.White;
            }


            // ==========================================
            // TABLA DE CLIENTES
            // ==========================================

            ConfigurarEstiloTabla(
                dgvClientes,
                SlateBlue
            );


            // ==========================================
            // TABLA DE HISTORIAL
            // ==========================================

            ConfigurarEstiloTabla(
                dgvHistorialOrdenes,
                SlateBlue
            );
        }
    }
}