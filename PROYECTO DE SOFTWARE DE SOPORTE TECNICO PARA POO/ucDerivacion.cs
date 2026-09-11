using Microsoft.Data.SqlClient;
using System;
using System.Data;
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
        Conexion_Base_de_Datos oCon = new Conexion_Base_de_Datos();

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

        private void CargarDerivacionesEntrantesDesdeBD(string destinoSucursal)
        {
            if (flpIzquierdoE == null)
                return;

            flpIzquierdoE.Controls.Clear();

            try
            {
                string sucursal = destinoSucursal.Replace("'", "''");
                string consulta = "select o.numero_orden, d.estado as Estado, c.nombre, d.sucursalorigen as Orig, d.sucursaldestino as Dest, d.fechaderivacion as FechaDerivacion from derivacionessucursales d inner join ordenes o on d.idorden = o.id inner join clientes c on o.cliente_id = c.id where d.sucursaldestino = '" + sucursal + "'";

                DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

                if (dt != null)
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        string codigo = fila["numero_orden"].ToString();
                        string estado = fila["Estado"].ToString();
                        string cliente = fila["nombre"].ToString();
                        string ruta = $"{fila["Orig"]} → {fila["Dest"]}";
                        string fecha = Convert.ToDateTime(fila["FechaDerivacion"]).ToString("dd/MM/yyyy HH:mm");

                        Panel tarjeta = CrearTarjetaDerivacion(codigo, estado, cliente, ruta, fecha, true);
                        flpIzquierdoE.Controls.Add(tarjeta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar derivaciones entrantes: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 2. LÓGICA DE SALIENTES (ENVIADAS)
        // ==========================================
        private void CargarDerivacionesSalientesDesdeBD(string origenSucursal)
        {
            if (flpIzquierdoS == null)
                return;

            flpIzquierdoS.Controls.Clear();

            try
            {
                string sucursal = origenSucursal.Replace("'", "''");
                string consulta = "select o.numero_orden, d.estado as Estado, c.nombre, d.sucursalorigen as Orig, d.sucursaldestino as Dest, d.fechaderivacion as FechaDerivacion, isnull(dp.tipo, 'Dispositivo') + ' ' + isnull(dp.marca, '') as DispositivoTexto from derivacionessucursales d inner join ordenes o on d.idorden = o.id inner join clientes c on o.cliente_id = c.id left join dispositivos dp on o.dispositivo_id = dp.id where d.sucursalorigen = '" + sucursal + "'";

                DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

                if (dt != null)
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        string codigo = fila["numero_orden"].ToString();
                        string estado = fila["Estado"].ToString();
                        string cliente = fila["nombre"].ToString();
                        string dispositivo = fila["DispositivoTexto"].ToString();
                        string ruta = $"{fila["Orig"]} → {fila["Dest"]}";
                        string fecha = Convert.ToDateTime(fila["FechaDerivacion"]).ToString("dd/MM/yyyy HH:mm");

                        Panel tarjeta = CrearTarjetaDerivacionSaliente(codigo, estado, cliente, dispositivo, ruta, fecha);
                        flpIzquierdoS.Controls.Add(tarjeta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar derivaciones salientes: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Panel CrearTarjetaDerivacionSaliente(string codigoOrden, string estado, string cliente, string dispositivo, string ruta, string fecha)
        {
            Panel card = new Panel();
            card.Size = new Size(460, 110);
            card.BackColor = Color.White;
            card.Margin = new Padding(10, 6, 10, 6);
            card.Cursor = Cursors.Hand;

            card.Paint += (s, e) =>
            {
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
            lblEstado.Paint += (s, e) =>
            {
                lblEstado.Paint += (s, e) =>
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    Color bg;
                    Color fg;

                    switch (estado.ToLower())
                    {
                        case "recibido":
                            bg = Color.FromArgb(220, 252, 231);
                            fg = Color.FromArgb(22, 101, 52);
                            break;

                        case "rechazado":
                            bg = Color.FromArgb(254, 226, 226);
                            fg = Color.FromArgb(185, 28, 28);
                            break;

                        default:
                            bg = Color.FromArgb(254, 243, 199);
                            fg = Color.FromArgb(217, 119, 6);
                            break;
                    }

                    using (GraphicsPath path = CrearPathRedondeado(
                        0, 0,
                        lblEstado.Width - 1,
                        lblEstado.Height - 1,
                        12f))
                    {
                        using (SolidBrush brush = new SolidBrush(bg))
                        {
                            e.Graphics.FillPath(brush, path);
                        }
                    }

                    TextRenderer.DrawText(
                        e.Graphics,
                        textoEstado,
                        lblEstado.Font,
                        lblEstado.ClientRectangle,
                        fg,
                        TextFormatFlags.HorizontalCenter |
                        TextFormatFlags.VerticalCenter);
                };
            };

            Label lblFecha = new Label() { Text = fecha, Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(340, 14), AutoSize = true };
            Label lblCliente = new Label() { Text = cliente, Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = Color.FromArgb(17, 24, 39), Location = new Point(16, 44), AutoSize = true };
            Label lblRuta = new Label() { Text = "🏢 " + ruta, Font = new Font("Segoe UI", 9F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(16, 74), AutoSize = true };

            card.Controls.AddRange(new Control[] { lblOrden, lblEstado, lblFecha, lblCliente, lblRuta });

            EventHandler seleccionarTarjeta = (s, e) =>
            {
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

            card.Paint += (s, e) =>
            {
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
            lblEstado.Paint += (s, e) =>
            {
                lblEstado.Paint += (s, e) =>
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    Color bg;
                    Color fg;

                    switch (estado.ToLower())
                    {
                        case "recibido":
                            bg = Color.FromArgb(220, 252, 231);
                            fg = Color.FromArgb(22, 101, 52);
                            break;

                        case "rechazado":
                            bg = Color.FromArgb(254, 226, 226);
                            fg = Color.FromArgb(185, 28, 28);
                            break;

                        default:
                            bg = Color.FromArgb(254, 243, 199);
                            fg = Color.FromArgb(217, 119, 6);
                            break;
                    }

                    using (GraphicsPath path = CrearPathRedondeado(
                        0, 0,
                        lblEstado.Width - 1,
                        lblEstado.Height - 1,
                        12f))
                    {
                        using (SolidBrush brush = new SolidBrush(bg))
                        {
                            e.Graphics.FillPath(brush, path);
                        }
                    }

                    TextRenderer.DrawText(
                        e.Graphics,
                        textoEstado,
                        lblEstado.Font,
                        lblEstado.ClientRectangle,
                        fg,
                        TextFormatFlags.HorizontalCenter |
                        TextFormatFlags.VerticalCenter);
                };
            };

            Label lblFecha = new Label() { Text = fecha, Font = new Font("Segoe UI", 8.5F), ForeColor = Color.FromArgb(107, 114, 128), Location = new Point(340, 14), AutoSize = true };
            Label lblCliente = new Label() { Text = cliente, Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = Color.FromArgb(17, 24, 39), Location = new Point(16, 44), AutoSize = true };
            Label lblRuta = new Label() { Text = "🏢 " + ruta, Font = new Font("Segoe UI", 9F), ForeColor = Color.FromArgb(75, 85, 99), Location = new Point(16, 74), AutoSize = true };

            card.Controls.AddRange(new Control[] { lblOrden, lblEstado, lblFecha, lblCliente, lblRuta });

            EventHandler seleccionarTarjeta = (s, e) =>
            {
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


        private void CargarDetallesEntrantesDerechos(string numeroOrden)
        {
            ordenSeleccionadaActual = numeroOrden.Trim();

            try
            {
                string orden = ordenSeleccionadaActual.Replace("'", "''");
                string sucursal = Sesion.SucursalActual.Replace("'", "''");

                string consulta = "select top 1 o.numero_orden, c.nombre as Cliente, c.telefono as Telefono, isnull(dp.tipo, 'N/A') as TipoDispositivo, isnull(dp.marca, 'N/A') as Marca, isnull(dp.modelo, 'N/A') as Modelo, d.estado as Estado, d.detalle as MotivoDerivacion, d.sucursalorigen as Origen, d.sucursaldestino as Destino, d.fechaderivacion as FechaDerivacion from derivacionessucursales d inner join ordenes o on d.idorden = o.id inner join clientes c on o.cliente_id = c.id left join dispositivos dp on o.dispositivo_id = dp.id where o.numero_orden = '" + orden + "' and d.sucursaldestino = '" + sucursal + "' order by d.fechaderivacion desc";

                DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];

                    lblValOrden.Text = "Orden: " + fila["numero_orden"].ToString();
                    lblValCliente.Text = "Cliente: " + fila["Cliente"].ToString();
                    lblValTelefono.Text = "Tel: " + fila["Telefono"].ToString();
                    lblValDispositivo.Text = $"Dispositivo: {fila["TipoDispositivo"]} - {fila["Marca"]} {fila["Modelo"]}";
                    lblValMotivo.Text = "Motivo: " + fila["MotivoDerivacion"].ToString();
                    lblValRuta.Text = $"Ruta: {fila["Origen"]} ➔ {fila["Destino"]}";

                    string estadoDerivacion = fila["Estado"].ToString();
                    bool estaPendiente = estadoDerivacion == "Pendiente";

                    pnlAccionBox.Visible = estaPendiente;
                    btnRecibir.Visible = estaPendiente;
                    btnRechazar.Visible = estaPendiente;
                    pnlDerechoE.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar detalles entrantes: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void CargarDetallesSalientesDerechos(string numeroOrden)
        {
            ordenSalienteSeleccionadaActual = numeroOrden.Trim();

            try
            {
                string orden = ordenSalienteSeleccionadaActual.Replace("'", "''");
                string consulta = "select o.numero_orden, o.fecha_ingreso, c.nombre as Cliente, c.correo as Correo, d.sucursalorigen as Origen, d.sucursaldestino as Destino, d.estado as Estado, isnull(dp.tipo, 'N/A') as TipoDispositivo, isnull(dp.marca, 'N/A') as Marca, isnull(dp.modelo, 'N/A') as Modelo, isnull(dp.serie_imei, 'S/N') as Serial, isnull(dp.estado_llegada, 'En reparación') as EstadoDisp, isnull(d.detalle, 'Ninguna') as Observaciones from derivacionessucursales d inner join ordenes o on d.idorden = o.id inner join clientes c on o.cliente_id = c.id left join dispositivos dp on o.dispositivo_id = dp.id where o.numero_orden = '" + orden + "'";

                DataTable dt = oCon.retornarRegistrosUsuarios(consulta);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];

                    lblSalValOrden.Text = fila["numero_orden"].ToString();

                    DateTime fechaIngreso = Convert.ToDateTime(fila["fecha_ingreso"]);
                    lblSalValFecha.Text = "Fecha de creación: " + fechaIngreso.ToString("dd/MM/yyyy hh:mm");

                    string estadoActual = fila["Estado"].ToString();
                    lblSalValEstadoBadge.Text = "  ● " + estadoActual;
                    lblSalValEstadoBadge.Invalidate();

                    lblSalValClienteName.Text = fila["Cliente"].ToString();
                    lblSalValClienteEmail.Text = fila["Correo"].ToString();

                    lblSalValOrigen.Text = "Sucursal origen\n" + fila["Origen"].ToString();
                    lblSalValDestino.Text = "Sucursal destino\n" + fila["Destino"].ToString();
                    lblSalValEnviadoPor.Text = "Enviado por\n" + fila["Cliente"].ToString();
                    lblSalValFechaEnvio.Text = "Fecha de envío\n" + fechaIngreso.ToString("dd/MM/yyyy hh:mm");

                    lblSalValDispTipo.Text = $"Dispositivo: {fila["TipoDispositivo"]} - {fila["Marca"]} {fila["Modelo"]}";
                    lblSalValCodOrden.Text = "Código / Orden: " + fila["numero_orden"].ToString();
                    lblSalValEstadoDisp.Text = "Estado del dispositivo: " + fila["EstadoDisp"].ToString();
                    lblSalValSerial.Text = "Número de serie: " + fila["Serial"].ToString();
                    lblSalValObs.Text = "Observaciones: " + fila["Observaciones"].ToString();

                    lblSalHistorialTexto.Text = $"{fechaIngreso.ToString("dd/MM/yyyy hh:mm")}\nDerivación creada desde {fila["Origen"]} hacia {fila["Destino"]}.";

                    pnlDerechoS.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar detalles salientes: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BadgeSaliente_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl == null)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            string estado = lbl.Text.ToLower();

            Color bg;
            Color fg;

            if (estado.Contains("recibido"))
            {
                bg = Color.FromArgb(220, 252, 231);
                fg = Color.FromArgb(22, 101, 52);
            }
            else if (estado.Contains("rechazado"))
            {
                bg = Color.FromArgb(254, 226, 226);
                fg = Color.FromArgb(185, 28, 28);
            }
            else
            {
                bg = Color.FromArgb(254, 243, 199);
                fg = Color.FromArgb(217, 119, 6);
            }

            using (GraphicsPath path = CrearPathRedondeado(
                0, 0,
                lbl.Width - 1,
                lbl.Height - 1,
                12f))
            {
                using (SolidBrush brush = new SolidBrush(bg))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }

            TextRenderer.DrawText(
                e.Graphics,
                lbl.Text,
                lbl.Font,
                lbl.ClientRectangle,
                fg,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter);
        }


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

            btnRechazar = new UIButton() { Text = "Rechazar orden", FillColor = Color.FromArgb(220, 38, 38), RectColor = Color.FromArgb(220, 38, 38), ForeColor = Color.White, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), Size = new Size(anchoMitad, 42), Location = new Point(24 + anchoMitad + 10, 462), Radius = 12, Cursor = Cursors.Hand, Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right };
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
                MessageBox.Show(
                    "Por favor, seleccione una orden primero.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Conexion_Base_de_Datos db = new Conexion_Base_de_Datos();

            try
            {
                if (db.abrirConexion())
                {
                    SqlTransaction transaccion = db.oCon.BeginTransaction();

                    try
                    {
                        string queryDerivacion = "update d set d.estado = @NuevoEstado from derivacionessucursales d inner join ordenes o on d.idorden = o.id where o.numero_orden = @NumeroOrden and d.sucursaldestino = @SucursalActual and d.estado = 'Pendiente'";

                        using (SqlCommand cmd = new SqlCommand(
                            queryDerivacion,
                            db.oCon,
                            transaccion))
                        {
                            cmd.Parameters.AddWithValue(
                                "@NuevoEstado",
                                nuevoEstado);

                            cmd.Parameters.AddWithValue(
                                "@NumeroOrden",
                                ordenSeleccionadaActual);

                            cmd.Parameters.AddWithValue(
                                "@SucursalActual",
                                Sesion.SucursalActual);

                            int filas = cmd.ExecuteNonQuery();

                            if (filas == 0)
                            {
                                transaccion.Rollback();

                                MessageBox.Show(
                                    "La derivación ya fue procesada o no corresponde a esta sucursal.",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return;
                            }
                        }

                        if (nuevoEstado == "Recibido")
                        {
                            string queryOrden = "update ordenes set sucursal = @SucursalActual, tecnico_id = null, estado = 'Recibido' where numero_orden = @NumeroOrden";

                            using (SqlCommand cmd = new SqlCommand(
                                queryOrden,
                                db.oCon,
                                transaccion))
                            {
                                cmd.Parameters.AddWithValue(
                                    "@SucursalActual",
                                    Sesion.SucursalActual);

                                cmd.Parameters.AddWithValue(
                                    "@NumeroOrden",
                                    ordenSeleccionadaActual);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaccion.Commit();

                        MessageBox.Show(
                            nuevoEstado == "Recibido"
                                ? "Orden recibida correctamente en esta sucursal."
                                : "Derivación rechazada correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        ordenSeleccionadaActual = "";

                        RefrescarTodo();
                        InicializarPanelDerechoEntrantes();
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();

                        MessageBox.Show(
                            "Error al procesar la derivación: " + ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        db.cerrarConexion();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error de conexión: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                db.cerrarConexion();
            }
        }

        private void btnNuevaDerivacion_Click(object sender, EventArgs e)
        {

        }

        private void flpIzquierdoS_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}