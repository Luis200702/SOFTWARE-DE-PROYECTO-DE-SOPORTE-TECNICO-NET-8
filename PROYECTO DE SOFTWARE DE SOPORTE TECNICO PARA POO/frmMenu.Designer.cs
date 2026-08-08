namespace PROYECTO_DE_SOFTWARE_DE_SOPORTE_TECNICO_PARA_POO
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            pnlContenedorMenu = new Panel();
            lblSeparador2 = new Label();
            lblAdministracion = new Label();
            lblComercial = new Label();
            btnConfiguracionGeneral = new Button();
            imageListBarrraMenu = new ImageList(components);
            btnGestionUsuarios = new Button();
            btnReportes = new Button();
            btnHistorialCliente = new Button();
            btnTradeIn = new Button();
            btnVentaDispositivos = new Button();
            btnDerivacionOrdenes = new Button();
            btnGestionStock = new Button();
            btnDevoluciónEntrega = new Button();
            btnSeguimientoReparaciones = new Button();
            btnRecepcionEquipos = new Button();
            lblSeparador3 = new Label();
            pnlContenedorLogotipo = new Panel();
            btnLogoMenu = new Button();
            ImagenListLogoMenu = new ImageList(components);
            label1 = new Label();
            pnlContenedorSalir = new Panel();
            btnSalirApp = new ReaLTaiizor.Controls.CyberButton();
            pnlInterfaces = new Panel();
            btnLogoPrincipal = new Button();
            imageListLogoPrincipal = new ImageList(components);
            timerDesplazamiento = new System.Windows.Forms.Timer(components);
            pnlContenedorMenu.SuspendLayout();
            pnlContenedorLogotipo.SuspendLayout();
            pnlContenedorSalir.SuspendLayout();
            pnlInterfaces.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedorMenu
            // 
            pnlContenedorMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlContenedorMenu.AutoSize = true;
            pnlContenedorMenu.BackColor = Color.FromArgb(10, 12, 30);
            pnlContenedorMenu.Controls.Add(lblSeparador2);
            pnlContenedorMenu.Controls.Add(lblAdministracion);
            pnlContenedorMenu.Controls.Add(lblComercial);
            pnlContenedorMenu.Controls.Add(btnConfiguracionGeneral);
            pnlContenedorMenu.Controls.Add(btnGestionUsuarios);
            pnlContenedorMenu.Controls.Add(btnReportes);
            pnlContenedorMenu.Controls.Add(btnHistorialCliente);
            pnlContenedorMenu.Controls.Add(btnTradeIn);
            pnlContenedorMenu.Controls.Add(btnVentaDispositivos);
            pnlContenedorMenu.Controls.Add(btnDerivacionOrdenes);
            pnlContenedorMenu.Controls.Add(btnGestionStock);
            pnlContenedorMenu.Controls.Add(btnDevoluciónEntrega);
            pnlContenedorMenu.Controls.Add(btnSeguimientoReparaciones);
            pnlContenedorMenu.Controls.Add(btnRecepcionEquipos);
            pnlContenedorMenu.Controls.Add(lblSeparador3);
            pnlContenedorMenu.Location = new Point(0, 90);
            pnlContenedorMenu.Name = "pnlContenedorMenu";
            pnlContenedorMenu.Size = new Size(223, 593);
            pnlContenedorMenu.TabIndex = 0;
            // 
            // lblSeparador2
            // 
            lblSeparador2.BackColor = Color.Transparent;
            lblSeparador2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeparador2.ForeColor = Color.FromArgb(155, 168, 171);
            lblSeparador2.Location = new Point(12, 236);
            lblSeparador2.Name = "lblSeparador2";
            lblSeparador2.Size = new Size(202, 18);
            lblSeparador2.TabIndex = 16;
            lblSeparador2.Text = "___________________________";
            // 
            // lblAdministracion
            // 
            lblAdministracion.BackColor = Color.Transparent;
            lblAdministracion.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdministracion.ForeColor = Color.DimGray;
            lblAdministracion.Location = new Point(27, 448);
            lblAdministracion.Name = "lblAdministracion";
            lblAdministracion.Size = new Size(105, 15);
            lblAdministracion.TabIndex = 14;
            lblAdministracion.Text = "ADMINISTRACIÓN";
            lblAdministracion.Visible = false;
            // 
            // lblComercial
            // 
            lblComercial.BackColor = Color.Transparent;
            lblComercial.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComercial.ForeColor = Color.DimGray;
            lblComercial.Location = new Point(27, 264);
            lblComercial.Name = "lblComercial";
            lblComercial.Size = new Size(70, 15);
            lblComercial.TabIndex = 3;
            lblComercial.Text = "COMERCIAL";
            // 
            // btnConfiguracionGeneral
            // 
            btnConfiguracionGeneral.BackColor = Color.Transparent;
            btnConfiguracionGeneral.FlatStyle = FlatStyle.Flat;
            btnConfiguracionGeneral.Font = new Font("Nirmala UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfiguracionGeneral.ForeColor = Color.FromArgb(155, 168, 171);
            btnConfiguracionGeneral.ImageIndex = 10;
            btnConfiguracionGeneral.ImageList = imageListBarrraMenu;
            btnConfiguracionGeneral.Location = new Point(14, 555);
            btnConfiguracionGeneral.Name = "btnConfiguracionGeneral";
            btnConfiguracionGeneral.Size = new Size(190, 35);
            btnConfiguracionGeneral.TabIndex = 13;
            btnConfiguracionGeneral.Text = "   Configuración                            ";
            btnConfiguracionGeneral.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracionGeneral.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracionGeneral.UseVisualStyleBackColor = false;
            btnConfiguracionGeneral.Visible = false;
            btnConfiguracionGeneral.Click += btnConfiguracionGeneral_Click;
            // 
            // imageListBarrraMenu
            // 
            imageListBarrraMenu.ColorDepth = ColorDepth.Depth32Bit;
            imageListBarrraMenu.ImageStream = (ImageListStreamer)resources.GetObject("imageListBarrraMenu.ImageStream");
            imageListBarrraMenu.TransparentColor = Color.Transparent;
            imageListBarrraMenu.Images.SetKeyName(0, "MynauiMonitor.png");
            imageListBarrraMenu.Images.SetKeyName(1, "StreamlineSharpMagnifyingGlass.png");
            imageListBarrraMenu.Images.SetKeyName(2, "MdiPackageVariantClosedCheck.png");
            imageListBarrraMenu.Images.SetKeyName(3, "MdiPackageVariantClosed.png");
            imageListBarrraMenu.Images.SetKeyName(4, "MynauiGitBranch.png");
            imageListBarrraMenu.Images.SetKeyName(5, "PhShoppingCartSimple.png");
            imageListBarrraMenu.Images.SetKeyName(6, "PhArrowsLeftRightLight.png");
            imageListBarrraMenu.Images.SetKeyName(7, "MynauiClock4.png");
            imageListBarrraMenu.Images.SetKeyName(8, "RiBarChartLine.png");
            imageListBarrraMenu.Images.SetKeyName(9, "FeatherUsers.png");
            imageListBarrraMenu.Images.SetKeyName(10, "AntDesignSettingOutlined.png");
            imageListBarrraMenu.Images.SetKeyName(11, "IconamoonExitLight.png");
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.BackColor = Color.Transparent;
            btnGestionUsuarios.FlatStyle = FlatStyle.Flat;
            btnGestionUsuarios.Font = new Font("Nirmala UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionUsuarios.ForeColor = Color.FromArgb(155, 168, 171);
            btnGestionUsuarios.ImageIndex = 9;
            btnGestionUsuarios.ImageList = imageListBarrraMenu;
            btnGestionUsuarios.Location = new Point(14, 516);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(190, 35);
            btnGestionUsuarios.TabIndex = 12;
            btnGestionUsuarios.Text = "   Gestión de Técnicos        ";
            btnGestionUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionUsuarios.UseVisualStyleBackColor = false;
            btnGestionUsuarios.Visible = false;
            btnGestionUsuarios.Click += btnGestionUsuarios_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.Transparent;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Nirmala UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.FromArgb(155, 168, 171);
            btnReportes.ImageIndex = 8;
            btnReportes.ImageList = imageListBarrraMenu;
            btnReportes.Location = new Point(14, 473);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(190, 35);
            btnReportes.TabIndex = 11;
            btnReportes.Text = "   Reportes                                     ";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Visible = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnHistorialCliente
            // 
            btnHistorialCliente.BackColor = Color.Transparent;
            btnHistorialCliente.FlatStyle = FlatStyle.Flat;
            btnHistorialCliente.Font = new Font("Nirmala UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorialCliente.ForeColor = Color.FromArgb(155, 168, 171);
            btnHistorialCliente.ImageIndex = 7;
            btnHistorialCliente.ImageList = imageListBarrraMenu;
            btnHistorialCliente.Location = new Point(14, 371);
            btnHistorialCliente.Name = "btnHistorialCliente";
            btnHistorialCliente.Size = new Size(190, 35);
            btnHistorialCliente.TabIndex = 10;
            btnHistorialCliente.Text = "   Historial de Clientes                ";
            btnHistorialCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorialCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistorialCliente.UseVisualStyleBackColor = false;
            btnHistorialCliente.Click += btnHistorialCliente_Click;
            // 
            // btnTradeIn
            // 
            btnTradeIn.BackColor = Color.Transparent;
            btnTradeIn.FlatStyle = FlatStyle.Flat;
            btnTradeIn.Font = new Font("Nirmala UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTradeIn.ForeColor = Color.FromArgb(155, 168, 171);
            btnTradeIn.ImageIndex = 6;
            btnTradeIn.ImageList = imageListBarrraMenu;
            btnTradeIn.Location = new Point(14, 330);
            btnTradeIn.Name = "btnTradeIn";
            btnTradeIn.Size = new Size(190, 35);
            btnTradeIn.TabIndex = 9;
            btnTradeIn.Text = "   Trade-In                                         ";
            btnTradeIn.TextAlign = ContentAlignment.MiddleLeft;
            btnTradeIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTradeIn.UseVisualStyleBackColor = false;
            btnTradeIn.Click += btnTradeIn_Click;
            // 
            // btnVentaDispositivos
            // 
            btnVentaDispositivos.BackColor = Color.Transparent;
            btnVentaDispositivos.FlatStyle = FlatStyle.Flat;
            btnVentaDispositivos.Font = new Font("Nirmala UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentaDispositivos.ForeColor = Color.FromArgb(155, 168, 171);
            btnVentaDispositivos.ImageIndex = 5;
            btnVentaDispositivos.ImageList = imageListBarrraMenu;
            btnVentaDispositivos.Location = new Point(14, 289);
            btnVentaDispositivos.Name = "btnVentaDispositivos";
            btnVentaDispositivos.Size = new Size(190, 35);
            btnVentaDispositivos.TabIndex = 8;
            btnVentaDispositivos.Text = "   Venta de Dispositivos            ";
            btnVentaDispositivos.TextAlign = ContentAlignment.MiddleLeft;
            btnVentaDispositivos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentaDispositivos.UseVisualStyleBackColor = false;
            btnVentaDispositivos.Click += btnVentaDispositivos_Click;
            // 
            // btnDerivacionOrdenes
            // 
            btnDerivacionOrdenes.BackColor = Color.Transparent;
            btnDerivacionOrdenes.FlatStyle = FlatStyle.Flat;
            btnDerivacionOrdenes.Font = new Font("Nirmala UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDerivacionOrdenes.ForeColor = Color.FromArgb(155, 168, 171);
            btnDerivacionOrdenes.ImageIndex = 4;
            btnDerivacionOrdenes.ImageList = imageListBarrraMenu;
            btnDerivacionOrdenes.Location = new Point(14, 188);
            btnDerivacionOrdenes.Name = "btnDerivacionOrdenes";
            btnDerivacionOrdenes.Size = new Size(190, 35);
            btnDerivacionOrdenes.TabIndex = 7;
            btnDerivacionOrdenes.Text = "   Derivación entre Sucursales ";
            btnDerivacionOrdenes.TextAlign = ContentAlignment.MiddleLeft;
            btnDerivacionOrdenes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDerivacionOrdenes.UseVisualStyleBackColor = false;
            btnDerivacionOrdenes.Click += btnDerivacionOrdenes_Click;
            // 
            // btnGestionStock
            // 
            btnGestionStock.BackColor = Color.Transparent;
            btnGestionStock.FlatStyle = FlatStyle.Flat;
            btnGestionStock.Font = new Font("Nirmala UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionStock.ForeColor = Color.FromArgb(155, 168, 171);
            btnGestionStock.ImageIndex = 3;
            btnGestionStock.ImageList = imageListBarrraMenu;
            btnGestionStock.Location = new Point(14, 147);
            btnGestionStock.Name = "btnGestionStock";
            btnGestionStock.Size = new Size(190, 35);
            btnGestionStock.TabIndex = 6;
            btnGestionStock.Text = "   Control de Stock                            ";
            btnGestionStock.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionStock.UseVisualStyleBackColor = false;
            btnGestionStock.Click += btnGestionStock_Click;
            // 
            // btnDevoluciónEntrega
            // 
            btnDevoluciónEntrega.BackColor = Color.Transparent;
            btnDevoluciónEntrega.FlatStyle = FlatStyle.Flat;
            btnDevoluciónEntrega.Font = new Font("Nirmala UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDevoluciónEntrega.ForeColor = Color.FromArgb(155, 168, 171);
            btnDevoluciónEntrega.ImageIndex = 2;
            btnDevoluciónEntrega.ImageList = imageListBarrraMenu;
            btnDevoluciónEntrega.Location = new Point(14, 106);
            btnDevoluciónEntrega.Name = "btnDevoluciónEntrega";
            btnDevoluciónEntrega.Size = new Size(190, 35);
            btnDevoluciónEntrega.TabIndex = 5;
            btnDevoluciónEntrega.Text = "   Devolución / Entrega                    ";
            btnDevoluciónEntrega.TextAlign = ContentAlignment.MiddleLeft;
            btnDevoluciónEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDevoluciónEntrega.UseVisualStyleBackColor = false;
            btnDevoluciónEntrega.Click += btnDevoluciónEntrega_Click;
            // 
            // btnSeguimientoReparaciones
            // 
            btnSeguimientoReparaciones.BackColor = Color.Transparent;
            btnSeguimientoReparaciones.FlatStyle = FlatStyle.Flat;
            btnSeguimientoReparaciones.Font = new Font("Nirmala UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeguimientoReparaciones.ForeColor = Color.FromArgb(155, 168, 171);
            btnSeguimientoReparaciones.ImageIndex = 1;
            btnSeguimientoReparaciones.ImageList = imageListBarrraMenu;
            btnSeguimientoReparaciones.Location = new Point(14, 65);
            btnSeguimientoReparaciones.Name = "btnSeguimientoReparaciones";
            btnSeguimientoReparaciones.Size = new Size(190, 35);
            btnSeguimientoReparaciones.TabIndex = 4;
            btnSeguimientoReparaciones.Text = "   Seguimiento de Reparaciones";
            btnSeguimientoReparaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnSeguimientoReparaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSeguimientoReparaciones.UseVisualStyleBackColor = false;
            btnSeguimientoReparaciones.Click += btnSeguimientoReparaciones_Click;
            // 
            // btnRecepcionEquipos
            // 
            btnRecepcionEquipos.BackColor = Color.Transparent;
            btnRecepcionEquipos.FlatStyle = FlatStyle.Flat;
            btnRecepcionEquipos.Font = new Font("Nirmala UI", 6.75F, FontStyle.Bold);
            btnRecepcionEquipos.ForeColor = Color.FromArgb(155, 168, 171);
            btnRecepcionEquipos.ImageIndex = 0;
            btnRecepcionEquipos.ImageList = imageListBarrraMenu;
            btnRecepcionEquipos.Location = new Point(14, 24);
            btnRecepcionEquipos.Name = "btnRecepcionEquipos";
            btnRecepcionEquipos.Size = new Size(190, 35);
            btnRecepcionEquipos.TabIndex = 3;
            btnRecepcionEquipos.Text = "    Recepción de Equipos             ";
            btnRecepcionEquipos.TextAlign = ContentAlignment.MiddleLeft;
            btnRecepcionEquipos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecepcionEquipos.UseVisualStyleBackColor = false;
            btnRecepcionEquipos.Click += btnRecepcionEquipos_Click;
            // 
            // lblSeparador3
            // 
            lblSeparador3.BackColor = Color.Transparent;
            lblSeparador3.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeparador3.ForeColor = Color.FromArgb(155, 168, 171);
            lblSeparador3.Location = new Point(12, 418);
            lblSeparador3.Name = "lblSeparador3";
            lblSeparador3.Size = new Size(202, 18);
            lblSeparador3.TabIndex = 15;
            lblSeparador3.Text = "___________________________";
            // 
            // pnlContenedorLogotipo
            // 
            pnlContenedorLogotipo.BackColor = Color.FromArgb(10, 12, 30);
            pnlContenedorLogotipo.Controls.Add(btnLogoMenu);
            pnlContenedorLogotipo.Controls.Add(label1);
            pnlContenedorLogotipo.Location = new Point(0, 0);
            pnlContenedorLogotipo.Name = "pnlContenedorLogotipo";
            pnlContenedorLogotipo.Size = new Size(223, 90);
            pnlContenedorLogotipo.TabIndex = 1;
            // 
            // btnLogoMenu
            // 
            btnLogoMenu.BackColor = Color.Transparent;
            btnLogoMenu.Enabled = false;
            btnLogoMenu.FlatAppearance.BorderColor = Color.FromArgb(10, 12, 30);
            btnLogoMenu.FlatStyle = FlatStyle.Flat;
            btnLogoMenu.ImageIndex = 0;
            btnLogoMenu.ImageList = ImagenListLogoMenu;
            btnLogoMenu.Location = new Point(67, 12);
            btnLogoMenu.Name = "btnLogoMenu";
            btnLogoMenu.Size = new Size(82, 66);
            btnLogoMenu.TabIndex = 18;
            btnLogoMenu.UseVisualStyleBackColor = false;
            // 
            // ImagenListLogoMenu
            // 
            ImagenListLogoMenu.ColorDepth = ColorDepth.Depth32Bit;
            ImagenListLogoMenu.ImageStream = (ImageListStreamer)resources.GetObject("ImagenListLogoMenu.ImageStream");
            ImagenListLogoMenu.TransparentColor = Color.Transparent;
            ImagenListLogoMenu.Images.SetKeyName(0, "LogotipoProyectoSd.png");
            ImagenListLogoMenu.Images.SetKeyName(1, "LogotipoProyecto.png");
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(155, 168, 171);
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(202, 18);
            label1.TabIndex = 17;
            label1.Text = "___________________________";
            // 
            // pnlContenedorSalir
            // 
            pnlContenedorSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlContenedorSalir.BackColor = Color.FromArgb(10, 12, 30);
            pnlContenedorSalir.Controls.Add(btnSalirApp);
            pnlContenedorSalir.Location = new Point(0, 654);
            pnlContenedorSalir.Name = "pnlContenedorSalir";
            pnlContenedorSalir.Size = new Size(220, 95);
            pnlContenedorSalir.TabIndex = 2;
            // 
            // btnSalirApp
            // 
            btnSalirApp.Alpha = 20;
            btnSalirApp.BackColor = Color.Transparent;
            btnSalirApp.Background = true;
            btnSalirApp.Background_WidthPen = 4F;
            btnSalirApp.BackgroundPen = true;
            btnSalirApp.ColorBackground = Color.FromArgb(10, 12, 30);
            btnSalirApp.ColorBackground_1 = Color.FromArgb(50, 52, 68);
            btnSalirApp.ColorBackground_2 = Color.FromArgb(26, 28, 44);
            btnSalirApp.ColorBackground_Pen = Color.FromArgb(10, 12, 30);
            btnSalirApp.ColorLighting = Color.FromArgb(10, 12, 30);
            btnSalirApp.ColorPen_1 = Color.FromArgb(6, 20, 27);
            btnSalirApp.ColorPen_2 = Color.FromArgb(6, 20, 27);
            btnSalirApp.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSalirApp.Effect_1 = false;
            btnSalirApp.Effect_1_ColorBackground = Color.FromArgb(255, 111, 111);
            btnSalirApp.Effect_1_Transparency = 100;
            btnSalirApp.Effect_2 = true;
            btnSalirApp.Effect_2_ColorBackground = Color.FromArgb(255, 111, 111);
            btnSalirApp.Effect_2_Transparency = 180;
            btnSalirApp.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalirApp.ForeColor = Color.FromArgb(155, 168, 171);
            btnSalirApp.Lighting = false;
            btnSalirApp.LinearGradient_Background = true;
            btnSalirApp.LinearGradientPen = false;
            btnSalirApp.Location = new Point(12, 43);
            btnSalirApp.Name = "btnSalirApp";
            btnSalirApp.PenWidth = 15;
            btnSalirApp.Rounding = true;
            btnSalirApp.RoundingInt = 80;
            btnSalirApp.Size = new Size(192, 40);
            btnSalirApp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSalirApp.TabIndex = 3;
            btnSalirApp.Tag = "Cyber";
            btnSalirApp.TextButton = "Salir";
            btnSalirApp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSalirApp.Timer_Effect_1 = 5;
            btnSalirApp.Timer_RGB = 300;
            btnSalirApp.Click += btnSalirApp_Click;
            // 
            // pnlInterfaces
            // 
            pnlInterfaces.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlInterfaces.AutoSize = true;
            pnlInterfaces.BackColor = Color.FromArgb(24, 35, 54);
            pnlInterfaces.Controls.Add(btnLogoPrincipal);
            pnlInterfaces.Location = new Point(220, 0);
            pnlInterfaces.Name = "pnlInterfaces";
            pnlInterfaces.Size = new Size(1025, 752);
            pnlInterfaces.TabIndex = 3;
            // 
            // btnLogoPrincipal
            // 
            btnLogoPrincipal.AutoSize = true;
            btnLogoPrincipal.Enabled = false;
            btnLogoPrincipal.FlatAppearance.BorderColor = Color.FromArgb(24, 35, 54);
            btnLogoPrincipal.FlatStyle = FlatStyle.Flat;
            btnLogoPrincipal.ImageIndex = 0;
            btnLogoPrincipal.ImageList = imageListLogoPrincipal;
            btnLogoPrincipal.Location = new Point(381, 255);
            btnLogoPrincipal.Name = "btnLogoPrincipal";
            btnLogoPrincipal.Size = new Size(264, 264);
            btnLogoPrincipal.TabIndex = 0;
            btnLogoPrincipal.UseVisualStyleBackColor = true;
            // 
            // imageListLogoPrincipal
            // 
            imageListLogoPrincipal.ColorDepth = ColorDepth.Depth32Bit;
            imageListLogoPrincipal.ImageStream = (ImageListStreamer)resources.GetObject("imageListLogoPrincipal.ImageStream");
            imageListLogoPrincipal.TransparentColor = Color.Transparent;
            imageListLogoPrincipal.Images.SetKeyName(0, "LogotipoProyecto.png");
            // 
            // timerDesplazamiento
            // 
            timerDesplazamiento.Interval = 1;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 35, 54);
            ClientSize = new Size(1242, 749);
            Controls.Add(pnlInterfaces);
            Controls.Add(pnlContenedorSalir);
            Controls.Add(pnlContenedorLogotipo);
            Controls.Add(pnlContenedorMenu);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            FormClosing += frmMenu_FormClosing;
            pnlContenedorMenu.ResumeLayout(false);
            pnlContenedorLogotipo.ResumeLayout(false);
            pnlContenedorSalir.ResumeLayout(false);
            pnlInterfaces.ResumeLayout(false);
            pnlInterfaces.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlContenedorMenu;
        private Panel pnlContenedorLogotipo;
        private Panel pnlContenedorSalir;
        private Button btnConfiguracionGeneral;
        private Button btnGestionUsuarios;
        private Button btnReportes;
        private Button btnHistorialCliente;
        private Button btnTradeIn;
        private Button btnVentaDispositivos;
        private Button btnDerivacionOrdenes;
        private Button btnGestionStock;
        private Button btnDevoluciónEntrega;
        private Button btnSeguimientoReparaciones;
        private Button btnRecepcionEquipos;
        private Label lblComercial;
        private Label lblAdministracion;
        private Label lblSeparador3;
        private Label lblSeparador2;
        private ReaLTaiizor.Controls.CyberButton btnSalirApp;
        private Panel pnlInterfaces;
        private System.Windows.Forms.Timer timerDesplazamiento;
        private ImageList imageListBarrraMenu;
        private Label label1;
        private Button btnLogoMenu;
        private ImageList ImagenListLogoMenu;
        private ImageList imageListLogoPrincipal;
        private Button btnLogoPrincipal;
        //private ToggleSwitch toggleSwitch1; =================================================================================================================
    }
}