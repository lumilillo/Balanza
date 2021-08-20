namespace Balanza.Componentes
{
    partial class ModificarUsuarioCard
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuarioCard));
            this.cardMovimiento = new Bunifu.Framework.UI.BunifuCards();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDni = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLegajo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnVolver2 = new System.Windows.Forms.Button();
            this.lblIndice1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtLegajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDni = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.cardMovimiento.Controls.Add(this.lblEmail);
            this.cardMovimiento.Controls.Add(this.lblDni);
            this.cardMovimiento.Controls.Add(this.lblLegajo);
            this.cardMovimiento.Controls.Add(this.lblNombre);
            this.cardMovimiento.Controls.Add(this.txtEmail);
            this.cardMovimiento.Controls.Add(this.btnVolver2);
            this.cardMovimiento.Controls.Add(this.lblIndice1);
            this.cardMovimiento.Controls.Add(this.txtLegajo);
            this.cardMovimiento.Controls.Add(this.txtDni);
            this.cardMovimiento.Controls.Add(this.txtNombre);
            this.alertaTransition.SetDecoration(this.cardMovimiento, BunifuAnimatorNS.DecorationType.None);
            this.cardMovimiento.LeftSahddow = true;
            this.cardMovimiento.Location = new System.Drawing.Point(-13, 0);
            this.cardMovimiento.Name = "cardMovimiento";
            this.cardMovimiento.RightSahddow = true;
            this.cardMovimiento.ShadowDepth = 20;
            this.cardMovimiento.Size = new System.Drawing.Size(838, 475);
            this.cardMovimiento.TabIndex = 100;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblEmail, BunifuAnimatorNS.DecorationType.None);
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEmail.Location = new System.Drawing.Point(445, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 102;
            this.lblEmail.Text = "Email";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblDni, BunifuAnimatorNS.DecorationType.None);
            this.lblDni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDni.Location = new System.Drawing.Point(447, 58);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(32, 20);
            this.lblDni.TabIndex = 102;
            this.lblDni.Text = "Dni";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblLegajo, BunifuAnimatorNS.DecorationType.None);
            this.lblLegajo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLegajo.Location = new System.Drawing.Point(30, 205);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(59, 20);
            this.lblLegajo.TabIndex = 102;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNombre.Location = new System.Drawing.Point(30, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 101;
            this.lblNombre.Text = "Nombre";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtEmail, BunifuAnimatorNS.DecorationType.None);
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HintForeColor = System.Drawing.Color.Black;
            this.txtEmail.HintText = "Email...";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtEmail.LineThickness = 4;
            this.txtEmail.Location = new System.Drawing.Point(449, 220);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 40, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 34);
            this.txtEmail.TabIndex = 103;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.OnValueChanged += new System.EventHandler(this.txtEmail_OnValueChanged);
            // 
            // btnVolver2
            // 
            this.btnVolver2.BackgroundImage = global::Balanza.Properties.Resources.icons8_volver_50;
            this.btnVolver2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertaTransition.SetDecoration(this.btnVolver2, BunifuAnimatorNS.DecorationType.None);
            this.btnVolver2.FlatAppearance.BorderSize = 0;
            this.btnVolver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver2.Location = new System.Drawing.Point(738, 8);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(59, 25);
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
            this.lblIndice1.Location = new System.Drawing.Point(24, 9);
            this.lblIndice1.Name = "lblIndice1";
            this.lblIndice1.Size = new System.Drawing.Size(85, 24);
            this.lblIndice1.TabIndex = 38;
            this.lblIndice1.Text = "Detalle";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtLegajo, BunifuAnimatorNS.DecorationType.None);
            this.txtLegajo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegajo.ForeColor = System.Drawing.Color.Black;
            this.txtLegajo.HintForeColor = System.Drawing.Color.Black;
            this.txtLegajo.HintText = "Legajo...";
            this.txtLegajo.isPassword = false;
            this.txtLegajo.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtLegajo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLegajo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtLegajo.LineThickness = 4;
            this.txtLegajo.Location = new System.Drawing.Point(30, 220);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(5, 5, 40, 5);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(380, 34);
            this.txtLegajo.TabIndex = 8;
            this.txtLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLegajo.OnValueChanged += new System.EventHandler(this.txtLegajo_OnValueChanged);
            // 
            // txtDni
            // 
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtDni, BunifuAnimatorNS.DecorationType.None);
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.Black;
            this.txtDni.HintForeColor = System.Drawing.Color.Black;
            this.txtDni.HintText = "Dni...";
            this.txtDni.isPassword = false;
            this.txtDni.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtDni.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDni.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtDni.LineThickness = 4;
            this.txtDni.Location = new System.Drawing.Point(451, 75);
            this.txtDni.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(380, 34);
            this.txtDni.TabIndex = 4;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDni.OnValueChanged += new System.EventHandler(this.txtDni_OnValueChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtNombre, BunifuAnimatorNS.DecorationType.None);
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HintForeColor = System.Drawing.Color.Black;
            this.txtNombre.HintText = "Nombre...";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtNombre.LineThickness = 4;
            this.txtNombre.Location = new System.Drawing.Point(30, 75);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(380, 34);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.OnValueChanged += new System.EventHandler(this.txtNombre_OnValueChanged);
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
            // ModificarUsuarioCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cardMovimiento);
            this.alertaTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "ModificarUsuarioCard";
            this.Size = new System.Drawing.Size(821, 530);
            this.cardMovimiento.ResumeLayout(false);
            this.cardMovimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards cardMovimiento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private System.Windows.Forms.Button btnVolver2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIndice1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLegajo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDni;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private BunifuAnimatorNS.BunifuTransition alertaTransition;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDni;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLegajo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
