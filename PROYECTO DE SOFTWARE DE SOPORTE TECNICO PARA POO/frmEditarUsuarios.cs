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
    public partial class frmEditarUsuarios : Form
    {
        public frmEditarUsuarios()
        {
            InitializeComponent();


        }

        private string usuarioOriginal;

        public frmEditarUsuarios(string nombre, string usuario, string perfil, string sucursal)
        {
            InitializeComponent();
            MessageBox.Show($"Nombre: {nombre}\nUsuario: {usuario}\nPerfil: {perfil}\nSucursal: {sucursal}");


            usuarioOriginal = usuario;


            txtNombre.Text = nombre;
            txtUsuario.Text = usuario;
            txtContrasena.Watermark = "Dejar vacío para no cambiar";

            if (perfil == "Administrador")
                btnAdministrador.BackColor = Color.FromArgb(0, 150, 136);
            else
                btnTecnico.BackColor = Color.FromArgb(0, 150, 136);

            cmbSucursal.Text = sucursal;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El usuario es obligatorio");
                txtUsuario.Focus();
                return;
            }

            string perfil = "";
            if (btnAdministrador.BackColor == Color.FromArgb(0, 150, 136))
                perfil = "Administrador";
            else if (btnTecnico.BackColor == Color.FromArgb(0, 150, 136))
                perfil = "Tecnico";
            else
            {
                MessageBox.Show("Debe seleccionar un perfil");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbSucursal.Text))
            {
                MessageBox.Show("Debe seleccionar una sucursal");
                return;
            }

            // Enviar los datos
            Conexion_Base_de_Datos conexion = new Conexion_Base_de_Datos();
            bool resultado = conexion.actualizarUsuario(
                usuarioOriginal,
                txtNombre.Text.Trim(),
                txtUsuario.Text.Trim(),
                txtContrasena.Text.Trim(),
                perfil,
                cmbSucursal.Text
            );

            if (resultado)
            {
                MessageBox.Show("Usuario actualizado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el usuario");
            }
        
        }
    }
}
