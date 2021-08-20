namespace Balanza.Forms
{
    partial class TableroPrincipalForm
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableroPrincipalForm));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.msjEstadoCard = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblMsjCardIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMensaje = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cardLog = new Bunifu.Framework.UI.BunifuCards();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.picActualizar = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.switchBalanza = new Bunifu.Framework.UI.BunifuSwitch();
            this.switchLectorTarjeta = new Bunifu.Framework.UI.BunifuSwitch();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPuertosCardIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.semaforoCard = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.picBoxSemaforoRojo = new System.Windows.Forms.PictureBox();
            this.lblSemaforoCardIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picBoxSemaforoVerde = new System.Windows.Forms.PictureBox();
            this.pesoCard = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblPesoCardIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPeso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nroTarjetaCard = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblNroTarjeta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNroCardIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.slideTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.fadeTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.semaforoTransition = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.toolTipBalanza = new System.Windows.Forms.ToolTip(this.components);
            this.balancaCOM = new System.IO.Ports.SerialPort(this.components);
            this.lectorCOM = new System.IO.Ports.SerialPort(this.components);
            this.estadoTimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuCards1.SuspendLayout();
            this.msjEstadoCard.SuspendLayout();
            this.cardLog.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picActualizar)).BeginInit();
            this.semaforoCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSemaforoRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSemaforoVerde)).BeginInit();
            this.pesoCard.SuspendLayout();
            this.nroTarjetaCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblIndice, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.lblIndice, BunifuAnimatorNS.DecorationType.None);
            this.lblIndice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndice.Location = new System.Drawing.Point(12, 18);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(187, 22);
            this.lblIndice.TabIndex = 1;
            this.lblIndice.Text = "Monitor Balanza sur";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.bunifuCards1.Controls.Add(this.msjEstadoCard);
            this.bunifuCards1.Controls.Add(this.cardLog);
            this.bunifuCards1.Controls.Add(this.bunifuCards2);
            this.bunifuCards1.Controls.Add(this.semaforoCard);
            this.bunifuCards1.Controls.Add(this.pesoCard);
            this.bunifuCards1.Controls.Add(this.nroTarjetaCard);
            this.slideTransition.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-13, 70);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.ShadowDepth = 50;
            this.bunifuCards1.Size = new System.Drawing.Size(951, 593);
            this.bunifuCards1.TabIndex = 0;
            // 
            // msjEstadoCard
            // 
            this.msjEstadoCard.BackColor = System.Drawing.Color.White;
            this.msjEstadoCard.BorderRadius = 0;
            this.msjEstadoCard.BottomSahddow = true;
            this.msjEstadoCard.color = System.Drawing.Color.Gray;
            this.msjEstadoCard.Controls.Add(this.bunifuSeparator2);
            this.msjEstadoCard.Controls.Add(this.lblMsjCardIndice);
            this.msjEstadoCard.Controls.Add(this.lblMensaje);
            this.slideTransition.SetDecoration(this.msjEstadoCard, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.msjEstadoCard, BunifuAnimatorNS.DecorationType.None);
            this.msjEstadoCard.LeftSahddow = true;
            this.msjEstadoCard.Location = new System.Drawing.Point(18, 440);
            this.msjEstadoCard.Name = "msjEstadoCard";
            this.msjEstadoCard.RightSahddow = true;
            this.msjEstadoCard.ShadowDepth = 60;
            this.msjEstadoCard.Size = new System.Drawing.Size(661, 138);
            this.msjEstadoCard.TabIndex = 23;
            this.toolTipBalanza.SetToolTip(this.msjEstadoCard, "Estado del Sistema");
            this.msjEstadoCard.MouseEnter += new System.EventHandler(this.msjEstadoCard_MouseEnter);
            this.msjEstadoCard.MouseLeave += new System.EventHandler(this.msjEstadoCard_MouseLeave);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.slideTransition.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(7, 36);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(189, 10);
            this.bunifuSeparator2.TabIndex = 13;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // lblMsjCardIndice
            // 
            this.lblMsjCardIndice.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblMsjCardIndice, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.lblMsjCardIndice, BunifuAnimatorNS.DecorationType.None);
            this.lblMsjCardIndice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjCardIndice.ForeColor = System.Drawing.Color.Black;
            this.lblMsjCardIndice.Location = new System.Drawing.Point(3, 10);
            this.lblMsjCardIndice.Name = "lblMsjCardIndice";
            this.lblMsjCardIndice.Size = new System.Drawing.Size(147, 18);
            this.lblMsjCardIndice.TabIndex = 7;
            this.lblMsjCardIndice.Text = "Mensaje de Estado";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AllowDrop = true;
            this.lblMensaje.AutoEllipsis = true;
            this.lblMensaje.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblMensaje, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.lblMensaje, BunifuAnimatorNS.DecorationType.None);
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMensaje.Location = new System.Drawing.Point(4, 58);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(193, 38);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "DISPONIBLE";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipBalanza.SetToolTip(this.lblMensaje, "Estado del Sistema");
            // 
            // cardLog
            // 
            this.cardLog.BackColor = System.Drawing.Color.White;
            this.cardLog.BorderRadius = 0;
            this.cardLog.BottomSahddow = true;
            this.cardLog.color = System.Drawing.Color.Gray;
            this.cardLog.Controls.Add(this.txtLog);
            this.cardLog.Controls.Add(this.bunifuSeparator6);
            this.cardLog.Controls.Add(this.bunifuCustomLabel1);
            this.slideTransition.SetDecoration(this.cardLog, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.cardLog, BunifuAnimatorNS.DecorationType.None);
            this.cardLog.LeftSahddow = true;
            this.cardLog.Location = new System.Drawing.Point(18, 443);
            this.cardLog.Name = "cardLog";
            this.cardLog.RightSahddow = true;
            this.cardLog.ShadowDepth = 60;
            this.cardLog.Size = new System.Drawing.Size(661, 135);
            this.cardLog.TabIndex = 32;
            this.toolTipBalanza.SetToolTip(this.cardLog, "Estado del Sistema");
            this.cardLog.Visible = false;
            // 
            // txtLog
            // 
            this.fadeTransition.SetDecoration(this.txtLog, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.txtLog, BunifuAnimatorNS.DecorationType.None);
            this.txtLog.Location = new System.Drawing.Point(6, 44);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(644, 82);
            this.txtLog.TabIndex = 14;
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.slideTransition.SetDecoration(this.bunifuSeparator6, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.bunifuSeparator6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator6.LineThickness = 1;
            this.bunifuSeparator6.Location = new System.Drawing.Point(7, 33);
            this.bunifuSeparator6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(189, 2);
            this.bunifuSeparator6.TabIndex = 13;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.fadeTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(35, 18);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Log";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 0;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Gray;
            this.bunifuCards2.Controls.Add(this.picActualizar);
            this.bunifuCards2.Controls.Add(this.bunifuSeparator5);
            this.bunifuCards2.Controls.Add(this.switchBalanza);
            this.bunifuCards2.Controls.Add(this.switchLectorTarjeta);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel9);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuCards2.Controls.Add(this.lblPuertosCardIndice);
            this.slideTransition.SetDecoration(this.bunifuCards2, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.bunifuCards2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards2.LeftSahddow = true;
            this.bunifuCards2.Location = new System.Drawing.Point(685, 440);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 60;
            this.bunifuCards2.Size = new System.Drawing.Size(231, 138);
            this.bunifuCards2.TabIndex = 31;
            this.toolTipBalanza.SetToolTip(this.bunifuCards2, "Estado de los Puertos");
            this.bunifuCards2.MouseEnter += new System.EventHandler(this.bunifuCards2_MouseEnter_2);
            this.bunifuCards2.MouseLeave += new System.EventHandler(this.bunifuCards2_MouseLeave_1);
            // 
            // picActualizar
            // 
            this.picActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.picActualizar, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.picActualizar, BunifuAnimatorNS.DecorationType.None);
            this.picActualizar.Image = global::Balanza.Properties.Resources.icons8_17387_0_73139_actualizar_izquierda_32_flechas_50;
            this.picActualizar.Location = new System.Drawing.Point(195, 6);
            this.picActualizar.Name = "picActualizar";
            this.picActualizar.Size = new System.Drawing.Size(30, 28);
            this.picActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picActualizar.TabIndex = 77;
            this.picActualizar.TabStop = false;
            this.toolTipBalanza.SetToolTip(this.picActualizar, "Actualizar Puertos");
            this.picActualizar.Click += new System.EventHandler(this.picActualizar_Click);
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.slideTransition.SetDecoration(this.bunifuSeparator5, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.bunifuSeparator5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(6, 28);
            this.bunifuSeparator5.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(120, 10);
            this.bunifuSeparator5.TabIndex = 31;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // switchBalanza
            // 
            this.switchBalanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchBalanza.BorderRadius = 5;
            this.switchBalanza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.switchBalanza, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.switchBalanza, BunifuAnimatorNS.DecorationType.None);
            this.switchBalanza.Enabled = false;
            this.switchBalanza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchBalanza.Location = new System.Drawing.Point(174, 107);
            this.switchBalanza.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.switchBalanza.Name = "switchBalanza";
            this.switchBalanza.Oncolor = System.Drawing.Color.LimeGreen;
            this.switchBalanza.Onoffcolor = System.Drawing.Color.Red;
            this.switchBalanza.Size = new System.Drawing.Size(51, 19);
            this.switchBalanza.TabIndex = 30;
            this.switchBalanza.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchBalanza.Value = false;
            // 
            // switchLectorTarjeta
            // 
            this.switchLectorTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchLectorTarjeta.BorderRadius = 5;
            this.switchLectorTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.switchLectorTarjeta, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.switchLectorTarjeta, BunifuAnimatorNS.DecorationType.None);
            this.switchLectorTarjeta.Enabled = false;
            this.switchLectorTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchLectorTarjeta.Location = new System.Drawing.Point(174, 58);
            this.switchLectorTarjeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.switchLectorTarjeta.Name = "switchLectorTarjeta";
            this.switchLectorTarjeta.Oncolor = System.Drawing.Color.LimeGreen;
            this.switchLectorTarjeta.Onoffcolor = System.Drawing.Color.Red;
            this.switchLectorTarjeta.Size = new System.Drawing.Size(51, 19);
            this.switchLectorTarjeta.TabIndex = 29;
            this.switchLectorTarjeta.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchLectorTarjeta.Value = false;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.fadeTransition.SetDecoration(this.bunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.bunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(102, 106);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(66, 20);
            this.bunifuCustomLabel9.TabIndex = 28;
            this.bunifuCustomLabel9.Text = "Balanza";
            this.toolTipBalanza.SetToolTip(this.bunifuCustomLabel9, "Puerto Balanza");
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.fadeTransition.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(54, 57);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(114, 20);
            this.bunifuCustomLabel7.TabIndex = 26;
            this.bunifuCustomLabel7.Text = "Lector Tarjetas";
            this.toolTipBalanza.SetToolTip(this.bunifuCustomLabel7, "Puerto Lector Tarjetas");
            // 
            // lblPuertosCardIndice
            // 
            this.lblPuertosCardIndice.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblPuertosCardIndice, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.lblPuertosCardIndice, BunifuAnimatorNS.DecorationType.None);
            this.lblPuertosCardIndice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertosCardIndice.ForeColor = System.Drawing.Color.Black;
            this.lblPuertosCardIndice.Location = new System.Drawing.Point(3, 6);
            this.lblPuertosCardIndice.Name = "lblPuertosCardIndice";
            this.lblPuertosCardIndice.Size = new System.Drawing.Size(60, 18);
            this.lblPuertosCardIndice.TabIndex = 7;
            this.lblPuertosCardIndice.Text = "Puertos";
            // 
            // semaforoCard
            // 
            this.semaforoCard.BackColor = System.Drawing.Color.White;
            this.semaforoCard.BorderRadius = 0;
            this.semaforoCard.BottomSahddow = true;
            this.semaforoCard.color = System.Drawing.Color.Gray;
            this.semaforoCard.Controls.Add(this.bunifuSeparator1);
            this.semaforoCard.Controls.Add(this.picBoxSemaforoRojo);
            this.semaforoCard.Controls.Add(this.lblSemaforoCardIndice);
            this.semaforoCard.Controls.Add(this.picBoxSemaforoVerde);
            this.slideTransition.SetDecoration(this.semaforoCard, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.semaforoCard, BunifuAnimatorNS.DecorationType.None);
            this.semaforoCard.LeftSahddow = true;
            this.semaforoCard.Location = new System.Drawing.Point(18, 10);
            this.semaforoCard.Name = "semaforoCard";
            this.semaforoCard.RightSahddow = true;
            this.semaforoCard.ShadowDepth = 60;
            this.semaforoCard.Size = new System.Drawing.Size(898, 163);
            this.semaforoCard.TabIndex = 24;
            this.toolTipBalanza.SetToolTip(this.semaforoCard, "Estado del Semaforo");
            this.semaforoCard.MouseEnter += new System.EventHandler(this.bunifuCards2_MouseEnter_1);
            this.semaforoCard.MouseLeave += new System.EventHandler(this.bunifuCards2_MouseLeave);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.slideTransition.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(425, 27);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(29, 130);
            this.bunifuSeparator1.TabIndex = 10;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // picBoxSemaforoRojo
            // 
            this.fadeTransition.SetDecoration(this.picBoxSemaforoRojo, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.picBoxSemaforoRojo, BunifuAnimatorNS.DecorationType.None);
            this.picBoxSemaforoRojo.Image = global::Balanza.Properties.Resources._276386_removebg_preview;
            this.picBoxSemaforoRojo.Location = new System.Drawing.Point(514, 6);
            this.picBoxSemaforoRojo.Name = "picBoxSemaforoRojo";
            this.picBoxSemaforoRojo.Size = new System.Drawing.Size(381, 151);
            this.picBoxSemaforoRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSemaforoRojo.TabIndex = 7;
            this.picBoxSemaforoRojo.TabStop = false;
            this.toolTipBalanza.SetToolTip(this.picBoxSemaforoRojo, "Balanza Ocupada");
            this.picBoxSemaforoRojo.Visible = false;
            this.picBoxSemaforoRojo.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.picBoxSemaforoRojo.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // lblSemaforoCardIndice
            // 
            this.lblSemaforoCardIndice.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblSemaforoCardIndice, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.lblSemaforoCardIndice, BunifuAnimatorNS.DecorationType.None);
            this.lblSemaforoCardIndice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemaforoCardIndice.ForeColor = System.Drawing.Color.Black;
            this.lblSemaforoCardIndice.Location = new System.Drawing.Point(402, 7);
            this.lblSemaforoCardIndice.Name = "lblSemaforoCardIndice";
            this.lblSemaforoCardIndice.Size = new System.Drawing.Size(79, 18);
            this.lblSemaforoCardIndice.TabIndex = 5;
            this.lblSemaforoCardIndice.Text = "Semáforo";
            // 
            // picBoxSemaforoVerde
            // 
            this.fadeTransition.SetDecoration(this.picBoxSemaforoVerde, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.picBoxSemaforoVerde, BunifuAnimatorNS.DecorationType.None);
            this.picBoxSemaforoVerde.Image = global::Balanza.Properties.Resources._276841_removebg_preview;
            this.picBoxSemaforoVerde.Location = new System.Drawing.Point(10, 7);
            this.picBoxSemaforoVerde.Name = "picBoxSemaforoVerde";
            this.picBoxSemaforoVerde.Size = new System.Drawing.Size(374, 150);
            this.picBoxSemaforoVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSemaforoVerde.TabIndex = 6;
            this.picBoxSemaforoVerde.TabStop = false;
            this.toolTipBalanza.SetToolTip(this.picBoxSemaforoVerde, "Balanza Disponible");
            this.picBoxSemaforoVerde.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.picBoxSemaforoVerde.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pesoCard
            // 
            this.pesoCard.BackColor = System.Drawing.Color.White;
            this.pesoCard.BorderRadius = 0;
            this.pesoCard.BottomSahddow = true;
            this.pesoCard.color = System.Drawing.Color.Gray;
            this.pesoCard.Controls.Add(this.bunifuSeparator4);
            this.pesoCard.Controls.Add(this.lblPesoCardIndice);
            this.pesoCard.Controls.Add(this.lblPeso);
            this.slideTransition.SetDecoration(this.pesoCard, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.pesoCard, BunifuAnimatorNS.DecorationType.None);
            this.pesoCard.LeftSahddow = true;
            this.pesoCard.Location = new System.Drawing.Point(465, 179);
            this.pesoCard.Name = "pesoCard";
            this.pesoCard.RightSahddow = true;
            this.pesoCard.ShadowDepth = 60;
            this.pesoCard.Size = new System.Drawing.Size(451, 255);
            this.pesoCard.TabIndex = 22;
            this.toolTipBalanza.SetToolTip(this.pesoCard, "Peso Registrado (Kg.)");
            this.pesoCard.MouseEnter += new System.EventHandler(this.pesoCard_MouseEnter);
            this.pesoCard.MouseLeave += new System.EventHandler(this.pesoCard_MouseLeave);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.slideTransition.SetDecoration(this.bunifuSeparator4, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.bunifuSeparator4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(3, 38);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(328, 12);
            this.bunifuSeparator4.TabIndex = 32;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // lblPesoCardIndice
            // 
            this.lblPesoCardIndice.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblPesoCardIndice, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.lblPesoCardIndice, BunifuAnimatorNS.DecorationType.None);
            this.lblPesoCardIndice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoCardIndice.ForeColor = System.Drawing.Color.Black;
            this.lblPesoCardIndice.Location = new System.Drawing.Point(3, 12);
            this.lblPesoCardIndice.Name = "lblPesoCardIndice";
            this.lblPesoCardIndice.Size = new System.Drawing.Size(81, 18);
            this.lblPesoCardIndice.TabIndex = 7;
            this.lblPesoCardIndice.Text = "Peso (Kg.)";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblPeso, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.lblPeso, BunifuAnimatorNS.DecorationType.None);
            this.lblPeso.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.lblPeso.ForeColor = System.Drawing.Color.Black;
            this.lblPeso.Location = new System.Drawing.Point(123, 96);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(208, 65);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "000000";
            this.toolTipBalanza.SetToolTip(this.lblPeso, "Peso Registrado (Kg.)");
            // 
            // nroTarjetaCard
            // 
            this.nroTarjetaCard.BackColor = System.Drawing.Color.White;
            this.nroTarjetaCard.BorderRadius = 0;
            this.nroTarjetaCard.BottomSahddow = true;
            this.nroTarjetaCard.color = System.Drawing.Color.Gray;
            this.nroTarjetaCard.Controls.Add(this.bunifuSeparator3);
            this.nroTarjetaCard.Controls.Add(this.lblNroTarjeta);
            this.nroTarjetaCard.Controls.Add(this.lblNroCardIndice);
            this.slideTransition.SetDecoration(this.nroTarjetaCard, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.nroTarjetaCard, BunifuAnimatorNS.DecorationType.None);
            this.nroTarjetaCard.LeftSahddow = true;
            this.nroTarjetaCard.Location = new System.Drawing.Point(18, 179);
            this.nroTarjetaCard.Name = "nroTarjetaCard";
            this.nroTarjetaCard.RightSahddow = true;
            this.nroTarjetaCard.ShadowDepth = 60;
            this.nroTarjetaCard.Size = new System.Drawing.Size(441, 255);
            this.nroTarjetaCard.TabIndex = 21;
            this.toolTipBalanza.SetToolTip(this.nroTarjetaCard, "Numero Tarjeta Ingresada");
            this.nroTarjetaCard.MouseEnter += new System.EventHandler(this.bunifuCards2_MouseEnter);
            this.nroTarjetaCard.MouseLeave += new System.EventHandler(this.nroTarjetaCard_MouseLeave);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.slideTransition.SetDecoration(this.bunifuSeparator3, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.bunifuSeparator3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(7, 37);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(328, 12);
            this.bunifuSeparator3.TabIndex = 12;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // lblNroTarjeta
            // 
            this.lblNroTarjeta.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblNroTarjeta, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.lblNroTarjeta, BunifuAnimatorNS.DecorationType.None);
            this.lblNroTarjeta.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.lblNroTarjeta.ForeColor = System.Drawing.Color.Black;
            this.lblNroTarjeta.Location = new System.Drawing.Point(37, 96);
            this.lblNroTarjeta.Name = "lblNroTarjeta";
            this.lblNroTarjeta.Size = new System.Drawing.Size(358, 65);
            this.lblNroTarjeta.TabIndex = 6;
            this.lblNroTarjeta.Text = "XXXXXXXXXX";
            this.toolTipBalanza.SetToolTip(this.lblNroTarjeta, "Numero Tarjeta Ingresada");
            // 
            // lblNroCardIndice
            // 
            this.lblNroCardIndice.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblNroCardIndice, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.lblNroCardIndice, BunifuAnimatorNS.DecorationType.None);
            this.lblNroCardIndice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCardIndice.ForeColor = System.Drawing.Color.Black;
            this.lblNroCardIndice.Location = new System.Drawing.Point(3, 12);
            this.lblNroCardIndice.Name = "lblNroCardIndice";
            this.lblNroCardIndice.Size = new System.Drawing.Size(78, 18);
            this.lblNroCardIndice.TabIndex = 5;
            this.lblNroCardIndice.Text = "N° Tarjeta";
            // 
            // slideTransition
            // 
            this.slideTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.slideTransition.Cursor = null;
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
            this.slideTransition.DefaultAnimation = animation1;
            this.slideTransition.Interval = 15;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.WhiteSmoke;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransition.SetDecoration(this.bunifuTileButton2, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.bunifuTileButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 10;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 1;
            this.bunifuTileButton2.LabelText = "";
            this.bunifuTileButton2.Location = new System.Drawing.Point(12, 372);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(43, 40);
            this.bunifuTileButton2.TabIndex = 18;
            // 
            // fadeTransition
            // 
            this.fadeTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.fadeTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.fadeTransition.DefaultAnimation = animation2;
            this.fadeTransition.Interval = 15;
            // 
            // semaforoTransition
            // 
            this.semaforoTransition.Color1 = System.Drawing.Color.Lime;
            this.semaforoTransition.Color2 = System.Drawing.Color.Red;
            this.semaforoTransition.ProgessValue = 0;
            // 
            // balancaCOM
            // 
            this.balancaCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.balancaCOM_DataReceived);
            // 
            // lectorCOM
            // 
            this.lectorCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.lectorCOM_DataReceived);
            // 
            // estadoTimer
            // 
            this.estadoTimer.Interval = 60000;
            this.estadoTimer.Tick += new System.EventHandler(this.estadoTimer_Tick);
            // 
            // TableroPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 650);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.lblIndice);
            this.fadeTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TableroPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TableroPrincipalForm";
            this.bunifuCards1.ResumeLayout(false);
            this.msjEstadoCard.ResumeLayout(false);
            this.msjEstadoCard.PerformLayout();
            this.cardLog.ResumeLayout(false);
            this.cardLog.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picActualizar)).EndInit();
            this.semaforoCard.ResumeLayout(false);
            this.semaforoCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSemaforoRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSemaforoVerde)).EndInit();
            this.pesoCard.ResumeLayout(false);
            this.pesoCard.PerformLayout();
            this.nroTarjetaCard.ResumeLayout(false);
            this.nroTarjetaCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIndice;
        private System.Windows.Forms.PictureBox picBoxSemaforoVerde;
        private Bunifu.Framework.UI.BunifuCards pesoCard;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPesoCardIndice;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPeso;
        private Bunifu.Framework.UI.BunifuCards nroTarjetaCard;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNroTarjeta;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNroCardIndice;
        private Bunifu.Framework.UI.BunifuCards msjEstadoCard;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMsjCardIndice;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMensaje;
        private BunifuAnimatorNS.BunifuTransition slideTransition;
        private BunifuAnimatorNS.BunifuTransition fadeTransition;
        private Bunifu.Framework.UI.BunifuCards semaforoCard;
        private System.Windows.Forms.PictureBox picBoxSemaforoRojo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSemaforoCardIndice;
        private Bunifu.Framework.UI.BunifuColorTransition semaforoTransition;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuSwitch switchBalanza;
        private Bunifu.Framework.UI.BunifuSwitch switchLectorTarjeta;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPuertosCardIndice;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private System.Windows.Forms.ToolTip toolTipBalanza;
        private System.IO.Ports.SerialPort balancaCOM;
        private System.IO.Ports.SerialPort lectorCOM;
        private System.Windows.Forms.PictureBox picActualizar;
        private Bunifu.Framework.UI.BunifuCards cardLog;
        private System.Windows.Forms.TextBox txtLog;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer estadoTimer;
    }
}