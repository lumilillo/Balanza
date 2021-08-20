namespace Balanza.Componentes
{
    partial class AltaProveedorCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaProveedorCard));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.cardMovimiento = new Bunifu.Framework.UI.BunifuCards();
            this.btnFinalizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRequerido = new System.Windows.Forms.Label();
            this.txtCuitDato = new System.Windows.Forms.TextBox();
            this.btnVolver2 = new System.Windows.Forms.Button();
            this.lblIndice1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDomicilio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.radCliente = new System.Windows.Forms.RadioButton();
            this.radProveedor = new System.Windows.Forms.RadioButton();
            this.cBoxProvincia = new System.Windows.Forms.ComboBox();
            this.txtTipoMovimiento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCuit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cBoxLocalidad = new System.Windows.Forms.ComboBox();
            this.txtRazonSocial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.alertaTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cardMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardMovimiento
            // 
            this.cardMovimiento.BackColor = System.Drawing.Color.White;
            this.cardMovimiento.BorderRadius = 0;
            this.cardMovimiento.BottomSahddow = true;
            this.cardMovimiento.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.cardMovimiento.Controls.Add(this.btnFinalizar);
            this.cardMovimiento.Controls.Add(this.label4);
            this.cardMovimiento.Controls.Add(this.label3);
            this.cardMovimiento.Controls.Add(this.label2);
            this.cardMovimiento.Controls.Add(this.lblRequerido);
            this.cardMovimiento.Controls.Add(this.txtCuitDato);
            this.cardMovimiento.Controls.Add(this.btnVolver2);
            this.cardMovimiento.Controls.Add(this.lblIndice1);
            this.cardMovimiento.Controls.Add(this.txtDomicilio);
            this.cardMovimiento.Controls.Add(this.txtCP);
            this.cardMovimiento.Controls.Add(this.radCliente);
            this.cardMovimiento.Controls.Add(this.radProveedor);
            this.cardMovimiento.Controls.Add(this.cBoxProvincia);
            this.cardMovimiento.Controls.Add(this.txtTipoMovimiento);
            this.cardMovimiento.Controls.Add(this.txtCuit);
            this.cardMovimiento.Controls.Add(this.bunifuMaterialTextbox4);
            this.cardMovimiento.Controls.Add(this.cBoxLocalidad);
            this.cardMovimiento.Controls.Add(this.txtRazonSocial);
            this.cardMovimiento.Controls.Add(this.bunifuMaterialTextbox2);
            this.alertaTransition.SetDecoration(this.cardMovimiento, BunifuAnimatorNS.DecorationType.None);
            this.cardMovimiento.LeftSahddow = true;
            this.cardMovimiento.Location = new System.Drawing.Point(-1, 0);
            this.cardMovimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardMovimiento.Name = "cardMovimiento";
            this.cardMovimiento.RightSahddow = true;
            this.cardMovimiento.ShadowDepth = 20;
            this.cardMovimiento.Size = new System.Drawing.Size(919, 587);
            this.cardMovimiento.TabIndex = 100;
            this.cardMovimiento.Paint += new System.Windows.Forms.PaintEventHandler(this.cardMovimiento_Paint);
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
            this.btnFinalizar.Location = new System.Drawing.Point(694, 500);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(190, 59);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.alertaTransition.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(865, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 24);
            this.label4.TabIndex = 101;
            this.label4.Text = "*";
            this.toolTip1.SetToolTip(this.label4, "Requerido");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.alertaTransition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(385, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 24);
            this.label3.TabIndex = 103;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.alertaTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(865, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 24);
            this.label2.TabIndex = 102;
            this.label2.Text = "*";
            this.toolTip1.SetToolTip(this.label2, "Requerido");
            // 
            // lblRequerido
            // 
            this.lblRequerido.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblRequerido, BunifuAnimatorNS.DecorationType.None);
            this.lblRequerido.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido.ForeColor = System.Drawing.Color.Crimson;
            this.lblRequerido.Location = new System.Drawing.Point(385, 76);
            this.lblRequerido.Name = "lblRequerido";
            this.lblRequerido.Size = new System.Drawing.Size(19, 24);
            this.lblRequerido.TabIndex = 101;
            this.lblRequerido.Text = "*";
            this.toolTip1.SetToolTip(this.lblRequerido, "Requerido");
            // 
            // txtCuitDato
            // 
            this.txtCuitDato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alertaTransition.SetDecoration(this.txtCuitDato, BunifuAnimatorNS.DecorationType.None);
            this.txtCuitDato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuitDato.ForeColor = System.Drawing.Color.Black;
            this.txtCuitDato.Location = new System.Drawing.Point(38, 209);
            this.txtCuitDato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCuitDato.MaxLength = 13;
            this.txtCuitDato.Name = "txtCuitDato";
            this.txtCuitDato.Size = new System.Drawing.Size(356, 20);
            this.txtCuitDato.TabIndex = 41;
            this.txtCuitDato.Text = "Cuit...";
            this.toolTip1.SetToolTip(this.txtCuitDato, "Requerido");
            this.txtCuitDato.Enter += new System.EventHandler(this.txtCuitDato_Enter);
            this.txtCuitDato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuitDato_KeyDown);
            this.txtCuitDato.Leave += new System.EventHandler(this.txtCuitDato_Leave);
            // 
            // btnVolver2
            // 
            this.btnVolver2.BackgroundImage = global::Balanza.Properties.Resources.icons8_volver_50;
            this.btnVolver2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertaTransition.SetDecoration(this.btnVolver2, BunifuAnimatorNS.DecorationType.None);
            this.btnVolver2.FlatAppearance.BorderSize = 0;
            this.btnVolver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver2.Location = new System.Drawing.Point(818, 12);
            this.btnVolver2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(69, 31);
            this.btnVolver2.TabIndex = 39;
            this.btnVolver2.UseVisualStyleBackColor = true;
            this.btnVolver2.Click += new System.EventHandler(this.btnVolver2_Click);
            // 
            // lblIndice1
            // 
            this.lblIndice1.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblIndice1, BunifuAnimatorNS.DecorationType.None);
            this.lblIndice1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndice1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndice1.Location = new System.Drawing.Point(28, 11);
            this.lblIndice1.Name = "lblIndice1";
            this.lblIndice1.Size = new System.Drawing.Size(186, 24);
            this.lblIndice1.TabIndex = 38;
            this.lblIndice1.Text = "Alta Proveedores";
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
            this.txtDomicilio.Location = new System.Drawing.Point(514, 199);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(5, 6, 47, 6);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(373, 42);
            this.txtDomicilio.TabIndex = 5;
            this.txtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDomicilio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDomicilio_KeyDown);
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
            this.txtCP.Location = new System.Drawing.Point(34, 447);
            this.txtCP.Margin = new System.Windows.Forms.Padding(5, 6, 47, 6);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(373, 42);
            this.txtCP.TabIndex = 8;
            this.txtCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // radCliente
            // 
            this.radCliente.AutoSize = true;
            this.alertaTransition.SetDecoration(this.radCliente, BunifuAnimatorNS.DecorationType.None);
            this.radCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCliente.Location = new System.Drawing.Point(165, 128);
            this.radCliente.Margin = new System.Windows.Forms.Padding(3, 37, 3, 4);
            this.radCliente.Name = "radCliente";
            this.radCliente.Size = new System.Drawing.Size(79, 24);
            this.radCliente.TabIndex = 2;
            this.radCliente.Text = "Cliente";
            this.radCliente.UseVisualStyleBackColor = true;
            // 
            // radProveedor
            // 
            this.radProveedor.AutoSize = true;
            this.radProveedor.Checked = true;
            this.alertaTransition.SetDecoration(this.radProveedor, BunifuAnimatorNS.DecorationType.None);
            this.radProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radProveedor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProveedor.Location = new System.Drawing.Point(34, 128);
            this.radProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radProveedor.Name = "radProveedor";
            this.radProveedor.Size = new System.Drawing.Size(106, 24);
            this.radProveedor.TabIndex = 1;
            this.radProveedor.TabStop = true;
            this.radProveedor.Text = "Proveedor";
            this.radProveedor.UseVisualStyleBackColor = true;
            // 
            // cBoxProvincia
            // 
            this.cBoxProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.alertaTransition.SetDecoration(this.cBoxProvincia, BunifuAnimatorNS.DecorationType.None);
            this.cBoxProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxProvincia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxProvincia.FormattingEnabled = true;
            this.cBoxProvincia.Location = new System.Drawing.Point(32, 364);
            this.cBoxProvincia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxProvincia.Name = "cBoxProvincia";
            this.cBoxProvincia.Size = new System.Drawing.Size(373, 29);
            this.cBoxProvincia.TabIndex = 6;
            this.cBoxProvincia.SelectedIndexChanged += new System.EventHandler(this.cBoxProvincia_SelectedIndexChanged);
            // 
            // txtTipoMovimiento
            // 
            this.txtTipoMovimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtTipoMovimiento, BunifuAnimatorNS.DecorationType.None);
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
            this.txtTipoMovimiento.Location = new System.Drawing.Point(32, 76);
            this.txtTipoMovimiento.Margin = new System.Windows.Forms.Padding(47, 6, 5, 6);
            this.txtTipoMovimiento.Name = "txtTipoMovimiento";
            this.txtTipoMovimiento.Size = new System.Drawing.Size(373, 42);
            this.txtTipoMovimiento.TabIndex = 13;
            this.txtTipoMovimiento.Text = "Tipo de Ente";
            this.txtTipoMovimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCuit
            // 
            this.txtCuit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtCuit, BunifuAnimatorNS.DecorationType.None);
            this.txtCuit.Enabled = false;
            this.txtCuit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit.ForeColor = System.Drawing.Color.Black;
            this.txtCuit.HintForeColor = System.Drawing.Color.Black;
            this.txtCuit.HintText = "";
            this.txtCuit.isPassword = false;
            this.txtCuit.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtCuit.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCuit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtCuit.LineThickness = 4;
            this.txtCuit.Location = new System.Drawing.Point(32, 199);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(23, 6, 5, 6);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(373, 42);
            this.txtCuit.TabIndex = 4;
            this.txtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(373, 42);
            this.bunifuMaterialTextbox4.TabIndex = 24;
            this.bunifuMaterialTextbox4.Text = "Provincia";
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cBoxLocalidad
            // 
            this.cBoxLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.alertaTransition.SetDecoration(this.cBoxLocalidad, BunifuAnimatorNS.DecorationType.None);
            this.cBoxLocalidad.Enabled = false;
            this.cBoxLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxLocalidad.FormattingEnabled = true;
            this.cBoxLocalidad.Location = new System.Drawing.Point(511, 364);
            this.cBoxLocalidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxLocalidad.Name = "cBoxLocalidad";
            this.cBoxLocalidad.Size = new System.Drawing.Size(373, 29);
            this.cBoxLocalidad.TabIndex = 7;
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
            this.txtRazonSocial.Location = new System.Drawing.Point(514, 76);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(23, 6, 5, 6);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(373, 42);
            this.txtRazonSocial.TabIndex = 3;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(373, 42);
            this.bunifuMaterialTextbox2.TabIndex = 23;
            this.bunifuMaterialTextbox2.Text = "Localidad";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // AltaProveedorCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cardMovimiento);
            this.alertaTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(5, 3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AltaProveedorCard";
            this.Size = new System.Drawing.Size(918, 583);
            this.cardMovimiento.ResumeLayout(false);
            this.cardMovimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnFinalizar;
        private Bunifu.Framework.UI.BunifuCards cardMovimiento;
        private System.Windows.Forms.RadioButton radProveedor;
        private System.Windows.Forms.RadioButton radCliente;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCuit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRazonSocial;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipoMovimiento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.ComboBox cBoxProvincia;
        private System.Windows.Forms.ComboBox cBoxLocalidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDomicilio;
        private BunifuAnimatorNS.BunifuTransition alertaTransition;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIndice1;
        private System.Windows.Forms.Button btnVolver2;
        private System.Windows.Forms.TextBox txtCuitDato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRequerido;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
