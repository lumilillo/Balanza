namespace Balanza.Forms
{
    partial class BusquedaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cardBusqueda = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panelIndicacion1 = new System.Windows.Forms.Panel();
            this.lblIndicacion1 = new System.Windows.Forms.Label();
            this.btnAccion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridCamiones = new System.Windows.Forms.DataGridView();
            this.PatenteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCamionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cardBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // cardBusqueda
            // 
            this.cardBusqueda.BackColor = System.Drawing.Color.White;
            this.cardBusqueda.BorderRadius = 0;
            this.cardBusqueda.BottomSahddow = true;
            this.cardBusqueda.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.cardBusqueda.Controls.Add(this.bunifuSeparator3);
            this.cardBusqueda.Controls.Add(this.lblBuscar);
            this.cardBusqueda.Controls.Add(this.txtBuscar);
            this.cardBusqueda.Controls.Add(this.panelIndicacion1);
            this.cardBusqueda.Controls.Add(this.lblIndicacion1);
            this.cardBusqueda.Controls.Add(this.btnAccion);
            this.cardBusqueda.Controls.Add(this.lblTitulo);
            this.cardBusqueda.Controls.Add(this.bunifuSeparator2);
            this.cardBusqueda.Controls.Add(this.btnVolver);
            this.cardBusqueda.Controls.Add(this.dataGridCamiones);
            this.cardBusqueda.Controls.Add(this.bunifuSeparator1);
            this.cardBusqueda.LeftSahddow = true;
            this.cardBusqueda.Location = new System.Drawing.Point(-3, 0);
            this.cardBusqueda.Name = "cardBusqueda";
            this.cardBusqueda.RightSahddow = true;
            this.cardBusqueda.ShadowDepth = 20;
            this.cardBusqueda.Size = new System.Drawing.Size(732, 584);
            this.cardBusqueda.TabIndex = 0;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(19, 106);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(687, 10);
            this.bunifuSeparator3.TabIndex = 48;
            this.bunifuSeparator3.Transparency = 150;
            this.bunifuSeparator3.Vertical = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Gray;
            this.lblBuscar.Location = new System.Drawing.Point(15, 52);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(88, 21);
            this.lblBuscar.TabIndex = 47;
            this.lblBuscar.Text = "Busqueda";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(19, 76);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(350, 27);
            this.txtBuscar.TabIndex = 46;
            // 
            // panelIndicacion1
            // 
            this.panelIndicacion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(210)))), ((int)(((byte)(150)))));
            this.panelIndicacion1.Location = new System.Drawing.Point(21, 537);
            this.panelIndicacion1.Name = "panelIndicacion1";
            this.panelIndicacion1.Size = new System.Drawing.Size(17, 17);
            this.panelIndicacion1.TabIndex = 44;
            this.panelIndicacion1.Visible = false;
            // 
            // lblIndicacion1
            // 
            this.lblIndicacion1.AutoSize = true;
            this.lblIndicacion1.BackColor = System.Drawing.Color.Transparent;
            this.lblIndicacion1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion1.ForeColor = System.Drawing.Color.Gray;
            this.lblIndicacion1.Location = new System.Drawing.Point(44, 537);
            this.lblIndicacion1.Name = "lblIndicacion1";
            this.lblIndicacion1.Size = new System.Drawing.Size(83, 17);
            this.lblIndicacion1.TabIndex = 43;
            this.lblIndicacion1.Text = "Indicacion1";
            this.lblIndicacion1.Visible = false;
            // 
            // btnAccion
            // 
            this.btnAccion.ActiveBorderThickness = 2;
            this.btnAccion.ActiveCornerRadius = 20;
            this.btnAccion.ActiveFillColor = System.Drawing.Color.White;
            this.btnAccion.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnAccion.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnAccion.BackColor = System.Drawing.Color.White;
            this.btnAccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccion.BackgroundImage")));
            this.btnAccion.ButtonText = "Accion1";
            this.btnAccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAccion.IdleBorderThickness = 1;
            this.btnAccion.IdleCornerRadius = 20;
            this.btnAccion.IdleFillColor = System.Drawing.Color.White;
            this.btnAccion.IdleForecolor = System.Drawing.SystemColors.ControlDark;
            this.btnAccion.IdleLineColor = System.Drawing.SystemColors.ControlDark;
            this.btnAccion.Location = new System.Drawing.Point(546, 531);
            this.btnAccion.Margin = new System.Windows.Forms.Padding(5);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(163, 40);
            this.btnAccion.TabIndex = 42;
            this.btnAccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTitulo.Location = new System.Drawing.Point(13, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(102, 23);
            this.lblTitulo.TabIndex = 41;
            this.lblTitulo.Text = "Busqueda";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(19, 524);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(689, 10);
            this.bunifuSeparator2.TabIndex = 40;
            this.bunifuSeparator2.Transparency = 150;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Balanza.Properties.Resources.icons8_macos_cerrar_32;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(664, 8);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(53, 29);
            this.btnVolver.TabIndex = 39;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCamiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCamiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatenteColumn,
            this.TipoCamionColumn});
            this.dataGridCamiones.EnableHeadersVisualStyles = false;
            this.dataGridCamiones.GridColor = System.Drawing.Color.Black;
            this.dataGridCamiones.Location = new System.Drawing.Point(19, 120);
            this.dataGridCamiones.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.dataGridCamiones.Name = "dataGridCamiones";
            this.dataGridCamiones.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCamiones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCamiones.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCamiones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCamiones.RowTemplate.Height = 30;
            this.dataGridCamiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCamiones.Size = new System.Drawing.Size(687, 403);
            this.dataGridCamiones.TabIndex = 3;
            this.dataGridCamiones.Visible = false;
            // 
            // PatenteColumn
            // 
            this.PatenteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PatenteColumn.DataPropertyName = "patente_chasis";
            this.PatenteColumn.HeaderText = "Patente";
            this.PatenteColumn.Name = "PatenteColumn";
            this.PatenteColumn.ReadOnly = true;
            // 
            // TipoCamionColumn
            // 
            this.TipoCamionColumn.DataPropertyName = "tipoCamion";
            this.TipoCamionColumn.HeaderText = "Tipo Camión";
            this.TipoCamionColumn.Name = "TipoCamionColumn";
            this.TipoCamionColumn.ReadOnly = true;
            this.TipoCamionColumn.Width = 200;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(17, 39);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(689, 10);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BusquedaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 577);
            this.Controls.Add(this.cardBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusquedaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusquedaForm";
            this.Activated += new System.EventHandler(this.BusquedaForm_Activated);
            this.cardBusqueda.ResumeLayout(false);
            this.cardBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCamiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardBusqueda;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.DataGridView dataGridCamiones;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Button btnVolver;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAccion;
        private System.Windows.Forms.Panel panelIndicacion1;
        private System.Windows.Forms.Label lblIndicacion1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatenteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCamionColumn;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}