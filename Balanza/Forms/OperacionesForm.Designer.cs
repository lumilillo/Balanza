namespace Balanza.Forms
{
    partial class OperacionesForm
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
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperacionesForm));
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            this.lblIndice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.cardMenu = new Bunifu.Framework.UI.BunifuCards();
            this.btnAsignarFlota1 = new System.Windows.Forms.Button();
            this.btnAsignarTarjetas1 = new System.Windows.Forms.Button();
            this.btnAsignarFlota = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAsgignarTarjetas = new Bunifu.Framework.UI.BunifuTileButton();
            this.slideTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            this.fadeTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelPrincipal.SuspendLayout();
            this.cardMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.slideTransition.SetDecoration(this.lblIndice, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.lblIndice, BunifuAnimatorNS.DecorationType.None);
            this.lblIndice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndice.Location = new System.Drawing.Point(14, 17);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(129, 22);
            this.lblIndice.TabIndex = 2;
            this.lblIndice.Text = "Operaciones";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.cardMenu);
            this.fadeTransition.SetDecoration(this.panelPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.panelPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 66);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(3, 1, 3, 4);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(951, 602);
            this.panelPrincipal.TabIndex = 3;
            // 
            // cardMenu
            // 
            this.cardMenu.BackColor = System.Drawing.Color.White;
            this.cardMenu.BorderRadius = 0;
            this.cardMenu.BottomSahddow = false;
            this.cardMenu.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.cardMenu.Controls.Add(this.btnAsignarFlota1);
            this.cardMenu.Controls.Add(this.btnAsignarTarjetas1);
            this.cardMenu.Controls.Add(this.btnAsignarFlota);
            this.cardMenu.Controls.Add(this.btnAsgignarTarjetas);
            this.fadeTransition.SetDecoration(this.cardMenu, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.cardMenu, BunifuAnimatorNS.DecorationType.None);
            this.cardMenu.LeftSahddow = false;
            this.cardMenu.Location = new System.Drawing.Point(-9, 4);
            this.cardMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cardMenu.Name = "cardMenu";
            this.cardMenu.RightSahddow = false;
            this.cardMenu.ShadowDepth = 50;
            this.cardMenu.Size = new System.Drawing.Size(951, 593);
            this.cardMenu.TabIndex = 2;
            // 
            // btnAsignarFlota1
            // 
            this.btnAsignarFlota1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnAsignarFlota1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransition.SetDecoration(this.btnAsignarFlota1, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.btnAsignarFlota1, BunifuAnimatorNS.DecorationType.None);
            this.btnAsignarFlota1.FlatAppearance.BorderSize = 0;
            this.btnAsignarFlota1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarFlota1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarFlota1.ForeColor = System.Drawing.Color.White;
            this.btnAsignarFlota1.Location = new System.Drawing.Point(541, 141);
            this.btnAsignarFlota1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 4);
            this.btnAsignarFlota1.Name = "btnAsignarFlota1";
            this.btnAsignarFlota1.Size = new System.Drawing.Size(224, 49);
            this.btnAsignarFlota1.TabIndex = 7;
            this.btnAsignarFlota1.Text = "ASIGNAR FLOTA";
            this.btnAsignarFlota1.UseVisualStyleBackColor = false;
            this.btnAsignarFlota1.Click += new System.EventHandler(this.btnAsignarFlota1_Click);
            this.btnAsignarFlota1.MouseEnter += new System.EventHandler(this.btnAsignarFlota1_MouseEnter);
            this.btnAsignarFlota1.MouseLeave += new System.EventHandler(this.btnAsignarFlota1_MouseLeave);
            // 
            // btnAsignarTarjetas1
            // 
            this.btnAsignarTarjetas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnAsignarTarjetas1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransition.SetDecoration(this.btnAsignarTarjetas1, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.btnAsignarTarjetas1, BunifuAnimatorNS.DecorationType.None);
            this.btnAsignarTarjetas1.FlatAppearance.BorderSize = 0;
            this.btnAsignarTarjetas1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarTarjetas1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarTarjetas1.ForeColor = System.Drawing.Color.White;
            this.btnAsignarTarjetas1.Location = new System.Drawing.Point(168, 141);
            this.btnAsignarTarjetas1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 4);
            this.btnAsignarTarjetas1.Name = "btnAsignarTarjetas1";
            this.btnAsignarTarjetas1.Size = new System.Drawing.Size(224, 49);
            this.btnAsignarTarjetas1.TabIndex = 6;
            this.btnAsignarTarjetas1.Text = "ASIGNAR TARJETAS";
            this.btnAsignarTarjetas1.UseVisualStyleBackColor = false;
            this.btnAsignarTarjetas1.Click += new System.EventHandler(this.btnAsignarTarjetas1_Click);
            this.btnAsignarTarjetas1.MouseEnter += new System.EventHandler(this.btnAsignarTarjetas1_MouseEnter);
            this.btnAsignarTarjetas1.MouseLeave += new System.EventHandler(this.btnAsignarTarjetas1_MouseLeave);
            // 
            // btnAsignarFlota
            // 
            this.btnAsignarFlota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(160)))));
            this.btnAsignarFlota.color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(160)))));
            this.btnAsignarFlota.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(175)))), ((int)(((byte)(140)))));
            this.btnAsignarFlota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnAsignarFlota, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.btnAsignarFlota, BunifuAnimatorNS.DecorationType.None);
            this.btnAsignarFlota.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarFlota.ForeColor = System.Drawing.Color.Black;
            this.btnAsignarFlota.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarFlota.Image")));
            this.btnAsignarFlota.ImagePosition = 1;
            this.btnAsignarFlota.ImageZoom = 30;
            this.btnAsignarFlota.LabelPosition = 0;
            this.btnAsignarFlota.LabelText = "Asignar Flota";
            this.btnAsignarFlota.Location = new System.Drawing.Point(541, 60);
            this.btnAsignarFlota.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnAsignarFlota.Name = "btnAsignarFlota";
            this.btnAsignarFlota.Size = new System.Drawing.Size(224, 79);
            this.btnAsignarFlota.TabIndex = 2;
            this.btnAsignarFlota.Click += new System.EventHandler(this.btnAsignarFlota_Click);
            this.btnAsignarFlota.MouseEnter += new System.EventHandler(this.btnAsignarFlota_MouseEnter);
            this.btnAsignarFlota.MouseLeave += new System.EventHandler(this.btnAsignarFlota_MouseLeave);
            // 
            // btnAsgignarTarjetas
            // 
            this.btnAsgignarTarjetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(160)))));
            this.btnAsgignarTarjetas.color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(160)))));
            this.btnAsgignarTarjetas.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(175)))), ((int)(((byte)(140)))));
            this.btnAsgignarTarjetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fadeTransition.SetDecoration(this.btnAsgignarTarjetas, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this.btnAsgignarTarjetas, BunifuAnimatorNS.DecorationType.None);
            this.btnAsgignarTarjetas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsgignarTarjetas.ForeColor = System.Drawing.Color.Black;
            this.btnAsgignarTarjetas.Image = ((System.Drawing.Image)(resources.GetObject("btnAsgignarTarjetas.Image")));
            this.btnAsgignarTarjetas.ImagePosition = 1;
            this.btnAsgignarTarjetas.ImageZoom = 30;
            this.btnAsgignarTarjetas.LabelPosition = 0;
            this.btnAsgignarTarjetas.LabelText = "Asignar Tarjetas";
            this.btnAsgignarTarjetas.Location = new System.Drawing.Point(168, 60);
            this.btnAsgignarTarjetas.Margin = new System.Windows.Forms.Padding(9, 10, 9, 1);
            this.btnAsgignarTarjetas.Name = "btnAsgignarTarjetas";
            this.btnAsgignarTarjetas.Size = new System.Drawing.Size(224, 79);
            this.btnAsgignarTarjetas.TabIndex = 1;
            this.btnAsgignarTarjetas.Click += new System.EventHandler(this.btnAsgignarTarjetas_Click);
            this.btnAsgignarTarjetas.MouseEnter += new System.EventHandler(this.btnAsgignarTarjetas_MouseEnter);
            this.btnAsgignarTarjetas.MouseLeave += new System.EventHandler(this.btnAsgignarTarjetas_MouseLeave);
            // 
            // slideTransition
            // 
            this.slideTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.slideTransition.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(0);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 1F;
            this.slideTransition.DefaultAnimation = animation11;
            this.slideTransition.Interval = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Balanza.Properties.Resources.icons8_macos_cerrar_322;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideTransition.SetDecoration(this.btnVolver, BunifuAnimatorNS.DecorationType.None);
            this.fadeTransition.SetDecoration(this.btnVolver, BunifuAnimatorNS.DecorationType.None);
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(847, -1);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(57, 63);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // fadeTransition
            // 
            this.fadeTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.fadeTransition.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 1F;
            this.fadeTransition.DefaultAnimation = animation12;
            this.fadeTransition.Interval = 15;
            // 
            // OperacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 650);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.lblIndice);
            this.fadeTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.slideTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OperacionesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AsignacionTarjetasForm";
            this.panelPrincipal.ResumeLayout(false);
            this.cardMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblIndice;
        private System.Windows.Forms.Panel panelPrincipal;
        private Bunifu.Framework.UI.BunifuCards cardMenu;
        private Bunifu.Framework.UI.BunifuTileButton btnAsgignarTarjetas;
        private BunifuAnimatorNS.BunifuTransition slideTransition;
        private System.Windows.Forms.Button btnVolver;
        private Bunifu.Framework.UI.BunifuTileButton btnAsignarFlota;
        private System.Windows.Forms.Button btnAsignarFlota1;
        private System.Windows.Forms.Button btnAsignarTarjetas1;
        private BunifuAnimatorNS.BunifuTransition fadeTransition;
    }
}