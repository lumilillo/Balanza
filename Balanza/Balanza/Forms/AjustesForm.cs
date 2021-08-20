using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Balanza.Componentes;
using Balanza.Herramientas;
using Balanza.Properties;
using Entidades.Entidades;
using Negocio.Modelos;

namespace Balanza.Forms
{
    public partial class AjustesForm : Form
    {
        TableroPrincipalForm balanza;
        public AjustesForm(TableroPrincipalForm balanzaInstance)
        {
            InitializeComponent();
            balanza = balanzaInstance;

            LoadPuertos();
            LoadSettings();
            LoadEstadoPuertos();

        }

        #region LOAD

        void LoadEstadoPuertos()
        {
            if(Globales.balanzaCOM != null
                && Globales.balanzaCOM.IsOpen)
            {
                switchBalanza.Value = true;
            }
            else
            {
                switchBalanza.Value = false;
            }

            if (Globales.balanzaLectorCOM != null
                && Globales.balanzaLectorCOM.IsOpen)
            {
                switchLectorBalanza.Value = true;
            }
            else
            {
                switchLectorBalanza.Value = false;
            }

            if (Globales.lectorCOM != null
                && Globales.lectorCOM.IsOpen)
            {
                switchLectorDespacho.Value = true;
            }
            else
            {
                switchLectorDespacho.Value = false;
            }
        }

        void LoadPuertos()
        {
            string[] puertos = SerialPort.GetPortNames();

            cBoxPuertoBalanza.DataSource = puertos;

            string[] puertos1 = SerialPort.GetPortNames();

            cBoxPuertoLectorBalanza.DataSource = puertos1;

            string[] puertos3 = SerialPort.GetPortNames();

            cBoxPuertoLector.DataSource = puertos3;
        }

        void LoadSettings()
        {
            LoadBalanzaSettings();
            LoadLectorBalanzaSettings();
            LoadLectorSettings();
        }

        void LoadBalanzaSettings()
        {
            PuertosCOMModel portSv = new PuertosCOMModel();
            puerto_com balanzaPort = portSv.FindByUbicacion("Balanza");

            ParametrosGeneralesModel paramSv = new ParametrosGeneralesModel();
            parametros_generales pesoMin = paramSv.FindByCodigo("PESO_MIN");

            txtPesoMin.Value = Convert.ToDecimal(pesoMin.valor);

            foreach(object item in cBoxPuertoBalanza.Items)
            {
                if(item.ToString() == balanzaPort.port_name)
                {
                    cBoxPuertoBalanza.SelectedItem = item;
                }
            }

            foreach (object item in cBoxDataBalanza.Items)
            {
                if (Convert.ToInt32(item) == balanzaPort.data_bits)
                {
                    cBoxDataBalanza.SelectedItem = item;
                }

            }

            foreach (object item in cBoxBaudBalanza.Items)
            {
                if (Convert.ToInt32(item) == balanzaPort.baud_rate)
                {
                    cBoxBaudBalanza.SelectedItem = item;
                }
            }

            foreach (object item in cBoxParityBalanza.Items)
            {
                if(item.ToString() == balanzaPort.parity)
                {
                    cBoxParityBalanza.SelectedItem = item;
                }
            }

            foreach (object item in cBoxBalanzaStop.Items)
            {
                if (item.ToString() == balanzaPort.stop_bits)
                {
                    cBoxBalanzaStop.SelectedItem = item;
                }
            }

            txtThreshold.Value = Convert.ToInt32(balanzaPort.threshold);
        }

        void LoadLectorBalanzaSettings()
        {
            PuertosCOMModel portSv = new PuertosCOMModel();
            puerto_com lectorBalanzaPort = portSv.FindByUbicacion("Lector Balanza");

            foreach (object item in cBoxPuertoLectorBalanza.Items)
            {
                if (item.ToString() == lectorBalanzaPort.port_name)
                {
                    cBoxPuertoLectorBalanza.SelectedItem = item;
                }
            }

            foreach (object item in cBoxDataLectorBalanza.Items)
            {
                if (Convert.ToInt32(item) == lectorBalanzaPort.data_bits)
                {
                    cBoxDataLectorBalanza.SelectedItem = item;
                }

            }

            foreach (object item in cBoxBaudLectorBalanza.Items)
            {
                if (Convert.ToInt32(item) == lectorBalanzaPort.baud_rate)
                {
                    cBoxBaudLectorBalanza.SelectedItem = item;
                }
            }

            foreach (object item in cBoxParityLectorBalanza.Items)
            {
                if (item.ToString() == lectorBalanzaPort.parity)
                {
                    cBoxParityLectorBalanza.SelectedItem = item;
                }
            }

            foreach (object item in cBoxLectorBalanzaStop.Items)
            {
                if (item.ToString() == lectorBalanzaPort.stop_bits)
                {
                    cBoxLectorBalanzaStop.SelectedItem = item;
                }
            }
        }

        void LoadLectorSettings()
        {
            PuertosCOMModel portSv = new PuertosCOMModel();
            puerto_com lectorPort;

            if (Globales.ubicacion == "balanzaRegistro")
            {
                lectorPort = portSv.FindByUbicacion("Lector Balanza");
            }
            else
            {
                lectorPort = portSv.FindByUbicacion("Lector Despacho");
            }

            foreach (object item in cBoxPuertoLector.Items)
            {
                if (item.ToString() == lectorPort.port_name)
                {
                    cBoxPuertoLector.SelectedItem = item;
                }
            }

            foreach (object item in cBoxDataLector.Items)
            {
                if (Convert.ToInt32(item) == lectorPort.data_bits)
                {
                    cBoxDataLector.SelectedItem = item;
                }

            }

            foreach (object item in cBoxBaudLector.Items)
            {
                if (Convert.ToInt32(item) == lectorPort.baud_rate)
                {
                    cBoxBaudLector.SelectedItem = item;
                }
            }

            foreach (object item in cBoxParityLector.Items)
            {
                if (item.ToString() == lectorPort.parity)
                {
                    cBoxParityLector.SelectedItem = item;
                }
            }

            foreach (object item in cBoxLectorStop.Items)
            {
                if (item.ToString() == lectorPort.stop_bits)
                {
                    cBoxLectorStop.SelectedItem = item;
                }
            }
        }

        #endregion

        #region SAVE

        void SaveSettings()
        {
            SaveBalanzaSettings();
            SaveLectorBalanzaSettings();
            SaveLectorSettings();

            LoadEstadoPuertos();
        }


        void SaveBalanzaSettings()
        {
            PuertosCOMModel portSv = new PuertosCOMModel();
            puerto_com balanzaPort = portSv.FindByUbicacion("Balanza");

            ParametrosGeneralesModel paramSv = new ParametrosGeneralesModel();
            parametros_generales pesoMin = paramSv.FindByCodigo("PESO_MIN");

            if (cBoxPuertoBalanza.SelectedItem != null)
            {
                balanzaPort.port_name = cBoxPuertoBalanza.SelectedItem.ToString();
            }
            else
            {
                DesconectarBalanza();
                return;
            }

            if (cBoxDataBalanza.SelectedItem != null)
            {
                balanzaPort.data_bits = Convert.ToInt32(cBoxDataBalanza.SelectedItem);
            }

            if (cBoxBaudBalanza.SelectedItem != null)
            {
                balanzaPort.baud_rate = Convert.ToInt32(cBoxBaudBalanza.SelectedItem);

            }

            if (cBoxParityBalanza.SelectedItem != null)
            {
                balanzaPort.parity = cBoxParityBalanza.SelectedItem.ToString();
            }

            if (cBoxBalanzaStop.SelectedItem != null)
            {
                balanzaPort.stop_bits = cBoxBalanzaStop.SelectedItem.ToString();
            }

            balanzaPort.threshold = Convert.ToInt32(txtThreshold.Value);
            pesoMin.valor = Convert.ToString(txtPesoMin.Value);

            Resultado result = portSv.Editar(balanzaPort);

            if (!result.isOk) { throw new ArgumentException(result.error); }

            result = paramSv.Editar(pesoMin);

            if (!result.isOk) { throw new ArgumentException(result.error); }

            ConectarBalanza();
        }

        void SaveLectorBalanzaSettings()
        {

            PuertosCOMModel portSv = new PuertosCOMModel();
            puerto_com lectorBalanzaPort = portSv.FindByUbicacion("Lector Balanza");

            if (cBoxPuertoLectorBalanza.SelectedItem != null)
            {
                lectorBalanzaPort.port_name = cBoxPuertoLectorBalanza.SelectedItem.ToString();
            }
            else
            {
                DesconectarLectorBalanza();
                return;
            }

            if (cBoxDataLectorBalanza.SelectedItem != null)
            {
                lectorBalanzaPort.data_bits = Convert.ToInt32(cBoxDataLectorBalanza.SelectedItem);
            }

            if (cBoxBaudLectorBalanza.SelectedItem != null)
            {
                lectorBalanzaPort.baud_rate = Convert.ToInt32(cBoxBaudLectorBalanza.SelectedItem);

            }

            if (cBoxParityLectorBalanza.SelectedItem != null)
            {
                lectorBalanzaPort.parity = cBoxParityLectorBalanza.SelectedItem.ToString();
            }

            if (cBoxLectorBalanzaStop.SelectedItem != null)
            {
                lectorBalanzaPort.stop_bits = cBoxLectorBalanzaStop.SelectedItem.ToString();
            }

            Resultado result = portSv.Editar(lectorBalanzaPort);

            if (!result.isOk) { throw new ArgumentException(result.error); }

            ConectarLectorBalanza();
        }

        void SaveLectorSettings()
        {
            PuertosCOMModel portSv = new PuertosCOMModel();
            puerto_com lectorPort;

            if (Globales.ubicacion == "balanza")
            {
                lectorPort = portSv.FindByUbicacion("Lector Balanza Despacho");
            }
            else
            {
                lectorPort = portSv.FindByUbicacion("Lector Despacho");
            }

            if (cBoxPuertoLector.SelectedItem != null)
            {
                lectorPort.port_name = cBoxPuertoLector.SelectedItem.ToString();
            }
            else
            {
                DesconectarLector();
                return;
            }

            if (cBoxDataLector.SelectedItem != null)
            {
                lectorPort.data_bits = Convert.ToInt32(cBoxDataLector.SelectedItem);
            }

            if (cBoxBaudLector.SelectedItem != null)
            {
                lectorPort.baud_rate = Convert.ToInt32(cBoxBaudLector.SelectedItem);

            }

            if (cBoxParityLector.SelectedItem != null)
            {
                lectorPort.parity = cBoxParityLector.SelectedItem.ToString();
            }

            if (cBoxLectorStop.SelectedItem != null)
            {
                lectorPort.stop_bits = cBoxLectorStop.SelectedItem.ToString();
            }

            Resultado result = portSv.Editar(lectorPort);

            if (!result.isOk) { throw new ArgumentException(result.error); }

            ConectarLector();
        }



        #endregion

        #region METODOS

        void ConectarBalanza()
        {
            try
            {
                Globales.OpenBalanzaCOM();
                switchBalanza.Value = true;
            }
            catch (Exception ex) { switchBalanza.Value = false; MessageBox.Show(ex.Message); }
        }

        void ConectarLectorBalanza()
        {
            try
            {
                Globales.OpenLectorBalanzaCOM();
                switchLectorBalanza.Value = true;
            }
            catch (Exception ex) { switchLectorBalanza.Value = false; MessageBox.Show(ex.Message); }
        }

        void ConectarLector()
        {
            try
            {
                Globales.OpenLectorCOM();
                switchLectorDespacho.Value = true;
            }
            catch (Exception ex) { switchLectorDespacho.Value = false; MessageBox.Show(ex.Message); }
        }

        void DesconectarBalanza()
        {
            Globales.CloseBalanzaCOM();
            switchBalanza.Value = false;
        }

        void DesconectarLectorBalanza()
        {
            Globales.CloseLectorBalanzaCOM();
            switchLectorBalanza.Value = false;
        }

        void DesconectarLector()
        {
            Globales.CloseLectorCOM();
            switchLectorDespacho.Value = false;
        }

        #endregion

        #region BOTONES
        private void btnCancelPuertoBalanza_Click_1(object sender, EventArgs e)
        {
            this.cBoxPuertoBalanza.SelectedIndex = -1;
        }

        private void btnCancelPuertoLectorBalanza_Click_1(object sender, EventArgs e)
        {
            this.cBoxPuertoLectorBalanza.SelectedIndex = -1;
        }


        private void btnCancelPuertoLector_Click_1(object sender, EventArgs e)
        {
            this.cBoxPuertoLector.SelectedIndex = -1;
        }

        private void picDesconectarBalanza_Click_1(object sender, EventArgs e)
        {
            DesconectarBalanza();
            cBoxPuertoBalanza.SelectedIndex = -1;
        }

        private void picDesconectarLectorBalanza_Click_1(object sender, EventArgs e)
        {
            DesconectarLectorBalanza();
            cBoxPuertoLectorBalanza.SelectedIndex = -1;
        }

        private void picDesconectarLector_Click_1(object sender, EventArgs e)
        {
            DesconectarLector();
            cBoxPuertoLector.SelectedIndex = -1;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea guardar los cambios?", "Ajustes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SaveSettings();
                    balanza.SetPuertos();
                    balanza.SetPesoMin();

                    Alertas.ShowExito("Ajustes guardados.");
                    this.Refresh();
                }
                catch (Exception ex) { Alertas.ShowError(ex.Message); }
            }
            else
            {
                LoadSettings();
                LoadEstadoPuertos();
                this.Refresh();
            }
        }

        #endregion

        #region PAPELERA

        /*
         void SaveBalanzaSettings()
        {
            Settings.Default["pesoMin"] = Convert.ToInt32(txtPesoMin.Value);

            if(cBoxPuertoBalanza.SelectedItem != null)
            {
                Settings.Default["puertoBalanza"] = cBoxPuertoBalanza.SelectedItem.ToString();
                Settings.Default.Save();
            }

            if(cBoxParityBalanza.SelectedItem != null)
            {
                Settings.Default["balanzaParity"] = cBoxParityBalanza.SelectedItem.ToString();
                Settings.Default.Save();
            }

            if(cBoxBaudBalanza.SelectedItem != null)
            {
                Settings.Default["balanzaBaud"] = Convert.ToInt32(cBoxBaudBalanza.SelectedItem);
                Settings.Default.Save();
            }

            if(cBoxDataBalanza.SelectedItem != null)
            {
                Settings.Default["balanzaData"] = Convert.ToInt32(cBoxDataBalanza.SelectedItem);
                Settings.Default.Save();
            }

            Settings.Default["balanzaThreshold"] = Convert.ToInt32(txtThreshold.Value);
            Settings.Default.Save();
        }

        void SaveLectorBalanzaSettings()
        {
            if (cBoxPuertoLectorBalanza.SelectedItem != null)
            {
                Settings.Default["puertoLectorBalanza"] = cBoxPuertoLectorBalanza.SelectedItem.ToString();
                Settings.Default.Save();
            }

            if (cBoxParityLectorBalanza.SelectedItem != null)
            {
                Settings.Default["lectorBalanzaParity"] = cBoxParityLectorBalanza.SelectedItem.ToString();
                Settings.Default.Save();
            }

            if (cBoxBaudLectorBalanza.SelectedItem != null)
            {
                Settings.Default["lectorBalanzaBaud"] = Convert.ToInt32(cBoxBaudLectorBalanza.SelectedItem);
                Settings.Default.Save();
            }

            if (cBoxDataLectorBalanza.SelectedItem != null)
            {
                Settings.Default["lectorBalanzaData"] = Convert.ToInt32(cBoxDataLectorBalanza.SelectedItem);
                Settings.Default.Save();
            }
        }

        void SaveLectorSettings()
        {
            if (cBoxPuertoLector.SelectedItem != null)
            {
                Settings.Default["puertoLector"] = cBoxPuertoLector.SelectedItem.ToString();
                Settings.Default.Save();
            }

            if (cBoxParityLector.SelectedItem != null)
            {
                Settings.Default["lectorParity"] = cBoxParityLector.SelectedItem.ToString();
                Settings.Default.Save();
            }

            if (cBoxBaudLector.SelectedItem != null)
            {
                Settings.Default["lectorBaud"] = Convert.ToInt32(cBoxBaudLector.SelectedItem);
                Settings.Default.Save();
            }

            if (cBoxDataLector.SelectedItem != null)
            {
                Settings.Default["lectorData"] = Convert.ToInt32(cBoxDataLector.SelectedItem);
                Settings.Default.Save();
            }
        }
         
         
         */

        #endregion

    }
}
