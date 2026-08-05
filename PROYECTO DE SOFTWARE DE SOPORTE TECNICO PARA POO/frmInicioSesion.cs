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
            try
            {
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"SELECT COUNT(*) 
                                FROM usuarios
                                WHERE username = @usuario
                                AND password = @password";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtContraseña.Text.Trim());

                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                    if (resultado > 0)
                    {
                        frmMenu menuPrincipal = new frmMenu();
                        menuPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
