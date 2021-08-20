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
using Balanza.Forms;
using Balanza.Herramientas;

namespace Balanza.Componentes
{
    public partial class AltaMovimientoCard : UserControl
    {
        MovimientosForm formPadre;
        registros_tarjetas unRegistro;
        public AltaMovimientoCard(MovimientosForm padre, registros_tarjetas registro)
        {
            InitializeComponent();

            formPadre = padre;
            unRegistro = registro;

            DateTimePickerFormat();
            LoadRegistro();
        }

        #region METODOS

        void LoadRegistro()
        {
            if(unRegistro != null)
            {
                dtFechaEntrada.Value = unRegistro.fecha;
                txtNroTarjeta.Text = unRegistro.nro_tarjeta;
                txtRazonSocial.Text = unRegistro.razon_social;
                txtPatente.Text = unRegistro.patente;
                txtMaterial.Text = unRegistro.material;
            }
        }

        void DateTimePickerFormat()
        {
            dtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtHoraEntrada.ShowUpDown = true;

            dtHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtHoraSalida.ShowUpDown = true;

            dtFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtFechaEntrada.CustomFormat = "dd-MM-yyyy";
        }

        void MostrarAlerta(Panel alerta)
        {
            btnVolver.Enabled = false;
            btnFinalizar.Enabled = false;

            numPesoEntrada.Enabled = false;
            numPesoSalida.Enabled = false;

            txtPesoEntrada.Enabled = false;
            txtPesoSalida.Enabled = false;
            txtFecha.Enabled = false;
            txtObservaciones.Enabled = false;

            dtFechaEntrada.Enabled = false;
            dtHoraEntrada.Enabled = false;
            dtHoraSalida.Enabled = false;

            alerta.BringToFront();
            alertaTransition.Show(alerta);
        }

        void EsconderAlerta(Panel alerta)
        {
            btnVolver.Enabled = true;
            btnFinalizar.Enabled = true;

            numPesoEntrada.Enabled = true;
            numPesoSalida.Enabled = true;

            txtPesoEntrada.Enabled = true;
            txtPesoSalida.Enabled = true;
            txtFecha.Enabled = true;
            txtObservaciones.Enabled = true;

            dtFechaEntrada.Enabled = true;
            dtHoraEntrada.Enabled = true;
            dtHoraSalida.Enabled = true;

            alertaTransition.Hide(alerta);
        }

        #endregion

        #region BOTONES

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //VALIDACIONES
            if(dtHoraSalida.Value < dtHoraEntrada.Value)
            {
                Alertas.ShowError("Hora de salida menor a la de entrada.");
                return;
            }

            MovimientosCamionesModel movimientoSv = new MovimientosCamionesModel();
            movimientos_camiones movimiento = new movimientos_camiones();

            movimiento.registros_tarjeta_id = unRegistro.id;
            movimiento.peso_entrada = Convert.ToInt32(numPesoEntrada.Value);
            movimiento.peso_salida = Convert.ToInt32(numPesoSalida.Value);

            DateTime entrada = new DateTime
                               (dtFechaEntrada.Value.Year,
                                dtFechaEntrada.Value.Month,
                                dtFechaEntrada.Value.Day,
                                dtHoraEntrada.Value.Hour,
                                dtHoraEntrada.Value.Minute,
                                dtHoraEntrada.Value.Second
                                );

            movimiento.fecha_entrada = entrada;

            DateTime salida = new DateTime
                              (dtFechaEntrada.Value.Year,
                               dtFechaEntrada.Value.Month,
                               dtFechaEntrada.Value.Day,
                               dtHoraSalida.Value.Hour,
                               dtHoraSalida.Value.Minute,
                               dtHoraSalida.Value.Second
                               );

            movimiento.fecha_salida = salida;

            movimiento.observacion_planta = txtObservaciones.Text;
            movimiento.balanza_entrada_sn = true;
            movimiento.balanza_salida_sn = true;
            movimiento.created_at = DateTime.Now;
            movimiento.updated_at = DateTime.Now;

            users usuarioLogeado = Globales.GetCurrentUser();
            movimiento.user_id = usuarioLogeado.id;

            Resultado resultado = movimientoSv.Insertar(movimiento);

            if(!resultado.isOk)
            {
                Alertas.ShowError(resultado.error);
            }
            else
            {
                Alertas.ShowExito("Movimiento Creado.");
                formPadre.ShowMovimientosByRegistro();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPadre.ShowMovimientos();
        }


        #endregion

    }
}
