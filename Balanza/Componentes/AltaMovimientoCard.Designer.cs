namespace Balanza.Componentes
{
    partial class AltaMovimientoCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaMovimientoCard));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnFinalizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMaterial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPatente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtRazonSocial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblCodigo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNroTarjeta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRequerido1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtObservaciones = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtFecha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPesoSalida = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.numPesoSalida = new System.Windows.Forms.NumericUpDown();
            this.txtPesoEntrada = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.numPesoEntrada = new System.Windows.Forms.NumericUpDown();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblModificar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.alertaTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.bunifuCards1.Controls.Add(this.btnFinalizar);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.txtMaterial);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards1.Controls.Add(this.txtPatente);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.txtRazonSocial);
            this.bunifuCards1.Controls.Add(this.lblCodigo);
            this.bunifuCards1.Controls.Add(this.txtNroTarjeta);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.lblRequerido1);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.dtHoraSalida);
            this.bunifuCards1.Controls.Add(this.dtHoraEntrada);
            this.bunifuCards1.Controls.Add(this.txtObservaciones);
            this.bunifuCards1.Controls.Add(this.dtFechaEntrada);
            this.bunifuCards1.Controls.Add(this.txtFecha);
            this.bunifuCards1.Controls.Add(this.txtPesoSalida);
            this.bunifuCards1.Controls.Add(this.numPesoSalida);
            this.bunifuCards1.Controls.Add(this.txtPesoEntrada);
            this.bunifuCards1.Controls.Add(this.numPesoEntrada);
            this.bunifuCards1.Controls.Add(this.btnVolver);
            this.bunifuCards1.Controls.Add(this.lblModificar);
            this.alertaTransition.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-9, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(830, 464);
            this.bunifuCards1.TabIndex = 1;
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
            this.alertaTransition.SetDecoration(this.btnFinalizar, BunifuAnimatorNS.DecorationType.None);
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFinalizar.IdleBorderThickness = 1;
            this.btnFinalizar.IdleCornerRadius = 20;
            this.btnFinalizar.IdleFillColor = System.Drawing.Color.White;
            this.btnFinalizar.IdleForecolor = System.Drawing.SystemColors.ControlDark;
            this.btnFinalizar.IdleLineColor = System.Drawing.SystemColors.ControlDark;
            this.btnFinalizar.Location = new System.Drawing.Point(598, 411);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(163, 48);
            this.btnFinalizar.TabIndex = 64;
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.alertaTransition.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(447, 111);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(60, 17);
            this.bunifuCustomLabel4.TabIndex = 71;
            this.bunifuCustomLabel4.Text = "Material";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtMaterial, BunifuAnimatorNS.DecorationType.None);
            this.txtMaterial.Enabled = false;
            this.txtMaterial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterial.ForeColor = System.Drawing.Color.Black;
            this.txtMaterial.HintForeColor = System.Drawing.Color.Black;
            this.txtMaterial.HintText = "Material...";
            this.txtMaterial.isPassword = false;
            this.txtMaterial.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtMaterial.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaterial.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtMaterial.LineThickness = 4;
            this.txtMaterial.Location = new System.Drawing.Point(450, 124);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(5, 5, 40, 5);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(362, 34);
            this.txtMaterial.TabIndex = 70;
            this.txtMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.alertaTransition.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(25, 111);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(59, 17);
            this.bunifuCustomLabel5.TabIndex = 69;
            this.bunifuCustomLabel5.Text = "Patente";
            // 
            // txtPatente
            // 
            this.txtPatente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtPatente, BunifuAnimatorNS.DecorationType.None);
            this.txtPatente.Enabled = false;
            this.txtPatente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.ForeColor = System.Drawing.Color.Black;
            this.txtPatente.HintForeColor = System.Drawing.Color.Black;
            this.txtPatente.HintText = "Patente...";
            this.txtPatente.isPassword = false;
            this.txtPatente.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtPatente.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPatente.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtPatente.LineThickness = 4;
            this.txtPatente.Location = new System.Drawing.Point(28, 124);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(5, 5, 40, 5);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(362, 34);
            this.txtPatente.TabIndex = 68;
            this.txtPatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.alertaTransition.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(447, 39);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(90, 17);
            this.bunifuCustomLabel3.TabIndex = 67;
            this.bunifuCustomLabel3.Text = "Razón Social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtRazonSocial, BunifuAnimatorNS.DecorationType.None);
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.txtRazonSocial.HintForeColor = System.Drawing.Color.Black;
            this.txtRazonSocial.HintText = "Razón Social...";
            this.txtRazonSocial.isPassword = false;
            this.txtRazonSocial.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtRazonSocial.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRazonSocial.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtRazonSocial.LineThickness = 4;
            this.txtRazonSocial.Location = new System.Drawing.Point(450, 52);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(5, 5, 40, 5);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(362, 34);
            this.txtRazonSocial.TabIndex = 66;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblCodigo, BunifuAnimatorNS.DecorationType.None);
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCodigo.Location = new System.Drawing.Point(25, 39);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 17);
            this.lblCodigo.TabIndex = 65;
            this.lblCodigo.Text = "N° Tarjeta";
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtNroTarjeta, BunifuAnimatorNS.DecorationType.None);
            this.txtNroTarjeta.Enabled = false;
            this.txtNroTarjeta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroTarjeta.ForeColor = System.Drawing.Color.Black;
            this.txtNroTarjeta.HintForeColor = System.Drawing.Color.Black;
            this.txtNroTarjeta.HintText = "N° Tarjeta...";
            this.txtNroTarjeta.isPassword = false;
            this.txtNroTarjeta.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtNroTarjeta.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNroTarjeta.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtNroTarjeta.LineThickness = 4;
            this.txtNroTarjeta.Location = new System.Drawing.Point(28, 52);
            this.txtNroTarjeta.Margin = new System.Windows.Forms.Padding(5, 5, 40, 5);
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(362, 34);
            this.txtNroTarjeta.TabIndex = 64;
            this.txtNroTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.alertaTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(320, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 24);
            this.label2.TabIndex = 61;
            this.label2.Text = "*";
            this.toolTip1.SetToolTip(this.label2, "Requerido");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.alertaTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(742, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 24);
            this.label1.TabIndex = 60;
            this.label1.Text = "*";
            // 
            // lblRequerido1
            // 
            this.lblRequerido1.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblRequerido1, BunifuAnimatorNS.DecorationType.None);
            this.lblRequerido1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido1.ForeColor = System.Drawing.Color.Crimson;
            this.lblRequerido1.Location = new System.Drawing.Point(742, 183);
            this.lblRequerido1.Name = "lblRequerido1";
            this.lblRequerido1.Size = new System.Drawing.Size(19, 24);
            this.lblRequerido1.TabIndex = 59;
            this.lblRequerido1.Text = "*";
            this.toolTip1.SetToolTip(this.lblRequerido1, "Requerido");
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.alertaTransition.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(24, 309);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(57, 21);
            this.bunifuCustomLabel2.TabIndex = 58;
            this.bunifuCustomLabel2.Text = "Salida";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.alertaTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(24, 255);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(74, 21);
            this.bunifuCustomLabel1.TabIndex = 57;
            this.bunifuCustomLabel1.Text = "Entrada";
            // 
            // dtHoraSalida
            // 
            this.dtHoraSalida.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertaTransition.SetDecoration(this.dtHoraSalida, BunifuAnimatorNS.DecorationType.None);
            this.dtHoraSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHoraSalida.Location = new System.Drawing.Point(28, 333);
            this.dtHoraSalida.Name = "dtHoraSalida";
            this.dtHoraSalida.Size = new System.Drawing.Size(311, 27);
            this.dtHoraSalida.TabIndex = 56;
            // 
            // dtHoraEntrada
            // 
            this.dtHoraEntrada.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertaTransition.SetDecoration(this.dtHoraEntrada, BunifuAnimatorNS.DecorationType.None);
            this.dtHoraEntrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHoraEntrada.Location = new System.Drawing.Point(28, 279);
            this.dtHoraEntrada.Name = "dtHoraEntrada";
            this.dtHoraEntrada.Size = new System.Drawing.Size(311, 27);
            this.dtHoraEntrada.TabIndex = 55;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtObservaciones, BunifuAnimatorNS.DecorationType.None);
            this.txtObservaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.Black;
            this.txtObservaciones.HintForeColor = System.Drawing.Color.Gray;
            this.txtObservaciones.HintText = "Observaciones";
            this.txtObservaciones.isPassword = false;
            this.txtObservaciones.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtObservaciones.LineIdleColor = System.Drawing.Color.Gray;
            this.txtObservaciones.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtObservaciones.LineThickness = 4;
            this.txtObservaciones.Location = new System.Drawing.Point(28, 377);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(853, 34);
            this.txtObservaciones.TabIndex = 54;
            this.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtFechaEntrada
            // 
            this.dtFechaEntrada.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertaTransition.SetDecoration(this.dtFechaEntrada, BunifuAnimatorNS.DecorationType.None);
            this.dtFechaEntrada.Enabled = false;
            this.dtFechaEntrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaEntrada.Location = new System.Drawing.Point(28, 225);
            this.dtFechaEntrada.Name = "dtFechaEntrada";
            this.dtFechaEntrada.Size = new System.Drawing.Size(311, 27);
            this.dtFechaEntrada.TabIndex = 52;
            // 
            // txtFecha
            // 
            this.txtFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtFecha, BunifuAnimatorNS.DecorationType.None);
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.Gray;
            this.txtFecha.HintForeColor = System.Drawing.Color.Gray;
            this.txtFecha.HintText = "";
            this.txtFecha.isPassword = false;
            this.txtFecha.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtFecha.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFecha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtFecha.LineThickness = 4;
            this.txtFecha.Location = new System.Drawing.Point(28, 183);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(362, 34);
            this.txtFecha.TabIndex = 50;
            this.txtFecha.Text = "Fecha";
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPesoSalida
            // 
            this.txtPesoSalida.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtPesoSalida, BunifuAnimatorNS.DecorationType.None);
            this.txtPesoSalida.Enabled = false;
            this.txtPesoSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoSalida.ForeColor = System.Drawing.Color.Gray;
            this.txtPesoSalida.HintForeColor = System.Drawing.Color.Gray;
            this.txtPesoSalida.HintText = "";
            this.txtPesoSalida.isPassword = false;
            this.txtPesoSalida.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtPesoSalida.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPesoSalida.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtPesoSalida.LineThickness = 4;
            this.txtPesoSalida.Location = new System.Drawing.Point(450, 289);
            this.txtPesoSalida.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPesoSalida.Name = "txtPesoSalida";
            this.txtPesoSalida.Size = new System.Drawing.Size(362, 34);
            this.txtPesoSalida.TabIndex = 49;
            this.txtPesoSalida.Text = "Peso Salida(Kg)";
            this.txtPesoSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.txtPesoSalida, "Requerido");
            // 
            // numPesoSalida
            // 
            this.numPesoSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.numPesoSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPesoSalida.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.alertaTransition.SetDecoration(this.numPesoSalida, BunifuAnimatorNS.DecorationType.None);
            this.numPesoSalida.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.numPesoSalida.Location = new System.Drawing.Point(450, 333);
            this.numPesoSalida.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPesoSalida.Name = "numPesoSalida";
            this.numPesoSalida.Size = new System.Drawing.Size(311, 27);
            this.numPesoSalida.TabIndex = 48;
            // 
            // txtPesoEntrada
            // 
            this.txtPesoEntrada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtPesoEntrada, BunifuAnimatorNS.DecorationType.None);
            this.txtPesoEntrada.Enabled = false;
            this.txtPesoEntrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoEntrada.ForeColor = System.Drawing.Color.Gray;
            this.txtPesoEntrada.HintForeColor = System.Drawing.Color.Gray;
            this.txtPesoEntrada.HintText = "";
            this.txtPesoEntrada.isPassword = false;
            this.txtPesoEntrada.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtPesoEntrada.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPesoEntrada.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtPesoEntrada.LineThickness = 4;
            this.txtPesoEntrada.Location = new System.Drawing.Point(450, 183);
            this.txtPesoEntrada.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPesoEntrada.Name = "txtPesoEntrada";
            this.txtPesoEntrada.Size = new System.Drawing.Size(362, 34);
            this.txtPesoEntrada.TabIndex = 47;
            this.txtPesoEntrada.Text = "Peso Entrada(Kg)";
            this.txtPesoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // numPesoEntrada
            // 
            this.numPesoEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.numPesoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPesoEntrada.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.alertaTransition.SetDecoration(this.numPesoEntrada, BunifuAnimatorNS.DecorationType.None);
            this.numPesoEntrada.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.numPesoEntrada.Location = new System.Drawing.Point(450, 225);
            this.numPesoEntrada.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPesoEntrada.Name = "numPesoEntrada";
            this.numPesoEntrada.Size = new System.Drawing.Size(311, 27);
            this.numPesoEntrada.TabIndex = 46;
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Balanza.Properties.Resources.icons8_volver_50;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertaTransition.SetDecoration(this.btnVolver, BunifuAnimatorNS.DecorationType.None);
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(727, 8);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(59, 25);
            this.btnVolver.TabIndex = 44;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblModificar, BunifuAnimatorNS.DecorationType.None);
            this.lblModificar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblModificar.Location = new System.Drawing.Point(24, 9);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(207, 24);
            this.lblModificar.TabIndex = 43;
            this.lblModificar.Text = "Nuevo Movimiento";
            // 
            // alertaTransition
            // 
            this.alertaTransition.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.alertaTransition.Cursor = null;
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
            animation1.TransparencyCoeff = 0F;
            this.alertaTransition.DefaultAnimation = animation1;
            // 
            // AltaMovimientoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuCards1);
            this.alertaTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "AltaMovimientoCard";
            this.Size = new System.Drawing.Size(812, 472);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoEntrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRequerido1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DateTimePicker dtHoraSalida;
        private System.Windows.Forms.DateTimePicker dtHoraEntrada;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtObservaciones;
        private System.Windows.Forms.DateTimePicker dtFechaEntrada;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFecha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPesoSalida;
        private System.Windows.Forms.NumericUpDown numPesoSalida;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPesoEntrada;
        private System.Windows.Forms.NumericUpDown numPesoEntrada;
        private System.Windows.Forms.Button btnVolver;
        private Bunifu.Framework.UI.BunifuCustomLabel lblModificar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFinalizar;
        private BunifuAnimatorNS.BunifuTransition alertaTransition;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCodigo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNroTarjeta;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRazonSocial;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPatente;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaterial;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
