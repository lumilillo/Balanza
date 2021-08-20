using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Balanza.Forms;
using Entidades.Entidades;
using Negocio.Modelos;
using Balanza.Herramientas;

namespace Balanza.Componentes
{
    public partial class ModificarMovimientoCard : UserControl
    {
        MovimientosForm formPadre;
        movimientos_camiones movimientoEditar;
        registros_tarjetas registro;
        List<permissions> permisos;
        bool preguntarEstado;

        public ModificarMovimientoCard(MovimientosForm padre, movimientos_camiones movimiento)
        {
            InitializeComponent();

            formPadre = padre;
            movimientoEditar = movimiento;

            RegistrosTarjetasModelo registroSv = new RegistrosTarjetasModelo();
            registro = registroSv.FindById(movimientoEditar.registros_tarjeta_id);

            DateTimePickerFormat();
            LoadMovimiento();
        }

        #region FORMATO

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
            txtObsWeb.Enabled = false;

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
            txtObsWeb.Enabled = true;

            dtFechaEntrada.Enabled = true;
            dtHoraEntrada.Enabled = true;
            dtHoraSalida.Enabled = true;

            alertaTransition.Hide(alerta);
        }

        #endregion

        #region METODOS

        void LoadMovimiento()
        {
            if(movimientoEditar != null)
            {
                numPesoEntrada.Value = movimientoEditar.peso_entrada;

                if (movimientoEditar.peso_salida != null)
                {
                    numPesoSalida.Value = (int)movimientoEditar.peso_salida;
                }
                else
                {
                    numPesoSalida.Value = 0;
                }

                dtFechaEntrada.Value = movimientoEditar.fecha_entrada;
                dtHoraEntrada.Value = movimientoEditar.fecha_entrada;

                if (movimientoEditar.fecha_salida != null)
                {
                    dtHoraSalida.Value = (DateTime)movimientoEditar.fecha_salida;
                }
                else
                {
                    dtHoraSalida.Value = DateTime.Today;
                }

                txtNroTarjeta.Text = movimientoEditar.tarjeta;
                txtRazonSocial.Text = movimientoEditar.razon_social;
                txtPatente.Text = movimientoEditar.patente;
                txtMaterial.Text = movimientoEditar.material;
                txtObsWeb.Text = movimientoEditar.observacion_web;
                txtObsParva.Text = movimientoEditar.observacion_planta;
            }
        }

        #endregion

        #region BOTONES

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPadre.ShowMovimientos();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //VALIDACIONES

            //if(registro.carga_sn && numPesoSalida.Value < numPesoEntrada.Value)
            //{
            //    Alertas.ShowError("Carga: " + "\n" + "El peso salida debe ser mayor al de entrada.");
            //    return;
            //}
            //if (registro.devolucion_sn && numPesoSalida.Value < numPesoEntrada.Value)
            //{
            //    Alertas.ShowError("Carga: " + "\n" + "El peso salida debe ser menor al de entrada.");
            //    return;
            //}
            //if (registro.descarga_sn && numPesoSalida.Value > numPesoEntrada.Value)
            //{

            //    Alertas.ShowError("Descarga: " + "\n" + "El peso salida debe ser menor al de entrada.");
            //    return;
            //}
            //if(dtHoraSalida.Value < dtHoraEntrada.Value)
            //{
            //    Alertas.ShowError("Hora de salida menor a la de entrada.");
            //    return;
            //}

            MovimientosCamionesModel movimientosSv = new MovimientosCamionesModel();

            //movimientoEditar.peso_entrada = Convert.ToInt32(numPesoEntrada.Value);
            //movimientoEditar.peso_salida = Convert.ToInt32(numPesoSalida.Value);

            //DateTime entrada = new DateTime
            //    (dtFechaEntrada.Value.Year,
            //     dtFechaEntrada.Value.Month,
            //     dtFechaEntrada.Value.Day,
            //     dtHoraEntrada.Value.Hour,
            //     dtHoraEntrada.Value.Minute,
            //     dtHoraEntrada.Value.Second
            //    );

            //movimientoEditar.fecha_entrada = entrada;

            //DateTime salida = new DateTime
            //    (dtFechaEntrada.Value.Year,
            //     dtFechaEntrada.Value.Month,
            //     dtFechaEntrada.Value.Day,
            //     dtHoraSalida.Value.Hour,
            //     dtHoraSalida.Value.Minute,
            //     dtHoraSalida.Value.Second
            //    );

            //movimientoEditar.fecha_salida = salida;
            //movimientoEditar.updated_at = DateTime.Now;
            movimientoEditar.observacion_planta = txtObsParva.Text;
            movimientoEditar.updated_at = DateTime.Now;

            if (!string.IsNullOrEmpty(txtObsParva.Text))
            {
                EstadosModel estadoSv = new EstadosModel();
                estados estado = estadoSv.FindByCodigo("COMENTADO");
                movimientoEditar.estado_id = estado.id;
            }

            users usuarioLogeado = Globales.GetCurrentUser();
            movimientoEditar.user_id = usuarioLogeado.id; 

            Resultado resultado = movimientosSv.Editar(movimientoEditar);

            if(!resultado.isOk)
            {
                Alertas.ShowError(resultado.error);
            }
            else
            {
                //movimientoEditar.pesoFinal = Math.Abs((int)movimientoEditar.peso_entrada - (int)movimientoEditar.peso_salida);
                Alertas.ShowExito("Movimiento Modificado.");
                formPadre.ShowMovimientosByRegistro();
            }
        }

        #endregion

    }
}
