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
            frmMenu menuPrincipal = new frmMenu();
            menuPrincipal.MostrarAdministrador();
            menuPrincipal.Show();
            var db = new Conexion_Base_de_Datos();
           // using (SqlConnection con = db.ObtenerConexion())
            {
               //
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
