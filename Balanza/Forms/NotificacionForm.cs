using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balanza.Forms
{
    public partial class NotificacionForm : Form
    {
        Form formPadre;
        public string mensajes;

        public NotificacionForm(Form padre)
        {
            InitializeComponent();

            formPadre = padre;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(formPadre.Location.X + 430, formPadre.Location.Y + 50);

            FadeIn();
            Cerrar();
        }

        public void SetFormato(string mensaje)
        {
            lblMensajes.Text = mensaje;
        }

        async void FadeIn()
        {
            while (this.Opacity < 1.0)
            {
                await Task.Delay(30);
                this.Opacity += 0.05;
            }
            this.Opacity = 1;
        }

        void Cerrar()
        {
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuProgressBar1.Value += 1;
        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {
            if(bunifuProgressBar1.Value ==  bunifuProgressBar1.MaximumValue)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
