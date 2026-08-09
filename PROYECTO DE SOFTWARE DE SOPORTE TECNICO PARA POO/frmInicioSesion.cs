using Microsoft.Data.SqlClient;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class frmInicioSesion : Form
    {
        frmMenu administrador = new frmMenu();
        Conexion_Base_de_Datos conexion = new Conexion_Base_de_Datos();
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string perfil = conexion.validarUsuario(
                txtUsuario.Text,
                txtContrasena.Text
            );

            if (perfil == "")
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }

            frmMenu menu = new frmMenu();

            if (perfil == "Administrador")
            {
                menu.MostrarAdministrador();
                menu.Show();
                this.Hide();
            }
            else if (perfil == "Tecnico")
            {
                menu.Show();
                this.Hide();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
