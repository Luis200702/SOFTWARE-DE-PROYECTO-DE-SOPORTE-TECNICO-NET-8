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
    public partial class frmDetallesOrden : Form
    {
        ucRecepcion Unsoloboton = new ucRecepcion();
        private string ordenActual;

        // Nueva variable para memorizar qué botón de estado se tocó
        private string estadoSeleccionado;

        // Actualizamos el constructor para recibir todos los datos de la grilla
        public frmDetallesOrden(string numeroOrden, string clienteDispositivo, string estadoActual, string tecnicoActual)
        {
            InitializeComponent();
            ordenActual = numeroOrden;

            // 1. Asignamos el número de orden
            lblNumeroOrden.Text = numeroOrden;

            // 2. Separamos el "Cliente - Dispositivo" usando el guion que pusiste en SQL
            string[] partes = clienteDispositivo.Split(new string[] { " - " }, StringSplitOptions.None);
            if (partes.Length >= 2)
            {
                lblCliente.Text = partes[0].Trim();
                lblDispositivo.Text = partes[1].Trim();
            }
            else
            {
                lblCliente.Text = clienteDispositivo;
                lblDispositivo.Text = "Dispositivo no especificado";
            }

            CargarTecnicos();
            cmbTecnico.Text = tecnicoActual;

            CargarRepuestosStock(); // <-- Lo movemos aquí

            ActualizarDiseñoBotonesEstado(estadoActual);

            estadoSeleccionado = estadoActual;
        }

        // --- EVENTO LOAD: Se ejecuta al abrir el formulario ---
        private void frmDetallesOrden_Load(object sender, EventArgs e)
        {

        }

        // --- MÉTODOS DE CARGA DE BASE DE DATOS ---
        private void CargarTecnicos()
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                // Ajusta el nombre de la tabla si es distinto en tu SQL
                string query = "SELECT Id, Nombre FROM Usuarios WHERE Perfil = 'Tecnico'"; SqlDataAdapter da = new SqlDataAdapter(query, db.oCon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTecnico.DataSource = dt;
                cmbTecnico.DisplayMember = "Nombre";
                cmbTecnico.ValueMember = "Id";

                db.cerrarConexion();
            }
        }



        // --- LÓGICA DE INTERFAZ Y EFECTOS VISUALES ---

        private void ActualizarDiseñoBotonesEstado(string estadoSeleccionado)
        {
            // Usamos tu función personalizada para "presionar" el botón correcto al abrir la ventana
            switch (estadoSeleccionado)
            {
                case "Recibido":
                    Unsoloboton.SeleccionarBoton(btnRecibido);
                    break;
                case "En diagnóstico":
                    Unsoloboton.SeleccionarBoton(btnDiagnostico);
                    break;
                case "En reparación":
                    Unsoloboton.SeleccionarBoton(btnReparacion);
                    break;
                case "Listo":
                    Unsoloboton.SeleccionarBoton(btnListo);
                    break;
                case "Entregado":
                    Unsoloboton.SeleccionarBoton(btnEntregado);
                    break;
            }
        }


        // --- EVENTO: BOTÓN DE AGREGAR REPUESTO ---
        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            if (cmbRepuestos.SelectedValue != null)
            {
                // Agregamos el texto que el usuario ve a la lista visual inferior
                string repuestoTexto = cmbRepuestos.Text;
                lstRepuestos.Items.Add("• " + repuestoTexto);

                // NOTA: El descuento del inventario real en SQL se haría idealmente
                // cuando el usuario guarde el formulario o haga clic en el botón verde final.
            }
        }

        private void btnRecibido_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnRecibido);
            estadoSeleccionado = "Recibido";
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnDiagnostico);
            estadoSeleccionado = "En diagnóstico";
        }

        private void btnReparacion_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnReparacion);
            estadoSeleccionado = "En reparación";
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnListo);
            estadoSeleccionado = "Listo";
        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            Unsoloboton.SeleccionarBoton(btnEntregado);
            estadoSeleccionado = "Entregado";
        }

        private void CargarRepuestosStock()
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // Usamos los nombres exactos de tu tabla: IdRepuesto y NombreRepuesto
                    string query = "SELECT IdRepuesto, NombreRepuesto AS Descripcion FROM Repuestos";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Llenamos el ComboBox
                        cmbRepuestos.DataSource = dt;
                        cmbRepuestos.DisplayMember = "Descripcion";
                        cmbRepuestos.ValueMember = "IdRepuesto";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar repuestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }

        private void btnMarcarListo_Click(object sender, EventArgs e)
        {
            var db = new Conexion_Base_de_Datos();
            if (db.abrirConexion())
            {
                try
                {
                    // Hacemos el UPDATE de la tabla ordenes
                    string query = @"
                UPDATE ordenes 
                SET estado = @estado, 
                    tecnico_id = @tecnico 
                WHERE numero_orden = @orden";

                    using (SqlCommand cmd = new SqlCommand(query, db.oCon))
                    {
                        // Le pasamos la variable que memorizó el estado, el ID del combobox y la orden
                        cmd.Parameters.AddWithValue("@estado", estadoSeleccionado);
                        cmd.Parameters.AddWithValue("@tecnico", cmbTecnico.SelectedValue);
                        cmd.Parameters.AddWithValue("@orden", ordenActual);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("¡La orden se actualizó correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Cerramos este panel para que el usuario vuelva a la tabla principal
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la orden para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.cerrarConexion();
                }
            }
        }
    }
}