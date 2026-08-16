using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Sunny.UI;

namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    public partial class ucDerivacion : UserControl
    {
        public ucDerivacion()
        {
            InitializeComponent();

            // Usamos directamente la sucursal almacenada al iniciar sesión
            CargarDerivacionesEntrantesDesdeBD(Sesion.SucursalActual);
        }

        private void CargarDerivacionesEntrantesDesdeBD(string destinoSucursal)
        {
            flpIzquierdoE.Controls.Clear();

            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();

            try
            {
                if (db.abrirConexion())
                {
                    string query = @"
                        SELECT 
                            o.numero_orden,
                            d.Estado,
                            c.nombre,
                            d.SucursalOrigen AS Orig,
                            d.SucursalDestino AS Dest,
                            o.fecha_ingreso
                        FROM dbo.DerivacionesSucursales d
                        INNER JOIN dbo.ordenes o ON d.idOrden = o.id
                        INNER JOIN dbo.clientes c ON o.cliente_id = c.id
                        WHERE d.SucursalDestino = @SucursalDestino";

                    using (SqlCommand comando = new SqlCommand(query, db.oCon))
                    {
                        comando.Parameters.AddWithValue("@SucursalDestino", destinoSucursal);

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                string codigo = lector["numero_orden"].ToString();
                                string estado = lector["Estado"].ToString();
                                string cliente = lector["nombre"].ToString();
                                string ruta = $"{lector["Orig"]} → {lector["Dest"]}";
                                string fecha = Convert.ToDateTime(lector["fecha_ingreso"]).ToString("dd/MM/yyyy hh:mm tt");

                                Panel tarjeta = CrearTarjetaDerivacion(codigo, estado, cliente, ruta, fecha);
                                flpIzquierdoE.Controls.Add(tarjeta);
                            }
                        }
                    }
                    db.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las derivaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.cerrarConexion();
            }
        }

        private Panel CrearTarjetaDerivacion(string codigoOrden, string estado, string cliente, string ruta, string fecha)
        {
            Panel card = new Panel();
            card.Size = new Size(460, 110);
            card.BackColor = Color.White;
            card.Margin = new Padding(10, 6, 10, 6);
            card.Cursor = Cursors.Hand;

            // Pintado personalizado para esquinas redondeadas de la tarjeta principal (Radio: 12)
            card.Paint += (s, e) => {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = CrearPathRedondeado(0, 0, card.Width - 1, card.Height - 1, 12f))
                {
                    using (SolidBrush brush = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                    using (Pen pen = new Pen(Color.FromArgb(220, 224, 230), 1f))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };

            Label lblOrden = new Label()
            {
                Text = codigoOrden,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 136, 229),
                Location = new Point(16, 14),
                AutoSize = true
            };

            // =========================================================
            // CONFIGURACIÓN DEL BADGE DEL ESTADO CON ESQUINAS REDONDEADAS
            // =========================================================
            string textoEstado = "  ⏱ " + estado;
            Label lblEstado = new Label()
            {
                Text = "", // Lo dejamos vacío aquí para que el texto por defecto no quede oculto por el fondo
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                BackColor = Color.Transparent,
                Location = new Point(135, 12),
                Size = new Size(95, 24)
            };

            lblEstado.Paint += (s, e) => {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // 1. Dibujamos el fondo naranja claro con esquinas redondeadas (Radio: 12)
                using (GraphicsPath path = CrearPathRedondeado(0, 0, lblEstado.Width - 1, lblEstado.Height - 1, 12f))
                {
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(254, 243, 199)))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                }

                // 2. Dibujamos el texto naranja oscuro centrado justo encima del fondo
                TextRenderer.DrawText(e.Graphics, textoEstado, lblEstado.Font, lblEstado.ClientRectangle, Color.FromArgb(217, 119, 6), TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };

            Label lblFecha = new Label()
            {
                Text = fecha,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(340, 14),
                AutoSize = true
            };

            Label lblCliente = new Label()
            {
                Text = cliente,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(17, 24, 39),
                Location = new Point(16, 44),
                AutoSize = true
            };

            Label lblRuta = new Label()
            {
                Text = "🏢 " + ruta,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(75, 85, 99),
                Location = new Point(16, 74),
                AutoSize = true
            };

            card.Controls.AddRange(new Control[] { lblOrden, lblEstado, lblFecha, lblCliente, lblRuta });

            return card;
        }

        // Método auxiliar para generar la ruta geométrica de las esquinas redondeadas
        private GraphicsPath CrearPathRedondeado(float x, float y, float ancho, float alto, float radio)
        {
            GraphicsPath path = new GraphicsPath();
            if (ancho <= 0 || alto <= 0) return path;

            radio = Math.Min(radio, Math.Min(ancho / 2f, alto / 2f));
            if (radio < 0) radio = 0;

            float diametro = radio * 2f;

            path.StartFigure();
            path.AddArc(x, y, diametro, diametro, 180, 90);
            path.AddArc(x + ancho - diametro, y, diametro, diametro, 270, 90);
            path.AddArc(x + ancho - diametro, y + alto - diametro, diametro, diametro, 0, 90);
            path.AddArc(x, y + alto - diametro, diametro, diametro, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}