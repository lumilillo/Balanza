namespace Balanza.Componentes
{
    partial class ModificarProveedorCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProveedorCard));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.cardLocalidad = new Bunifu.Framework.UI.BunifuCards();
            this.btnFinalizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRequerido = new System.Windows.Forms.Label();
            this.txtCuitDato = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCP = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCUIT = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDomicilio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCuit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRazonSocial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDomicilio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cBoxProvincia = new System.Windows.Forms.ComboBox();
            this.cBoxLocalidad = new System.Windows.Forms.ComboBox();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.alertaTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cardLocalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardLocalidad
            // 
            this.cardLocalidad.BackColor = System.Drawing.Color.White;
            this.cardLocalidad.BorderRadius = 0;
            this.cardLocalidad.BottomSahddow = true;
            this.cardLocalidad.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.cardLocalidad.Controls.Add(this.btnFinalizar);
            this.cardLocalidad.Controls.Add(this.label4);
            this.cardLocalidad.Controls.Add(this.label3);
            this.cardLocalidad.Controls.Add(this.lblRequerido);
            this.cardLocalidad.Controls.Add(this.txtCuitDato);
            this.cardLocalidad.Controls.Add(this.lblRazonSocial);
            this.cardLocalidad.Controls.Add(this.lblCP);
            this.cardLocalidad.Controls.Add(this.lblCUIT);
            this.cardLocalidad.Controls.Add(this.lblDomicilio);
            this.cardLocalidad.Controls.Add(this.txtCuit);
            this.cardLocalidad.Controls.Add(this.txtRazonSocial);
            this.cardLocalidad.Controls.Add(this.btnVolver);
            this.cardLocalidad.Controls.Add(this.lblIndice);
            this.cardLocalidad.Controls.Add(this.txtDomicilio);
            this.cardLocalidad.Controls.Add(this.cBoxProvincia);
            this.cardLocalidad.Controls.Add(this.cBoxLocalidad);
            this.cardLocalidad.Controls.Add(this.bunifuMaterialTextbox4);
            this.cardLocalidad.Controls.Add(this.bunifuMaterialTextbox2);
            this.cardLocalidad.Controls.Add(this.txtCP);
            this.alertaTransition.SetDecoration(this.cardLocalidad, BunifuAnimatorNS.DecorationType.None);
            this.cardLocalidad.LeftSahddow = true;
            this.cardLocalidad.Location = new System.Drawing.Point(-1, 0);
            this.cardLocalidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardLocalidad.Name = "cardLocalidad";
            this.cardLocalidad.RightSahddow = true;
            this.cardLocalidad.ShadowDepth = 20;
            this.cardLocalidad.Size = new System.Drawing.Size(919, 587);
            this.cardLocalidad.TabIndex = 26;
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
            this.btnFinalizar.ButtonText = "Modificar";
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertaTransition.SetDecoration(this.btnFinalizar, BunifuAnimatorNS.DecorationType.None);
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFinalizar.IdleBorderThickness = 1;
            this.btnFinalizar.IdleCornerRadius = 20;
            this.btnFinalizar.IdleFillColor = System.Drawing.Color.White;
            this.btnFinalizar.IdleForecolor = System.Drawing.SystemColors.ControlDark;
            this.btnFinalizar.IdleLineColor = System.Drawing.SystemColors.ControlDark;
            this.btnFinalizar.Location = new System.Drawing.Point(694, 500);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(190, 59);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.alertaTransition.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(388, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "*";
            this.toolTip1.SetToolTip(this.label4, "Requerido");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.alertaTransition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(866, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "*";
            this.toolTip1.SetToolTip(this.label3, "Requerido");
            // 
            // lblRequerido
            // 
            this.lblRequerido.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblRequerido, BunifuAnimatorNS.DecorationType.None);
            this.lblRequerido.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido.ForeColor = System.Drawing.Color.Crimson;
            this.lblRequerido.Location = new System.Drawing.Point(388, 76);
            this.lblRequerido.Name = "lblRequerido";
            this.lblRequerido.Size = new System.Drawing.Size(19, 24);
            this.lblRequerido.TabIndex = 44;
            this.lblRequerido.Text = "*";
            this.toolTip1.SetToolTip(this.lblRequerido, "Requerido");
            // 
            // txtCuitDato
            // 
            this.txtCuitDato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alertaTransition.SetDecoration(this.txtCuitDato, BunifuAnimatorNS.DecorationType.None);
            this.txtCuitDato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuitDato.ForeColor = System.Drawing.Color.Black;
            this.txtCuitDato.Location = new System.Drawing.Point(520, 87);
            this.txtCuitDato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCuitDato.MaxLength = 13;
            this.txtCuitDato.Name = "txtCuitDato";
            this.txtCuitDato.Size = new System.Drawing.Size(373, 20);
            this.txtCuitDato.TabIndex = 42;
            this.txtCuitDato.Text = "Cuit...";
            this.txtCuitDato.Enter += new System.EventHandler(this.txtCuitDato_Enter);
            this.txtCuitDato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuitDato_KeyDown);
            this.txtCuitDato.Leave += new System.EventHandler(this.txtCuitDato_Leave);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblRazonSocial, BunifuAnimatorNS.DecorationType.None);
            this.lblRazonSocial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRazonSocial.Location = new System.Drawing.Point(30, 59);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(107, 21);
            this.lblRazonSocial.TabIndex = 39;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblCP, BunifuAnimatorNS.DecorationType.None);
            this.lblCP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCP.Location = new System.Drawing.Point(510, 177);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(118, 21);
            this.lblCP.TabIndex = 39;
            this.lblCP.Text = "Codigo Postal";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblCUIT, BunifuAnimatorNS.DecorationType.None);
            this.lblCUIT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCUIT.Location = new System.Drawing.Point(510, 59);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(43, 21);
            this.lblCUIT.TabIndex = 41;
            this.lblCUIT.Text = "Cuit";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblDomicilio, BunifuAnimatorNS.DecorationType.None);
            this.lblDomicilio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDomicilio.Location = new System.Drawing.Point(30, 177);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(79, 21);
            this.lblDomicilio.TabIndex = 38;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtCuit
            // 
            this.txtCuit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtCuit, BunifuAnimatorNS.DecorationType.None);
            this.txtCuit.Enabled = false;
            this.txtCuit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit.ForeColor = System.Drawing.Color.Black;
            this.txtCuit.HintForeColor = System.Drawing.Color.Black;
            this.txtCuit.HintText = "";
            this.txtCuit.isPassword = false;
            this.txtCuit.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtCuit.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCuit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtCuit.LineThickness = 4;
            this.txtCuit.Location = new System.Drawing.Point(514, 76);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(6);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(373, 42);
            this.txtCuit.TabIndex = 2;
            this.txtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCuit.OnValueChanged += new System.EventHandler(this.txtCuit_OnValueChanged);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtRazonSocial, BunifuAnimatorNS.DecorationType.None);
            this.txtRazonSocial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.txtRazonSocial.HintForeColor = System.Drawing.Color.Black;
            this.txtRazonSocial.HintText = "Razón Social...";
            this.txtRazonSocial.isPassword = false;
            this.txtRazonSocial.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtRazonSocial.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRazonSocial.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtRazonSocial.LineThickness = 4;
            this.txtRazonSocial.Location = new System.Drawing.Point(32, 76);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(6, 6, 47, 6);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(373, 42);
            this.txtRazonSocial.TabIndex = 1;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRazonSocial.OnValueChanged += new System.EventHandler(this.txtRazonSocial_OnValueChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Balanza.Properties.Resources.icons8_volver_50;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertaTransition.SetDecoration(this.btnVolver, BunifuAnimatorNS.DecorationType.None);
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(818, 12);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(69, 31);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblIndice, BunifuAnimatorNS.DecorationType.None);
            this.lblIndice.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblIndice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndice.Location = new System.Drawing.Point(28, 11);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(274, 24);
            this.lblIndice.TabIndex = 37;
            this.lblIndice.Text = "Modificando Proveedores";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtDomicilio, BunifuAnimatorNS.DecorationType.None);
            this.txtDomicilio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.ForeColor = System.Drawing.Color.Black;
            this.txtDomicilio.HintForeColor = System.Drawing.Color.Black;
            this.txtDomicilio.HintText = "Domicilio..";
            this.txtDomicilio.isPassword = false;
            this.txtDomicilio.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtDomicilio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDomicilio.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtDomicilio.LineThickness = 4;
            this.txtDomicilio.Location = new System.Drawing.Point(32, 199);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(6, 6, 47, 6);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(373, 42);
            this.txtDomicilio.TabIndex = 3;
            this.txtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDomicilio.OnValueChanged += new System.EventHandler(this.txtDomicilio_OnValueChanged);
            // 
            // cBoxProvincia
            // 
            this.cBoxProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.alertaTransition.SetDecoration(this.cBoxProvincia, BunifuAnimatorNS.DecorationType.None);
            this.cBoxProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxProvincia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxProvincia.FormattingEnabled = true;
            this.cBoxProvincia.Location = new System.Drawing.Point(32, 366);
            this.cBoxProvincia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxProvincia.Name = "cBoxProvincia";
            this.cBoxProvincia.Size = new System.Drawing.Size(373, 30);
            this.cBoxProvincia.TabIndex = 5;
            this.cBoxProvincia.SelectedIndexChanged += new System.EventHandler(this.cBoxProvincia_SelectedIndexChanged);
            // 
            // cBoxLocalidad
            // 
            this.cBoxLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.alertaTransition.SetDecoration(this.cBoxLocalidad, BunifuAnimatorNS.DecorationType.None);
            this.cBoxLocalidad.Enabled = false;
            this.cBoxLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxLocalidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxLocalidad.FormattingEnabled = true;
            this.cBoxLocalidad.Location = new System.Drawing.Point(511, 370);
            this.cBoxLocalidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxLocalidad.Name = "cBoxLocalidad";
            this.cBoxLocalidad.Size = new System.Drawing.Size(373, 30);
            this.cBoxLocalidad.TabIndex = 6;
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.bunifuMaterialTextbox4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox4.Enabled = false;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox4.HintText = "";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.bunifuMaterialTextbox4.LineThickness = 4;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(32, 318);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(373, 42);
            this.bunifuMaterialTextbox4.TabIndex = 24;
            this.bunifuMaterialTextbox4.Text = "Provincia";
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox2.Enabled = false;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.HintText = "CUIT...";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.bunifuMaterialTextbox2.LineThickness = 4;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(511, 318);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(373, 42);
            this.bunifuMaterialTextbox2.TabIndex = 23;
            this.bunifuMaterialTextbox2.Text = "Localidad";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCP
            // 
            this.txtCP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtCP, BunifuAnimatorNS.DecorationType.None);
            this.txtCP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.ForeColor = System.Drawing.Color.Black;
            this.txtCP.HintForeColor = System.Drawing.Color.Black;
            this.txtCP.HintText = "Codigo Postal..";
            this.txtCP.isPassword = false;
            this.txtCP.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtCP.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCP.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtCP.LineThickness = 4;
            this.txtCP.Location = new System.Drawing.Point(514, 199);
            this.txtCP.Margin = new System.Windows.Forms.Padding(6, 6, 47, 6);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(373, 42);
            this.txtCP.TabIndex = 4;
            this.txtCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCP.OnValueChanged += new System.EventHandler(this.txtCP_OnValueChanged);
            this.txtCP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCP_KeyDown);
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
            // ModificarProveedorCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cardLocalidad);
            this.alertaTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModificarProveedorCard";
            this.Size = new System.Drawing.Size(919, 587);
            this.Load += new System.EventHandler(this.ModificarProveedorCard_Load);
            this.cardLocalidad.ResumeLayout(false);
            this.cardLocalidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardLocalidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCuit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRazonSocial;
        private System.Windows.Forms.Button btnVolver;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDomicilio;
        private System.Windows.Forms.ComboBox cBoxProvincia;
        private System.Windows.Forms.ComboBox cBoxLocalidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCP;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFinalizar;
        private BunifuAnimatorNS.BunifuTransition alertaTransition;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCP;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCUIT;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDomicilio;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRazonSocial;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIndice;
        private System.Windows.Forms.TextBox txtCuitDato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRequerido;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
