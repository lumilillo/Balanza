namespace Balanza.Componentes
{
    partial class AsigntarTarjetaControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsigntarTarjetaControl));
            this.cardMenu = new Bunifu.Framework.UI.BunifuCards();
            this.lblTarjetaError = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSinRegistro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lblPuertosCardIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picActualizar = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.switchLectorTarjeta = new Bunifu.Framework.UI.BunifuSwitch();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblNroTarjeta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnFinalizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProveedor = new System.Windows.Forms.TabPage();
            this.proveedorCard = new Bunifu.Framework.UI.BunifuCards();
            this.panelMaterial = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaterial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cBoxMateriales = new System.Windows.Forms.ComboBox();
            this.panelPatenteAcoplado = new System.Windows.Forms.Panel();
            this.txtPatente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelTipoMovimiento = new System.Windows.Forms.Panel();
            this.lblRequerido1 = new System.Windows.Forms.Label();
            this.radDescarga = new System.Windows.Forms.RadioButton();
            this.radCarga = new System.Windows.Forms.RadioButton();
            this.raddevolucion = new System.Windows.Forms.RadioButton();
            this.txtTipoMovimiento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelNombrefletero = new System.Windows.Forms.Panel();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelTipoCamion = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTipoCamion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cBoxTipoCamion = new System.Windows.Forms.ComboBox();
            this.panelClienteProveedor = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProveedores = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cBoxCliente = new System.Windows.Forms.ComboBox();
            this.cBoxProveedor = new System.Windows.Forms.ComboBox();
            this.panelCBoxCamion = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCamion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cBoxCamiones = new System.Windows.Forms.ComboBox();
            this.panelEntidad = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEntidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.radProveedor = new System.Windows.Forms.RadioButton();
            this.radCliente = new System.Windows.Forms.RadioButton();
            this.tabObservaciones = new System.Windows.Forms.TabPage();
            this.observacionesCard = new Bunifu.Framework.UI.BunifuCards();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtBoxObservaciones = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lectorCOM = new System.IO.Ports.SerialPort(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cardMenu.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picActualizar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabProveedor.SuspendLayout();
            this.proveedorCard.SuspendLayout();
            this.panelMaterial.SuspendLayout();
            this.panelPatenteAcoplado.SuspendLayout();
            this.panelTipoMovimiento.SuspendLayout();
            this.panelNombrefletero.SuspendLayout();
            this.panelTipoCamion.SuspendLayout();
            this.panelClienteProveedor.SuspendLayout();
            this.panelCBoxCamion.SuspendLayout();
            this.panelEntidad.SuspendLayout();
            this.tabObservaciones.SuspendLayout();
            this.observacionesCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardMenu
            // 
            this.cardMenu.BackColor = System.Drawing.Color.White;
            this.cardMenu.BorderRadius = 0;
            this.cardMenu.BottomSahddow = false;
            this.cardMenu.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.cardMenu.Controls.Add(this.lblTarjetaError);
            this.cardMenu.Controls.Add(this.lblSinRegistro);
            this.cardMenu.Controls.Add(this.bunifuCards2);
            this.cardMenu.Controls.Add(this.txtTarjeta);
            this.cardMenu.Controls.Add(this.lblNroTarjeta);
            this.cardMenu.Controls.Add(this.btnFinalizar);
            this.cardMenu.Controls.Add(this.tabControl1);
            this.cardMenu.LeftSahddow = false;
            this.cardMenu.Location = new System.Drawing.Point(0, 0);
            this.cardMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cardMenu.Name = "cardMenu";
            this.cardMenu.RightSahddow = false;
            this.cardMenu.ShadowDepth = 50;
            this.cardMenu.Size = new System.Drawing.Size(918, 583);
            this.cardMenu.TabIndex = 3;
            // 
            // lblTarjetaError
            // 
            this.lblTarjetaError.AutoSize = true;
            this.lblTarjetaError.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjetaError.ForeColor = System.Drawing.Color.Crimson;
            this.lblTarjetaError.Location = new System.Drawing.Point(265, 11);
            this.lblTarjetaError.Name = "lblTarjetaError";
            this.lblTarjetaError.Size = new System.Drawing.Size(139, 21);
            this.lblTarjetaError.TabIndex = 42;
            this.lblTarjetaError.Text = "¡Tarjeta invalida!";
            this.lblTarjetaError.Visible = false;
            // 
            // lblSinRegistro
            // 
            this.lblSinRegistro.AutoSize = true;
            this.lblSinRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinRegistro.ForeColor = System.Drawing.Color.Crimson;
            this.lblSinRegistro.Location = new System.Drawing.Point(237, 11);
            this.lblSinRegistro.Name = "lblSinRegistro";
            this.lblSinRegistro.Size = new System.Drawing.Size(163, 21);
            this.lblSinRegistro.TabIndex = 41;
            this.lblSinRegistro.Text = "¡Tarjeta sin registros!";
            this.lblSinRegistro.Visible = false;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 0;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Gray;
            this.bunifuCards2.Controls.Add(this.lblPuertosCardIndice);
            this.bunifuCards2.Controls.Add(this.picActualizar);
            this.bunifuCards2.Controls.Add(this.bunifuSeparator5);
            this.bunifuCards2.Controls.Add(this.switchLectorTarjeta);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(626, 11);
            this.bunifuCards2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = false;
            this.bunifuCards2.ShadowDepth = 30;
            this.bunifuCards2.Size = new System.Drawing.Size(268, 79);
            this.bunifuCards2.TabIndex = 40;
            this.bunifuCards2.Click += new System.EventHandler(this.bunifuSeparator5_Click);
            // 
            // lblPuertosCardIndice
            // 
            this.lblPuertosCardIndice.AutoSize = true;
            this.lblPuertosCardIndice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertosCardIndice.ForeColor = System.Drawing.Color.Black;
            this.lblPuertosCardIndice.Location = new System.Drawing.Point(3, 7);
            this.lblPuertosCardIndice.Name = "lblPuertosCardIndice";
            this.lblPuertosCardIndice.Size = new System.Drawing.Size(60, 18);
            this.lblPuertosCardIndice.TabIndex = 43;
            this.lblPuertosCardIndice.Text = "Puertos";
            // 
            // picActualizar
            // 
            this.picActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picActualizar.Image = global::Balanza.Properties.Resources.icons8_17387_0_73139_actualizar_izquierda_32_flechas_50;
            this.picActualizar.Location = new System.Drawing.Point(220, 4);
            this.picActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picActualizar.Name = "picActualizar";
            this.picActualizar.Size = new System.Drawing.Size(35, 37);
            this.picActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picActualizar.TabIndex = 78;
            this.picActualizar.TabStop = false;
            this.toolTip1.SetToolTip(this.picActualizar, "Actualizar Puertos");
            this.picActualizar.Click += new System.EventHandler(this.picActualizar_Click);
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(8, 32);
            this.bunifuSeparator5.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(140, 12);
            this.bunifuSeparator5.TabIndex = 31;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            this.bunifuSeparator5.Click += new System.EventHandler(this.bunifuSeparator5_Click);
            // 
            // switchLectorTarjeta
            // 
            this.switchLectorTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchLectorTarjeta.BorderRadius = 5;
            this.switchLectorTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchLectorTarjeta.Enabled = false;
            this.switchLectorTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchLectorTarjeta.Location = new System.Drawing.Point(196, 46);
            this.switchLectorTarjeta.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.switchLectorTarjeta.Name = "switchLectorTarjeta";
            this.switchLectorTarjeta.Oncolor = System.Drawing.Color.LimeGreen;
            this.switchLectorTarjeta.Onoffcolor = System.Drawing.Color.Red;
            this.switchLectorTarjeta.Size = new System.Drawing.Size(51, 19);
            this.switchLectorTarjeta.TabIndex = 29;
            this.switchLectorTarjeta.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchLectorTarjeta.Value = false;
            this.switchLectorTarjeta.Click += new System.EventHandler(this.bunifuSeparator5_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(3, 44);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(114, 20);
            this.bunifuCustomLabel7.TabIndex = 26;
            this.bunifuCustomLabel7.Text = "Lector Tarjetas";
            this.bunifuCustomLabel7.Click += new System.EventHandler(this.bunifuSeparator5_Click);
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Enabled = false;
            this.txtTarjeta.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjeta.Location = new System.Drawing.Point(19, 39);
            this.txtTarjeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(410, 41);
            this.txtTarjeta.TabIndex = 33;
            this.txtTarjeta.TabStop = false;
            this.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNroTarjeta
            // 
            this.lblNroTarjeta.AutoSize = true;
            this.lblNroTarjeta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroTarjeta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNroTarjeta.Location = new System.Drawing.Point(16, 11);
            this.lblNroTarjeta.Name = "lblNroTarjeta";
            this.lblNroTarjeta.Size = new System.Drawing.Size(87, 21);
            this.lblNroTarjeta.TabIndex = 18;
            this.lblNroTarjeta.Text = "N° Tarjeta";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.ActiveBorderThickness = 2;
            this.btnFinalizar.ActiveCornerRadius = 20;
            this.btnFinalizar.ActiveFillColor = System.Drawing.Color.White;
            this.btnFinalizar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnFinalizar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnFinalizar.BackColor = System.Drawing.Color.White;
            this.btnFinalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.BackgroundImage")));
            this.btnFinalizar.ButtonText = "Finalizar";
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFinalizar.IdleBorderThickness = 1;
            this.btnFinalizar.IdleCornerRadius = 20;
            this.btnFinalizar.IdleFillColor = System.Drawing.Color.White;
            this.btnFinalizar.IdleForecolor = System.Drawing.SystemColors.ControlDark;
            this.btnFinalizar.IdleLineColor = System.Drawing.SystemColors.ControlDark;
            this.btnFinalizar.Location = new System.Drawing.Point(713, 529);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(181, 53);
            this.btnFinalizar.TabIndex = 16;
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            this.btnFinalizar.Enter += new System.EventHandler(this.btnFinalizar_Enter);
            this.btnFinalizar.Leave += new System.EventHandler(this.btnFinalizar_Leave);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProveedor);
            this.tabControl1.Controls.Add(this.tabObservaciones);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl1.Location = new System.Drawing.Point(19, 89);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(875, 441);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 15;
            // 
            // tabProveedor
            // 
            this.tabProveedor.Controls.Add(this.proveedorCard);
            this.tabProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProveedor.Location = new System.Drawing.Point(4, 29);
            this.tabProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProveedor.Name = "tabProveedor";
            this.tabProveedor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProveedor.Size = new System.Drawing.Size(867, 408);
            this.tabProveedor.TabIndex = 1;
            this.tabProveedor.Text = "Movimiento";
            this.tabProveedor.UseVisualStyleBackColor = true;
            // 
            // proveedorCard
            // 
            this.proveedorCard.BackColor = System.Drawing.Color.White;
            this.proveedorCard.BorderRadius = 0;
            this.proveedorCard.BottomSahddow = false;
            this.proveedorCard.color = System.Drawing.Color.Black;
            this.proveedorCard.Controls.Add(this.panelMaterial);
            this.proveedorCard.Controls.Add(this.panelPatenteAcoplado);
            this.proveedorCard.Controls.Add(this.panelTipoMovimiento);
            this.proveedorCard.Controls.Add(this.panelNombrefletero);
            this.proveedorCard.Controls.Add(this.panelTipoCamion);
            this.proveedorCard.Controls.Add(this.panelClienteProveedor);
            this.proveedorCard.Controls.Add(this.panelCBoxCamion);
            this.proveedorCard.Controls.Add(this.panelEntidad);
            this.proveedorCard.LeftSahddow = false;
            this.proveedorCard.Location = new System.Drawing.Point(-5, 0);
            this.proveedorCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.proveedorCard.Name = "proveedorCard";
            this.proveedorCard.RightSahddow = false;
            this.proveedorCard.ShadowDepth = 20;
            this.proveedorCard.Size = new System.Drawing.Size(951, 405);
            this.proveedorCard.TabIndex = 2;
            // 
            // panelMaterial
            // 
            this.panelMaterial.Controls.Add(this.label11);
            this.panelMaterial.Controls.Add(this.txtMaterial);
            this.panelMaterial.Controls.Add(this.cBoxMateriales);
            this.panelMaterial.Location = new System.Drawing.Point(446, 20);
            this.panelMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMaterial.Name = "panelMaterial";
            this.panelMaterial.Size = new System.Drawing.Size(420, 94);
            this.panelMaterial.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(390, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 24);
            this.label11.TabIndex = 45;
            this.label11.Text = "*";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaterial.Enabled = false;
            this.txtMaterial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaterial.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaterial.HintText = "Material";
            this.txtMaterial.isPassword = false;
            this.txtMaterial.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtMaterial.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaterial.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtMaterial.LineThickness = 4;
            this.txtMaterial.Location = new System.Drawing.Point(36, 7);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(373, 42);
            this.txtMaterial.TabIndex = 14;
            this.txtMaterial.TabStop = false;
            this.txtMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaterial.MouseEnter += new System.EventHandler(this.cBoxMateriales_MouseEnter);
            this.txtMaterial.MouseLeave += new System.EventHandler(this.cBoxMateriales_MouseLeave);
            // 
            // cBoxMateriales
            // 
            this.cBoxMateriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxMateriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxMateriales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMateriales.FormattingEnabled = true;
            this.cBoxMateriales.Location = new System.Drawing.Point(36, 54);
            this.cBoxMateriales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxMateriales.Name = "cBoxMateriales";
            this.cBoxMateriales.Size = new System.Drawing.Size(373, 29);
            this.cBoxMateriales.TabIndex = 4;
            this.cBoxMateriales.MouseEnter += new System.EventHandler(this.cBoxMateriales_MouseEnter);
            this.cBoxMateriales.MouseLeave += new System.EventHandler(this.cBoxMateriales_MouseLeave);
            // 
            // panelPatenteAcoplado
            // 
            this.panelPatenteAcoplado.Controls.Add(this.txtPatente);
            this.panelPatenteAcoplado.Location = new System.Drawing.Point(446, 322);
            this.panelPatenteAcoplado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPatenteAcoplado.Name = "panelPatenteAcoplado";
            this.panelPatenteAcoplado.Size = new System.Drawing.Size(420, 94);
            this.panelPatenteAcoplado.TabIndex = 39;
            // 
            // txtPatente
            // 
            this.txtPatente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.ForeColor = System.Drawing.Color.Black;
            this.txtPatente.HintForeColor = System.Drawing.Color.Empty;
            this.txtPatente.HintText = "Patente Acoplado...";
            this.txtPatente.isPassword = false;
            this.txtPatente.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtPatente.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPatente.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtPatente.LineThickness = 4;
            this.txtPatente.Location = new System.Drawing.Point(36, 6);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(373, 42);
            this.txtPatente.TabIndex = 11;
            this.txtPatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPatente.Leave += new System.EventHandler(this.txtPatente_Leave);
            this.txtPatente.MouseEnter += new System.EventHandler(this.txtPatente_MouseEnter);
            this.txtPatente.MouseLeave += new System.EventHandler(this.txtPatente_MouseLeave);
            // 
            // panelTipoMovimiento
            // 
            this.panelTipoMovimiento.Controls.Add(this.lblRequerido1);
            this.panelTipoMovimiento.Controls.Add(this.radDescarga);
            this.panelTipoMovimiento.Controls.Add(this.radCarga);
            this.panelTipoMovimiento.Controls.Add(this.raddevolucion);
            this.panelTipoMovimiento.Controls.Add(this.txtTipoMovimiento);
            this.panelTipoMovimiento.Location = new System.Drawing.Point(11, 20);
            this.panelTipoMovimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTipoMovimiento.Name = "panelTipoMovimiento";
            this.panelTipoMovimiento.Size = new System.Drawing.Size(420, 94);
            this.panelTipoMovimiento.TabIndex = 35;
            // 
            // lblRequerido1
            // 
            this.lblRequerido1.AutoSize = true;
            this.lblRequerido1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido1.ForeColor = System.Drawing.Color.Crimson;
            this.lblRequerido1.Location = new System.Drawing.Point(356, 6);
            this.lblRequerido1.Name = "lblRequerido1";
            this.lblRequerido1.Size = new System.Drawing.Size(19, 24);
            this.lblRequerido1.TabIndex = 45;
            this.lblRequerido1.Text = "*";
            // 
            // radDescarga
            // 
            this.radDescarga.AutoSize = true;
            this.radDescarga.Checked = true;
            this.radDescarga.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radDescarga.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radDescarga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radDescarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radDescarga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDescarga.Location = new System.Drawing.Point(7, 58);
            this.radDescarga.Margin = new System.Windows.Forms.Padding(3, 37, 3, 4);
            this.radDescarga.Name = "radDescarga";
            this.radDescarga.Size = new System.Drawing.Size(104, 25);
            this.radDescarga.TabIndex = 2;
            this.radDescarga.TabStop = true;
            this.radDescarga.Text = "Descarga";
            this.radDescarga.UseVisualStyleBackColor = true;
            this.radDescarga.CheckedChanged += new System.EventHandler(this.radDescarga_CheckedChanged);
            this.radDescarga.MouseEnter += new System.EventHandler(this.radCarga_MouseEnter);
            this.radDescarga.MouseLeave += new System.EventHandler(this.radCarga_MouseLeave);
            // 
            // radCarga
            // 
            this.radCarga.AutoSize = true;
            this.radCarga.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCarga.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCarga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCarga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCarga.Location = new System.Drawing.Point(135, 58);
            this.radCarga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radCarga.Name = "radCarga";
            this.radCarga.Size = new System.Drawing.Size(79, 25);
            this.radCarga.TabIndex = 1;
            this.radCarga.Text = "Carga";
            this.radCarga.UseVisualStyleBackColor = true;
            this.radCarga.CheckedChanged += new System.EventHandler(this.radCarga_CheckedChanged);
            this.radCarga.MouseEnter += new System.EventHandler(this.radCarga_MouseEnter);
            this.radCarga.MouseLeave += new System.EventHandler(this.radCarga_MouseLeave);
            // 
            // raddevolucion
            // 
            this.raddevolucion.AutoSize = true;
            this.raddevolucion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.raddevolucion.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.raddevolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.raddevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.raddevolucion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddevolucion.Location = new System.Drawing.Point(234, 58);
            this.raddevolucion.Margin = new System.Windows.Forms.Padding(3, 37, 3, 4);
            this.raddevolucion.Name = "raddevolucion";
            this.raddevolucion.Size = new System.Drawing.Size(116, 25);
            this.raddevolucion.TabIndex = 3;
            this.raddevolucion.Text = "Devolución";
            this.raddevolucion.UseVisualStyleBackColor = true;
            this.raddevolucion.CheckedChanged += new System.EventHandler(this.raddevolucion_CheckedChanged);
            this.raddevolucion.MouseEnter += new System.EventHandler(this.radCarga_MouseEnter);
            this.raddevolucion.MouseLeave += new System.EventHandler(this.radCarga_MouseLeave);
            // 
            // txtTipoMovimiento
            // 
            this.txtTipoMovimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoMovimiento.Enabled = false;
            this.txtTipoMovimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoMovimiento.HintForeColor = System.Drawing.Color.Empty;
            this.txtTipoMovimiento.HintText = "";
            this.txtTipoMovimiento.isPassword = false;
            this.txtTipoMovimiento.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtTipoMovimiento.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTipoMovimiento.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtTipoMovimiento.LineThickness = 4;
            this.txtTipoMovimiento.Location = new System.Drawing.Point(2, 6);
            this.txtTipoMovimiento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTipoMovimiento.Name = "txtTipoMovimiento";
            this.txtTipoMovimiento.Size = new System.Drawing.Size(373, 42);
            this.txtTipoMovimiento.TabIndex = 13;
            this.txtTipoMovimiento.TabStop = false;
            this.txtTipoMovimiento.Text = "Tipo de Movimiento";
            this.txtTipoMovimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelNombrefletero
            // 
            this.panelNombrefletero.Controls.Add(this.txtNombre);
            this.panelNombrefletero.Location = new System.Drawing.Point(11, 322);
            this.panelNombrefletero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNombrefletero.Name = "panelNombrefletero";
            this.panelNombrefletero.Size = new System.Drawing.Size(420, 94);
            this.panelNombrefletero.TabIndex = 38;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "Nombre Fletero...";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtNombre.LineThickness = 4;
            this.txtNombre.Location = new System.Drawing.Point(2, 6);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(373, 42);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.MouseEnter += new System.EventHandler(this.txtNombre_MouseEnter);
            this.txtNombre.MouseLeave += new System.EventHandler(this.txtNombre_MouseLeave);
            // 
            // panelTipoCamion
            // 
            this.panelTipoCamion.Controls.Add(this.label13);
            this.panelTipoCamion.Controls.Add(this.txtTipoCamion);
            this.panelTipoCamion.Controls.Add(this.cBoxTipoCamion);
            this.panelTipoCamion.Location = new System.Drawing.Point(446, 222);
            this.panelTipoCamion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTipoCamion.Name = "panelTipoCamion";
            this.panelTipoCamion.Size = new System.Drawing.Size(420, 94);
            this.panelTipoCamion.TabIndex = 37;
            this.panelTipoCamion.MouseEnter += new System.EventHandler(this.panel1_MouseEnter_1);
            this.panelTipoCamion.MouseLeave += new System.EventHandler(this.panel1_MouseLeave_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(390, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 24);
            this.label13.TabIndex = 45;
            this.label13.Text = "*";
            // 
            // txtTipoCamion
            // 
            this.txtTipoCamion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoCamion.Enabled = false;
            this.txtTipoCamion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCamion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoCamion.HintForeColor = System.Drawing.Color.Empty;
            this.txtTipoCamion.HintText = "";
            this.txtTipoCamion.isPassword = false;
            this.txtTipoCamion.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtTipoCamion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTipoCamion.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtTipoCamion.LineThickness = 4;
            this.txtTipoCamion.Location = new System.Drawing.Point(36, 6);
            this.txtTipoCamion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTipoCamion.Name = "txtTipoCamion";
            this.txtTipoCamion.Size = new System.Drawing.Size(373, 42);
            this.txtTipoCamion.TabIndex = 29;
            this.txtTipoCamion.TabStop = false;
            this.txtTipoCamion.Text = "Tipo de Camión";
            this.txtTipoCamion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTipoCamion.MouseEnter += new System.EventHandler(this.panel1_MouseEnter_1);
            this.txtTipoCamion.MouseLeave += new System.EventHandler(this.panel1_MouseLeave_1);
            // 
            // cBoxTipoCamion
            // 
            this.cBoxTipoCamion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxTipoCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTipoCamion.Enabled = false;
            this.cBoxTipoCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxTipoCamion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTipoCamion.FormattingEnabled = true;
            this.cBoxTipoCamion.Location = new System.Drawing.Point(36, 53);
            this.cBoxTipoCamion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxTipoCamion.Name = "cBoxTipoCamion";
            this.cBoxTipoCamion.Size = new System.Drawing.Size(373, 29);
            this.cBoxTipoCamion.TabIndex = 9;
            this.cBoxTipoCamion.MouseEnter += new System.EventHandler(this.panel1_MouseEnter_1);
            this.cBoxTipoCamion.MouseLeave += new System.EventHandler(this.panel1_MouseLeave_1);
            // 
            // panelClienteProveedor
            // 
            this.panelClienteProveedor.Controls.Add(this.label12);
            this.panelClienteProveedor.Controls.Add(this.txtProveedores);
            this.panelClienteProveedor.Controls.Add(this.cBoxCliente);
            this.panelClienteProveedor.Controls.Add(this.cBoxProveedor);
            this.panelClienteProveedor.Location = new System.Drawing.Point(446, 121);
            this.panelClienteProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelClienteProveedor.Name = "panelClienteProveedor";
            this.panelClienteProveedor.Size = new System.Drawing.Size(420, 94);
            this.panelClienteProveedor.TabIndex = 36;
            this.panelClienteProveedor.MouseEnter += new System.EventHandler(this.panelClienteProveedor_MouseEnter);
            this.panelClienteProveedor.MouseLeave += new System.EventHandler(this.panelClienteProveedor_MouseLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(390, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 24);
            this.label12.TabIndex = 45;
            this.label12.Text = "*";
            // 
            // txtProveedores
            // 
            this.txtProveedores.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedores.Enabled = false;
            this.txtProveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProveedores.HintForeColor = System.Drawing.Color.Empty;
            this.txtProveedores.HintText = "";
            this.txtProveedores.isPassword = false;
            this.txtProveedores.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtProveedores.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProveedores.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtProveedores.LineThickness = 4;
            this.txtProveedores.Location = new System.Drawing.Point(36, 7);
            this.txtProveedores.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProveedores.Name = "txtProveedores";
            this.txtProveedores.Size = new System.Drawing.Size(373, 42);
            this.txtProveedores.TabIndex = 17;
            this.txtProveedores.TabStop = false;
            this.txtProveedores.Text = "Proveedor";
            this.txtProveedores.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProveedores.MouseEnter += new System.EventHandler(this.panelClienteProveedor_MouseEnter);
            this.txtProveedores.MouseLeave += new System.EventHandler(this.panelClienteProveedor_MouseLeave);
            // 
            // cBoxCliente
            // 
            this.cBoxCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCliente.FormattingEnabled = true;
            this.cBoxCliente.Location = new System.Drawing.Point(36, 54);
            this.cBoxCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxCliente.Name = "cBoxCliente";
            this.cBoxCliente.Size = new System.Drawing.Size(373, 29);
            this.cBoxCliente.TabIndex = 7;
            this.cBoxCliente.Visible = false;
            this.cBoxCliente.SelectedIndexChanged += new System.EventHandler(this.cBoxCliente_SelectedIndexChanged);
            this.cBoxCliente.MouseEnter += new System.EventHandler(this.panelClienteProveedor_MouseEnter);
            this.cBoxCliente.MouseLeave += new System.EventHandler(this.panelClienteProveedor_MouseLeave);
            // 
            // cBoxProveedor
            // 
            this.cBoxProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxProveedor.FormattingEnabled = true;
            this.cBoxProveedor.Location = new System.Drawing.Point(36, 54);
            this.cBoxProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxProveedor.Name = "cBoxProveedor";
            this.cBoxProveedor.Size = new System.Drawing.Size(373, 29);
            this.cBoxProveedor.TabIndex = 18;
            this.cBoxProveedor.SelectedIndexChanged += new System.EventHandler(this.cBoxProveedor_SelectedIndexChanged);
            // 
            // panelCBoxCamion
            // 
            this.panelCBoxCamion.Controls.Add(this.label10);
            this.panelCBoxCamion.Controls.Add(this.txtCamion);
            this.panelCBoxCamion.Controls.Add(this.cBoxCamiones);
            this.panelCBoxCamion.Location = new System.Drawing.Point(11, 222);
            this.panelCBoxCamion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCBoxCamion.Name = "panelCBoxCamion";
            this.panelCBoxCamion.Size = new System.Drawing.Size(420, 94);
            this.panelCBoxCamion.TabIndex = 35;
            this.panelCBoxCamion.MouseEnter += new System.EventHandler(this.panelCBoxCamion_MouseEnter);
            this.panelCBoxCamion.MouseLeave += new System.EventHandler(this.panelCBoxCamion_MouseLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(356, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "*";
            // 
            // txtCamion
            // 
            this.txtCamion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCamion.Enabled = false;
            this.txtCamion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCamion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCamion.HintForeColor = System.Drawing.Color.Empty;
            this.txtCamion.HintText = "";
            this.txtCamion.isPassword = false;
            this.txtCamion.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtCamion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCamion.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtCamion.LineThickness = 4;
            this.txtCamion.Location = new System.Drawing.Point(2, 6);
            this.txtCamion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCamion.Name = "txtCamion";
            this.txtCamion.Size = new System.Drawing.Size(373, 42);
            this.txtCamion.TabIndex = 27;
            this.txtCamion.TabStop = false;
            this.txtCamion.Text = "Camión";
            this.txtCamion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCamion.MouseEnter += new System.EventHandler(this.panelCBoxCamion_MouseEnter);
            this.txtCamion.MouseLeave += new System.EventHandler(this.panelCBoxCamion_MouseLeave);
            // 
            // cBoxCamiones
            // 
            this.cBoxCamiones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxCamiones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxCamiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxCamiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxCamiones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCamiones.FormattingEnabled = true;
            this.cBoxCamiones.Location = new System.Drawing.Point(2, 53);
            this.cBoxCamiones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxCamiones.Name = "cBoxCamiones";
            this.cBoxCamiones.Size = new System.Drawing.Size(373, 29);
            this.cBoxCamiones.TabIndex = 8;
            this.cBoxCamiones.SelectedIndexChanged += new System.EventHandler(this.cBoxCamiones_SelectedIndexChanged);
            this.cBoxCamiones.Leave += new System.EventHandler(this.cBoxCamiones_Leave);
            this.cBoxCamiones.MouseEnter += new System.EventHandler(this.panelCBoxCamion_MouseEnter);
            this.cBoxCamiones.MouseLeave += new System.EventHandler(this.panelCBoxCamion_MouseLeave);
            // 
            // panelEntidad
            // 
            this.panelEntidad.Controls.Add(this.label8);
            this.panelEntidad.Controls.Add(this.txtEntidad);
            this.panelEntidad.Controls.Add(this.radProveedor);
            this.panelEntidad.Controls.Add(this.radCliente);
            this.panelEntidad.Location = new System.Drawing.Point(11, 121);
            this.panelEntidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEntidad.Name = "panelEntidad";
            this.panelEntidad.Size = new System.Drawing.Size(420, 94);
            this.panelEntidad.TabIndex = 34;
            this.panelEntidad.MouseEnter += new System.EventHandler(this.panelEntidad_MouseEnter);
            this.panelEntidad.MouseLeave += new System.EventHandler(this.txtEntidad_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(356, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "*";
            // 
            // txtEntidad
            // 
            this.txtEntidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEntidad.Enabled = false;
            this.txtEntidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEntidad.HintForeColor = System.Drawing.Color.Empty;
            this.txtEntidad.HintText = "";
            this.txtEntidad.isPassword = false;
            this.txtEntidad.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtEntidad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEntidad.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtEntidad.LineThickness = 4;
            this.txtEntidad.Location = new System.Drawing.Point(2, 6);
            this.txtEntidad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(373, 42);
            this.txtEntidad.TabIndex = 26;
            this.txtEntidad.TabStop = false;
            this.txtEntidad.Text = "Entidad";
            this.txtEntidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEntidad.MouseEnter += new System.EventHandler(this.panelEntidad_MouseEnter);
            this.txtEntidad.MouseLeave += new System.EventHandler(this.txtEntidad_MouseLeave);
            // 
            // radProveedor
            // 
            this.radProveedor.AutoSize = true;
            this.radProveedor.Checked = true;
            this.radProveedor.Enabled = false;
            this.radProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radProveedor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProveedor.Location = new System.Drawing.Point(7, 58);
            this.radProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radProveedor.Name = "radProveedor";
            this.radProveedor.Size = new System.Drawing.Size(108, 25);
            this.radProveedor.TabIndex = 5;
            this.radProveedor.TabStop = true;
            this.radProveedor.Text = "Proveedor";
            this.radProveedor.UseVisualStyleBackColor = true;
            this.radProveedor.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radProveedor.MouseEnter += new System.EventHandler(this.panelEntidad_MouseEnter);
            this.radProveedor.MouseLeave += new System.EventHandler(this.txtEntidad_MouseLeave);
            // 
            // radCliente
            // 
            this.radCliente.AutoSize = true;
            this.radCliente.Enabled = false;
            this.radCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCliente.Location = new System.Drawing.Point(140, 58);
            this.radCliente.Margin = new System.Windows.Forms.Padding(3, 18, 3, 4);
            this.radCliente.Name = "radCliente";
            this.radCliente.Size = new System.Drawing.Size(84, 25);
            this.radCliente.TabIndex = 6;
            this.radCliente.Text = "Cliente";
            this.radCliente.UseVisualStyleBackColor = true;
            this.radCliente.CheckedChanged += new System.EventHandler(this.radCliente_CheckedChanged);
            this.radCliente.MouseEnter += new System.EventHandler(this.panelEntidad_MouseEnter);
            this.radCliente.MouseLeave += new System.EventHandler(this.txtEntidad_MouseLeave);
            // 
            // tabObservaciones
            // 
            this.tabObservaciones.Controls.Add(this.observacionesCard);
            this.tabObservaciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabObservaciones.Location = new System.Drawing.Point(4, 29);
            this.tabObservaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabObservaciones.Name = "tabObservaciones";
            this.tabObservaciones.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabObservaciones.Size = new System.Drawing.Size(867, 408);
            this.tabObservaciones.TabIndex = 3;
            this.tabObservaciones.Text = "Observaciones";
            this.tabObservaciones.UseVisualStyleBackColor = true;
            // 
            // observacionesCard
            // 
            this.observacionesCard.BackColor = System.Drawing.Color.White;
            this.observacionesCard.BorderRadius = 0;
            this.observacionesCard.BottomSahddow = false;
            this.observacionesCard.color = System.Drawing.Color.Black;
            this.observacionesCard.Controls.Add(this.lblObs);
            this.observacionesCard.Controls.Add(this.txtBoxObservaciones);
            this.observacionesCard.Controls.Add(this.txtObservaciones);
            this.observacionesCard.LeftSahddow = false;
            this.observacionesCard.Location = new System.Drawing.Point(-5, 0);
            this.observacionesCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.observacionesCard.Name = "observacionesCard";
            this.observacionesCard.RightSahddow = false;
            this.observacionesCard.ShadowDepth = 20;
            this.observacionesCard.Size = new System.Drawing.Size(951, 418);
            this.observacionesCard.TabIndex = 4;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblObs.ForeColor = System.Drawing.Color.Gray;
            this.lblObs.Location = new System.Drawing.Point(30, 14);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(163, 24);
            this.lblObs.TabIndex = 28;
            this.lblObs.Text = "Observaciones";
            // 
            // txtBoxObservaciones
            // 
            this.txtBoxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxObservaciones.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtBoxObservaciones.Location = new System.Drawing.Point(34, 58);
            this.txtBoxObservaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxObservaciones.Multiline = true;
            this.txtBoxObservaciones.Name = "txtBoxObservaciones";
            this.txtBoxObservaciones.Size = new System.Drawing.Size(810, 320);
            this.txtBoxObservaciones.TabIndex = 11;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtObservaciones.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtObservaciones.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtObservaciones.BorderThickness = 1;
            this.txtObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.Black;
            this.txtObservaciones.isPassword = false;
            this.txtObservaciones.Location = new System.Drawing.Point(21, 45);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(834, 343);
            this.txtObservaciones.TabIndex = 1;
            this.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lectorCOM
            // 
            this.lectorCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.lectorCOM_DataReceived);
            // 
            // AsigntarTarjetaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cardMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AsigntarTarjetaControl";
            this.Size = new System.Drawing.Size(918, 583);
            this.cardMenu.ResumeLayout(false);
            this.cardMenu.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picActualizar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabProveedor.ResumeLayout(false);
            this.proveedorCard.ResumeLayout(false);
            this.panelMaterial.ResumeLayout(false);
            this.panelMaterial.PerformLayout();
            this.panelPatenteAcoplado.ResumeLayout(false);
            this.panelTipoMovimiento.ResumeLayout(false);
            this.panelTipoMovimiento.PerformLayout();
            this.panelNombrefletero.ResumeLayout(false);
            this.panelTipoCamion.ResumeLayout(false);
            this.panelTipoCamion.PerformLayout();
            this.panelClienteProveedor.ResumeLayout(false);
            this.panelClienteProveedor.PerformLayout();
            this.panelCBoxCamion.ResumeLayout(false);
            this.panelCBoxCamion.PerformLayout();
            this.panelEntidad.ResumeLayout(false);
            this.panelEntidad.PerformLayout();
            this.tabObservaciones.ResumeLayout(false);
            this.observacionesCard.ResumeLayout(false);
            this.observacionesCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardMenu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFinalizar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNroTarjeta;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.RadioButton raddevolucion;
        private System.Windows.Forms.RadioButton radDescarga;
        private System.Windows.Forms.RadioButton radCarga;
        private System.Windows.Forms.ComboBox cBoxMateriales;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaterial;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipoMovimiento;
        private System.Windows.Forms.TabPage tabProveedor;
        private Bunifu.Framework.UI.BunifuCards proveedorCard;
        private System.Windows.Forms.RadioButton radCliente;
        private System.Windows.Forms.RadioButton radProveedor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPatente;
        private System.Windows.Forms.ComboBox cBoxTipoCamion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipoCamion;
        private System.Windows.Forms.ComboBox cBoxCamiones;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCamion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEntidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.ComboBox cBoxCliente;
        private System.Windows.Forms.ComboBox cBoxProveedor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProveedores;
        private System.Windows.Forms.TabPage tabObservaciones;
        private Bunifu.Framework.UI.BunifuCards observacionesCard;
        private System.Windows.Forms.TextBox txtBoxObservaciones;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtObservaciones;
        private System.Windows.Forms.Panel panelClienteProveedor;
        private System.Windows.Forms.Panel panelCBoxCamion;
        private System.Windows.Forms.Panel panelEntidad;
        private System.Windows.Forms.Panel panelTipoCamion;
        private System.Windows.Forms.Panel panelPatenteAcoplado;
        private System.Windows.Forms.Panel panelNombrefletero;
        private System.Windows.Forms.Panel panelMaterial;
        private System.Windows.Forms.Panel panelTipoMovimiento;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRequerido1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private Bunifu.Framework.UI.BunifuSwitch switchLectorTarjeta;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSinRegistro;
        private System.IO.Ports.SerialPort lectorCOM;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTarjetaError;
        private System.Windows.Forms.PictureBox picActualizar;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPuertosCardIndice;
    }
}
