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
    public partial class frmAgregarUsuario : Form
    {
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();
        string campos;
        string datos;
        public frmAgregarUsuario()
        {
            InitializeComponent();
            CargarSucursales();
        }


        public void CargarSucursales()
        {
           
            DataTable dt = oCon.retornarRegistrosUsuarios("select IdSucursal, NombreSucursal from Sucursales order by NombreSucursal");

            if (dt != null && dt.Rows.Count > 0)
            {
                cmbSucursal.DataSource = dt;
                cmbSucursal.DisplayMember = "NombreSucursal";
                cmbSucursal.ValueMember = "IdSucursal";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ucRecepcion Boton = new ucRecepcion();
        private string perfil = "";

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

   
            if (perfil == "Administrador")
                perfil = "Administrador";
            else if (perfil == "Tecnico")
                perfil = "Tecnico";
            else
            {
                MessageBox.Show("Seleccione un perfil.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSucursal.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una sucursal válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            int idSucursalSeleccionada = Convert.ToInt32(cmbSucursal.SelectedValue);

            // Guardar en la base de datos enviando el ID (int)
            campos = "Nombre, Usuario, Contrasena, Perfil, IdSucursal";
            datos = "'" + txtNombre.Text.Trim() + "','" + txtUsuario.Text.Trim() + "','" + txtContrasena.Text.Trim() + "','" + perfil + "','" + idSucursalSeleccionada + "'";

            bool guardado = oCon.insertDatosCliente("Usuarios", campos, datos);

            if (guardado)
            {
                MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            Boton.SeleccionarBoton(btnTecnico);
            perfil = "Tecnico";
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            Boton.SeleccionarBoton(btnAdministrador);
            perfil = "Administrador";
        }
    }
}