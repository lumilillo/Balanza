namespace Balanza.Componentes
{
    partial class CamionesCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CamionesCard));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cardMenu = new Bunifu.Framework.UI.BunifuCards();
            this.separadorNaranja1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dataGridCamiones = new System.Windows.Forms.DataGridView();
            this.PatenteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCamionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditarColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.EliminarColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.panelABM = new System.Windows.Forms.Panel();
            this.fadeTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.alertaTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTipIndicaciones = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cardMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCamiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelABM.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardMenu
            // 
            this.cardMenu.BackColor = System.Drawing.Color.White;
            this.cardMenu.BorderRadius = 0;
            this.cardMenu.BottomSahddow = false;
            this.cardMenu.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.cardMenu.Controls.Add(this.separadorNaranja1);
            this.cardMenu.Controls.Add(this.dataGridCamiones);
            this.cardMenu.Controls.Add(this.pictureBox3);
            this.cardMenu.Controls.Add(this.lblBuscar);
            this.cardMenu.Controls.Add(this.label2);
            this.cardMenu.Controls.Add(this.txtBuscar);
            this.cardMenu.Controls.Add(this.btnAlta);
            this.fadeTransition.SetDecoration(this.cardMenu, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.cardMenu, BunifuAnimatorNS.DecorationType.None);
            this.cardMenu.LeftSahddow = false;
            this.cardMenu.Location = new System.Drawing.Point(0, 0);
            this.cardMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cardMenu.Name = "cardMenu";
            this.cardMenu.RightSahddow = false;
            this.cardMenu.ShadowDepth = 50;
            this.cardMenu.Size = new System.Drawing.Size(918, 583);
            this.cardMenu.TabIndex = 5;
            // 
            // separadorNaranja1
            // 
            this.separadorNaranja1.BackColor = System.Drawing.Color.Transparent;
            this.fadeTransition.SetDecoration(this.separadorNaranja1, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.separadorNaranja1, BunifuAnimatorNS.DecorationType.None);
            this.separadorNaranja1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.separadorNaranja1.LineThickness = 1727;
            this.separadorNaranja1.Location = new System.Drawing.Point(17, 113);
            this.separadorNaranja1.Margin = new System.Windows.Forms.Padding(6);
            this.separadorNaranja1.Name = "separadorNaranja1";
            this.separadorNaranja1.Size = new System.Drawing.Size(870, 4);
            this.separadorNaranja1.TabIndex = 53;
            this.separadorNaranja1.Transparency = 255;
            this.separadorNaranja1.Vertical = false;
            // 
            // dataGridCamiones
            // 
            this.dataGridCamiones.AllowUserToAddRows = false;
            this.dataGridCamiones.AllowUserToDeleteRows = false;
            this.dataGridCamiones.AllowUserToResizeColumns = false;
            this.dataGridCamiones.AllowUserToResizeRows = false;
            this.dataGridCamiones.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCamiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCamiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridCamiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCamiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCamiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatenteColumn,
            this.TipoCamionColumn,
            this.EditarColumn,
            this.EliminarColumn});
            this.fadeTransition.SetDecoration(this.dataGridCamiones, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.dataGridCamiones, BunifuAnimatorNS.DecorationType.None);
            this.dataGridCamiones.EnableHeadersVisualStyles = false;
            this.dataGridCamiones.GridColor = System.Drawing.Color.Black;
            this.dataGridCamiones.Location = new System.Drawing.Point(17, 87);
            this.dataGridCamiones.Margin = new System.Windows.Forms.Padding(3, 1, 3, 4);
            this.dataGridCamiones.Name = "dataGridCamiones";
            this.dataGridCamiones.ReadOnly = true;
            this.dataGridCamiones.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCamiones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCamiones.RowTemplate.Height = 45;
            this.dataGridCamiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCamiones.Size = new System.Drawing.Size(890, 492);
            this.dataGridCamiones.TabIndex = 3;
            this.toolTipIndicaciones.SetToolTip(this.dataGridCamiones, "Camiones");
            this.dataGridCamiones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCamiones_CellClick);
            this.dataGridCamiones.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCamiones_CellMouseMove);
            this.dataGridCamiones.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridCamiones_CellPainting);
            // 
            // PatenteColumn
            // 
            this.PatenteColumn.DataPropertyName = "patente_chasis";
            this.PatenteColumn.FillWeight = 182.4561F;
            this.PatenteColumn.HeaderText = "Patente";
            this.PatenteColumn.Name = "PatenteColumn";
            this.PatenteColumn.ReadOnly = true;
            this.PatenteColumn.Width = 420;
            // 
            // TipoCamionColumn
            // 
            this.TipoCamionColumn.DataPropertyName = "tipoCamion";
            this.TipoCamionColumn.FillWeight = 17.54385F;
            this.TipoCamionColumn.HeaderText = "Tipo Camión";
            this.TipoCamionColumn.Name = "TipoCamionColumn";
            this.TipoCamionColumn.ReadOnly = true;
            this.TipoCamionColumn.Width = 360;
            // 
            // EditarColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.EditarColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.EditarColumn.Description = "Editar";
            this.EditarColumn.HeaderText = "";
            this.EditarColumn.Image = global::Balanza.Properties.Resources.icons8_editar_archivo_50__4_;
            this.EditarColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarColumn.Name = "EditarColumn";
            this.EditarColumn.ReadOnly = true;
            this.EditarColumn.ToolTipText = "Editar";
            this.EditarColumn.Width = 45;
            // 
            // EliminarColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.EliminarColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.EliminarColumn.Description = "Eliminar";
            this.EliminarColumn.HeaderText = "";
            this.EliminarColumn.Image = global::Balanza.Properties.Resources.icons8_eliminar_50__4_;
            this.EliminarColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EliminarColumn.Name = "EliminarColumn";
            this.EliminarColumn.ReadOnly = true;
            this.EliminarColumn.ToolTipText = "Eliminar";
            this.EliminarColumn.Width = 45;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertaTransition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::Balanza.Properties.Resources.icons8_búsqueda_60;
            this.pictureBox3.Location = new System.Drawing.Point(866, 47);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            this.toolTipIndicaciones.SetToolTip(this.pictureBox3, "Buscar por Patente o Tipo");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblBuscar, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.lblBuscar, BunifuAnimatorNS.DecorationType.None);
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblBuscar.ForeColor = System.Drawing.Color.Gray;
            this.lblBuscar.Location = new System.Drawing.Point(616, 16);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(73, 21);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.alertaTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alta | Baja | Modificación";
            // 
            // txtBuscar
            // 
            this.alertaTransition.SetDecoration(this.txtBuscar, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.txtBuscar, BunifuAnimatorNS.DecorationType.None);
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(620, 47);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(238, 35);
            this.txtBuscar.TabIndex = 2;
            this.toolTipIndicaciones.SetToolTip(this.txtBuscar, "Buscar por Patente o Tipo");
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertaTransition.SetDecoration(this.btnAlta, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.btnAlta, BunifuAnimatorNS.DecorationType.None);
            this.btnAlta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlta.FlatAppearance.BorderSize = 0;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Image = global::Balanza.Properties.Resources.icons8_añadir_241;
            this.btnAlta.Location = new System.Drawing.Point(17, 46);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(125, 36);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Nuevo";
            this.btnAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipIndicaciones.SetToolTip(this.btnAlta, "Ingresar Nuevo Camión");
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelABM
            // 
            this.panelABM.Controls.Add(this.cardMenu);
            this.fadeTransition.SetDecoration(this.panelABM, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.panelABM, BunifuAnimatorNS.DecorationType.None);
            this.panelABM.Location = new System.Drawing.Point(0, 0);
            this.panelABM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelABM.Name = "panelABM";
            this.panelABM.Size = new System.Drawing.Size(918, 583);
            this.panelABM.TabIndex = 5;
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
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewImageColumn1.Description = "Editar";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Balanza.Properties.Resources.icons8_editar_100;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.ToolTipText = "Editar";
            this.dataGridViewImageColumn1.Width = 45;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn2.Description = "Eliminar";
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Balanza.Properties.Resources.icons8_eliminar_papelera_50;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.ToolTipText = "Eliminar";
            this.dataGridViewImageColumn2.Width = 45;
            // 
            // CamionesCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelABM);
            this.fadeTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CamionesCard";
            this.Size = new System.Drawing.Size(918, 583);
            this.Load += new System.EventHandler(this.CamionesCard_Load);
            this.cardMenu.ResumeLayout(false);
            this.cardMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCamiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelABM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardMenu;
        private System.Windows.Forms.Panel panelABM;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridCamiones;
        private BunifuAnimatorNS.BunifuTransition alertaTransition;
        private BunifuAnimatorNS.BunifuTransition fadeTransition;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ToolTip toolTipIndicaciones;
        private Bunifu.Framework.UI.BunifuSeparator separadorNaranja1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatenteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCamionColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditarColumn;
        private System.Windows.Forms.DataGridViewImageColumn EliminarColumn;
    }
}
