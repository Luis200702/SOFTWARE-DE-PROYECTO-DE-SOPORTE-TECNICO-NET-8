using System;
using System.Data;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmSeguimientoDerivacion : Form
    {
        private int idOrdenSeleccionada;
        private string sucursalOrigenActual;

        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();

        public frmSeguimientoDerivacion(int idOrden, string sucursalOrigen)
        {
            InitializeComponent();

            idOrdenSeleccionada = idOrden;
            sucursalOrigenActual = sucursalOrigen;

            CargarSucursales();
        }

        private void CargarSucursales()
        {
            string origen = sucursalOrigenActual.Replace("'", "''");

            string consulta = "select nombresucursal from sucursales where nombresucursal <> '" + origen + "'";

            DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

            cmbSucursalDestino.Items.Clear();

            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    cmbSucursalDestino.Items.Add(
                        fila["NombreSucursal"].ToString());
                }
            }
        }

        private void btnConfirmarDerivacion_Click(object sender, EventArgs e)
        {
            if (cmbSucursalDestino.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Por favor selecciona una sucursal destino.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string consultaPendiente = "select count(*) as cantidad from derivacionessucursales where idorden = " + idOrdenSeleccionada + " and estado = 'Pendiente'";

            DataTable dtPendiente =
                oCon.retornarRegistrosUsuarios(consultaPendiente);

            int pendientes = 0;

            if (dtPendiente != null &&
                dtPendiente.Rows.Count > 0)
            {
                pendientes = Convert.ToInt32(
                    dtPendiente.Rows[0]["cantidad"]);
            }

            if (pendientes > 0)
            {
                MessageBox.Show(
                    "Esta orden ya tiene una derivación pendiente.",
                    "Derivación pendiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string origen =
                sucursalOrigenActual.Replace("'", "''");

            string destino =
                cmbSucursalDestino.Text.Replace("'", "''");

            string motivo =
                txtMotivo.Text.Trim().Replace("'", "''");

            string detalle =
                txtDetalle.Text.Trim().Replace("'", "''");

            string campos =
                "idorden, sucursalorigen, sucursaldestino, estado, motivo, detalle, fechaderivacion";

            string datos =
                idOrdenSeleccionada + "," +
                "'" + origen + "'," +
                "'" + destino + "'," +
                "'Pendiente'," +
                "'" + motivo + "'," +
                "'" + detalle + "'," +
                "getdate()";

            bool guardado =
                oCon.insertDatosCliente(
                    "derivacionessucursales",
                    campos,
                    datos);

            if (guardado)
            {
                MessageBox.Show(
                    "¡Equipo derivado con éxito!",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "No se pudo registrar la derivación.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}