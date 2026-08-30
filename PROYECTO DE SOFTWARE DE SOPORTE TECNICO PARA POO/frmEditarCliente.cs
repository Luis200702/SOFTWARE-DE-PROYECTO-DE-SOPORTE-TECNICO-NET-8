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
    public partial class frmEditarCliente : Form
    {
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();
        private string cedula_actual;

        public frmEditarCliente()
        {
            InitializeComponent();
        }

        public frmEditarCliente(string cedula)
        {
            InitializeComponent();
            cedula_actual = cedula;
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cedula_actual))
            {
                CargarDatosClienteEnFormulario();
            }
        }

        private void CargarDatosClienteEnFormulario()
        {
            DataTable Cargar = oCon.retornarRegistrosUsuarios("SELECT * FROM clientes WHERE cedula_pasaporte = '" + cedula_actual + "'");

            if (Cargar.Rows.Count > 0)
            {
                DataRow row = Cargar.Rows[0];
                txtIdentificacionCliente.Text = row["cedula_pasaporte"].ToString();
                txtNombres.Text = row["nombre"].ToString();
                txtNumeroTelefonico.Text = row["telefono"].ToString();
                txtCorreo.Text = row["correo"].ToString();
                txtNumeroTelefonicoAlt.Text = row["telefono_alt"].ToString();
                txtDireccion.Text = row["direccion"].ToString();
            }
        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de eliminar este cliente? Se borrarán sus registros asociados.",
        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataTable dtCliente = oCon.retornarRegistrosUsuarios("SELECT id FROM clientes WHERE cedula_pasaporte = '" + cedula_actual + "'");

                if (dtCliente.Rows.Count > 0)
                {
                    string idCliente = dtCliente.Rows[0]["id"].ToString();

                    // 1. Borramos primero los registros dependientes en DerivacionesSucursales que apuntan a las órdenes del cliente
                    oCon.eliminarDatos("DerivacionesSucursales", "IdOrden IN (SELECT id FROM ordenes WHERE cliente_id = " + idCliente + ")");

                    // 2. Borramos las órdenes asociadas
                    oCon.eliminarDatos("ordenes", "cliente_id = " + idCliente);

                    // 3. Borramos los dispositivos asociados
                    oCon.eliminarDatos("dispositivos", "cliente_id = " + idCliente);

                    // 4. Finalmente eliminamos al cliente
                    bool eliminado = oCon.eliminarDatos("clientes", "cedula_pasaporte = '" + cedula_actual + "'");

                    if (eliminado)
                    {
                        MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdentificacionCliente.Text) ||
        string.IsNullOrWhiteSpace(txtNombres.Text) ||
        string.IsNullOrWhiteSpace(txtNumeroTelefonico.Text))
            {
                MessageBox.Show("Por favor, completa los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preparamos la cadena de campos a modificar
            string campos = $"nombre = '{txtNombres.Text.Trim()}', " +
                            $"telefono = '{txtNumeroTelefonico.Text.Trim()}', " +
                            $"correo = '{txtCorreo.Text.Trim()}', " +
                            $"cedula_pasaporte = '{txtIdentificacionCliente.Text.Trim()}', " +
                            $"telefono_alt = '{txtNumeroTelefonicoAlt.Text.Trim()}', " +
                            $"direccion = '{txtDireccion.Text.Trim()}'";

            string condicion = $"cedula_pasaporte = '{cedula_actual}'";

            // Ejecutamos tu método genérico de actualización
            bool actualizado = oCon.actualizarDatos("clientes", campos, condicion);

            if (actualizado)
            {
                MessageBox.Show("Datos del cliente actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}