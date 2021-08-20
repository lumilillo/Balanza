using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Entidades;
using Negocio.Modelos;
using System.Text.RegularExpressions;
using Balanza.Herramientas;

namespace Balanza.Componentes
{
    public partial class AltaCamionCard : UserControl
    {
        CamionesCard cardPadre;
        camiones camionEditando;

        public AltaCamionCard(CamionesCard padre, bool modificacion, camiones camion)
        {
            InitializeComponent();

            cardPadre = padre;

            LoadTipoCamiones();
            LoadFormatoAlerta();

            if (modificacion)
            {
                camionEditando = camion;
                LoadModificacion();
            }
        }

        #region LOAD

        void LoadModificacion()
        {
            lblIndice.Visible = false;
            btnFinalizar.Visible = false;

            btnModificar.Visible = true;
            lblModificar.Visible = true;
            //lblExito.Text = "Camión Modificado!";

            cBoxTipoCamion.SelectedValue = camionEditando.tipo_camion_id;

            txtPatente.Text = camionEditando.patente_chasis;

            txtPatente.Focus();
        }

        void LoadTipoCamiones()
        {
            TipoCamionesModel tipoCamionesSv = new TipoCamionesModel();
            List<tipo_camiones> tipoCamiones = tipoCamionesSv.GetAll();

            cBoxTipoCamion.DataSource = tipoCamiones;
            cBoxTipoCamion.DisplayMember = "codigo";
            cBoxTipoCamion.ValueMember = "id";

        }

        void LoadFormatoAlerta()
        {
            //btnFinalizarError.BackColor = Color.FromArgb(233, 133, 153);
            //btnFinalizarAlta.BackColor = Color.FromArgb(155, 220, 170);
        }

        #endregion

        #region METODOS

        //VALIDA QUE LA PATENTE SEA NUEVA O VIEJA
        bool ValidarPatente(string patente)
        {
            Regex patenteVieja = new Regex("^[A-Z]{3}[0-9]{3}$");
            Regex patenteNueva = new Regex("[A-Z]{2}[0-9]{3}[A-Z]{2}$");

            if (!patenteVieja.IsMatch(patente) && !patenteNueva.IsMatch(patente))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        void MostrarAlerta(Panel alerta)
        {
            btnFinalizar.Enabled = false;
            btnVolver.Enabled = false;
            cBoxTipoCamion.Enabled = false;
            txtPatente.Enabled = false;

            alerta.BringToFront();
            alertaTransition.Show(alerta);
            alerta.Focus();
        }

        void EsconderAlerta(Panel alerta)
        {
            btnFinalizar.Enabled = true;
            btnVolver.Enabled = true;
            cBoxTipoCamion.Enabled = true;
            txtPatente.Enabled = true;

            alertaTransition.Hide(alerta);
        }

        #endregion

        #region BOTONES

        //INTENTA DAR DE ALTA EL CAMION
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            CamionesModel camionesSv = new CamionesModel();
            camiones camion = new camiones();

            string patente = Regex.Replace(txtPatente.Text.ToUpper(), @"\s+", "");

            //VALIDA FORMATO PATENTE
            if (!ValidarPatente(patente))
            {
                Alertas.ShowError("Patente Invalida.");
                return;
            }

            //VALIDA QUE NO EXISTA LA PATENTE
            camiones camionRepetido = camionesSv.FindByPatente(patente);
            if(camionRepetido != null)
            {
                Alertas.ShowError("Patente Repetida.");
                return;
            }


            camion.tipo_camion_id = ((tipo_camiones)cBoxTipoCamion.SelectedItem).id;
            camion.patente_chasis = patente;
            camion.created_at = DateTime.Now;
            camion.updated_at = DateTime.Now;

            //INSERT
            Resultado resultado = camionesSv.Insertar(camion);

            if(resultado.isOk)
            {
                Alertas.ShowExito("Camión Creado.");
                cardPadre.ShowABM();
            }
            else
            {
                Alertas.ShowError(resultado.error);
                return;
            }
        }

        //INTENTA MODIFICAR EL CAMION
        private void btnModificar_Click(object sender, EventArgs e)
        {
            CamionesModel camionesSv = new CamionesModel();

            string patente = Regex.Replace(txtPatente.Text.ToUpper(), @"\s+", "");

            //VALIDA FORMATO PATENTE
            if (!ValidarPatente(patente))
            {
                Alertas.ShowError("Patente Invalida.");
                return;
            }

            //VALIDA QUE NO EXISTA LA PATENTE Y QUE NO SEA EL MISMO CAMION
            camiones camionRepetido = camionesSv.FindByPatente(patente);
            if (camionRepetido != null && camionRepetido.id != camionEditando.id)
            {
                Alertas.ShowError("Patente Repetida.");
                return;
            }


            camionEditando.tipo_camion_id = ((tipo_camiones)cBoxTipoCamion.SelectedItem).id;
            camionEditando.patente_chasis = patente;
            camionEditando.updated_at = DateTime.Now;

            //EDITAR
            Resultado resultado = camionesSv.Editar(camionEditando);

            if (resultado.isOk)
            {
                Alertas.ShowExito("Camión Modificado.");
                cardPadre.ShowABM();
            }
            else
            {
                Alertas.ShowError(resultado.error);
                return;
            }
        }

        //VUELVE AL ABM
        private void btnVolver_Click(object sender, EventArgs e)
        {
            cardPadre.ShowABM();
        }

        //CERRRA ALERTA ERRORES
        //private void btnFinalizarError_Click(object sender, EventArgs e)
        //{
        //    EsconderAlerta(alertaError);
        //}

        ////CERRAR ALERTA EXITO, VUELVE AL BM
        //private void btnFinalizarAlta_Click(object sender, EventArgs e)
        //{
        //    EsconderAlerta(alertaExito);
        //    cardPadre.ShowABM();
        //}

        #endregion

        #region COMPORTAMIENTO

        //CAMBIO DE FOCO A PATENTE
        private void cBoxTipoCamion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPatente.Focus();
            }
        }

        //FINALIZA ALTA
        private void txtPatente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btnFinalizar.Visible)
                {
                    btnFinalizar_Click(sender, e);
                }
                else
                {
                    btnModificar_Click(sender, e);
                }
            }
        }

        #endregion

        private void txtPatente_OnValueChanged(object sender, EventArgs e)
        {
            if (txtPatente.Text.Length > 0 && camionEditando != null)
            {
                lblIndicePatente.Visible = true;
            }
            else
            {
                lblIndicePatente.Visible = false;
            }
        }

        private void AltaCamionCard_Load(object sender, EventArgs e)
        {
            if(camionEditando != null)
            {
                txtPatente.Width = cBoxTipoCamion.Width;
                txtTipoCamion.Width = cBoxTipoCamion.Width;
            }
        }
    }
}
