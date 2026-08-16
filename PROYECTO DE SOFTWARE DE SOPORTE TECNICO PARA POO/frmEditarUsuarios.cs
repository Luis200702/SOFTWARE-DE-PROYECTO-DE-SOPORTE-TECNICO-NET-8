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
        private string usuarioOriginal;

        public frmEditarUsuarios()
        {
            InitializeComponent();
            CargarSucursales(); // Cargamos las sucursales por si se abre vacío
        }

        public frmEditarUsuarios(string nombre, string usuario, string perfil, string sucursal)
        {
            InitializeComponent();

            // 1. Primero cargamos el ComboBox con las sucursales de la BD
            CargarSucursales();

            usuarioOriginal = usuario;

            txtNombre.Text = nombre;
            txtUsuario.Text = usuario;
            txtContrasena.Watermark = "Dejar vacío para no cambiar";

            if (perfil == "Administrador")
                btnAdministrador.BackColor = Color.FromArgb(0, 150, 136);
            else
                btnTecnico.BackColor = Color.FromArgb(0, 150, 136);

            // 2. Seleccionamos la sucursal que traía el usuario por su texto/nombre
            cmbSucursal.Text = sucursal;
        }

        // --- Método para llenar el ComboBox desde la BD ---
        private void CargarSucursales()
        {
            Conexion_Base_de_Datos conexion = new Conexion_Base_de_Datos();
            DataTable dt = conexion.obtenerSucursales(); // Devuelve IdSucursal y NombreSucursal

            if (dt != null && dt.Rows.Count > 0)
            {
                cmbSucursal.DataSource = dt;
                cmbSucursal.DisplayMember = "NombreSucursal"; // Lo que ve el usuario
                cmbSucursal.ValueMember = "IdSucursal";       // El ID oculto que necesitamos
            }
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

            if (cmbSucursal.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una sucursal válida");
                return;
            }

            // 🔥 OBTENEMOS EL ID NUMÉRICO DE LA SUCURSAL SELECCIONADA
            int idSucursalSeleccionada = Convert.ToInt32(cmbSucursal.SelectedValue);

            // Enviar los datos actualizados usando el ID (int)
            Conexion_Base_de_Datos conexion = new Conexion_Base_de_Datos();
            bool resultado = conexion.actualizarUsuario(
                usuarioOriginal,
                txtNombre.Text.Trim(),
                txtUsuario.Text.Trim(),
                txtContrasena.Text.Trim(),
                perfil,
                idSucursalSeleccionada // <-- Aquí enviamos el entero en lugar del texto
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