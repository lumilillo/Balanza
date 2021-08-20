using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Entidades;
using Negocio.Modelos;

namespace Balanza.Forms
{
    public partial class AlertaObservaciones : Form
    {
        Form formPadre;
        registros_tarjetas registro;
        public string mensajes;

        public AlertaObservaciones(Form padre)
        {
            InitializeComponent();

            this.formPadre = padre;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(formPadre.Location.X + 400, formPadre.Location.Y + 60);

            FadeIn();
        }
        public void SetFormato(registros_tarjetas registro, string obsPlanta, string obsWeb)
        {
            this.registro = registro;
            this.txtObsPlanta.Text = obsPlanta;
            this.txtObsWeb.Text = obsWeb;
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (txtObsPlanta.Text == this.registro.observacion_planta) { this.Close(); return; }

            RegistrosTarjetasModelo registroSv = new RegistrosTarjetasModelo();
            this.registro.observacion_planta = txtObsPlanta.Text;
            this.registro.updated_at = DateTime.Now;
 
            Resultado resultado = registroSv.Editar(this.registro);

            if(!resultado.isOk) { this.lblError.Visible = true; this.lblError.Text = "El campo debe ser menor a los 200 caracteres"; return; }

            this.Close();
        }
    }
}
