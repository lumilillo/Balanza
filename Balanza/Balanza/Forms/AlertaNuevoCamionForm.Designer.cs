namespace Balanza.Forms
{
    partial class AlertaNuevoCamionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertaNuevoCamionForm));
            this.cardAlerta = new Bunifu.Framework.UI.BunifuCards();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnAltaCamion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.cBoxPanelTipoCamion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cardAlerta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cardAlerta
            // 
            this.cardAlerta.BackColor = System.Drawing.Color.White;
            this.cardAlerta.BorderRadius = 0;
            this.cardAlerta.BottomSahddow = false;
            this.cardAlerta.color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.cardAlerta.Controls.Add(this.btnCancelar);
            this.cardAlerta.Controls.Add(this.bunifuSeparator2);
            this.cardAlerta.Controls.Add(this.bunifuSeparator1);
            this.cardAlerta.Controls.Add(this.btnAltaCamion);
            this.cardAlerta.Controls.Add(this.label2);
            this.cardAlerta.Controls.Add(this.label1);
            this.cardAlerta.Controls.Add(this.lblPatente);
            this.cardAlerta.Controls.Add(this.cBoxPanelTipoCamion);
            this.cardAlerta.Controls.Add(this.label3);
            this.cardAlerta.Controls.Add(this.pictureBox1);
            this.cardAlerta.LeftSahddow = false;
            this.cardAlerta.Location = new System.Drawing.Point(0, 0);
            this.cardAlerta.Name = "cardAlerta";
            this.cardAlerta.RightSahddow = false;
            this.cardAlerta.ShadowDepth = 20;
            this.cardAlerta.Size = new System.Drawing.Size(441, 242);
            this.cardAlerta.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 10;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.White;
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.Crimson;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 2;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.White;
            this.btnCancelar.IdleForecolor = System.Drawing.Color.Crimson;
            this.btnCancelar.IdleLineColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(6, 189);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(181, 43);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(6, 136);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(423, 10);
            this.bunifuSeparator2.TabIndex = 40;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(6, 68);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(423, 10);
            this.bunifuSeparator1.TabIndex = 39;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnAltaCamion
            // 
            this.btnAltaCamion.ActiveBorderThickness = 1;
            this.btnAltaCamion.ActiveCornerRadius = 10;
            this.btnAltaCamion.ActiveFillColor = System.Drawing.Color.White;
            this.btnAltaCamion.ActiveForecolor = System.Drawing.Color.RoyalBlue;
            this.btnAltaCamion.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnAltaCamion.BackColor = System.Drawing.Color.White;
            this.btnAltaCamion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAltaCamion.BackgroundImage")));
            this.btnAltaCamion.ButtonText = "Agregar";
            this.btnAltaCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaCamion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCamion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAltaCamion.IdleBorderThickness = 1;
            this.btnAltaCamion.IdleCornerRadius = 2;
            this.btnAltaCamion.IdleFillColor = System.Drawing.Color.White;
            this.btnAltaCamion.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnAltaCamion.IdleLineColor = System.Drawing.Color.White;
            this.btnAltaCamion.Location = new System.Drawing.Point(248, 189);
            this.btnAltaCamion.Margin = new System.Windows.Forms.Padding(5);
            this.btnAltaCamion.Name = "btnAltaCamion";
            this.btnAltaCamion.Size = new System.Drawing.Size(181, 43);
            this.btnAltaCamion.TabIndex = 36;
            this.btnAltaCamion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAltaCamion.Click += new System.EventHandler(this.btnAltaCamion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Patente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(3, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.BackColor = System.Drawing.Color.Transparent;
            this.lblPatente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(12, 75);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(70, 23);
            this.lblPatente.TabIndex = 22;
            this.lblPatente.Text = "Errores";
            this.lblPatente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cBoxPanelTipoCamion
            // 
            this.cBoxPanelTipoCamion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxPanelTipoCamion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxPanelTipoCamion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(153)))));
            this.cBoxPanelTipoCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPanelTipoCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPanelTipoCamion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPanelTipoCamion.FormattingEnabled = true;
            this.cBoxPanelTipoCamion.Location = new System.Drawing.Point(12, 150);
            this.cBoxPanelTipoCamion.Name = "cBoxPanelTipoCamion";
            this.cBoxPanelTipoCamion.Size = new System.Drawing.Size(197, 29);
            this.cBoxPanelTipoCamion.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(145, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nuevo Camión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            // 
            // AlertaNuevoCamionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 243);
            this.Controls.Add(this.cardAlerta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertaNuevoCamionForm";
            this.Opacity = 0D;
            this.Text = "AlertaNuevoCamionForm";
            this.cardAlerta.ResumeLayout(false);
            this.cardAlerta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardAlerta;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxPanelTipoCamion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAltaCamion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
    }
}