namespace Balanza.Forms
{
    partial class MaestrosForm
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaestrosForm));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.cardMenu = new Bunifu.Framework.UI.BunifuCards();
            this.btnMateriales1 = new System.Windows.Forms.Button();
            this.btnUsuarios1 = new System.Windows.Forms.Button();
            this.btnCamiones1 = new System.Windows.Forms.Button();
            this.btnProveedores1 = new System.Windows.Forms.Button();
            this.btnProveedores = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMateriales = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCamiones = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fadeTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            this.slideTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelPrincipal.SuspendLayout();
            this.cardMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoSize = true;
            this.panelPrincipal.Controls.Add(this.cardMenu);
            this.fadeTransition.SetDecoration(this.panelPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.panelPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 70);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(3, 1, 3, 4);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(918, 583);
            this.panelPrincipal.TabIndex = 6;
            // 
            // cardMenu
            // 
            this.cardMenu.BackColor = System.Drawing.Color.White;
            this.cardMenu.BorderRadius = 0;
            this.cardMenu.BottomSahddow = false;
            this.cardMenu.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.cardMenu.Controls.Add(this.btnMateriales1);
            this.cardMenu.Controls.Add(this.btnUsuarios1);
            this.cardMenu.Controls.Add(this.btnCamiones1);
            this.cardMenu.Controls.Add(this.btnProveedores1);
            this.cardMenu.Controls.Add(this.btnProveedores);
            this.cardMenu.Controls.Add(this.btnUsuarios);
            this.cardMenu.Controls.Add(this.btnMateriales);
            this.cardMenu.Controls.Add(this.btnCamiones);
            this.fadeTransition.SetDecoration(this.cardMenu, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.cardMenu, BunifuAnimatorNS.DecorationType.None);
            this.cardMenu.LeftSahddow = false;
            this.cardMenu.Location = new System.Drawing.Point(0, 0);
            this.cardMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cardMenu.Name = "cardMenu";
            this.cardMenu.RightSahddow = false;
            this.cardMenu.ShadowDepth = 50;
            this.cardMenu.Size = new System.Drawing.Size(915, 578);
            this.cardMenu.TabIndex = 2;
            // 
            // btnMateriales1
            // 
            this.btnMateriales1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnMateriales1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransition.SetDecoration(this.btnMateriales1, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.btnMateriales1, BunifuAnimatorNS.DecorationType.None);
            this.btnMateriales1.FlatAppearance.BorderSize = 0;
            this.btnMateriales1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMateriales1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriales1.ForeColor = System.Drawing.Color.White;
            this.btnMateriales1.Location = new System.Drawing.Point(541, 368);
            this.btnMateriales1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMateriales1.Name = "btnMateriales1";
            this.btnMateriales1.Size = new System.Drawing.Size(224, 49);
            this.btnMateriales1.TabIndex = 8;
            this.btnMateriales1.Text = "MATERIALES";
            this.btnMateriales1.UseVisualStyleBackColor = false;
            this.btnMateriales1.Click += new System.EventHandler(this.btnMateriales1_Click);
            this.btnMateriales1.MouseEnter += new System.EventHandler(this.btnMateriales1_MouseEnter);
            this.btnMateriales1.MouseLeave += new System.EventHandler(this.btnMateriales1_MouseLeave);
            // 
            // btnUsuarios1
            // 
            this.btnUsuarios1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnUsuarios1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransition.SetDecoration(this.btnUsuarios1, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.btnUsuarios1, BunifuAnimatorNS.DecorationType.None);
            this.btnUsuarios1.FlatAppearance.BorderSize = 0;
            this.btnUsuarios1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios1.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios1.Location = new System.Drawing.Point(168, 368);
            this.btnUsuarios1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 4);
            this.btnUsuarios1.Name = "btnUsuarios1";
            this.btnUsuarios1.Size = new System.Drawing.Size(224, 49);
            this.btnUsuarios1.TabIndex = 7;
            this.btnUsuarios1.Text = "USUARIOS";
            this.btnUsuarios1.UseVisualStyleBackColor = false;
            this.btnUsuarios1.Click += new System.EventHandler(this.btnUsuarios1_Click);
            this.btnUsuarios1.MouseEnter += new System.EventHandler(this.btnUsuarios1_MouseEnter);
            this.btnUsuarios1.MouseLeave += new System.EventHandler(this.btnUsuarios1_MouseLeave);
            // 
            // btnCamiones1
            // 
            this.btnCamiones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnCamiones1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransition.SetDecoration(this.btnCamiones1, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.btnCamiones1, BunifuAnimatorNS.DecorationType.None);
            this.btnCamiones1.FlatAppearance.BorderSize = 0;
            this.btnCamiones1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamiones1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamiones1.ForeColor = System.Drawing.Color.White;
            this.btnCamiones1.Location = new System.Drawing.Point(541, 141);
            this.btnCamiones1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCamiones1.Name = "btnCamiones1";
            this.btnCamiones1.Size = new System.Drawing.Size(224, 49);
            this.btnCamiones1.TabIndex = 6;
            this.btnCamiones1.Text = "CAMIONES";
            this.btnCamiones1.UseVisualStyleBackColor = false;
            this.btnCamiones1.Click += new System.EventHandler(this.btnCamiones1_Click);
            this.btnCamiones1.MouseEnter += new System.EventHandler(this.btnCamiones1_MouseEnter);
            this.btnCamiones1.MouseLeave += new System.EventHandler(this.btnCamiones1_MouseLeave);
            // 
            // btnProveedores1
            // 
            this.btnProveedores1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnProveedores1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransition.SetDecoration(this.btnProveedores1, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.btnProveedores1, BunifuAnimatorNS.DecorationType.None);
            this.btnProveedores1.FlatAppearance.BorderSize = 0;
            this.btnProveedores1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores1.ForeColor = System.Drawing.Color.White;
            this.btnProveedores1.Location = new System.Drawing.Point(168, 141);
            this.btnProveedores1.Margin = new System.Windows.Forms.Padding(180, 1, 3, 4);
            this.btnProveedores1.Name = "btnProveedores1";
            this.btnProveedores1.Size = new System.Drawing.Size(224, 49);
            this.btnProveedores1.TabIndex = 5;
            this.btnProveedores1.Text = "PROVEEDORES";
            this.btnProveedores1.UseVisualStyleBackColor = false;
            this.btnProveedores1.Click += new System.EventHandler(this.btnProveedores1_Click);
            this.btnProveedores1.MouseEnter += new System.EventHandler(this.btnProveedores1_MouseEnter);
            this.btnProveedores1.MouseLeave += new System.EventHandler(this.btnProveedores1_MouseLeave);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(160)))));
            this.btnProveedores.color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(160)))));
            this.btnProveedores.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(175)))), ((int)(((byte)(140)))));
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnProveedores, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.btnProveedores, BunifuAnimatorNS.DecorationType.None);
            this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.Black;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImagePosition = 1;
            this.btnProveedores.ImageZoom = 30;
            this.btnProveedores.LabelPosition = 0;
            this.btnProveedores.LabelText = "Proveedores";
            this.btnProveedores.Location = new System.Drawing.Point(168, 60);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(150, 10, 9, 1);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(224, 79);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            this.btnProveedores.MouseEnter += new System.EventHandler(this.btnProveedores_MouseEnter);
            this.btnProveedores.MouseLeave += new System.EventHandler(this.btnProveedores_MouseLeave);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(160)))));
            this.btnUsuarios.color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(160)))));
            this.btnUsuarios.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(175)))), ((int)(((byte)(140)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.btnUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImagePosition = 1;
            this.btnUsuarios.ImageZoom = 30;
            this.btnUsuarios.LabelPosition = 0;
            this.btnUsuarios.LabelText = "Usuarios";
            this.btnUsuarios.Location = new System.Drawing.Point(168, 287);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(9, 123, 9, 1);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(224, 79);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            this.btnUsuarios.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.btnUsuarios_MouseLeave);
            // 
            // btnMateriales
            // 
            this.btnMateriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(160)))));
            this.btnMateriales.color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(160)))));
            this.btnMateriales.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(175)))), ((int)(((byte)(140)))));
            this.btnMateriales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnMateriales, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.btnMateriales, BunifuAnimatorNS.DecorationType.None);
            this.btnMateriales.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriales.ForeColor = System.Drawing.Color.Black;
            this.btnMateriales.Image = ((System.Drawing.Image)(resources.GetObject("btnMateriales.Image")));
            this.btnMateriales.ImagePosition = 1;
            this.btnMateriales.ImageZoom = 30;
            this.btnMateriales.LabelPosition = 0;
            this.btnMateriales.LabelText = "Materiales";
            this.btnMateriales.Location = new System.Drawing.Point(541, 287);
            this.btnMateriales.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(224, 79);
            this.btnMateriales.TabIndex = 3;
            this.btnMateriales.Click += new System.EventHandler(this.btnMateriales_Click);
            this.btnMateriales.MouseEnter += new System.EventHandler(this.btnMateriales_MouseEnter);
            this.btnMateriales.MouseLeave += new System.EventHandler(this.btnMateriales_MouseLeave);
            // 
            // btnCamiones
            // 
            this.btnCamiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(160)))));
            this.btnCamiones.color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(160)))));
            this.btnCamiones.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(175)))), ((int)(((byte)(140)))));
            this.btnCamiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnCamiones, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.btnCamiones, BunifuAnimatorNS.DecorationType.None);
            this.btnCamiones.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamiones.ForeColor = System.Drawing.Color.Black;
            this.btnCamiones.Image = ((System.Drawing.Image)(resources.GetObject("btnCamiones.Image")));
            this.btnCamiones.ImagePosition = 1;
            this.btnCamiones.ImageZoom = 30;
            this.btnCamiones.LabelPosition = 0;
            this.btnCamiones.LabelText = "Camiones";
            this.btnCamiones.Location = new System.Drawing.Point(541, 60);
            this.btnCamiones.Margin = new System.Windows.Forms.Padding(9, 10, 150, 10);
            this.btnCamiones.Name = "btnCamiones";
            this.btnCamiones.Size = new System.Drawing.Size(224, 79);
            this.btnCamiones.TabIndex = 2;
            this.btnCamiones.Click += new System.EventHandler(this.btnCamiones_Click);
            this.btnCamiones.MouseEnter += new System.EventHandler(this.btnCamiones_MouseEnter);
            this.btnCamiones.MouseLeave += new System.EventHandler(this.btnCamiones_MouseLeave);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.slideTransition.SetDecoration(this.lblIndice, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.lblIndice, BunifuAnimatorNS.DecorationType.None);
            this.lblIndice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndice.Location = new System.Drawing.Point(14, 18);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(91, 22);
            this.lblIndice.TabIndex = 5;
            this.lblIndice.Text = "Maestros";
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
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Balanza.Properties.Resources.icons8_macos_cerrar_321;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransition.SetDecoration(this.btnVolver, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.btnVolver, BunifuAnimatorNS.DecorationType.None);
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(846, 0);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(57, 63);
            this.btnVolver.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnVolver, "Volver a Maestros");
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            // MaestrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 650);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.lblIndice);
            this.slideTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MaestrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaestrosForm";
            this.panelPrincipal.ResumeLayout(false);
            this.cardMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panelPrincipal;
        private Bunifu.Framework.UI.BunifuCards cardMenu;
        private Bunifu.Framework.UI.BunifuTileButton btnProveedores;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIndice;
        private BunifuAnimatorNS.BunifuTransition fadeTransition;
        private BunifuAnimatorNS.BunifuTransition slideTransition;
        private Bunifu.Framework.UI.BunifuTileButton btnCamiones;
        private Bunifu.Framework.UI.BunifuTileButton btnMateriales;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuTileButton btnUsuarios;
        private System.Windows.Forms.Button btnProveedores1;
        private System.Windows.Forms.Button btnCamiones1;
        private System.Windows.Forms.Button btnMateriales1;
        private System.Windows.Forms.Button btnUsuarios1;
    }
}