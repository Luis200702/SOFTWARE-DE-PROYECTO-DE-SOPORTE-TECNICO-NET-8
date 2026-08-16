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
        // --- Variables Globales Entrantes ---
        private Label lblValOrden, lblValCliente, lblValTelefono, lblValDispositivo, lblValRuta, lblValMotivo;
        private UIButton btnRecibir, btnRechazar;
        private string ordenSeleccionadaActual = "";
        private UIPanel pnlClienteBox, pnlDispBox, pnlRutaBox, pnlAccionBox;

        // --- Variables Globales Salientes ---
        private Label lblSalValOrden, lblSalValFecha, lblSalValEstadoBadge;
        private Label lblSalValClienteName, lblSalValClienteEmail;
        private Label lblSalValOrigen, lblSalValDestino, lblSalValEnviadoPor, lblSalValFechaEnvio;
        private Label lblSalValDispTipo, lblSalValCodOrden, lblSalValEstadoDisp, lblSalValSerial, lblSalValObs;
        private Label lblSalHistorialTexto;
        private string ordenSalienteSeleccionadaActual = "";
        private UIPanel pnlSalCliBox, pnlSalEnvioBox, pnlSalDispBox, pnlSalHistorialBox;

        public ucDerivacion()
        {
            InitializeComponent();

            RefrescarTodo();

            InicializarPanelDerechoEntrantes();
            InicializarPanelDerechoSalientes();
        }

        private void RefrescarTodo()
        {
            CargarDerivacionesEntrantesDesdeBD(Sesion.SucursalActual);
            CargarDerivacionesSalientesDesdeBD(Sesion.SucursalActual);
        }

        // ==========================================
        // 1. LÓGICA DE ENTRANTES (RECIBIDAS)
        // ==========================================
        private void CargarDerivacionesEntrantesDesdeBD(string destinoSucursal)
        {
            if (flpIzquierdoE == null) return;
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
                                string fecha = Convert.ToDateTime(lector["fecha_ingreso"]).ToString("dd/MM/yyyy hh:mm");

                                Panel tarjeta = CrearTarjetaDerivacion(codigo, estado, cliente, ruta, fecha, true);
                                flpIzquierdoE.Controls.Add(tarjeta);
                            }
                        }
                    }
                    db.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar derivaciones entrantes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.cerrarConexion();
            }
        }

        // ==========================================
        // 2. LÓGICA DE SALIENTES (ENVIADAS)
        // ==========================================
        private void CargarDerivacionesSalientesDesdeBD(string origenSucursal)
        {
            if (flpIzquierdoS == null) return;
            flpIzquierdoS.Controls.Clear();

            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();
            try
            {
                if (db.abrirConexion())
                {
                    // Relación corregida usando o.dispositivo_id = dp.id
                    string query = @"
                        SELECT 
                            o.numero_orden,
                            d.Estado,
                            c.nombre,
                            d.SucursalOrigen AS Orig,
                            d.SucursalDestino AS Dest,
                            o.fecha_ingreso,
                            ISNULL(dp.tipo, 'Dispositivo') + ' ' + ISNULL(dp.marca, '') AS DispositivoTexto
                        FROM dbo.DerivacionesSucursales d
                        INNER JOIN dbo.ordenes o ON d.idOrden = o.id
                        INNER JOIN dbo.clientes c ON o.cliente_id = c.id
                        LEFT JOIN dbo.dispositivos dp ON o.dispositivo_id = dp.id
                        WHERE d.SucursalOrigen = @SucursalOrigen";

                    using (SqlCommand comando = new SqlCommand(query, db.oCon))
                    {
                        comando.Parameters.AddWithValue("@SucursalOrigen", origenSucursal);
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                string codigo = lector["numero_orden"].ToString();
                                string estado = lector["Estado"].ToString();
                                string cliente = lector["nombre"].ToString();
                                string dispositivo = lector["DispositivoTexto"].ToString();
                                string ruta = $"{lector["Orig"]} → {lector["Dest"]}";
                                string fecha = Convert.ToDateTime(lector["fecha_ingreso"]).ToString("dd/MM/yyyy hh:mm");

                                Panel tarjeta = CrearTarjetaDerivacionSaliente(codigo, estado, cliente, dispositivo, ruta, fecha);
                                flpIzquierdoS.Controls.Add(tarjeta);
                            }
                        }
                    }
                    db.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar derivaciones salientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.cerrarConexion();
            }
        }

        private Panel CrearTarjetaDerivacionSaliente(string codigoOrden, string estado, string cliente, string dispositivo, string ruta, string fecha)
        {
            Panel card = new Panel();
            card.Size = new Size(460, 110);
            card.BackColor = Color.White;
            card.Margin = new Padding(10, 6, 10, 6);
            card.Cursor = Cursors.Hand;

            card.Paint += (s, e) => {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = CrearPathRedondeado(0, 0, card.Width - 1, card.Height - 1, 12f))
                {
                    using (SolidBrush brush = new SolidBrush(Color.White)) { e.Graphics.FillPath(brush, path); }
                    using (Pen pen = new Pen(Color.FromArgb(220, 224, 230), 1f)) { e.Graphics.DrawPath(pen, path); }
                }
            };

            Label lblOrden = new Label() { Text = codigoOrden, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), ForeColor = Color.FromArgb(30, 136, 229), Location = new Point(16, 14), AutoSize = true };

            string textoEstado = "  ● " + estado;
            Label lblEstado = new Label() { Text = "", Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), BackColor = Color.Transparent, Location = new Point(135, 12), Size = new Size(95, 24) };
            lblEstado.Paint += (s, e) => {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = CrearPathRedondeado(0, 0, lblEstado.Width - 1, lblEstado.Height - 1, 12f))
                {
                    Color bg = estado.ToLower() == "recibido" ? Color.FromArgb(220, 252, 231) : Color.FromArgb(254, 243, 199);
                    using (SolidBrush brush = new SolidBrush(bg)) { e.Graphics.FillPath(brush, path); }
                }
                Color fg = estado.ToLower() == "recibido" ? Color.FromArgb(22, 101, 52) : Color.FromArgb(217, 119, 6);
                TextRenderer.DrawText(e.Graphics, textoEstado, lblEstado.Font, lblEstado.ClientRectangle, fg, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };

            Label lblFecha = new Label() { Text = fecha, Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(340, 14), AutoSize = true };
            Label lblCliente = new Label() { Text = cliente, Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = Color.FromArgb(17, 24, 39), Location = new Point(16, 44), AutoSize = true };
            Label lblRuta = new Label() { Text = "🏢 " + ruta, Font = new Font("Segoe UI", 9F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(16, 74), AutoSize = true };

            card.Controls.AddRange(new Control[] { lblOrden, lblEstado, lblFecha, lblCliente, lblRuta });

            EventHandler seleccionarTarjeta = (s, e) => {
                CargarDetallesSalientesDerechos(codigoOrden);
            };

            card.Click += seleccionarTarjeta;
            foreach (Control c in card.Controls) { c.Click += seleccionarTarjeta; }

            return card;
        }

        private Panel CrearTarjetaDerivacion(string codigoOrden, string estado, string cliente, string ruta, string fecha, bool esEntrante)
        {
            Panel card = new Panel();
            card.Size = new Size(460, 110);
            card.BackColor = Color.White;
            card.Margin = new Padding(10, 6, 10, 6);
            card.Cursor = Cursors.Hand;

            card.Paint += (s, e) => {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = CrearPathRedondeado(0, 0, card.Width - 1, card.Height - 1, 12f))
                {
                    using (SolidBrush brush = new SolidBrush(Color.White)) { e.Graphics.FillPath(brush, path); }
                    using (Pen pen = new Pen(Color.FromArgb(220, 224, 230), 1f)) { e.Graphics.DrawPath(pen, path); }
                }
            };

            Label lblOrden = new Label() { Text = codigoOrden, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), ForeColor = Color.FromArgb(30, 136, 229), Location = new Point(16, 14), AutoSize = true };

            string textoEstado = "  ● " + estado;
            Label lblEstado = new Label() { Text = "", Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), BackColor = Color.Transparent, Location = new Point(135, 12), Size = new Size(95, 24) };
            lblEstado.Paint += (s, e) => {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = CrearPathRedondeado(0, 0, lblEstado.Width - 1, lblEstado.Height - 1, 12f))
                {
                    Color bg = estado.ToLower() == "recibido" ? Color.FromArgb(220, 252, 231) : Color.FromArgb(254, 243, 199);
                    using (SolidBrush brush = new SolidBrush(bg)) { e.Graphics.FillPath(brush, path); }
                }
                Color fg = estado.ToLower() == "recibido" ? Color.FromArgb(22, 101, 52) : Color.FromArgb(217, 119, 6);
                TextRenderer.DrawText(e.Graphics, textoEstado, lblEstado.Font, lblEstado.ClientRectangle, fg, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };

            Label lblFecha = new Label() { Text = fecha, Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(340, 14), AutoSize = true };
            Label lblCliente = new Label() { Text = cliente, Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = Color.FromArgb(17, 24, 39), Location = new Point(16, 44), AutoSize = true };
            Label lblRuta = new Label() { Text = "🏢 " + ruta, Font = new Font("Segoe UI", 9F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(16, 74), AutoSize = true };

            card.Controls.AddRange(new Control[] { lblOrden, lblEstado, lblFecha, lblCliente, lblRuta });

            EventHandler seleccionarTarjeta = (s, e) => {
                if (esEntrante) CargarDetallesEntrantesDerechos(codigoOrden);
            };

            card.Click += seleccionarTarjeta;
            foreach (Control c in card.Controls) { c.Click += seleccionarTarjeta; }

            return card;
        }

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

        // ==========================================
        // 3. CARGA DE DETALLES - ENTRANTES
        // ==========================================
        private void CargarDetallesEntrantesDerechos(string numeroOrden)
        {
            ordenSeleccionadaActual = numeroOrden.Trim();
            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();

            try
            {
                if (db.abrirConexion())
                {
                    string query = @"
                        SELECT 
                            o.numero_orden,
                            c.nombre AS Cliente,
                            c.telefono AS Telefono,
                            ISNULL(dp.tipo, 'N/A') AS TipoDispositivo,
                            ISNULL(dp.marca, 'N/A') AS Marca,
                            ISNULL(dp.modelo, 'N/A') AS Modelo,
                            d.Estado,
                            d.Detalle AS MotivoDerivacion,
                            d.SucursalOrigen AS Origen,
                            d.SucursalDestino AS Destino,
                            o.fecha_ingreso
                        FROM dbo.DerivacionesSucursales d
                        INNER JOIN dbo.ordenes o ON d.idOrden = o.id
                        INNER JOIN dbo.clientes c ON o.cliente_id = c.id
                        LEFT JOIN dbo.dispositivos dp ON o.dispositivo_id = dp.id
                        WHERE o.numero_orden = @NumeroOrden";

                    using (SqlCommand comando = new SqlCommand(query, db.oCon))
                    {
                        comando.Parameters.AddWithValue("@NumeroOrden", ordenSeleccionadaActual);
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                lblValOrden.Text = "Orden: " + lector["numero_orden"].ToString();
                                lblValCliente.Text = "Cliente: " + lector["Cliente"].ToString();
                                lblValTelefono.Text = "Tel: " + lector["Telefono"].ToString();
                                lblValDispositivo.Text = $"Dispositivo: {lector["TipoDispositivo"]} - {lector["Marca"]} {lector["Modelo"]}";
                                lblValMotivo.Text = "Motivo: " + lector["MotivoDerivacion"].ToString();
                                lblValRuta.Text = $"Ruta: {lector["Origen"]} ➔ {lector["Destino"]}";
                                pnlDerechoE.Refresh();
                            }
                        }
                    }
                    db.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles entrantes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.cerrarConexion();
            }
        }

        // ==========================================
        // 4. CARGA DE DETALLES - SALIENTES (CORREGIDO CON LA RELACIÓN CORRECTA)
        // ==========================================
        private void CargarDetallesSalientesDerechos(string numeroOrden)
        {
            ordenSalienteSeleccionadaActual = numeroOrden.Trim();
            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();

            try
            {
                if (db.abrirConexion())
                {
                    string query = @"
                        SELECT 
                            o.numero_orden,
                            o.fecha_ingreso,
                            c.nombre AS Cliente,
                            c.correo AS Correo,
                            d.SucursalOrigen AS Origen,
                            d.SucursalDestino AS Destino,
                            d.Estado,
                            ISNULL(dp.tipo, 'N/A') AS TipoDispositivo,
                            ISNULL(dp.marca, 'N/A') AS Marca,
                            ISNULL(dp.modelo, 'N/A') AS Modelo,
                            ISNULL(dp.serie_imei, 'S/N') AS Serial,
                            ISNULL(dp.estado_llegada, 'En reparación') AS EstadoDisp,
                            ISNULL(d.Detalle, 'Ninguna') AS Observaciones
                        FROM dbo.DerivacionesSucursales d
                        INNER JOIN dbo.ordenes o ON d.idOrden = o.id
                        INNER JOIN dbo.clientes c ON o.cliente_id = c.id
                        LEFT JOIN dbo.dispositivos dp ON o.dispositivo_id = dp.id
                        WHERE o.numero_orden = @NumeroOrden";

                    using (SqlCommand comando = new SqlCommand(query, db.oCon))
                    {
                        comando.Parameters.AddWithValue("@NumeroOrden", ordenSalienteSeleccionadaActual);
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                lblSalValOrden.Text = lector["numero_orden"].ToString();
                                lblSalValFecha.Text = "Fecha de creación: " + Convert.ToDateTime(lector["fecha_ingreso"]).ToString("dd/MM/yyyy hh:mm");

                                string estadoActual = lector["Estado"].ToString();
                                lblSalValEstadoBadge.Text = "  ● " + estadoActual;
                                lblSalValEstadoBadge.Invalidate();

                                lblSalValClienteName.Text = lector["Cliente"].ToString();
                                lblSalValClienteEmail.Text = lector["Correo"].ToString();

                                lblSalValOrigen.Text = "Sucursal origen\n" + lector["Origen"].ToString();
                                lblSalValDestino.Text = "Sucursal destino\n" + lector["Destino"].ToString();
                                lblSalValEnviadoPor.Text = "Enviado por\n" + lector["Cliente"].ToString();
                                lblSalValFechaEnvio.Text = "Fecha de envío\n" + Convert.ToDateTime(lector["fecha_ingreso"]).ToString("dd/MM/yyyy hh:mm");

                                lblSalValDispTipo.Text = $"Dispositivo: {lector["TipoDispositivo"]} - {lector["Marca"]} {lector["Modelo"]}";
                                lblSalValCodOrden.Text = "Código / Orden: " + lector["numero_orden"].ToString();
                                lblSalValEstadoDisp.Text = "Estado del dispositivo: " + lector["EstadoDisp"].ToString();
                                lblSalValSerial.Text = "Número de serie: " + lector["Serial"].ToString();
                                lblSalValObs.Text = "Observaciones: " + lector["Observaciones"].ToString();

                                lblSalHistorialTexto.Text = $"{Convert.ToDateTime(lector["fecha_ingreso"]).ToString("dd/MM/yyyy hh:mm")}\nDerivación creada desde {lector["Origen"]} hacia {lector["Destino"]}.";

                                pnlDerechoS.Refresh();
                            }
                        }
                    }
                    db.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles salientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.cerrarConexion();
            }
        }

        private void BadgeSaliente_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl == null) return;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = CrearPathRedondeado(0, 0, lbl.Width - 1, lbl.Height - 1, 12f))
            {
                bool esRecibido = lbl.Text.ToLower().Contains("recibido");
                Color bg = esRecibido ? Color.FromArgb(220, 252, 231) : Color.FromArgb(254, 243, 199);
                using (SolidBrush brush = new SolidBrush(bg)) { e.Graphics.FillPath(brush, path); }
            }
            Color fg = lbl.Text.ToLower().Contains("recibido") ? Color.FromArgb(22, 101, 52) : Color.FromArgb(217, 119, 6);
            TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, lbl.ClientRectangle, fg, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // ==========================================
        // 5. INICIALIZACIÓN DE PANELES DERECHOS
        // ==========================================
        private void InicializarPanelDerechoEntrantes()
        {
            if (pnlDerechoE == null) return;
            pnlDerechoE.Visible = true;
            pnlDerechoE.BringToFront();
            pnlDerechoE.BackColor = Color.White;

            pnlDerechoE.Controls.Clear();
            int anchoDinamico = Math.Max(300, pnlDerechoE.Width - 48);

            Label lblTitulo = new Label() { Text = "Detalle de la derivación", Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = Color.FromArgb(17, 24, 39), Location = new Point(24, 20), AutoSize = true };
            lblValOrden = new Label() { Text = "Seleccione una orden", Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), ForeColor = Color.FromArgb(30, 136, 229), Location = new Point(24, 55), AutoSize = true };

            pnlClienteBox = CrearCajaSunny(24, 95, anchoDinamico, 70);
            Label lblSeccionCliente = new Label() { Text = "Información del cliente", Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(16, 10), AutoSize = true };
            lblValCliente = new Label() { Text = "Cliente: -", Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = Color.FromArgb(17, 24, 39), Location = new Point(16, 32), AutoSize = true };
            lblValTelefono = new Label() { Text = "Tel: -", Font = new Font("Segoe UI", 9F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(16, 52), AutoSize = true };
            pnlClienteBox.Controls.AddRange(new Control[] { lblSeccionCliente, lblValCliente, lblValTelefono });

            pnlDispBox = CrearCajaSunny(24, 175, anchoDinamico, 95);
            Label lblSeccionDisp = new Label() { Text = "Detalles del Dispositivo y Motivo", Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(16, 10), AutoSize = true };
            lblValDispositivo = new Label() { Text = "Dispositivo: -", Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), ForeColor = Color.FromArgb(17, 24, 39), Location = new Point(16, 32), AutoSize = true };
            lblValMotivo = new Label() { Text = "Motivo: -", Font = new Font("Segoe UI", 9F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(16, 60), AutoSize = true };
            pnlDispBox.Controls.AddRange(new Control[] { lblSeccionDisp, lblValDispositivo, lblValMotivo });

            pnlRutaBox = CrearCajaSunny(24, 280, anchoDinamico, 65);
            Label lblSeccionRuta = new Label() { Text = "Ruteo entre sucursales", Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(16, 10), AutoSize = true };
            lblValRuta = new Label() { Text = "Ruta: -", Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), ForeColor = Color.FromArgb(17, 24, 39), Location = new Point(16, 34), AutoSize = true };
            pnlRutaBox.Controls.AddRange(new Control[] { lblSeccionRuta, lblValRuta });

            pnlAccionBox = new UIPanel() { Location = new Point(24, 358), Size = new Size(anchoDinamico, 90), FillColor = Color.FromArgb(240, 253, 244), RectColor = Color.FromArgb(187, 247, 208), Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right };
            Label lblInfoAccion = new Label() { Text = "ℹ Esta derivación requiere tu acción.\nPuedes recibir el repuesto o rechazarlo si no aplica.", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(22, 101, 52), Location = new Point(14, 14), AutoSize = true };
            pnlAccionBox.Controls.Add(lblInfoAccion);

            int anchoMitad = (anchoDinamico - 10) / 2;
            btnRecibir = new UIButton() { Text = "Recibir orden", FillColor = Color.FromArgb(13, 148, 136), RectColor = Color.FromArgb(13, 148, 136), ForeColor = Color.White, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), Size = new Size(anchoMitad, 42), Location = new Point(24, 462), Radius = 12, Cursor = Cursors.Hand, Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right };
            btnRecibir.Click += (s, e) => { ActualizarEstadoDerivacion("Recibido"); };

            btnRechazar = new UIButton() { Text = "Recazar orden", FillColor = Color.FromArgb(220, 38, 38), RectColor = Color.FromArgb(220, 38, 38), ForeColor = Color.White, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), Size = new Size(anchoMitad, 42), Location = new Point(24 + anchoMitad + 10, 462), Radius = 12, Cursor = Cursors.Hand, Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right };
            btnRechazar.Click += (s, e) => { ActualizarEstadoDerivacion("Rechazado"); };

            pnlDerechoE.Controls.AddRange(new Control[] { lblTitulo, lblValOrden, pnlClienteBox, pnlDispBox, pnlRutaBox, pnlAccionBox, btnRecibir, btnRechazar });
        }

        private void InicializarPanelDerechoSalientes()
        {
            if (pnlDerechoS == null) return;
            pnlDerechoS.Visible = true;
            pnlDerechoS.BringToFront();
            pnlDerechoS.BackColor = Color.White;

            pnlDerechoS.Controls.Clear();
            int anchoDinamico = Math.Max(300, pnlDerechoS.Width - 48);

            Label lblTitulo = new Label() { Text = "Detalle de la derivación", Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = Color.FromArgb(17, 24, 39), Location = new Point(24, 20), AutoSize = true };

            lblSalValOrden = new Label() { Text = "ORD-2026-000", Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), ForeColor = Color.FromArgb(30, 136, 229), Location = new Point(24, 55), AutoSize = true };
            lblSalValFecha = new Label() { Text = "Fecha de creación: -", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(24, 75), AutoSize = true };

            // Badge de estado superior derecho alineado perfectamente
            lblSalValEstadoBadge = new Label() { Text = "  ● Pendiente", Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), Location = new Point(anchoDinamico - 48, 53), Size = new Size(95, 24), BackColor = Color.Transparent };
            lblSalValEstadoBadge.Paint -= BadgeSaliente_Paint;
            lblSalValEstadoBadge.Paint += BadgeSaliente_Paint;

            // 1. Cliente Box (Posición original y = 105)
            pnlSalCliBox = CrearCajaSunny(24, 105, anchoDinamico, 68);
            Label lblSecCli = new Label() { Text = "Información del cliente", Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(14, 8), AutoSize = true };
            lblSalValClienteName = new Label() { Text = "-", Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), ForeColor = Color.FromArgb(17, 24, 39), Location = new Point(14, 26), AutoSize = true };
            lblSalValClienteEmail = new Label() { Text = "-", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(14, 44), AutoSize = true };
            pnlSalCliBox.Controls.AddRange(new Control[] { lblSecCli, lblSalValClienteName, lblSalValClienteEmail });

            // 2. Envío Box (Posición original y = 183)
            pnlSalEnvioBox = CrearCajaSunny(24, 183, anchoDinamico, 95);
            Label lblSecEnv = new Label() { Text = "Envío", Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(14, 8), AutoSize = true };
            lblSalValOrigen = new Label() { Text = "Sucursal origen\n-", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(14, 26), AutoSize = true };
            lblSalValDestino = new Label() { Text = "Sucursal destino\n-", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(220, 26), AutoSize = true };
            lblSalValEnviadoPor = new Label() { Text = "Enviado por\n-", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(14, 56), AutoSize = true };
            lblSalValFechaEnvio = new Label() { Text = "Fecha de envío\n-", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(220, 56), AutoSize = true };
            pnlSalEnvioBox.Controls.AddRange(new Control[] { lblSecEnv, lblSalValOrigen, lblSalValDestino, lblSalValEnviadoPor, lblSalValFechaEnvio });

            // 3. Dispositivo Box (Posición original y = 289)
            pnlSalDispBox = CrearCajaSunny(24, 289, anchoDinamico, 115);
            Label lblSecDisp = new Label() { Text = "Información del dispositivo", Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(14, 8), AutoSize = true };
            lblSalValDispTipo = new Label() { Text = "Dispositivo: -", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(14, 28), AutoSize = true };
            lblSalValCodOrden = new Label() { Text = "Código / Orden: -", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(220, 28), AutoSize = true };
            lblSalValEstadoDisp = new Label() { Text = "Estado del dispositivo: -", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(14, 48), AutoSize = true };
            lblSalValSerial = new Label() { Text = "Número de serie: -", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(220, 48), AutoSize = true };
            lblSalValObs = new Label() { Text = "Observaciones: -", Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(14, 72), AutoSize = true };
            pnlSalDispBox.Controls.AddRange(new Control[] { lblSecDisp, lblSalValDispTipo, lblSalValCodOrden, lblSalValEstadoDisp, lblSalValSerial, lblSalValObs });

            // 4. Historial Box (Posición original y = 415)
            pnlSalHistorialBox = CrearCajaSunny(24, 415, anchoDinamico, 65);
            Label lblSecHist = new Label() { Text = "⏱ Historial", Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(14, 8), AutoSize = true };
            lblSalHistorialTexto = new Label() { Text = "Sin historial registrado.", Font = new Font("Segoe UI", 8F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(14, 28), AutoSize = true };
            pnlSalHistorialBox.Controls.AddRange(new Control[] { lblSecHist, lblSalHistorialTexto });

            pnlDerechoS.Controls.AddRange(new Control[] { lblTitulo, lblSalValOrden, lblSalValFecha, lblSalValEstadoBadge, pnlSalCliBox, pnlSalEnvioBox, pnlSalDispBox, pnlSalHistorialBox });
        }

        private UIPanel CrearCajaSunny(int x, int y, int ancho, int alto)
        {
            return new UIPanel()
            {
                Location = new Point(x, y),
                Size = new Size(ancho, alto),
                FillColor = Color.FromArgb(249, 250, 251),
                RectColor = Color.FromArgb(229, 231, 235),
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right
            };
        }

        private void ActualizarEstadoDerivacion(string nuevoEstado)
        {
            if (string.IsNullOrEmpty(ordenSeleccionadaActual))
            {
                MessageBox.Show("Por favor, seleccione una orden primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();
            try
            {
                if (db.abrirConexion())
                {
                    string query = @"
                        UPDATE d 
                        SET d.Estado = @NuevoEstado
                        FROM dbo.DerivacionesSucursales d
                        INNER JOIN dbo.ordenes o ON d.idOrden = o.id
                        WHERE o.numero_orden = @NumeroOrden";

                    using (SqlCommand comando = new SqlCommand(query, db.oCon))
                    {
                        comando.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
                        comando.Parameters.AddWithValue("@NumeroOrden", ordenSeleccionadaActual);

                        int filas = comando.ExecuteNonQuery();
                        if (filas > 0)
                        {
                            MessageBox.Show($"Orden {ordenSeleccionadaActual} actualizada a estado: {nuevoEstado}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefrescarTodo();
                        }
                    }
                    db.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.cerrarConexion();
            }
        }
    }
}