namespace Balanza
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.btnCambiarModo = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelGradientUser = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.picBoxUsuario = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelGradientLeft = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.picBoxSalir = new System.Windows.Forms.PictureBox();
            this.picBoxMovimientos = new System.Windows.Forms.PictureBox();
            this.picBoxAjustes = new System.Windows.Forms.PictureBox();
            this.picBoxMaestros = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.picBoxOperaciones = new System.Windows.Forms.PictureBox();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.picBoxBalanza = new System.Windows.Forms.PictureBox();
            this.btnMaestros = new System.Windows.Forms.Button();
            this.btnBalanza = new System.Windows.Forms.Button();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.fadeTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelGradientUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsuario)).BeginInit();
            this.panelGradientLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMaestros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOperaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBalanza)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelTop.Controls.Add(this.lblUbicacion);
            this.panelTop.Controls.Add(this.btnCambiarModo);
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.picBoxLogo);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.fadeTransition.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1120, 48);
            this.panelTop.TabIndex = 52;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblUbicacion, BunifuAnimatorNS.DecorationType.None);
            this.lblUbicacion.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUbicacion.Location = new System.Drawing.Point(573, 3);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(152, 41);
            this.lblUbicacion.TabIndex = 10;
            this.lblUbicacion.Text = "Balanza";
            this.lblUbicacion.Visible = false;
            // 
            // btnCambiarModo
            // 
            this.btnCambiarModo.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarModo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnCambiarModo, BunifuAnimatorNS.DecorationType.None);
            this.btnCambiarModo.FlatAppearance.BorderSize = 0;
            this.btnCambiarModo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCambiarModo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarModo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCambiarModo.ForeColor = System.Drawing.Color.White;
            this.btnCambiarModo.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarModo.Image")));
            this.btnCambiarModo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiarModo.Location = new System.Drawing.Point(202, 3);
            this.btnCambiarModo.Name = "btnCambiarModo";
            this.btnCambiarModo.Size = new System.Drawing.Size(181, 41);
            this.btnCambiarModo.TabIndex = 9;
            this.btnCambiarModo.Text = "Cambiar a registro";
            this.btnCambiarModo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCambiarModo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarModo.UseVisualStyleBackColor = false;
            this.btnCambiarModo.Visible = false;
            this.btnCambiarModo.Click += new System.EventHandler(this.btnCambiarModo_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::Balanza.Properties.Resources.icons8_minimizar_la_ventana_50__2_;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.Image = global::Balanza.Properties.Resources.icons8_minimizar_la_ventana_50__3_;
            this.btnMinimizar.Location = new System.Drawing.Point(1013, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(49, 48);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackgroundImage = global::Balanza.Properties.Resources.logo_nav_principal_pie;
            this.picBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fadeTransition.SetDecoration(this.picBoxLogo, BunifuAnimatorNS.DecorationType.None);
            this.picBoxLogo.Location = new System.Drawing.Point(6, 1);
            this.picBoxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(193, 44);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            this.picBoxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxLogo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::Balanza.Properties.Resources.icons8_cerrar_ventana_50__3_1;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.Image = global::Balanza.Properties.Resources.icons8_cerrar_ventana_50__5_;
            this.btnCerrar.Location = new System.Drawing.Point(1068, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(49, 48);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Fuchsia;
            this.panelLeft.Controls.Add(this.panelGradientUser);
            this.panelLeft.Controls.Add(this.panelGradientLeft);
            this.fadeTransition.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.panelLeft.Location = new System.Drawing.Point(0, 49);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 4, 1, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(199, 663);
            this.panelLeft.TabIndex = 53;
            // 
            // panelGradientUser
            // 
            this.panelGradientUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGradientUser.BackgroundImage")));
            this.panelGradientUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGradientUser.Controls.Add(this.picBoxUsuario);
            this.panelGradientUser.Controls.Add(this.lblUsuario);
            this.fadeTransition.SetDecoration(this.panelGradientUser, BunifuAnimatorNS.DecorationType.None);
            this.panelGradientUser.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelGradientUser.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelGradientUser.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelGradientUser.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelGradientUser.Location = new System.Drawing.Point(0, 0);
            this.panelGradientUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGradientUser.Name = "panelGradientUser";
            this.panelGradientUser.Quality = 10;
            this.panelGradientUser.Size = new System.Drawing.Size(199, 72);
            this.panelGradientUser.TabIndex = 11;
            // 
            // picBoxUsuario
            // 
            this.picBoxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.picBoxUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxUsuario.BackgroundImage")));
            this.picBoxUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fadeTransition.SetDecoration(this.picBoxUsuario, BunifuAnimatorNS.DecorationType.None);
            this.picBoxUsuario.Location = new System.Drawing.Point(3, 3);
            this.picBoxUsuario.Name = "picBoxUsuario";
            this.picBoxUsuario.Size = new System.Drawing.Size(60, 64);
            this.picBoxUsuario.TabIndex = 10;
            this.picBoxUsuario.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.fadeTransition.SetDecoration(this.lblUsuario, BunifuAnimatorNS.DecorationType.None);
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(69, 28);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 16);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelGradientLeft
            // 
            this.panelGradientLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGradientLeft.BackgroundImage")));
            this.panelGradientLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGradientLeft.Controls.Add(this.picBoxSalir);
            this.panelGradientLeft.Controls.Add(this.picBoxMovimientos);
            this.panelGradientLeft.Controls.Add(this.picBoxAjustes);
            this.panelGradientLeft.Controls.Add(this.picBoxMaestros);
            this.panelGradientLeft.Controls.Add(this.btnSalir);
            this.panelGradientLeft.Controls.Add(this.bunifuSeparator2);
            this.panelGradientLeft.Controls.Add(this.btnAjustes);
            this.panelGradientLeft.Controls.Add(this.picBoxOperaciones);
            this.panelGradientLeft.Controls.Add(this.btnMovimientos);
            this.panelGradientLeft.Controls.Add(this.picBoxBalanza);
            this.panelGradientLeft.Controls.Add(this.btnMaestros);
            this.panelGradientLeft.Controls.Add(this.btnBalanza);
            this.panelGradientLeft.Controls.Add(this.btnOperaciones);
            this.fadeTransition.SetDecoration(this.panelGradientLeft, BunifuAnimatorNS.DecorationType.None);
            this.panelGradientLeft.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelGradientLeft.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelGradientLeft.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelGradientLeft.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelGradientLeft.Location = new System.Drawing.Point(0, 78);
            this.panelGradientLeft.Margin = new System.Windows.Forms.Padding(2, 2, 3, 4);
            this.panelGradientLeft.Name = "panelGradientLeft";
            this.panelGradientLeft.Quality = 10;
            this.panelGradientLeft.Size = new System.Drawing.Size(199, 580);
            this.panelGradientLeft.TabIndex = 0;
            // 
            // picBoxSalir
            // 
            this.picBoxSalir.BackColor = System.Drawing.Color.Transparent;
            this.picBoxSalir.BackgroundImage = global::Balanza.Properties.Resources.icons8_salir_redondeado_501;
            this.picBoxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.picBoxSalir, BunifuAnimatorNS.DecorationType.None);
            this.picBoxSalir.Location = new System.Drawing.Point(3, 512);
            this.picBoxSalir.Name = "picBoxSalir";
            this.picBoxSalir.Size = new System.Drawing.Size(60, 51);
            this.picBoxSalir.TabIndex = 11;
            this.picBoxSalir.TabStop = false;
            this.picBoxSalir.MouseEnter += new System.EventHandler(this.picBoxSalir_MouseEnter);
            this.picBoxSalir.MouseLeave += new System.EventHandler(this.picBoxSalir_MouseLeave);
            // 
            // picBoxMovimientos
            // 
            this.picBoxMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMovimientos.BackgroundImage = global::Balanza.Properties.Resources.icons8_calendario_50__1_;
            this.picBoxMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.picBoxMovimientos, BunifuAnimatorNS.DecorationType.None);
            this.picBoxMovimientos.Location = new System.Drawing.Point(3, 334);
            this.picBoxMovimientos.Name = "picBoxMovimientos";
            this.picBoxMovimientos.Size = new System.Drawing.Size(60, 52);
            this.picBoxMovimientos.TabIndex = 7;
            this.picBoxMovimientos.TabStop = false;
            this.picBoxMovimientos.MouseEnter += new System.EventHandler(this.picBoxMovimientos_MouseEnter);
            this.picBoxMovimientos.MouseLeave += new System.EventHandler(this.picBoxMovimientos_MouseLeave);
            // 
            // picBoxAjustes
            // 
            this.picBoxAjustes.BackColor = System.Drawing.Color.Transparent;
            this.picBoxAjustes.BackgroundImage = global::Balanza.Properties.Resources.icons8_servicios_50;
            this.picBoxAjustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.picBoxAjustes, BunifuAnimatorNS.DecorationType.None);
            this.picBoxAjustes.Location = new System.Drawing.Point(3, 455);
            this.picBoxAjustes.Name = "picBoxAjustes";
            this.picBoxAjustes.Size = new System.Drawing.Size(60, 51);
            this.picBoxAjustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAjustes.TabIndex = 10;
            this.picBoxAjustes.TabStop = false;
            this.picBoxAjustes.MouseEnter += new System.EventHandler(this.picBoxAjustes_MouseEnter);
            this.picBoxAjustes.MouseLeave += new System.EventHandler(this.picBoxAjustes_MouseLeave);
            // 
            // picBoxMaestros
            // 
            this.picBoxMaestros.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMaestros.BackgroundImage = global::Balanza.Properties.Resources.icons8_base_de_datos_50;
            this.picBoxMaestros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxMaestros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.picBoxMaestros, BunifuAnimatorNS.DecorationType.None);
            this.picBoxMaestros.Location = new System.Drawing.Point(3, 224);
            this.picBoxMaestros.Name = "picBoxMaestros";
            this.picBoxMaestros.Size = new System.Drawing.Size(60, 52);
            this.picBoxMaestros.TabIndex = 6;
            this.picBoxMaestros.TabStop = false;
            this.picBoxMaestros.MouseEnter += new System.EventHandler(this.picBoxMaestros_MouseEnter);
            this.picBoxMaestros.MouseLeave += new System.EventHandler(this.picBoxMaestros_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnSalir, BunifuAnimatorNS.DecorationType.None);
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(63, 512);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 51);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.fadeTransition.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 2518;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 430);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(199, 5);
            this.bunifuSeparator2.TabIndex = 10;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnAjustes, BunifuAnimatorNS.DecorationType.None);
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.Location = new System.Drawing.Point(63, 455);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(130, 51);
            this.btnAjustes.TabIndex = 8;
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            this.btnAjustes.MouseEnter += new System.EventHandler(this.btnAjustes_MouseEnter);
            this.btnAjustes.MouseLeave += new System.EventHandler(this.btnAjustes_MouseLeave);
            // 
            // picBoxOperaciones
            // 
            this.picBoxOperaciones.BackColor = System.Drawing.Color.Transparent;
            this.picBoxOperaciones.BackgroundImage = global::Balanza.Properties.Resources.icons8_maletín_50;
            this.picBoxOperaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxOperaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.picBoxOperaciones, BunifuAnimatorNS.DecorationType.None);
            this.picBoxOperaciones.Location = new System.Drawing.Point(3, 114);
            this.picBoxOperaciones.Name = "picBoxOperaciones";
            this.picBoxOperaciones.Size = new System.Drawing.Size(60, 52);
            this.picBoxOperaciones.TabIndex = 5;
            this.picBoxOperaciones.TabStop = false;
            this.picBoxOperaciones.MouseEnter += new System.EventHandler(this.picBoxOperaciones_MouseEnter);
            this.picBoxOperaciones.MouseLeave += new System.EventHandler(this.picBoxOperaciones_MouseLeave);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.btnMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnMovimientos, BunifuAnimatorNS.DecorationType.None);
            this.btnMovimientos.FlatAppearance.BorderSize = 0;
            this.btnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimientos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMovimientos.ForeColor = System.Drawing.Color.White;
            this.btnMovimientos.Location = new System.Drawing.Point(63, 334);
            this.btnMovimientos.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(130, 52);
            this.btnMovimientos.TabIndex = 3;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovimientos.UseVisualStyleBackColor = false;
            this.btnMovimientos.Click += new System.EventHandler(this.button4_Click);
            this.btnMovimientos.MouseEnter += new System.EventHandler(this.btnMovimientos_MouseEnter);
            this.btnMovimientos.MouseLeave += new System.EventHandler(this.btnMovimientos_MouseLeave);
            // 
            // picBoxBalanza
            // 
            this.picBoxBalanza.BackColor = System.Drawing.Color.Transparent;
            this.picBoxBalanza.BackgroundImage = global::Balanza.Properties.Resources.icons8_camión_50;
            this.picBoxBalanza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxBalanza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.picBoxBalanza, BunifuAnimatorNS.DecorationType.None);
            this.picBoxBalanza.Location = new System.Drawing.Point(3, 4);
            this.picBoxBalanza.Name = "picBoxBalanza";
            this.picBoxBalanza.Size = new System.Drawing.Size(60, 52);
            this.picBoxBalanza.TabIndex = 4;
            this.picBoxBalanza.TabStop = false;
            this.picBoxBalanza.MouseEnter += new System.EventHandler(this.picBoxBalanza_MouseEnter);
            this.picBoxBalanza.MouseLeave += new System.EventHandler(this.picBoxBalanza_MouseLeave);
            // 
            // btnMaestros
            // 
            this.btnMaestros.BackColor = System.Drawing.Color.Transparent;
            this.btnMaestros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnMaestros, BunifuAnimatorNS.DecorationType.None);
            this.btnMaestros.FlatAppearance.BorderSize = 0;
            this.btnMaestros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaestros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMaestros.ForeColor = System.Drawing.Color.White;
            this.btnMaestros.Location = new System.Drawing.Point(63, 224);
            this.btnMaestros.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnMaestros.Name = "btnMaestros";
            this.btnMaestros.Size = new System.Drawing.Size(130, 52);
            this.btnMaestros.TabIndex = 2;
            this.btnMaestros.Text = "Maestros";
            this.btnMaestros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaestros.UseVisualStyleBackColor = false;
            this.btnMaestros.Click += new System.EventHandler(this.button3_Click);
            this.btnMaestros.MouseEnter += new System.EventHandler(this.btnMaestros_MouseEnter);
            this.btnMaestros.MouseLeave += new System.EventHandler(this.btnMaestros_MouseLeave);
            // 
            // btnBalanza
            // 
            this.btnBalanza.BackColor = System.Drawing.Color.Transparent;
            this.btnBalanza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnBalanza, BunifuAnimatorNS.DecorationType.None);
            this.btnBalanza.FlatAppearance.BorderSize = 0;
            this.btnBalanza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalanza.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBalanza.ForeColor = System.Drawing.Color.White;
            this.btnBalanza.Location = new System.Drawing.Point(63, 4);
            this.btnBalanza.Name = "btnBalanza";
            this.btnBalanza.Size = new System.Drawing.Size(130, 52);
            this.btnBalanza.TabIndex = 0;
            this.btnBalanza.Text = "Balanza";
            this.btnBalanza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBalanza.UseVisualStyleBackColor = false;
            this.btnBalanza.Click += new System.EventHandler(this.button1_Click_1);
            this.btnBalanza.MouseEnter += new System.EventHandler(this.btnBalanza_MouseEnter);
            this.btnBalanza.MouseLeave += new System.EventHandler(this.btnBalanza_MouseLeave);
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnOperaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnOperaciones, BunifuAnimatorNS.DecorationType.None);
            this.btnOperaciones.FlatAppearance.BorderSize = 0;
            this.btnOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOperaciones.ForeColor = System.Drawing.Color.White;
            this.btnOperaciones.Location = new System.Drawing.Point(63, 114);
            this.btnOperaciones.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(130, 52);
            this.btnOperaciones.TabIndex = 1;
            this.btnOperaciones.Text = "Operaciones";
            this.btnOperaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOperaciones.UseVisualStyleBackColor = false;
            this.btnOperaciones.Click += new System.EventHandler(this.button2_Click);
            this.btnOperaciones.MouseEnter += new System.EventHandler(this.btnOperaciones_MouseEnter);
            this.btnOperaciones.MouseLeave += new System.EventHandler(this.btnOperaciones_MouseLeave);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fadeTransition.SetDecoration(this.panelPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.panelPrincipal.Location = new System.Drawing.Point(202, 49);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(918, 659);
            this.panelPrincipal.TabIndex = 54;
            // 
            // fadeTransition
            // 
            this.fadeTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.fadeTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.fadeTransition.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1122, 712);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.fadeTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balanza Rusoft";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelGradientUser.ResumeLayout(false);
            this.panelGradientUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsuario)).EndInit();
            this.panelGradientLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMaestros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOperaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBalanza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelLeft;
        private Bunifu.Framework.UI.BunifuGradientPanel panelGradientLeft;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private BunifuAnimatorNS.BunifuTransition fadeTransition;
        private Bunifu.Framework.UI.BunifuGradientPanel panelGradientUser;
        private System.Windows.Forms.PictureBox picBoxUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsuario;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Button btnBalanza;
        private System.Windows.Forms.Button btnMaestros;
        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.PictureBox picBoxMovimientos;
        private System.Windows.Forms.PictureBox picBoxMaestros;
        private System.Windows.Forms.PictureBox picBoxOperaciones;
        private System.Windows.Forms.PictureBox picBoxBalanza;
        private System.Windows.Forms.PictureBox picBoxSalir;
        private System.Windows.Forms.PictureBox picBoxAjustes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Button btnCambiarModo;
        private System.Windows.Forms.Label lblUbicacion;
    }
}

