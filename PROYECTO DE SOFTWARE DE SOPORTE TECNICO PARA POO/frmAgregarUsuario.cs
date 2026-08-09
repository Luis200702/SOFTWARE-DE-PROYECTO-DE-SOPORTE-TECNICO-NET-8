using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
            CargarSucursales();
        }

        private void CargarSucursales()
        {
            Conexion_Base_de_Datos conexion = new Conexion_Base_de_Datos();
            DataTable dt = conexion.obtenerSucursales();

            cmbSucursal.Items.Clear();

            foreach (DataRow fila in dt.Rows)
            {
                cmbSucursal.Items.Add(fila["Sucursal"].ToString());
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
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el perfil seleccionado

            if (perfil == "Administrador")
                perfil = "Administrador";
            else if (perfil == "Tecnico")
                perfil = "Tecnico";
            else
            {
                MessageBox.Show("Seleccione un perfil.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una sucursal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar en la base de datos
            Conexion_Base_de_Datos conexion = new Conexion_Base_de_Datos();
            bool guardado = conexion.insertarUsuario(
                txtNombre.Text.Trim(),
                txtUsuario.Text.Trim(),
                txtContrasena.Text.Trim(),
                perfil,
                cmbSucursal.Text
            );

            if (guardado)
            {
                MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
