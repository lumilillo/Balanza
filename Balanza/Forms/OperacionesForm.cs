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
    public partial class OperacionesForm : Form
    {
        AsigntarTarjetaControl tarjetaCard;
        FlotaCard flotaCard;
        Control currentControl;

        public Boolean Trabajando;
        public OperacionesForm()
        {
            InitializeComponent();

            currentControl = cardMenu;
        }

        #region LOAD

        //LOAD OPCIONES MENU

        void LoadTarjetaCard()
        {
            tarjetaCard = new AsigntarTarjetaControl(this);
            tarjetaCard.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(tarjetaCard);
            panelPrincipal.Tag = tarjetaCard;

            currentControl = tarjetaCard;

            lblIndice.Text = "Asignación de Tarjetas";
        }

        void LoadCamionCard()
        {
            flotaCard = new FlotaCard(this);

            flotaCard.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(flotaCard);
            panelPrincipal.Tag = flotaCard;

            currentControl = flotaCard;

            lblIndice.Text = "Asignación de Flota";
        }

        #endregion

        #region FORMATO

        //MOSTRAR ESCONDER
        public void ShowAsync()
        {
            fadeTransition.Show(btnVolver);
            fadeTransition.Show(lblIndice);
            slideTransition.Show(currentControl);
            this.Show();
        }

        public void HideSync()
        {
            btnVolver.Hide();
            lblIndice.Hide();
            slideTransition.Hide(currentControl);
            this.Hide();
        }

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

        public void ShowOperaciones()
        {
            HideMenuSync();

            currentControl = cardMenu;
            lblIndice.Text = "Operaciones";
            btnVolver.Visible = false;

            ShowMenuAsync();
        }

        private void btnAsignarTarjetas1_MouseEnter(object sender, EventArgs e)
        {
            btnAsgignarTarjetas.color = Color.FromArgb(213, 175, 140);
        }

        private void btnAsignarTarjetas1_MouseLeave(object sender, EventArgs e)
        {
            btnAsgignarTarjetas.color = Color.FromArgb(244, 201, 160);
        }

        private void btnAsgignarTarjetas_MouseEnter(object sender, EventArgs e)
        {
            btnAsignarTarjetas1.BackColor = Color.FromArgb(218, 113, 32);
        }

        private void btnAsgignarTarjetas_MouseLeave(object sender, EventArgs e)
        {
            btnAsignarTarjetas1.BackColor = Color.FromArgb(250, 129, 36);
        }

        private void btnAsignarFlota1_MouseEnter(object sender, EventArgs e)
        {
            btnAsignarFlota.color = Color.FromArgb(213, 175, 140);
        }

        private void btnAsignarFlota1_MouseLeave(object sender, EventArgs e)
        {
            btnAsignarFlota.color = Color.FromArgb(244, 201, 160);
        }

        private void btnAsignarFlota_MouseEnter(object sender, EventArgs e)
        {
            btnAsignarFlota1.BackColor = Color.FromArgb(218, 113, 32);
        }

        private void btnAsignarFlota_MouseLeave(object sender, EventArgs e)
        {
            btnAsignarFlota1.BackColor = Color.FromArgb(250, 129, 36);
        }

        #endregion

        #region BOTONES

        private void btnAsgignarTarjetas_Click(object sender, EventArgs e)
        {
            fadeTransition.Hide(cardMenu);

            LoadTarjetaCard();

            currentControl = tarjetaCard;

            fadeTransition.Show(tarjetaCard);

            btnVolver.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if(currentControl != null && currentControl != cardMenu)
            {
                ShowOperaciones();
            }
        }

        private void btnAsignarFlota_Click(object sender, EventArgs e)
        {
            fadeTransition.Hide(cardMenu);

            LoadCamionCard();

            currentControl = flotaCard;

            fadeTransition.Show(flotaCard);

            btnVolver.Visible = true;
        }

        private void btnAsignarTarjetas1_Click(object sender, EventArgs e)
        {
            btnAsgignarTarjetas_Click(sender, e);
        }

        private void btnAsignarFlota1_Click(object sender, EventArgs e)
        {
            btnAsignarFlota_Click(sender, e);
        }


        #endregion


    }
}
