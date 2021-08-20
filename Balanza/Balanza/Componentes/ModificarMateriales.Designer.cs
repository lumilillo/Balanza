namespace Balanza.Componentes
{
    partial class ModificarMateriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarMateriales));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.btnModificar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cardLocalidad = new Bunifu.Framework.UI.BunifuCards();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRequerido = new System.Windows.Forms.Label();
            this.checkBoxMaterialVenta = new System.Windows.Forms.CheckBox();
            this.checkBoxMateriaPrima = new System.Windows.Forms.CheckBox();
            this.lblDescripcion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCodigo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTipo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblModificar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCodigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cBoxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.txtUnidadMedida = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnVolver = new System.Windows.Forms.Button();
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
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(190, 59);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cardLocalidad
            // 
            this.cardLocalidad.BackColor = System.Drawing.Color.White;
            this.cardLocalidad.BorderRadius = 0;
            this.cardLocalidad.BottomSahddow = true;
            this.cardLocalidad.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.cardLocalidad.Controls.Add(this.btnModificar);
            this.cardLocalidad.Controls.Add(this.label3);
            this.cardLocalidad.Controls.Add(this.label2);
            this.cardLocalidad.Controls.Add(this.lblRequerido);
            this.cardLocalidad.Controls.Add(this.checkBoxMaterialVenta);
            this.cardLocalidad.Controls.Add(this.checkBoxMateriaPrima);
            this.cardLocalidad.Controls.Add(this.lblDescripcion);
            this.cardLocalidad.Controls.Add(this.lblCodigo);
            this.cardLocalidad.Controls.Add(this.txtTipo);
            this.cardLocalidad.Controls.Add(this.txtDescripcion);
            this.cardLocalidad.Controls.Add(this.lblModificar);
            this.cardLocalidad.Controls.Add(this.txtCodigo);
            this.cardLocalidad.Controls.Add(this.cBoxUnidadMedida);
            this.cardLocalidad.Controls.Add(this.txtUnidadMedida);
            this.cardLocalidad.Controls.Add(this.btnVolver);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.alertaTransition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(868, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "*";
            this.toolTip1.SetToolTip(this.label3, "Requerido");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.alertaTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(388, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "*";
            this.toolTip1.SetToolTip(this.label2, "Requerido");
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
            // checkBoxMaterialVenta
            // 
            this.checkBoxMaterialVenta.AutoSize = true;
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
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblDescripcion, BunifuAnimatorNS.DecorationType.None);
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDescripcion.Location = new System.Drawing.Point(511, 183);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 17);
            this.lblDescripcion.TabIndex = 44;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblCodigo, BunifuAnimatorNS.DecorationType.None);
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCodigo.Location = new System.Drawing.Point(31, 183);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 17);
            this.lblCodigo.TabIndex = 43;
            this.lblCodigo.Text = "Codigo ";
            // 
            // txtTipo
            // 
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtTipo, BunifuAnimatorNS.DecorationType.None);
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
            this.txtDescripcion.OnValueChanged += new System.EventHandler(this.txtDescripcion_OnValueChanged);
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
            this.lblModificar.Text = "Modificando Materiales";
            this.lblModificar.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertaTransition.SetDecoration(this.txtCodigo, BunifuAnimatorNS.DecorationType.None);
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
            this.txtCodigo.OnValueChanged += new System.EventHandler(this.txtCodigo_OnValueChanged);
            // 
            // cBoxUnidadMedida
            // 
            this.cBoxUnidadMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxUnidadMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
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
            // ModificarMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cardLocalidad);
            this.alertaTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModificarMateriales";
            this.Size = new System.Drawing.Size(918, 583);
            this.Load += new System.EventHandler(this.ModificarMateriales_Load);
            this.cardLocalidad.ResumeLayout(false);
            this.cardLocalidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificar;
        private Bunifu.Framework.UI.BunifuCards cardLocalidad;
        private System.Windows.Forms.CheckBox checkBoxMaterialVenta;
        private System.Windows.Forms.CheckBox checkBoxMateriaPrima;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescripcion;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCodigo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescripcion;
        private Bunifu.Framework.UI.BunifuCustomLabel lblModificar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigo;
        private System.Windows.Forms.ComboBox cBoxUnidadMedida;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUnidadMedida;
        private System.Windows.Forms.Button btnVolver;
        private BunifuAnimatorNS.BunifuTransition alertaTransition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRequerido;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
