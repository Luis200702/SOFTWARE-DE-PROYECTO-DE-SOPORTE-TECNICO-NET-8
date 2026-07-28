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
    public partial class ucDerivacion : UserControl
    {
        public ucDerivacion()
        {
            InitializeComponent();
            ConfigurarDataGridView();

            // Se llama a la función para redondear todos los botones del formulario
            this.RedondearBotones(40);
        }

        private void ucDerivacion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaDerivacion_Click(object sender, EventArgs e)
        {

        }

        private void dtgDetallesDerivacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void ConfigurarDataGridView()
        {

            dtgDetallesDerivacion.Columns.Add("Campo", "Campo");
            dtgDetallesDerivacion.Columns.Add("Valor", "Valor");

            dtgDetallesDerivacion.ColumnHeadersVisible = false;
            dtgDetallesDerivacion.RowHeadersVisible = false;

            dtgDetallesDerivacion.BackgroundColor = Color.White;
            dtgDetallesDerivacion.GridColor = Color.LightGray;
            dtgDetallesDerivacion.DefaultCellStyle.BackColor = Color.White;
            dtgDetallesDerivacion.DefaultCellStyle.ForeColor = Color.Black;
            dtgDetallesDerivacion.DefaultCellStyle.Font = new Font("Segoe UI", 12F);
            dtgDetallesDerivacion.RowTemplate.Height = 35;

            dtgDetallesDerivacion.Columns[0].DefaultCellStyle.BackColor = Color.Gainsboro;
            dtgDetallesDerivacion.Columns[0].DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }


        private void panel3_Click(object sender, EventArgs e)
        {
            dtgDetallesDerivacion.Rows.Clear();

            dtgDetallesDerivacion.Rows.Add("Usuario", lblUsarioderivaci.Text);
            dtgDetallesDerivacion.Rows.Add("Marca", lblGMarcaderivacion.Text);
            dtgDetallesDerivacion.Rows.Add("Fecha", lblfechaderivacion.Text);
            dtgDetallesDerivacion.Rows.Add("Origen", lblOrigenderivacion.Text);
            dtgDetallesDerivacion.Rows.Add("Destino", lblDestinoderivacion.Text);
            dtgDetallesDerivacion.Rows.Add("Motivo", lblmotivoderivación.Text);
            dtgDetallesDerivacion.Rows.Add("Recursos", lblfallaDerivacion.Text);
        }
    }
}

