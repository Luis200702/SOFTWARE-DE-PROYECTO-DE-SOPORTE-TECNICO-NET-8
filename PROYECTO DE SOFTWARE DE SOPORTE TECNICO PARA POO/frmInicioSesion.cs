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
            var db = new Conexion_Base_de_Datos();
            using (SqlConnection con = db.ObtenerConexion())
            {
                con.Open();
                string query = "SELECT id, nombre, perfil FROM usuarios WHERE username = @username AND password = @password AND estado = 'activo'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtContraseña.Text.Trim());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string nombre = reader["nombre"].ToString();
                        string perfil = reader["perfil"].ToString();
                        MessageBox.Show($"Bienvenido, {nombre} ({perfil})");

                        if (perfil == "Administrador")
                        {
                            frmMenu menuPrincipal = new frmMenu();
                            menuPrincipal.MostrarAdministrador();
                            menuPrincipal.Show();
                           
                            this.Hide();
                        }
                        else if (perfil == "Técnico")
                        {
                            frmMenu menuTecnico = new frmMenu();
                            menuTecnico.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
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
