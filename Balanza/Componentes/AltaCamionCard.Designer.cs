namespace Balanza.Componentes
{
    partial class AltaCamionCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCamionCard));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.btnModificar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnFinalizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cardLocalidad = new Bunifu.Framework.UI.BunifuCards();
            this.lblRequerido1 = new System.Windows.Forms.Label();
            this.lblRequerido = new System.Windows.Forms.Label();
            this.lblIndicePatente = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblModificar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPatente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cBoxTipoCamion = new System.Windows.Forms.ComboBox();
            this.txtTipoCamion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.alertaTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cardLocalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.ActiveBorderThickness = 2;
            this.btnModificar.ActiveCornerRadius = 20;
            this.btnModificar.ActiveFillColor = System.Drawing.Color.White;
            this.btnModificar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnModificar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.ButtonText = "Modificar";
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertaTransition.SetDecoration(this.btnModificar, BunifuAnimatorNS.DecorationType.None);
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModificar.IdleBorderThickness = 1;
            this.btnModificar.IdleCornerRadius = 20;
            this.btnModificar.IdleFillColor = System.Drawing.Color.White;
            this.btnModificar.IdleForecolor = System.Drawing.SystemColors.ControlDark;
            this.btnModificar.IdleLineColor = System.Drawing.SystemColors.ControlDark;
            this.btnModificar.Location = new System.Drawing.Point(694, 500);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(190, 59);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cardLocalidad
            // 
            this.cardLocalidad.BackColor = System.Drawing.Color.White;
            this.cardLocalidad.BorderRadius = 0;
            this.cardLocalidad.BottomSahddow = true;
            this.cardLocalidad.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.cardLocalidad.Controls.Add(this.btnModificar);
            this.cardLocalidad.Controls.Add(this.btnFinalizar);
            this.cardLocalidad.Controls.Add(this.lblRequerido1);
            this.cardLocalidad.Controls.Add(this.lblRequerido);
            this.cardLocalidad.Controls.Add(this.lblIndicePatente);
            this.cardLocalidad.Controls.Add(this.lblModificar);
            this.cardLocalidad.Controls.Add(this.txtPatente);
            this.cardLocalidad.Controls.Add(this.cBoxTipoCamion);
            this.cardLocalidad.Controls.Add(this.txtTipoCamion);
            this.cardLocalidad.Controls.Add(this.btnVolver);
            this.cardLocalidad.Controls.Add(this.lblIndice);
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
            // lblRequerido1
            // 
            this.lblRequerido1.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblRequerido1, BunifuAnimatorNS.DecorationType.None);
            this.lblRequerido1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido1.ForeColor = System.Drawing.Color.Crimson;
            this.lblRequerido1.Location = new System.Drawing.Point(868, 76);
            this.lblRequerido1.Name = "lblRequerido1";
            this.lblRequerido1.Size = new System.Drawing.Size(19, 24);
            this.lblRequerido1.TabIndex = 44;
            this.lblRequerido1.Text = "*";
            this.toolTip1.SetToolTip(this.lblRequerido1, "Requerido");
            // 
            // lblRequerido
            // 
            this.lblRequerido.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblRequerido, BunifuAnimatorNS.DecorationType.None);
            this.lblRequerido.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido.ForeColor = System.Drawing.Color.Crimson;
            this.lblRequerido.Location = new System.Drawing.Point(386, 76);
            this.lblRequerido.Name = "lblRequerido";
            this.lblRequerido.Size = new System.Drawing.Size(19, 24);
            this.lblRequerido.TabIndex = 43;
            this.lblRequerido.Text = "*";
            this.toolTip1.SetToolTip(this.lblRequerido, "Requerido");
            // 
            // lblIndicePatente
            // 
            this.lblIndicePatente.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblIndicePatente, BunifuAnimatorNS.DecorationType.None);
            this.lblIndicePatente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicePatente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndicePatente.Location = new System.Drawing.Point(29, 59);
            this.lblIndicePatente.Name = "lblIndicePatente";
            this.lblIndicePatente.Size = new System.Drawing.Size(74, 21);
            this.lblIndicePatente.TabIndex = 41;
            this.lblIndicePatente.Text = "Patente";
            this.lblIndicePatente.Visible = false;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblModificar, BunifuAnimatorNS.DecorationType.None);
            this.lblModificar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblModificar.Location = new System.Drawing.Point(28, 11);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(249, 24);
            this.lblModificar.TabIndex = 42;
            this.lblModificar.Text = "Modificando Camiones";
            this.lblModificar.Visible = false;
            // 
            // txtPatente
            // 
            this.txtPatente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtPatente, BunifuAnimatorNS.DecorationType.None);
            this.txtPatente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.ForeColor = System.Drawing.Color.Black;
            this.txtPatente.HintForeColor = System.Drawing.Color.Black;
            this.txtPatente.HintText = "Patente...";
            this.txtPatente.isPassword = false;
            this.txtPatente.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtPatente.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPatente.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtPatente.LineThickness = 4;
            this.txtPatente.Location = new System.Drawing.Point(32, 76);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(6, 6, 47, 6);
            this.txtPatente.MaximumSize = new System.Drawing.Size(443, 42);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(373, 42);
            this.txtPatente.TabIndex = 1;
            this.txtPatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPatente.OnValueChanged += new System.EventHandler(this.txtPatente_OnValueChanged);
            this.txtPatente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPatente_KeyDown);
            // 
            // cBoxTipoCamion
            // 
            this.cBoxTipoCamion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxTipoCamion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxTipoCamion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.alertaTransition.SetDecoration(this.cBoxTipoCamion, BunifuAnimatorNS.DecorationType.None);
            this.cBoxTipoCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxTipoCamion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTipoCamion.FormattingEnabled = true;
            this.cBoxTipoCamion.Location = new System.Drawing.Point(514, 128);
            this.cBoxTipoCamion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxTipoCamion.MaximumSize = new System.Drawing.Size(388, 0);
            this.cBoxTipoCamion.Name = "cBoxTipoCamion";
            this.cBoxTipoCamion.Size = new System.Drawing.Size(373, 30);
            this.cBoxTipoCamion.TabIndex = 2;
            this.cBoxTipoCamion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cBoxTipoCamion_KeyDown);
            // 
            // txtTipoCamion
            // 
            this.txtTipoCamion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtTipoCamion, BunifuAnimatorNS.DecorationType.None);
            this.txtTipoCamion.Enabled = false;
            this.txtTipoCamion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCamion.ForeColor = System.Drawing.Color.Gray;
            this.txtTipoCamion.HintForeColor = System.Drawing.Color.Gray;
            this.txtTipoCamion.HintText = "";
            this.txtTipoCamion.isPassword = false;
            this.txtTipoCamion.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtTipoCamion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTipoCamion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtTipoCamion.LineThickness = 4;
            this.txtTipoCamion.Location = new System.Drawing.Point(514, 76);
            this.txtTipoCamion.Margin = new System.Windows.Forms.Padding(6);
            this.txtTipoCamion.MaximumSize = new System.Drawing.Size(443, 42);
            this.txtTipoCamion.Name = "txtTipoCamion";
            this.txtTipoCamion.Size = new System.Drawing.Size(373, 42);
            this.txtTipoCamion.TabIndex = 39;
            this.txtTipoCamion.Text = "Tipo Camión";
            this.txtTipoCamion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnVolver.TabIndex = 6;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblIndice, BunifuAnimatorNS.DecorationType.None);
            this.lblIndice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndice.Location = new System.Drawing.Point(28, 11);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(161, 24);
            this.lblIndice.TabIndex = 37;
            this.lblIndice.Text = "Alta Camiones";
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
            // AltaCamionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cardLocalidad);
            this.alertaTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AltaCamionCard";
            this.Size = new System.Drawing.Size(918, 583);
            this.Load += new System.EventHandler(this.AltaCamionCard_Load);
            this.cardLocalidad.ResumeLayout(false);
            this.cardLocalidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards cardLocalidad;
        private System.Windows.Forms.Button btnVolver;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIndice;
        private System.Windows.Forms.ComboBox cBoxTipoCamion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipoCamion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPatente;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFinalizar;
        private BunifuAnimatorNS.BunifuTransition alertaTransition;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblModificar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIndicePatente;
        private System.Windows.Forms.Label lblRequerido1;
        private System.Windows.Forms.Label lblRequerido;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
