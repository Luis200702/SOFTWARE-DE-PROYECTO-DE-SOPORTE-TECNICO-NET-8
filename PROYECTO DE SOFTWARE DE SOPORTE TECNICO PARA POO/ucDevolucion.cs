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
    public partial class ucDevolucion : UserControl
    {
        public ucDevolucion()
        {
            InitializeComponent();
        }

        ucRecepcion UnSoloBoton = new ucRecepcion();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string numeroOrden = txtBuscarOrden.Text.Trim();

            if (string.IsNullOrEmpty(numeroOrden))
            {
                MessageBox.Show("Ingresa un número de orden.");
                return;
            }

            var db = new Conexion_Base_de_Datos();

            using (SqlConnection con = db.ObtenerConexion())
            {
                con.Open();

                string query = @"SELECT o.numero_orden, o.estado, o.descripcion_problema, 
                                o.diagnostico_inicial, o.costo_estimado, o.fecha_estimada_entrega,
                                o.fecha_ingreso, c.nombre, c.telefono,
                                d.marca, d.modelo, d.serie_imei,
                                u.nombre AS tecnico
                         FROM ordenes o
                         INNER JOIN clientes c ON o.cliente_id = c.id
                         INNER JOIN dispositivos d ON o.dispositivo_id = d.id
                         INNER JOIN usuarios u ON o.tecnico_id = u.id
                         WHERE o.numero_orden = @numero_orden";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@numero_orden", numeroOrden);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblNumeroOrden.Text = reader["numero_orden"].ToString();
                        lblCliente.Text = reader["nombre"].ToString();
                        lblTelefono.Text = reader["telefono"].ToString();
                        lblDispositivo.Text = reader["marca"].ToString() + " " + reader["modelo"].ToString();
                        lblTecnicoAsignado.Text = reader["tecnico"].ToString();
                        lblFechaIngreso.Text = Convert.ToDateTime(reader["fecha_ingreso"]).ToString("dd/MM/yyyy");

                        pnlResumen.Visible = true;
                        //pnlTrabajoRealizado.Visible = true;
                        //pnlDesgloseCosto.Visible = true;
                        pnlFormaDePago.Visible = true;
                        btnRegistraEntrega.Visible = true;
                        btnComprobante.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna orden con ese número.");
                    }
                }
            }

        }

        private void ucDevolucion_Load(object sender, EventArgs e)
        {
            cmbFormaPago.SelectedIndex = 0;
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            UnSoloBoton.SeleccionarBoton(btnReparado);
        }

        private void btnParcial_Click(object sender, EventArgs e)
        {
            UnSoloBoton.SeleccionarBoton(btnParcial);
        }

        private void btnSinReparar_Click(object sender, EventArgs e)
        {
            UnSoloBoton.SeleccionarBoton(btnSinReparar);
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
