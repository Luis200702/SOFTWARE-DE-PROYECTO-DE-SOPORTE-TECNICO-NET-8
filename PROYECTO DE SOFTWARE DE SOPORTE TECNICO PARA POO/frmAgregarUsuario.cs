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
        public frmAgregarUsuario()
        {
            InitializeComponent();
            CargarSucursales();
        }

        // --- Cargar sucursales usando la estructura relacional ---
        private void CargarSucursales()
        {
            Conexion_Base_de_Datos conexion = new Conexion_Base_de_Datos();
            DataTable dt = conexion.obtenerSucursales(); // Devuelve IdSucursal y NombreSucursal

            if (dt != null && dt.Rows.Count > 0)
            {
                cmbSucursal.DataSource = dt;
                cmbSucursal.DisplayMember = "NombreSucursal"; // Lo que ve el usuario
                cmbSucursal.ValueMember = "IdSucursal";       // El ID numérico oculto
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

            if (cmbSucursal.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una sucursal válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔥 OBTENEMOS EL ID NUMÉRICO DE LA SUCURSAL SELECCIONADA
            int idSucursalSeleccionada = Convert.ToInt32(cmbSucursal.SelectedValue);

            // Guardar en la base de datos enviando el ID (int)
            Conexion_Base_de_Datos conexion = new Conexion_Base_de_Datos();
            bool guardado = conexion.insertarUsuario(
                txtNombre.Text.Trim(),
                txtUsuario.Text.Trim(),
                txtContrasena.Text.Trim(),
                perfil,
                idSucursalSeleccionada // <-- Aquí va el entero en lugar del texto
            );

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