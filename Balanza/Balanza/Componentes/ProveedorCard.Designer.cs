namespace Balanza.Componentes
{
    partial class ProveedorCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedorCard));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.cardMenu = new Bunifu.Framework.UI.BunifuCards();
            this.separadorNaranja1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radClientes = new System.Windows.Forms.RadioButton();
            this.dataGridProveedores = new System.Windows.Forms.DataGridView();
            this.RazonSocialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditarColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.EliminarColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.radProveedores = new System.Windows.Forms.RadioButton();
            this.panelABM = new System.Windows.Forms.Panel();
            this.fadeTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.alertaTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cardMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).BeginInit();
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
            this.cardMenu.Controls.Add(this.btnAlta);
            this.cardMenu.Controls.Add(this.label2);
            this.cardMenu.Controls.Add(this.radClientes);
            this.cardMenu.Controls.Add(this.dataGridProveedores);
            this.cardMenu.Controls.Add(this.pictureBox3);
            this.cardMenu.Controls.Add(this.txtBuscar);
            this.cardMenu.Controls.Add(this.lblBuscar);
            this.cardMenu.Controls.Add(this.radProveedores);
            this.fadeTransition.SetDecoration(this.cardMenu, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.cardMenu, BunifuAnimatorNS.DecorationType.None);
            this.cardMenu.LeftSahddow = false;
            this.cardMenu.Location = new System.Drawing.Point(0, 0);
            this.cardMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cardMenu.Name = "cardMenu";
            this.cardMenu.RightSahddow = false;
            this.cardMenu.ShadowDepth = 50;
            this.cardMenu.Size = new System.Drawing.Size(918, 583);
            this.cardMenu.TabIndex = 4;
            // 
            // separadorNaranja1
            // 
            this.separadorNaranja1.BackColor = System.Drawing.Color.Transparent;
            this.fadeTransition.SetDecoration(this.separadorNaranja1, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.separadorNaranja1, BunifuAnimatorNS.DecorationType.None);
            this.separadorNaranja1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.separadorNaranja1.LineThickness = 2617;
            this.separadorNaranja1.Location = new System.Drawing.Point(17, 139);
            this.separadorNaranja1.Margin = new System.Windows.Forms.Padding(6);
            this.separadorNaranja1.Name = "separadorNaranja1";
            this.separadorNaranja1.Size = new System.Drawing.Size(869, 4);
            this.separadorNaranja1.TabIndex = 52;
            this.separadorNaranja1.Transparency = 255;
            this.separadorNaranja1.Vertical = false;
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
            this.btnAlta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Image = global::Balanza.Properties.Resources.icons8_añadir_24;
            this.btnAlta.Location = new System.Drawing.Point(17, 46);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(125, 36);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Nuevo";
            this.btnAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnAlta, "Ingresar Nuevo proveedor");
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.alertaTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Alta | Baja | Modificación";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // radClientes
            // 
            this.radClientes.AutoSize = true;
            this.alertaTransition.SetDecoration(this.radClientes, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.radClientes, BunifuAnimatorNS.DecorationType.None);
            this.radClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radClientes.Location = new System.Drawing.Point(784, 86);
            this.radClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 1);
            this.radClientes.Name = "radClientes";
            this.radClientes.Size = new System.Drawing.Size(74, 20);
            this.radClientes.TabIndex = 4;
            this.radClientes.Text = "Clientes";
            this.toolTip1.SetToolTip(this.radClientes, "Filtro Clientes");
            this.radClientes.UseVisualStyleBackColor = true;
            this.radClientes.CheckedChanged += new System.EventHandler(this.radClientes_CheckedChanged);
            // 
            // dataGridProveedores
            // 
            this.dataGridProveedores.AllowUserToAddRows = false;
            this.dataGridProveedores.AllowUserToDeleteRows = false;
            this.dataGridProveedores.AllowUserToResizeColumns = false;
            this.dataGridProveedores.AllowUserToResizeRows = false;
            this.dataGridProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dataGridProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RazonSocialColumn,
            this.CuitColumn,
            this.LocalidadColumn,
            this.EditarColumn,
            this.EliminarColumn});
            this.fadeTransition.SetDecoration(this.dataGridProveedores, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this.dataGridProveedores, BunifuAnimatorNS.DecorationType.None);
            this.dataGridProveedores.EnableHeadersVisualStyles = false;
            this.dataGridProveedores.GridColor = System.Drawing.Color.Black;
            this.dataGridProveedores.Location = new System.Drawing.Point(17, 113);
            this.dataGridProveedores.Margin = new System.Windows.Forms.Padding(3, 1, 3, 4);
            this.dataGridProveedores.Name = "dataGridProveedores";
            this.dataGridProveedores.ReadOnly = true;
            this.dataGridProveedores.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridProveedores.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridProveedores.RowTemplate.Height = 45;
            this.dataGridProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProveedores.Size = new System.Drawing.Size(889, 466);
            this.dataGridProveedores.TabIndex = 5;
            this.dataGridProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProveedores_CellClick);
            this.dataGridProveedores.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridProveedores_CellMouseMove);
            this.dataGridProveedores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridProveedores_CellPainting);
            // 
            // RazonSocialColumn
            // 
            this.RazonSocialColumn.DataPropertyName = "razon_social";
            this.RazonSocialColumn.HeaderText = "Razón Social";
            this.RazonSocialColumn.Name = "RazonSocialColumn";
            this.RazonSocialColumn.ReadOnly = true;
            this.RazonSocialColumn.Width = 345;
            // 
            // CuitColumn
            // 
            this.CuitColumn.DataPropertyName = "cuit";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CuitColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.CuitColumn.HeaderText = "Cuit";
            this.CuitColumn.Name = "CuitColumn";
            this.CuitColumn.ReadOnly = true;
            this.CuitColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CuitColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CuitColumn.Width = 190;
            // 
            // LocalidadColumn
            // 
            this.LocalidadColumn.DataPropertyName = "localidad";
            this.LocalidadColumn.HeaderText = "Localidad";
            this.LocalidadColumn.Name = "LocalidadColumn";
            this.LocalidadColumn.ReadOnly = true;
            this.LocalidadColumn.Width = 255;
            // 
            // EditarColumn
            // 
            this.EditarColumn.HeaderText = "";
            this.EditarColumn.Image = global::Balanza.Properties.Resources.icons8_editar_archivo_50__4_1;
            this.EditarColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarColumn.Name = "EditarColumn";
            this.EditarColumn.ReadOnly = true;
            this.EditarColumn.Width = 40;
            // 
            // EliminarColumn
            // 
            this.EliminarColumn.HeaderText = "";
            this.EliminarColumn.Image = global::Balanza.Properties.Resources.icons8_eliminar_50__4_;
            this.EliminarColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EliminarColumn.Name = "EliminarColumn";
            this.EliminarColumn.ReadOnly = true;
            this.EliminarColumn.Width = 40;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertaTransition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::Balanza.Properties.Resources.icons8_búsqueda_60;
            this.pictureBox3.Location = new System.Drawing.Point(866, 47);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtBuscar
            // 
            this.alertaTransition.SetDecoration(this.txtBuscar, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.txtBuscar, BunifuAnimatorNS.DecorationType.None);
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(620, 47);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(238, 35);
            this.txtBuscar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtBuscar, "Buscar Proveedor");
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.alertaTransition.SetDecoration(this.lblBuscar, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.lblBuscar, BunifuAnimatorNS.DecorationType.None);
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Gray;
            this.lblBuscar.Location = new System.Drawing.Point(616, 16);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(73, 21);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar...";
            // 
            // radProveedores
            // 
            this.radProveedores.AutoSize = true;
            this.alertaTransition.SetDecoration(this.radProveedores, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.radProveedores, BunifuAnimatorNS.DecorationType.None);
            this.radProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProveedores.Location = new System.Drawing.Point(631, 86);
            this.radProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 1);
            this.radProveedores.Name = "radProveedores";
            this.radProveedores.Size = new System.Drawing.Size(105, 20);
            this.radProveedores.TabIndex = 3;
            this.radProveedores.Text = "Proveedores";
            this.toolTip1.SetToolTip(this.radProveedores, "Filtro Proveedores");
            this.radProveedores.UseVisualStyleBackColor = true;
            this.radProveedores.CheckedChanged += new System.EventHandler(this.radProveedores_CheckedChanged);
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
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.fadeTransition.DefaultAnimation = animation3;
            this.fadeTransition.Interval = 15;
            // 
            // alertaTransition
            // 
            this.alertaTransition.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.alertaTransition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.alertaTransition.DefaultAnimation = animation4;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Balanza.Properties.Resources.icons8_editar_archivo_50__4_1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 45;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Balanza.Properties.Resources.icons8_eliminar_50__1_1;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 45;
            // 
            // ProveedorCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelABM);
            this.fadeTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.alertaTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProveedorCard";
            this.Size = new System.Drawing.Size(918, 583);
            this.Load += new System.EventHandler(this.ProveedorCard_Load);
            this.cardMenu.ResumeLayout(false);
            this.cardMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelABM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardMenu;
        private System.Windows.Forms.Panel panelABM;
        private BunifuAnimatorNS.BunifuTransition fadeTransition;
        private System.Windows.Forms.RadioButton radClientes;
        private System.Windows.Forms.RadioButton radProveedores;
        private System.Windows.Forms.DataGridView dataGridProveedores;
        private BunifuAnimatorNS.BunifuTransition alertaTransition;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuSeparator separadorNaranja1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalidadColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditarColumn;
        private System.Windows.Forms.DataGridViewImageColumn EliminarColumn;
    }
}
