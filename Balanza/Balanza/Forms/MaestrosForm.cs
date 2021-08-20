using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Balanza.Componentes;

namespace Balanza.Forms
{
    public partial class MaestrosForm : Form
    {
        ProveedorCard proveedorCard;
        CamionesCard camionesCard;
        MaterialesCard materialesCard;
        UsuariosCard usuariosCard;
        Control currentControl;

        public MaestrosForm()
        {
            InitializeComponent();

            currentControl = cardMenu;
        }

        #region SHOW HIDE

        public void ShowMenuAsync()
        {
            fadeTransition.Show(lblIndice);
            fadeTransition.Show(currentControl);
        }

        public void HideMenuSync()
        {
            fadeTransition.Hide(lblIndice);
            fadeTransition.HideSync(currentControl);

            if (currentControl != cardMenu)
            {
                this.Controls.Remove(currentControl);
                currentControl.Dispose();
            }
        }

        public void ShowMaestros()
        {
            HideMenuSync();

            currentControl = cardMenu;
            lblIndice.Text = "Maestros";
            btnVolver.Visible = false;

            ShowMenuAsync();
        }

        #endregion

        #region LOAD

        void LoadProveedor()
        {
            proveedorCard = new ProveedorCard(this);
            proveedorCard.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(proveedorCard);
            panelPrincipal.Tag = proveedorCard;

            currentControl = proveedorCard;

            lblIndice.Text = "Proveedores";
        }

        void LoadCamiones()
        {
            camionesCard = new CamionesCard(this);
            camionesCard.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(camionesCard);
            panelPrincipal.Tag = camionesCard;

            currentControl = camionesCard;

            lblIndice.Text = "Camiones";
        }

        void LoadMateriales()
        {
            materialesCard = new MaterialesCard(this);
            materialesCard.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(materialesCard);
            panelPrincipal.Tag = materialesCard;

            currentControl = materialesCard;

            lblIndice.Text = "Materiales";
        }

        void LoadUsuarios()
        {
            usuariosCard = new UsuariosCard(this);
            usuariosCard.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(usuariosCard);
            panelPrincipal.Tag = usuariosCard;

            currentControl = usuariosCard;

            lblIndice.Text = "Usuarios";
        }
        #endregion

        #region BOTONES

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (currentControl != null && currentControl != cardMenu)
            {
                ShowMaestros();
            }
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            fadeTransition.Hide(cardMenu);

            LoadProveedor();

            currentControl = proveedorCard;

            fadeTransition.Show(proveedorCard);

            btnVolver.Visible = true;
        }

        private void btnCamiones_Click(object sender, EventArgs e)
        {
            fadeTransition.Hide(cardMenu);

            LoadCamiones();

            currentControl = camionesCard;

            fadeTransition.Show(camionesCard);

            btnVolver.Visible = true;
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            
            fadeTransition.Hide(cardMenu);

            LoadMateriales();

            currentControl = materialesCard;

            fadeTransition.Show(materialesCard);

            btnVolver.Visible = true;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            fadeTransition.Hide(cardMenu);

            LoadUsuarios();

            currentControl = usuariosCard;

            fadeTransition.Show(usuariosCard);

            btnVolver.Visible = true;
        }

        private void btnProveedores1_Click(object sender, EventArgs e)
        {
            btnProveedores_Click(sender, e);
        }

        private void btnCamiones1_Click(object sender, EventArgs e)
        {
            btnCamiones_Click(sender, e);
        }

        private void btnUsuarios1_Click(object sender, EventArgs e)
        {
            bunifuTileButton1_Click(sender, e);
        }

        private void btnMateriales1_Click(object sender, EventArgs e)
        {
            btnMateriales_Click(sender, e);
        }

        #endregion

        #region FORMATO

        private void btnProveedores1_MouseEnter(object sender, EventArgs e)
        {
            btnProveedores.color = Color.FromArgb(213, 175, 140);
        }

        private void btnProveedores1_MouseLeave(object sender, EventArgs e)
        {
            btnProveedores.color = Color.FromArgb(244, 201, 160);
        }

        private void btnProveedores_MouseEnter(object sender, EventArgs e)
        {
            btnProveedores1.BackColor = Color.FromArgb(218,113,32);
        }

        private void btnProveedores_MouseLeave(object sender, EventArgs e)
        {
            btnProveedores1.BackColor = Color.FromArgb(250, 129, 36);
        }

        private void btnCamiones_MouseEnter(object sender, EventArgs e)
        {
            btnCamiones1.BackColor = Color.FromArgb(218, 113, 32);
        }

        private void btnCamiones_MouseLeave(object sender, EventArgs e)
        {
            btnCamiones1.BackColor = Color.FromArgb(250, 129, 36);
        }

        private void btnCamiones1_MouseEnter(object sender, EventArgs e)
        {
            btnCamiones.color = Color.FromArgb(213, 175, 140);
        }

        private void btnCamiones1_MouseLeave(object sender, EventArgs e)
        {
            btnCamiones.color = Color.FromArgb(244, 201, 160);
        }

        private void btnUsuarios1_MouseEnter(object sender, EventArgs e)
        {
            btnUsuarios.color = Color.FromArgb(213, 175, 140);
        }

        private void btnUsuarios1_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.color = Color.FromArgb(244, 201, 160);
        }

        private void btnUsuarios_MouseEnter(object sender, EventArgs e)
        {
            btnUsuarios1.BackColor = Color.FromArgb(218, 113, 32);
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios1.BackColor = Color.FromArgb(250, 129, 36);
        }

        private void btnMateriales1_MouseEnter(object sender, EventArgs e)
        {
            btnMateriales.color = Color.FromArgb(213, 175, 140);
        }

        private void btnMateriales1_MouseLeave(object sender, EventArgs e)
        {
            btnMateriales.color = Color.FromArgb(244, 201, 160);
        }

        private void btnMateriales_MouseEnter(object sender, EventArgs e)
        {
            btnMateriales1.BackColor = Color.FromArgb(218, 113, 32);
        }

        private void btnMateriales_MouseLeave(object sender, EventArgs e)
        {
            btnMateriales1.BackColor = Color.FromArgb(250, 129, 36);
        }

        #endregion

    }
}
