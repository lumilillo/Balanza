namespace Balanza.Forms
{
    partial class AjustesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjustesForm));
            this.lblIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.balanzaCOM = new System.IO.Ports.SerialPort(this.components);
            this.lectorBalanzaCOM = new System.IO.Ports.SerialPort(this.components);
            this.lectorCOM = new System.IO.Ports.SerialPort(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtThreshold = new System.Windows.Forms.NumericUpDown();
            this.picDesconectarLector = new System.Windows.Forms.PictureBox();
            this.picDesconectarLectorBalanza = new System.Windows.Forms.PictureBox();
            this.picDesconectarBalanza = new System.Windows.Forms.PictureBox();
            this.txtPesoMin = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.switchLectorDespacho = new Bunifu.Framework.UI.BunifuSwitch();
            this.switchLectorBalanza = new Bunifu.Framework.UI.BunifuSwitch();
            this.switchBalanza = new Bunifu.Framework.UI.BunifuSwitch();
            this.cardMenu = new Bunifu.Framework.UI.BunifuCards();
            this.btnCancelPuertoBalanza = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCancelPuertoLectorBalanza = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCancelPuertoLector = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel25 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel24 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cBoxLectorStop = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel23 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cBoxLectorBalanzaStop = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel22 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cBoxBalanzaStop = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel21 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel20 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel19 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cBoxDataLector = new System.Windows.Forms.ComboBox();
            this.cBoxDataLectorBalanza = new System.Windows.Forms.ComboBox();
            this.cBoxBaudLector = new System.Windows.Forms.ComboBox();
            this.cBoxBaudLectorBalanza = new System.Windows.Forms.ComboBox();
            this.cBoxParityLector = new System.Windows.Forms.ComboBox();
            this.cBoxParityLectorBalanza = new System.Windows.Forms.ComboBox();
            this.cBoxPuertoLector = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cBoxPuertoLectorBalanza = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cBoxDataBalanza = new System.Windows.Forms.ComboBox();
            this.cBoxBaudBalanza = new System.Windows.Forms.ComboBox();
            this.cBoxParityBalanza = new System.Windows.Forms.ComboBox();
            this.cBoxPuertoBalanza = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesconectarLector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesconectarLectorBalanza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesconectarBalanza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoMin)).BeginInit();
            this.cardMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelPuertoBalanza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelPuertoLectorBalanza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelPuertoLector)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndice.Location = new System.Drawing.Point(14, 18);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(189, 22);
            this.lblIndice.TabIndex = 7;
            this.lblIndice.Text = "Opciones de Ajuste";
            // 
            // txtThreshold
            // 
            this.txtThreshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtThreshold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThreshold.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThreshold.Location = new System.Drawing.Point(31, 495);
            this.txtThreshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThreshold.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(179, 22);
            this.txtThreshold.TabIndex = 81;
            this.toolTip1.SetToolTip(this.txtThreshold, "Peso Minimo Balanza");
            // 
            // picDesconectarLector
            // 
            this.picDesconectarLector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDesconectarLector.Image = global::Balanza.Properties.Resources.icons8_desconectado_50;
            this.picDesconectarLector.Location = new System.Drawing.Point(857, 479);
            this.picDesconectarLector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picDesconectarLector.Name = "picDesconectarLector";
            this.picDesconectarLector.Size = new System.Drawing.Size(29, 31);
            this.picDesconectarLector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDesconectarLector.TabIndex = 78;
            this.picDesconectarLector.TabStop = false;
            this.toolTip1.SetToolTip(this.picDesconectarLector, "Desconectar Lector Despacho");
            this.picDesconectarLector.Click += new System.EventHandler(this.picDesconectarLector_Click_1);
            // 
            // picDesconectarLectorBalanza
            // 
            this.picDesconectarLectorBalanza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDesconectarLectorBalanza.Image = global::Balanza.Properties.Resources.icons8_desconectado_50;
            this.picDesconectarLectorBalanza.Location = new System.Drawing.Point(511, 478);
            this.picDesconectarLectorBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picDesconectarLectorBalanza.Name = "picDesconectarLectorBalanza";
            this.picDesconectarLectorBalanza.Size = new System.Drawing.Size(29, 31);
            this.picDesconectarLectorBalanza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDesconectarLectorBalanza.TabIndex = 77;
            this.picDesconectarLectorBalanza.TabStop = false;
            this.toolTip1.SetToolTip(this.picDesconectarLectorBalanza, "Desconectar Puerto Lector Balanza");
            this.picDesconectarLectorBalanza.Click += new System.EventHandler(this.picDesconectarLectorBalanza_Click_1);
            // 
            // picDesconectarBalanza
            // 
            this.picDesconectarBalanza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDesconectarBalanza.Image = global::Balanza.Properties.Resources.icons8_desconectado_50;
            this.picDesconectarBalanza.Location = new System.Drawing.Point(181, 529);
            this.picDesconectarBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picDesconectarBalanza.Name = "picDesconectarBalanza";
            this.picDesconectarBalanza.Size = new System.Drawing.Size(29, 31);
            this.picDesconectarBalanza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDesconectarBalanza.TabIndex = 76;
            this.picDesconectarBalanza.TabStop = false;
            this.toolTip1.SetToolTip(this.picDesconectarBalanza, "Desconectar Puerto Balanza");
            this.picDesconectarBalanza.Click += new System.EventHandler(this.picDesconectarBalanza_Click_1);
            // 
            // txtPesoMin
            // 
            this.txtPesoMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPesoMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoMin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoMin.Location = new System.Drawing.Point(28, 79);
            this.txtPesoMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesoMin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPesoMin.Name = "txtPesoMin";
            this.txtPesoMin.Size = new System.Drawing.Size(199, 23);
            this.txtPesoMin.TabIndex = 69;
            this.toolTip1.SetToolTip(this.txtPesoMin, "Peso Minimo Balanza");
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 2;
            this.btnGuardar.ActiveCornerRadius = 20;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.White;
            this.btnGuardar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleCornerRadius = 20;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardar.IdleForecolor = System.Drawing.SystemColors.ControlDark;
            this.btnGuardar.IdleLineColor = System.Drawing.SystemColors.ControlDark;
            this.btnGuardar.Location = new System.Drawing.Point(724, 520);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(162, 50);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar Y Conectar Puertos");
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // switchLectorDespacho
            // 
            this.switchLectorDespacho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchLectorDespacho.BorderRadius = 0;
            this.switchLectorDespacho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchLectorDespacho.Enabled = false;
            this.switchLectorDespacho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchLectorDespacho.Location = new System.Drawing.Point(704, 478);
            this.switchLectorDespacho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.switchLectorDespacho.Name = "switchLectorDespacho";
            this.switchLectorDespacho.Oncolor = System.Drawing.Color.LimeGreen;
            this.switchLectorDespacho.Onoffcolor = System.Drawing.Color.Red;
            this.switchLectorDespacho.Size = new System.Drawing.Size(51, 19);
            this.switchLectorDespacho.TabIndex = 19;
            this.switchLectorDespacho.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTip1.SetToolTip(this.switchLectorDespacho, "Desconectado");
            this.switchLectorDespacho.Value = false;
            // 
            // switchLectorBalanza
            // 
            this.switchLectorBalanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchLectorBalanza.BorderRadius = 0;
            this.switchLectorBalanza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchLectorBalanza.Enabled = false;
            this.switchLectorBalanza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchLectorBalanza.Location = new System.Drawing.Point(358, 478);
            this.switchLectorBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.switchLectorBalanza.Name = "switchLectorBalanza";
            this.switchLectorBalanza.Oncolor = System.Drawing.Color.LimeGreen;
            this.switchLectorBalanza.Onoffcolor = System.Drawing.Color.Red;
            this.switchLectorBalanza.Size = new System.Drawing.Size(51, 19);
            this.switchLectorBalanza.TabIndex = 17;
            this.switchLectorBalanza.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTip1.SetToolTip(this.switchLectorBalanza, "Desconectado");
            this.switchLectorBalanza.Value = false;
            // 
            // switchBalanza
            // 
            this.switchBalanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchBalanza.BorderRadius = 0;
            this.switchBalanza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchBalanza.Enabled = false;
            this.switchBalanza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchBalanza.Location = new System.Drawing.Point(28, 529);
            this.switchBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.switchBalanza.Name = "switchBalanza";
            this.switchBalanza.Oncolor = System.Drawing.Color.LimeGreen;
            this.switchBalanza.Onoffcolor = System.Drawing.Color.Red;
            this.switchBalanza.Size = new System.Drawing.Size(51, 19);
            this.switchBalanza.TabIndex = 15;
            this.switchBalanza.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTip1.SetToolTip(this.switchBalanza, "Desconectado");
            this.switchBalanza.Value = false;
            // 
            // cardMenu
            // 
            this.cardMenu.BackColor = System.Drawing.Color.White;
            this.cardMenu.BorderRadius = 0;
            this.cardMenu.BottomSahddow = false;
            this.cardMenu.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.cardMenu.Controls.Add(this.btnCancelPuertoBalanza);
            this.cardMenu.Controls.Add(this.btnCancelPuertoLectorBalanza);
            this.cardMenu.Controls.Add(this.btnCancelPuertoLector);
            this.cardMenu.Controls.Add(this.txtThreshold);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel25);
            this.cardMenu.Controls.Add(this.picDesconectarLector);
            this.cardMenu.Controls.Add(this.picDesconectarLectorBalanza);
            this.cardMenu.Controls.Add(this.picDesconectarBalanza);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel24);
            this.cardMenu.Controls.Add(this.cBoxLectorStop);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel23);
            this.cardMenu.Controls.Add(this.cBoxLectorBalanzaStop);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel22);
            this.cardMenu.Controls.Add(this.cBoxBalanzaStop);
            this.cardMenu.Controls.Add(this.txtPesoMin);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel21);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel20);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel19);
            this.cardMenu.Controls.Add(this.btnGuardar);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel15);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel11);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel16);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel12);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel17);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel13);
            this.cardMenu.Controls.Add(this.cBoxDataLector);
            this.cardMenu.Controls.Add(this.cBoxDataLectorBalanza);
            this.cardMenu.Controls.Add(this.cBoxBaudLector);
            this.cardMenu.Controls.Add(this.cBoxBaudLectorBalanza);
            this.cardMenu.Controls.Add(this.cBoxParityLector);
            this.cardMenu.Controls.Add(this.cBoxParityLectorBalanza);
            this.cardMenu.Controls.Add(this.cBoxPuertoLector);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel18);
            this.cardMenu.Controls.Add(this.cBoxPuertoLectorBalanza);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel14);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel10);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel9);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel8);
            this.cardMenu.Controls.Add(this.cBoxDataBalanza);
            this.cardMenu.Controls.Add(this.cBoxBaudBalanza);
            this.cardMenu.Controls.Add(this.cBoxParityBalanza);
            this.cardMenu.Controls.Add(this.cBoxPuertoBalanza);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel7);
            this.cardMenu.Controls.Add(this.bunifuSeparator2);
            this.cardMenu.Controls.Add(this.bunifuSeparator1);
            this.cardMenu.Controls.Add(this.switchLectorDespacho);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel6);
            this.cardMenu.Controls.Add(this.switchLectorBalanza);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel5);
            this.cardMenu.Controls.Add(this.switchBalanza);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel4);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel3);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel2);
            this.cardMenu.Controls.Add(this.bunifuCustomLabel1);
            this.cardMenu.LeftSahddow = false;
            this.cardMenu.Location = new System.Drawing.Point(-13, 70);
            this.cardMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cardMenu.Name = "cardMenu";
            this.cardMenu.RightSahddow = false;
            this.cardMenu.ShadowDepth = 50;
            this.cardMenu.Size = new System.Drawing.Size(951, 593);
            this.cardMenu.TabIndex = 8;
            // 
            // btnCancelPuertoBalanza
            // 
            this.btnCancelPuertoBalanza.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelPuertoBalanza.Image = global::Balanza.Properties.Resources.icons8_macos_cerrar_32;
            this.btnCancelPuertoBalanza.ImageActive = null;
            this.btnCancelPuertoBalanza.Location = new System.Drawing.Point(216, 198);
            this.btnCancelPuertoBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelPuertoBalanza.Name = "btnCancelPuertoBalanza";
            this.btnCancelPuertoBalanza.Size = new System.Drawing.Size(29, 28);
            this.btnCancelPuertoBalanza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelPuertoBalanza.TabIndex = 84;
            this.btnCancelPuertoBalanza.TabStop = false;
            this.btnCancelPuertoBalanza.Zoom = 10;
            this.btnCancelPuertoBalanza.Click += new System.EventHandler(this.btnCancelPuertoBalanza_Click_1);
            // 
            // btnCancelPuertoLectorBalanza
            // 
            this.btnCancelPuertoLectorBalanza.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelPuertoLectorBalanza.Image = global::Balanza.Properties.Resources.icons8_macos_cerrar_32;
            this.btnCancelPuertoLectorBalanza.ImageActive = null;
            this.btnCancelPuertoLectorBalanza.Location = new System.Drawing.Point(546, 197);
            this.btnCancelPuertoLectorBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelPuertoLectorBalanza.Name = "btnCancelPuertoLectorBalanza";
            this.btnCancelPuertoLectorBalanza.Size = new System.Drawing.Size(29, 28);
            this.btnCancelPuertoLectorBalanza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelPuertoLectorBalanza.TabIndex = 83;
            this.btnCancelPuertoLectorBalanza.TabStop = false;
            this.btnCancelPuertoLectorBalanza.Zoom = 10;
            this.btnCancelPuertoLectorBalanza.Click += new System.EventHandler(this.btnCancelPuertoLectorBalanza_Click_1);
            // 
            // btnCancelPuertoLector
            // 
            this.btnCancelPuertoLector.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelPuertoLector.Image = global::Balanza.Properties.Resources.icons8_macos_cerrar_32;
            this.btnCancelPuertoLector.ImageActive = null;
            this.btnCancelPuertoLector.Location = new System.Drawing.Point(892, 198);
            this.btnCancelPuertoLector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelPuertoLector.Name = "btnCancelPuertoLector";
            this.btnCancelPuertoLector.Size = new System.Drawing.Size(29, 28);
            this.btnCancelPuertoLector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelPuertoLector.TabIndex = 82;
            this.btnCancelPuertoLector.TabStop = false;
            this.btnCancelPuertoLector.Zoom = 10;
            this.btnCancelPuertoLector.Click += new System.EventHandler(this.btnCancelPuertoLector_Click_1);
            // 
            // bunifuCustomLabel25
            // 
            this.bunifuCustomLabel25.AutoSize = true;
            this.bunifuCustomLabel25.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel25.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel25.Location = new System.Drawing.Point(29, 474);
            this.bunifuCustomLabel25.Name = "bunifuCustomLabel25";
            this.bunifuCustomLabel25.Size = new System.Drawing.Size(91, 17);
            this.bunifuCustomLabel25.TabIndex = 80;
            this.bunifuCustomLabel25.Text = "Bits Threshold";
            // 
            // bunifuCustomLabel24
            // 
            this.bunifuCustomLabel24.AutoSize = true;
            this.bunifuCustomLabel24.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel24.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel24.Location = new System.Drawing.Point(702, 415);
            this.bunifuCustomLabel24.Name = "bunifuCustomLabel24";
            this.bunifuCustomLabel24.Size = new System.Drawing.Size(61, 17);
            this.bunifuCustomLabel24.TabIndex = 75;
            this.bunifuCustomLabel24.Text = "Stop Bits";
            // 
            // cBoxLectorStop
            // 
            this.cBoxLectorStop.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxLectorStop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxLectorStop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxLectorStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxLectorStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxLectorStop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxLectorStop.FormattingEnabled = true;
            this.cBoxLectorStop.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxLectorStop.Location = new System.Drawing.Point(704, 439);
            this.cBoxLectorStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxLectorStop.Name = "cBoxLectorStop";
            this.cBoxLectorStop.Size = new System.Drawing.Size(182, 25);
            this.cBoxLectorStop.TabIndex = 74;
            // 
            // bunifuCustomLabel23
            // 
            this.bunifuCustomLabel23.AutoSize = true;
            this.bunifuCustomLabel23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel23.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel23.Location = new System.Drawing.Point(355, 415);
            this.bunifuCustomLabel23.Name = "bunifuCustomLabel23";
            this.bunifuCustomLabel23.Size = new System.Drawing.Size(61, 17);
            this.bunifuCustomLabel23.TabIndex = 73;
            this.bunifuCustomLabel23.Text = "Stop Bits";
            // 
            // cBoxLectorBalanzaStop
            // 
            this.cBoxLectorBalanzaStop.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxLectorBalanzaStop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxLectorBalanzaStop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxLectorBalanzaStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxLectorBalanzaStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxLectorBalanzaStop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxLectorBalanzaStop.FormattingEnabled = true;
            this.cBoxLectorBalanzaStop.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxLectorBalanzaStop.Location = new System.Drawing.Point(358, 439);
            this.cBoxLectorBalanzaStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxLectorBalanzaStop.Name = "cBoxLectorBalanzaStop";
            this.cBoxLectorBalanzaStop.Size = new System.Drawing.Size(182, 25);
            this.cBoxLectorBalanzaStop.TabIndex = 72;
            // 
            // bunifuCustomLabel22
            // 
            this.bunifuCustomLabel22.AutoSize = true;
            this.bunifuCustomLabel22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel22.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel22.Location = new System.Drawing.Point(29, 415);
            this.bunifuCustomLabel22.Name = "bunifuCustomLabel22";
            this.bunifuCustomLabel22.Size = new System.Drawing.Size(61, 17);
            this.bunifuCustomLabel22.TabIndex = 71;
            this.bunifuCustomLabel22.Text = "Stop Bits";
            // 
            // cBoxBalanzaStop
            // 
            this.cBoxBalanzaStop.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxBalanzaStop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxBalanzaStop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxBalanzaStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxBalanzaStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxBalanzaStop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxBalanzaStop.FormattingEnabled = true;
            this.cBoxBalanzaStop.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxBalanzaStop.Location = new System.Drawing.Point(28, 439);
            this.cBoxBalanzaStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxBalanzaStop.Name = "cBoxBalanzaStop";
            this.cBoxBalanzaStop.Size = new System.Drawing.Size(182, 25);
            this.cBoxBalanzaStop.TabIndex = 70;
            // 
            // bunifuCustomLabel21
            // 
            this.bunifuCustomLabel21.AutoSize = true;
            this.bunifuCustomLabel21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel21.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel21.Location = new System.Drawing.Point(702, 180);
            this.bunifuCustomLabel21.Name = "bunifuCustomLabel21";
            this.bunifuCustomLabel21.Size = new System.Drawing.Size(50, 17);
            this.bunifuCustomLabel21.TabIndex = 68;
            this.bunifuCustomLabel21.Text = "Puerto";
            // 
            // bunifuCustomLabel20
            // 
            this.bunifuCustomLabel20.AutoSize = true;
            this.bunifuCustomLabel20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel20.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel20.Location = new System.Drawing.Point(355, 180);
            this.bunifuCustomLabel20.Name = "bunifuCustomLabel20";
            this.bunifuCustomLabel20.Size = new System.Drawing.Size(50, 17);
            this.bunifuCustomLabel20.TabIndex = 67;
            this.bunifuCustomLabel20.Text = "Puerto";
            // 
            // bunifuCustomLabel19
            // 
            this.bunifuCustomLabel19.AutoSize = true;
            this.bunifuCustomLabel19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel19.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel19.Location = new System.Drawing.Point(24, 180);
            this.bunifuCustomLabel19.Name = "bunifuCustomLabel19";
            this.bunifuCustomLabel19.Size = new System.Drawing.Size(50, 17);
            this.bunifuCustomLabel19.TabIndex = 66;
            this.bunifuCustomLabel19.Text = "Puerto";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(702, 356);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(65, 17);
            this.bunifuCustomLabel15.TabIndex = 62;
            this.bunifuCustomLabel15.Text = "Data Bits";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(355, 356);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(65, 17);
            this.bunifuCustomLabel11.TabIndex = 62;
            this.bunifuCustomLabel11.Text = "Data Bits";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(702, 297);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(75, 17);
            this.bunifuCustomLabel16.TabIndex = 61;
            this.bunifuCustomLabel16.Text = "Baud Rate";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(355, 297);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(75, 17);
            this.bunifuCustomLabel12.TabIndex = 61;
            this.bunifuCustomLabel12.Text = "Baud Rate";
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel17.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(702, 238);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(67, 17);
            this.bunifuCustomLabel17.TabIndex = 60;
            this.bunifuCustomLabel17.Text = "Parity Bits";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(355, 238);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(67, 17);
            this.bunifuCustomLabel13.TabIndex = 60;
            this.bunifuCustomLabel13.Text = "Parity Bits";
            // 
            // cBoxDataLector
            // 
            this.cBoxDataLector.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxDataLector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxDataLector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxDataLector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxDataLector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDataLector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxDataLector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxDataLector.FormattingEnabled = true;
            this.cBoxDataLector.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "10"});
            this.cBoxDataLector.Location = new System.Drawing.Point(703, 380);
            this.cBoxDataLector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxDataLector.Name = "cBoxDataLector";
            this.cBoxDataLector.Size = new System.Drawing.Size(183, 25);
            this.cBoxDataLector.TabIndex = 59;
            // 
            // cBoxDataLectorBalanza
            // 
            this.cBoxDataLectorBalanza.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxDataLectorBalanza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxDataLectorBalanza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxDataLectorBalanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxDataLectorBalanza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDataLectorBalanza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxDataLectorBalanza.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxDataLectorBalanza.FormattingEnabled = true;
            this.cBoxDataLectorBalanza.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "10"});
            this.cBoxDataLectorBalanza.Location = new System.Drawing.Point(358, 380);
            this.cBoxDataLectorBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxDataLectorBalanza.Name = "cBoxDataLectorBalanza";
            this.cBoxDataLectorBalanza.Size = new System.Drawing.Size(182, 25);
            this.cBoxDataLectorBalanza.TabIndex = 59;
            // 
            // cBoxBaudLector
            // 
            this.cBoxBaudLector.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxBaudLector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxBaudLector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxBaudLector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxBaudLector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxBaudLector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxBaudLector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxBaudLector.FormattingEnabled = true;
            this.cBoxBaudLector.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600"});
            this.cBoxBaudLector.Location = new System.Drawing.Point(704, 321);
            this.cBoxBaudLector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxBaudLector.Name = "cBoxBaudLector";
            this.cBoxBaudLector.Size = new System.Drawing.Size(182, 25);
            this.cBoxBaudLector.TabIndex = 58;
            // 
            // cBoxBaudLectorBalanza
            // 
            this.cBoxBaudLectorBalanza.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxBaudLectorBalanza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxBaudLectorBalanza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxBaudLectorBalanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxBaudLectorBalanza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxBaudLectorBalanza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxBaudLectorBalanza.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxBaudLectorBalanza.FormattingEnabled = true;
            this.cBoxBaudLectorBalanza.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600"});
            this.cBoxBaudLectorBalanza.Location = new System.Drawing.Point(358, 321);
            this.cBoxBaudLectorBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxBaudLectorBalanza.Name = "cBoxBaudLectorBalanza";
            this.cBoxBaudLectorBalanza.Size = new System.Drawing.Size(182, 25);
            this.cBoxBaudLectorBalanza.TabIndex = 58;
            // 
            // cBoxParityLector
            // 
            this.cBoxParityLector.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxParityLector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxParityLector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxParityLector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxParityLector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxParityLector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxParityLector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxParityLector.FormattingEnabled = true;
            this.cBoxParityLector.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityLector.Location = new System.Drawing.Point(704, 262);
            this.cBoxParityLector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxParityLector.Name = "cBoxParityLector";
            this.cBoxParityLector.Size = new System.Drawing.Size(182, 25);
            this.cBoxParityLector.TabIndex = 57;
            // 
            // cBoxParityLectorBalanza
            // 
            this.cBoxParityLectorBalanza.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxParityLectorBalanza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxParityLectorBalanza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxParityLectorBalanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxParityLectorBalanza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxParityLectorBalanza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxParityLectorBalanza.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxParityLectorBalanza.FormattingEnabled = true;
            this.cBoxParityLectorBalanza.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityLectorBalanza.Location = new System.Drawing.Point(358, 262);
            this.cBoxParityLectorBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxParityLectorBalanza.Name = "cBoxParityLectorBalanza";
            this.cBoxParityLectorBalanza.Size = new System.Drawing.Size(182, 25);
            this.cBoxParityLectorBalanza.TabIndex = 57;
            // 
            // cBoxPuertoLector
            // 
            this.cBoxPuertoLector.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxPuertoLector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxPuertoLector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxPuertoLector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxPuertoLector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPuertoLector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPuertoLector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPuertoLector.FormattingEnabled = true;
            this.cBoxPuertoLector.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxPuertoLector.Location = new System.Drawing.Point(704, 201);
            this.cBoxPuertoLector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxPuertoLector.Name = "cBoxPuertoLector";
            this.cBoxPuertoLector.Size = new System.Drawing.Size(182, 25);
            this.cBoxPuertoLector.TabIndex = 56;
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(717, 198);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(50, 17);
            this.bunifuCustomLabel18.TabIndex = 55;
            this.bunifuCustomLabel18.Text = "Puerto";
            // 
            // cBoxPuertoLectorBalanza
            // 
            this.cBoxPuertoLectorBalanza.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxPuertoLectorBalanza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxPuertoLectorBalanza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxPuertoLectorBalanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxPuertoLectorBalanza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPuertoLectorBalanza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPuertoLectorBalanza.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPuertoLectorBalanza.FormattingEnabled = true;
            this.cBoxPuertoLectorBalanza.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxPuertoLectorBalanza.Location = new System.Drawing.Point(358, 200);
            this.cBoxPuertoLectorBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxPuertoLectorBalanza.Name = "cBoxPuertoLectorBalanza";
            this.cBoxPuertoLectorBalanza.Size = new System.Drawing.Size(182, 25);
            this.cBoxPuertoLectorBalanza.TabIndex = 56;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(371, 201);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(50, 17);
            this.bunifuCustomLabel14.TabIndex = 55;
            this.bunifuCustomLabel14.Text = "Puerto";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(29, 356);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(65, 17);
            this.bunifuCustomLabel10.TabIndex = 54;
            this.bunifuCustomLabel10.Text = "Data Bits";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(29, 297);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(75, 17);
            this.bunifuCustomLabel9.TabIndex = 53;
            this.bunifuCustomLabel9.Text = "Baud Rate";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(29, 238);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(67, 17);
            this.bunifuCustomLabel8.TabIndex = 52;
            this.bunifuCustomLabel8.Text = "Parity Bits";
            // 
            // cBoxDataBalanza
            // 
            this.cBoxDataBalanza.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxDataBalanza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxDataBalanza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxDataBalanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxDataBalanza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDataBalanza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxDataBalanza.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxDataBalanza.FormattingEnabled = true;
            this.cBoxDataBalanza.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "10"});
            this.cBoxDataBalanza.Location = new System.Drawing.Point(28, 380);
            this.cBoxDataBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxDataBalanza.Name = "cBoxDataBalanza";
            this.cBoxDataBalanza.Size = new System.Drawing.Size(182, 25);
            this.cBoxDataBalanza.TabIndex = 51;
            // 
            // cBoxBaudBalanza
            // 
            this.cBoxBaudBalanza.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxBaudBalanza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxBaudBalanza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxBaudBalanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxBaudBalanza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxBaudBalanza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxBaudBalanza.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxBaudBalanza.FormattingEnabled = true;
            this.cBoxBaudBalanza.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600"});
            this.cBoxBaudBalanza.Location = new System.Drawing.Point(28, 321);
            this.cBoxBaudBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxBaudBalanza.Name = "cBoxBaudBalanza";
            this.cBoxBaudBalanza.Size = new System.Drawing.Size(182, 25);
            this.cBoxBaudBalanza.TabIndex = 50;
            // 
            // cBoxParityBalanza
            // 
            this.cBoxParityBalanza.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxParityBalanza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxParityBalanza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxParityBalanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxParityBalanza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxParityBalanza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxParityBalanza.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxParityBalanza.FormattingEnabled = true;
            this.cBoxParityBalanza.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBalanza.Location = new System.Drawing.Point(28, 262);
            this.cBoxParityBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxParityBalanza.Name = "cBoxParityBalanza";
            this.cBoxParityBalanza.Size = new System.Drawing.Size(182, 25);
            this.cBoxParityBalanza.TabIndex = 49;
            // 
            // cBoxPuertoBalanza
            // 
            this.cBoxPuertoBalanza.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxPuertoBalanza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxPuertoBalanza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxPuertoBalanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cBoxPuertoBalanza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPuertoBalanza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPuertoBalanza.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPuertoBalanza.FormattingEnabled = true;
            this.cBoxPuertoBalanza.Location = new System.Drawing.Point(28, 201);
            this.cBoxPuertoBalanza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxPuertoBalanza.Name = "cBoxPuertoBalanza";
            this.cBoxPuertoBalanza.Size = new System.Drawing.Size(182, 25);
            this.cBoxPuertoBalanza.TabIndex = 48;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(41, 201);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(50, 17);
            this.bunifuCustomLabel7.TabIndex = 22;
            this.bunifuCustomLabel7.Text = "Puerto";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(28, 142);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1041, 6);
            this.bunifuSeparator2.TabIndex = 21;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(28, 43);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1041, 6);
            this.bunifuSeparator1.TabIndex = 20;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(699, 151);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(143, 21);
            this.bunifuCustomLabel6.TabIndex = 18;
            this.bunifuCustomLabel6.Text = "Lector Despacho";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(353, 151);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(125, 21);
            this.bunifuCustomLabel5.TabIndex = 16;
            this.bunifuCustomLabel5.Text = "Lector Balanza";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(23, 151);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(72, 21);
            this.bunifuCustomLabel4.TabIndex = 14;
            this.bunifuCustomLabel4.Text = "Balanza";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(23, 111);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(77, 22);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Puertos";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(23, 49);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(105, 21);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Peso Mínimo";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(83, 22);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Balanza";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AjustesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 650);
            this.Controls.Add(this.cardMenu);
            this.Controls.Add(this.lblIndice);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AjustesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AjustesForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesconectarLector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesconectarLectorBalanza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesconectarBalanza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoMin)).EndInit();
            this.cardMenu.ResumeLayout(false);
            this.cardMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelPuertoBalanza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelPuertoLectorBalanza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelPuertoLector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblIndice;
        public System.IO.Ports.SerialPort balanzaCOM;
        public System.IO.Ports.SerialPort lectorBalanzaCOM;
        public System.IO.Ports.SerialPort lectorCOM;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuCards cardMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelPuertoBalanza;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelPuertoLectorBalanza;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelPuertoLector;
        private System.Windows.Forms.NumericUpDown txtThreshold;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel25;
        private System.Windows.Forms.PictureBox picDesconectarLector;
        private System.Windows.Forms.PictureBox picDesconectarLectorBalanza;
        private System.Windows.Forms.PictureBox picDesconectarBalanza;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel24;
        private System.Windows.Forms.ComboBox cBoxLectorStop;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel23;
        private System.Windows.Forms.ComboBox cBoxLectorBalanzaStop;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel22;
        private System.Windows.Forms.ComboBox cBoxBalanzaStop;
        private System.Windows.Forms.NumericUpDown txtPesoMin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel21;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel20;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel19;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private System.Windows.Forms.ComboBox cBoxDataLector;
        private System.Windows.Forms.ComboBox cBoxDataLectorBalanza;
        private System.Windows.Forms.ComboBox cBoxBaudLector;
        private System.Windows.Forms.ComboBox cBoxBaudLectorBalanza;
        private System.Windows.Forms.ComboBox cBoxParityLector;
        private System.Windows.Forms.ComboBox cBoxParityLectorBalanza;
        private System.Windows.Forms.ComboBox cBoxPuertoLector;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private System.Windows.Forms.ComboBox cBoxPuertoLectorBalanza;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.ComboBox cBoxDataBalanza;
        private System.Windows.Forms.ComboBox cBoxBaudBalanza;
        private System.Windows.Forms.ComboBox cBoxParityBalanza;
        private System.Windows.Forms.ComboBox cBoxPuertoBalanza;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSwitch switchLectorDespacho;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuSwitch switchLectorBalanza;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuSwitch switchBalanza;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}