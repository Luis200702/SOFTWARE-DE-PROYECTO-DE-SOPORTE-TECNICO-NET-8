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

            CargarSeguimiento();
            dgvSeguimiento.ClearSelection();
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

                        dgvSeguimiento.AutoGenerateColumns = false;

                        dgvSeguimiento.Columns[0].DataPropertyName = "Orden";
                        dgvSeguimiento.Columns[1].DataPropertyName = "Cliente_Dispositivo";
                        dgvSeguimiento.Columns[2].DataPropertyName = "Tecnico";
                        dgvSeguimiento.Columns[3].DataPropertyName = "Estado";
                        dgvSeguimiento.Columns[4].DataPropertyName = "Ingreso";
                        dgvSeguimiento.Columns[5].DataPropertyName = "Entrega";
                        dgvSeguimiento.Columns[6].DataPropertyName = "Tiempo";

                        dgvSeguimiento.DataSource = dt;

                        // Fuerza blanco + negro en TODOS los niveles de estilo
                        // (fila, fila alterna, columna y grilla) para que ningún
                        // estilo oscuro heredado del Designer prevalezca.
                        var estiloClaro = new DataGridViewCellStyle
                        {
                            BackColor = Color.White,
                            ForeColor = Color.Black,
                            SelectionBackColor = Color.White,
                            SelectionForeColor = Color.Black
                        };

                        dgvSeguimiento.RowsDefaultCellStyle = estiloClaro;
                        dgvSeguimiento.AlternatingRowsDefaultCellStyle = estiloClaro;
                        dgvSeguimiento.DefaultCellStyle = estiloClaro;

                        foreach (DataGridViewColumn col in dgvSeguimiento.Columns)
                        {
                            col.DefaultCellStyle.BackColor = Color.White;
                            col.DefaultCellStyle.ForeColor = Color.Black;
                            col.DefaultCellStyle.SelectionBackColor = Color.White;
                            col.DefaultCellStyle.SelectionForeColor = Color.Black;
                        }

                        dgvSeguimiento.ClearSelection();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string estado = cmbEstado.SelectedItem?.ToString() ?? "Todos";
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cmbEstado.SelectedItem?.ToString() ?? "Todos";
        }

        private void txtBuscarOrden_TextChanged(object sender, EventArgs e)
        {
            string estado = cmbEstado.Text == "Todos los estados" ? "Todos" : cmbEstado.Text;
            CargarSeguimiento(txtBuscarOrden.Text.Trim(), estado);
        }

        private void cmbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string estado = cmbEstado.Text == "Todos los estados" ? "Todos" : cmbEstado.Text;
            CargarSeguimiento(txtBuscarOrden.Text.Trim(), estado);
        }

        private void dgvSeguimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSeguimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSeguimiento_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
            {
                using (SolidBrush accentBrush = new SolidBrush(Color.FromArgb(0, 210, 160)))
                {
                    e.Graphics.FillRectangle(accentBrush, e.RowBounds.Left, e.RowBounds.Top, 4, e.RowBounds.Height);
                }
            }
        }

        private void dgvSeguimiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Extraemos los datos reales ocultos en la fila
                    DataRowView filaSeleccionada = (DataRowView)dgvSeguimiento.Rows[e.RowIndex].DataBoundItem;

                    if (filaSeleccionada != null)
                    {
                        // Extraemos TODA la info de la celda
                        string numeroOrden = filaSeleccionada["Orden"].ToString();
                        string clienteDispositivo = filaSeleccionada["Cliente_Dispositivo"].ToString();
                        string estado = filaSeleccionada["Estado"].ToString();
                        string tecnico = filaSeleccionada["Tecnico"].ToString();

                        // Abrimos el formulario y le inyectamos toda esta información
                        frmDetallesOrden frm = new frmDetallesOrden(numeroOrden, clienteDispositivo, estado, tecnico);
                        frm.ShowDialog();

                        // Opcional: Al cerrar el formulario de detalles, refrescamos la tabla 
                        // por si actualizaste el estado o cambiaste de técnico.
                        string estadoFiltro = cmbEstado.Text == "Todos los estados" ? "Todos" : cmbEstado.Text;
                        CargarSeguimiento(txtBuscarOrden.Text.Trim(), estadoFiltro);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}