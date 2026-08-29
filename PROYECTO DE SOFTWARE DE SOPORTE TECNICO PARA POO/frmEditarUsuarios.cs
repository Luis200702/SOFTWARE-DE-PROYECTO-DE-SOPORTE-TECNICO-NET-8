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
        // Variables globales
        private int idUsuarioActual;
        private string usuarioOriginal;
        string cadena;
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();

        public frmEditarUsuarios()
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

        // 🔥 NOTA: Recuerda que al abrir este form desde tu otra pantalla, 
        // ahora debes enviarle el ID del usuario como primer parámetro.
        public frmEditarUsuarios(int idUsuario, string nombre, string usuario, string perfil, string sucursal)
        {
            InitializeComponent();
            CargarSucursales();

            idUsuarioActual = idUsuario; // Guardamos el ID real de la base de datos
            usuarioOriginal = usuario;

            txtNombre.Text = nombre;
            txtUsuario.Text = usuario;
            txtContrasena.Watermark = "Dejar vacío para no cambiar";

            // Seleccionamos el perfil automáticamente al abrir simulando el clic
            if (perfil == "Administrador")
            {
                btnAdministrador_Click(null, null);
            }
            else
            {
                btnTecnico_Click(null, null);
            }

            // Seleccionamos la sucursal
            cmbSucursal.Text = sucursal;
        }

        // --- Eventos de los Botones de Perfil (SunnyUI) ---
        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            // Estilo ACTIVO para Administrador
            btnAdministrador.FillColor = Color.FromArgb(0, 165, 155);
            btnAdministrador.ForeColor = Color.FromArgb(24, 43, 62);
            btnAdministrador.RectColor = Color.FromArgb(0, 165, 155);

            // Estilo INACTIVO para Técnico
            btnTecnico.FillColor = Color.White;
            btnTecnico.ForeColor = Color.FromArgb(70, 86, 103);
            btnTecnico.RectColor = Color.FromArgb(220, 226, 232);
        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            // Estilo ACTIVO para Técnico
            btnTecnico.FillColor = Color.FromArgb(0, 165, 155);
            btnTecnico.ForeColor = Color.FromArgb(24, 43, 62);
            btnTecnico.RectColor = Color.FromArgb(0, 165, 155);

            // Estilo INACTIVO para Administrador
            btnAdministrador.FillColor = Color.White;
            btnAdministrador.ForeColor = Color.FromArgb(70, 86, 103);
            btnAdministrador.RectColor = Color.FromArgb(220, 226, 232);
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

            // Determinamos el perfil basándonos en el color ACTIVO (FillColor) del botón
            string perfil = "";
            if (btnAdministrador.FillColor == Color.FromArgb(0, 165, 155))
            {
                perfil = "Administrador";
            }
            else if (btnTecnico.FillColor == Color.FromArgb(0, 165, 155))
            {
                perfil = "Tecnico";
            }
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

            // OBTENEMOS EL ID NUMÉRICO DE LA SUCURSAL SELECCIONADA
            int idSucursalSeleccionada = Convert.ToInt32(cmbSucursal.SelectedValue);

            // Armamos la cadena SIN la contraseña inicialmente
            cadena = "Nombre='" + txtNombre.Text.Trim() +
                     "', Usuario='" + txtUsuario.Text.Trim() +
                     "', Perfil='" + perfil +
                     "', IdSucursal=" + idSucursalSeleccionada;

            // Solo agregamos la contraseña a la actualización si el usuario escribió una nueva
            if (!string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                cadena += ", Contrasena='" + txtContrasena.Text.Trim() + "'";
            }

            // Usamos tu método actualizarDatos apuntando a la tabla Usuarios y a la columna "Id"
            bool resultado = oCon.actualizarDatos("Usuarios", cadena, "Id=" + idUsuarioActual);

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

        private void frmEditarUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}