namespace Balanza.Componentes
{
    partial class FlotaCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.radClientes = new System.Windows.Forms.RadioButton();
            this.radProveedores = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProveedores = new System.Windows.Forms.TabPage();
            this.dataGridProveedores = new System.Windows.Forms.DataGridView();
            this.RazonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomicilioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCamiones = new System.Windows.Forms.TabPage();
            this.btnAlta = new System.Windows.Forms.Button();
            this.dataGridCamiones = new System.Windows.Forms.DataGridView();
            this.PatenteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCamionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).BeginInit();
            this.tabCamiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.bunifuCards1.Controls.Add(this.txtBuscar);
            this.bunifuCards1.Controls.Add(this.pictureBox3);
            this.bunifuCards1.Controls.Add(this.radClientes);
            this.bunifuCards1.Controls.Add(this.radProveedores);
            this.bunifuCards1.Controls.Add(this.tabControl1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(918, 583);
            this.bunifuCards1.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscar.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscar.HintText = "Buscar...";
            this.txtBuscar.isPassword = false;
            this.txtBuscar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtBuscar.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBuscar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.txtBuscar.LineThickness = 4;
            this.txtBuscar.Location = new System.Drawing.Point(640, 14);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 34);
            this.txtBuscar.TabIndex = 55;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.OnValueChanged += new System.EventHandler(this.txtBuscar_OnValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Balanza.Properties.Resources.icons8_búsqueda_60;
            this.pictureBox3.Location = new System.Drawing.Point(848, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // radClientes
            // 
            this.radClientes.AutoSize = true;
            this.radClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radClientes.Location = new System.Drawing.Point(125, 15);
            this.radClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radClientes.Name = "radClientes";
            this.radClientes.Size = new System.Drawing.Size(77, 21);
            this.radClientes.TabIndex = 52;
            this.radClientes.TabStop = true;
            this.radClientes.Text = "Clientes";
            this.radClientes.UseVisualStyleBackColor = true;
            this.radClientes.CheckedChanged += new System.EventHandler(this.radClientes_CheckedChanged);
            // 
            // radProveedores
            // 
            this.radProveedores.AutoSize = true;
            this.radProveedores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProveedores.Location = new System.Drawing.Point(13, 15);
            this.radProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radProveedores.Name = "radProveedores";
            this.radProveedores.Size = new System.Drawing.Size(106, 21);
            this.radProveedores.TabIndex = 51;
            this.radProveedores.TabStop = true;
            this.radProveedores.Text = "Proveedores";
            this.radProveedores.UseVisualStyleBackColor = true;
            this.radProveedores.CheckedChanged += new System.EventHandler(this.radProveedores_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProveedores);
            this.tabControl1.Controls.Add(this.tabCamiones);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl1.Location = new System.Drawing.Point(13, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 529);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabProveedores
            // 
            this.tabProveedores.Controls.Add(this.dataGridProveedores);
            this.tabProveedores.Location = new System.Drawing.Point(4, 29);
            this.tabProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProveedores.Name = "tabProveedores";
            this.tabProveedores.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProveedores.Size = new System.Drawing.Size(872, 496);
            this.tabProveedores.TabIndex = 0;
            this.tabProveedores.Text = "Proveedores";
            this.tabProveedores.UseVisualStyleBackColor = true;
            // 
            // dataGridProveedores
            // 
            this.dataGridProveedores.AllowUserToAddRows = false;
            this.dataGridProveedores.AllowUserToDeleteRows = false;
            this.dataGridProveedores.AllowUserToResizeColumns = false;
            this.dataGridProveedores.AllowUserToResizeRows = false;
            this.dataGridProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dataGridProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RazonColumn,
            this.CuitColumn,
            this.DomicilioColumn});
            this.dataGridProveedores.EnableHeadersVisualStyles = false;
            this.dataGridProveedores.GridColor = System.Drawing.Color.Black;
            this.dataGridProveedores.Location = new System.Drawing.Point(7, 5);
            this.dataGridProveedores.Margin = new System.Windows.Forms.Padding(3, 1, 3, 4);
            this.dataGridProveedores.Name = "dataGridProveedores";
            this.dataGridProveedores.ReadOnly = true;
            this.dataGridProveedores.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridProveedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProveedores.RowTemplate.Height = 40;
            this.dataGridProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProveedores.Size = new System.Drawing.Size(849, 483);
            this.dataGridProveedores.TabIndex = 5;
            this.dataGridProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProveedores_CellDoubleClick);
            this.dataGridProveedores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridProveedores_CellPainting);
            // 
            // RazonColumn
            // 
            this.RazonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RazonColumn.DataPropertyName = "razon_social";
            this.RazonColumn.HeaderText = "Razón Social";
            this.RazonColumn.Name = "RazonColumn";
            this.RazonColumn.ReadOnly = true;
            // 
            // CuitColumn
            // 
            this.CuitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CuitColumn.DataPropertyName = "cuit";
            this.CuitColumn.HeaderText = "Cuit";
            this.CuitColumn.Name = "CuitColumn";
            this.CuitColumn.ReadOnly = true;
            // 
            // DomicilioColumn
            // 
            this.DomicilioColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DomicilioColumn.DataPropertyName = "localidad";
            this.DomicilioColumn.HeaderText = "Localidad";
            this.DomicilioColumn.Name = "DomicilioColumn";
            this.DomicilioColumn.ReadOnly = true;
            // 
            // tabCamiones
            // 
            this.tabCamiones.Controls.Add(this.btnAlta);
            this.tabCamiones.Controls.Add(this.dataGridCamiones);
            this.tabCamiones.Location = new System.Drawing.Point(4, 29);
            this.tabCamiones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCamiones.Name = "tabCamiones";
            this.tabCamiones.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCamiones.Size = new System.Drawing.Size(872, 496);
            this.tabCamiones.TabIndex = 1;
            this.tabCamiones.Text = "Flota";
            this.tabCamiones.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlta.FlatAppearance.BorderSize = 0;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Image = global::Balanza.Properties.Resources.icons8_añadir_24;
            this.btnAlta.Location = new System.Drawing.Point(7, 7);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(117, 34);
            this.btnAlta.TabIndex = 43;
            this.btnAlta.Text = "Camión";
            this.btnAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // dataGridCamiones
            // 
            this.dataGridCamiones.AllowUserToAddRows = false;
            this.dataGridCamiones.AllowUserToDeleteRows = false;
            this.dataGridCamiones.AllowUserToResizeColumns = false;
            this.dataGridCamiones.AllowUserToResizeRows = false;
            this.dataGridCamiones.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCamiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCamiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridCamiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCamiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCamiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatenteColumn,
            this.TipoCamionColumn,
            this.EliminarColumn});
            this.dataGridCamiones.EnableHeadersVisualStyles = false;
            this.dataGridCamiones.GridColor = System.Drawing.Color.Black;
            this.dataGridCamiones.Location = new System.Drawing.Point(7, 54);
            this.dataGridCamiones.Margin = new System.Windows.Forms.Padding(3, 1, 3, 4);
            this.dataGridCamiones.Name = "dataGridCamiones";
            this.dataGridCamiones.ReadOnly = true;
            this.dataGridCamiones.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCamiones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCamiones.RowTemplate.Height = 40;
            this.dataGridCamiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCamiones.Size = new System.Drawing.Size(849, 434);
            this.dataGridCamiones.TabIndex = 4;
            this.dataGridCamiones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCamiones_CellClick);
            this.dataGridCamiones.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCamiones_CellMouseMove);
            this.dataGridCamiones.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridCamiones_CellPainting);
            // 
            // PatenteColumn
            // 
            this.PatenteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PatenteColumn.DataPropertyName = "patente_chasis";
            this.PatenteColumn.FillWeight = 6.369431F;
            this.PatenteColumn.HeaderText = "Patente";
            this.PatenteColumn.Name = "PatenteColumn";
            this.PatenteColumn.ReadOnly = true;
            this.PatenteColumn.Width = 402;
            // 
            // TipoCamionColumn
            // 
            this.TipoCamionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipoCamionColumn.DataPropertyName = "tipoCamion";
            this.TipoCamionColumn.FillWeight = 193.6306F;
            this.TipoCamionColumn.HeaderText = "Tipo Camión";
            this.TipoCamionColumn.Name = "TipoCamionColumn";
            this.TipoCamionColumn.ReadOnly = true;
            this.TipoCamionColumn.Width = 402;
            // 
            // EliminarColumn
            // 
            this.EliminarColumn.HeaderText = "";
            this.EliminarColumn.Image = global::Balanza.Properties.Resources.icons8_eliminar_50__4_1;
            this.EliminarColumn.Name = "EliminarColumn";
            this.EliminarColumn.ReadOnly = true;
            this.EliminarColumn.Width = 44;
            // 
            // FlotaCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FlotaCard";
            this.Size = new System.Drawing.Size(918, 583);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).EndInit();
            this.tabCamiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCamiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.RadioButton radClientes;
        private System.Windows.Forms.RadioButton radProveedores;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProveedores;
        private System.Windows.Forms.DataGridView dataGridProveedores;
        private System.Windows.Forms.TabPage tabCamiones;
        private System.Windows.Forms.DataGridView dataGridCamiones;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomicilioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatenteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCamionColumn;
        private System.Windows.Forms.DataGridViewImageColumn EliminarColumn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBuscar;
    }
}
