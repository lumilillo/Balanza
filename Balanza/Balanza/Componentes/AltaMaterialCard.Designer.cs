namespace Balanza.Componentes
{
    partial class AltaMaterialCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaMaterialCard));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.btnFinalizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cardLocalidad = new Bunifu.Framework.UI.BunifuCards();
            this.lblRequerido2 = new System.Windows.Forms.Label();
            this.lblRequerido1 = new System.Windows.Forms.Label();
            this.lblRequerido = new System.Windows.Forms.Label();
            this.checkBoxMaterialVenta = new System.Windows.Forms.CheckBox();
            this.checkBoxMateriaPrima = new System.Windows.Forms.CheckBox();
            this.txtTipo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCodigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cBoxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.txtUnidadMedida = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.alertaTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.fadeTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cardLocalidad.SuspendLayout();
            this.SuspendLayout();
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
            this.fadeTransition.SetDecoration(this.btnFinalizar, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.btnFinalizar, BunifuAnimatorNS.DecorationType.None);
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFinalizar.IdleBorderThickness = 1;
            this.btnFinalizar.IdleCornerRadius = 20;
            this.btnFinalizar.IdleFillColor = System.Drawing.Color.White;
            this.btnFinalizar.IdleForecolor = System.Drawing.SystemColors.ControlDark;
            this.btnFinalizar.IdleLineColor = System.Drawing.SystemColors.ControlDark;
            this.btnFinalizar.Location = new System.Drawing.Point(694, 500);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(190, 59);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cardLocalidad
            // 
            this.cardLocalidad.BackColor = System.Drawing.Color.White;
            this.cardLocalidad.BorderRadius = 0;
            this.cardLocalidad.BottomSahddow = true;
            this.cardLocalidad.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.cardLocalidad.Controls.Add(this.btnFinalizar);
            this.cardLocalidad.Controls.Add(this.lblRequerido2);
            this.cardLocalidad.Controls.Add(this.lblRequerido1);
            this.cardLocalidad.Controls.Add(this.lblRequerido);
            this.cardLocalidad.Controls.Add(this.checkBoxMaterialVenta);
            this.cardLocalidad.Controls.Add(this.checkBoxMateriaPrima);
            this.cardLocalidad.Controls.Add(this.txtTipo);
            this.cardLocalidad.Controls.Add(this.txtDescripcion);
            this.cardLocalidad.Controls.Add(this.txtCodigo);
            this.cardLocalidad.Controls.Add(this.cBoxUnidadMedida);
            this.cardLocalidad.Controls.Add(this.txtUnidadMedida);
            this.cardLocalidad.Controls.Add(this.btnVolver);
            this.cardLocalidad.Controls.Add(this.lblIndice);
            this.alertaTransition.SetDecoration(this.cardLocalidad, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.cardLocalidad, BunifuAnimatorNS.DecorationType.None);
            this.cardLocalidad.LeftSahddow = true;
            this.cardLocalidad.Location = new System.Drawing.Point(-1, 0);
            this.cardLocalidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardLocalidad.Name = "cardLocalidad";
            this.cardLocalidad.RightSahddow = true;
            this.cardLocalidad.ShadowDepth = 20;
            this.cardLocalidad.Size = new System.Drawing.Size(919, 587);
            this.cardLocalidad.TabIndex = 26;
            // 
            // lblRequerido2
            // 
            this.lblRequerido2.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblRequerido2, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.lblRequerido2, BunifuAnimatorNS.DecorationType.None);
            this.lblRequerido2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido2.ForeColor = System.Drawing.Color.Crimson;
            this.lblRequerido2.Location = new System.Drawing.Point(388, 199);
            this.lblRequerido2.Name = "lblRequerido2";
            this.lblRequerido2.Size = new System.Drawing.Size(19, 24);
            this.lblRequerido2.TabIndex = 47;
            this.lblRequerido2.Text = "*";
            this.toolTip1.SetToolTip(this.lblRequerido2, "Requerido");
            // 
            // lblRequerido1
            // 
            this.lblRequerido1.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblRequerido1, BunifuAnimatorNS.DecorationType.None);
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
            this.fadeTransition.SetDecoration(this.lblRequerido, BunifuAnimatorNS.DecorationType.None);
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
            // checkBoxMaterialVenta
            // 
            this.checkBoxMaterialVenta.AutoSize = true;
            this.fadeTransition.SetDecoration(this.checkBoxMaterialVenta, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.checkBoxMaterialVenta, BunifuAnimatorNS.DecorationType.None);
            this.checkBoxMaterialVenta.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.checkBoxMaterialVenta.Location = new System.Drawing.Point(219, 132);
            this.checkBoxMaterialVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxMaterialVenta.Name = "checkBoxMaterialVenta";
            this.checkBoxMaterialVenta.Size = new System.Drawing.Size(147, 25);
            this.checkBoxMaterialVenta.TabIndex = 46;
            this.checkBoxMaterialVenta.Text = "Material Venta";
            this.checkBoxMaterialVenta.UseVisualStyleBackColor = true;
            // 
            // checkBoxMateriaPrima
            // 
            this.checkBoxMateriaPrima.AutoSize = true;
            this.fadeTransition.SetDecoration(this.checkBoxMateriaPrima, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.checkBoxMateriaPrima, BunifuAnimatorNS.DecorationType.None);
            this.checkBoxMateriaPrima.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.checkBoxMateriaPrima.Location = new System.Drawing.Point(51, 132);
            this.checkBoxMateriaPrima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxMateriaPrima.Name = "checkBoxMateriaPrima";
            this.checkBoxMateriaPrima.Size = new System.Drawing.Size(138, 25);
            this.checkBoxMateriaPrima.TabIndex = 45;
            this.checkBoxMateriaPrima.Text = "Materia Prima";
            this.checkBoxMateriaPrima.UseVisualStyleBackColor = true;
            // 
            // txtTipo
            // 
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtTipo, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.txtTipo, BunifuAnimatorNS.DecorationType.None);
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.Color.Gray;
            this.txtTipo.HintForeColor = System.Drawing.Color.Gray;
            this.txtTipo.HintText = "";
            this.txtTipo.isPassword = false;
            this.txtTipo.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtTipo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTipo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtTipo.LineThickness = 4;
            this.txtTipo.Location = new System.Drawing.Point(32, 76);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(6, 6, 47, 6);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(373, 42);
            this.txtTipo.TabIndex = 44;
            this.txtTipo.Text = "Tipo Material";
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtDescripcion, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.txtDescripcion, BunifuAnimatorNS.DecorationType.None);
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.HintForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.HintText = "Descripción...";
            this.txtDescripcion.isPassword = false;
            this.txtDescripcion.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtDescripcion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDescripcion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtDescripcion.LineThickness = 4;
            this.txtDescripcion.Location = new System.Drawing.Point(514, 199);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6, 6, 47, 6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(373, 42);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtCodigo, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.txtCodigo, BunifuAnimatorNS.DecorationType.None);
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.HintForeColor = System.Drawing.Color.Black;
            this.txtCodigo.HintText = "Código...";
            this.txtCodigo.isPassword = false;
            this.txtCodigo.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtCodigo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtCodigo.LineThickness = 4;
            this.txtCodigo.Location = new System.Drawing.Point(32, 199);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6, 6, 47, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(373, 42);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cBoxUnidadMedida
            // 
            this.cBoxUnidadMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxUnidadMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.fadeTransition.SetDecoration(this.cBoxUnidadMedida, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.cBoxUnidadMedida, BunifuAnimatorNS.DecorationType.None);
            this.cBoxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxUnidadMedida.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxUnidadMedida.FormattingEnabled = true;
            this.cBoxUnidadMedida.Location = new System.Drawing.Point(514, 127);
            this.cBoxUnidadMedida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxUnidadMedida.Name = "cBoxUnidadMedida";
            this.cBoxUnidadMedida.Size = new System.Drawing.Size(373, 30);
            this.cBoxUnidadMedida.TabIndex = 3;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtUnidadMedida, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.txtUnidadMedida, BunifuAnimatorNS.DecorationType.None);
            this.txtUnidadMedida.Enabled = false;
            this.txtUnidadMedida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadMedida.ForeColor = System.Drawing.Color.Gray;
            this.txtUnidadMedida.HintForeColor = System.Drawing.Color.Gray;
            this.txtUnidadMedida.HintText = "";
            this.txtUnidadMedida.isPassword = false;
            this.txtUnidadMedida.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtUnidadMedida.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUnidadMedida.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtUnidadMedida.LineThickness = 4;
            this.txtUnidadMedida.Location = new System.Drawing.Point(514, 76);
            this.txtUnidadMedida.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(373, 42);
            this.txtUnidadMedida.TabIndex = 39;
            this.txtUnidadMedida.Text = "Unidad Medida";
            this.txtUnidadMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Balanza.Properties.Resources.icons8_volver_50;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnVolver, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.btnVolver, BunifuAnimatorNS.DecorationType.None);
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(818, 12);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(69, 31);
            this.btnVolver.TabIndex = 38;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.fadeTransition.SetDecoration(this.lblIndice, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.lblIndice, BunifuAnimatorNS.DecorationType.None);
            this.lblIndice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndice.Location = new System.Drawing.Point(28, 11);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(161, 24);
            this.lblIndice.TabIndex = 37;
            this.lblIndice.Text = "Alta Materiales";
            // 
            // alertaTransition
            // 
            this.alertaTransition.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.alertaTransition.Cursor = null;
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
            animation2.TransparencyCoeff = 0F;
            this.alertaTransition.DefaultAnimation = animation2;
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
            this.fadeTransition.Interval = 15;
            // 
            // AltaMaterialCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cardLocalidad);
            this.alertaTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AltaMaterialCard";
            this.Size = new System.Drawing.Size(918, 583);
            this.Load += new System.EventHandler(this.AltaMaterialCard_Load);
            this.cardLocalidad.ResumeLayout(false);
            this.cardLocalidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnFinalizar;
        private Bunifu.Framework.UI.BunifuCards cardLocalidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigo;
        private System.Windows.Forms.ComboBox cBoxUnidadMedida;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUnidadMedida;
        private System.Windows.Forms.Button btnVolver;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIndice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescripcion;
        private BunifuAnimatorNS.BunifuTransition fadeTransition;
        private BunifuAnimatorNS.BunifuTransition alertaTransition;
        private System.Windows.Forms.CheckBox checkBoxMaterialVenta;
        private System.Windows.Forms.CheckBox checkBoxMateriaPrima;
        private System.Windows.Forms.Label lblRequerido2;
        private System.Windows.Forms.Label lblRequerido1;
        private System.Windows.Forms.Label lblRequerido;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
