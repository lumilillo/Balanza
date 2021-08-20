using Balanza.Properties;
using Entidades.Entidades;
using Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanza.Herramientas
{
    public static class Globales
    {
        public static users currentUser;
        public static SerialPort balanzaCOM;
        public static SerialPort balanzaLectorCOM;
        public static SerialPort lectorCOM;
        public static string token;
        public static string ubicacion = "";

        #region USUARIO

        public static void SetCurrentUser(users usuario)
        {
            currentUser = usuario;
        }

        public static void SetCurrentPc(string pc)
        {
            ubicacion = pc;
        }

        public static users GetCurrentUser()
        {
            return currentUser;
        }

        public static string GetPc()
        {
            return ubicacion;
        }

        #endregion

        #region PERMISOS

        public static List<permissions> LoadPermisos()
        {
            PermisosModelo permisosSv = new PermisosModelo();
            return permisosSv.GetPermisosByUsuario(currentUser.id);
        }

        #endregion

        #region PUERTOS

        static public void LoadPuertosByPc()
        {
            try
            {
                if (ubicacion == "balanza")
                {
                    OpenBalanzaCOM();
                    OpenLectorBalanzaCOM();
                    return;
                }

                if (ubicacion == "balanzaRegistro")
                {
                    OpenBalanzaAsLectorCOM();
                    return;
                }

                if (ubicacion != null)
                {
                    OpenLectorCOM();
                    return;
                }
            }
            catch(Exception ex) { throw ex; }
        }

        public static void OpenBalanzaCOM()
        {
            try
            {
                CloseBalanzaCOM();

                PuertosCOMModel portsSv = new PuertosCOMModel();
                puerto_com savedPort = portsSv.FindByUbicacion("Balanza");

                balanzaCOM = new SerialPort();
                balanzaCOM.PortName = savedPort.port_name;
                balanzaCOM.DataBits = savedPort.data_bits;
                balanzaCOM.BaudRate = savedPort.baud_rate;
                balanzaCOM.Parity = (Parity)Enum.Parse(typeof(Parity), savedPort.parity);
                balanzaCOM.StopBits = (StopBits)Enum.Parse(typeof(StopBits), savedPort.stop_bits);
                balanzaCOM.ReceivedBytesThreshold = savedPort.threshold != null ? (int)savedPort.threshold : 16;
                balanzaCOM.DiscardNull = savedPort.discard_null;

                balanzaCOM.Open();
            }
            catch (Exception ex) { CloseBalanzaCOM(); throw ex; }
        }

        public static void OpenLectorBalanzaCOM()
        {
            try
            {
                CloseLectorBalanzaCOM();

                PuertosCOMModel portsSv = new PuertosCOMModel();
                puerto_com savedPort = portsSv.FindByUbicacion("Lector Balanza");

                balanzaLectorCOM = new SerialPort();
                balanzaLectorCOM.PortName = savedPort.port_name;
                balanzaLectorCOM.DataBits = savedPort.data_bits;
                balanzaLectorCOM.BaudRate = savedPort.baud_rate;
                balanzaLectorCOM.Parity = (Parity)Enum.Parse(typeof(Parity), savedPort.parity);
                balanzaLectorCOM.StopBits = (StopBits)Enum.Parse(typeof(StopBits), savedPort.stop_bits);
                balanzaLectorCOM.DiscardNull = savedPort.discard_null;

                balanzaLectorCOM.Open();
            }
            catch (Exception ex) { CloseLectorBalanzaCOM(); throw ex; }
        }

        public static void OpenLectorCOM()
        {
            try
            {
                CloseLectorCOM();

                PuertosCOMModel portsSv = new PuertosCOMModel();
                puerto_com savedPort = portsSv.FindByUbicacion("Lector Despacho");

                lectorCOM = new SerialPort();
                lectorCOM.PortName = savedPort.port_name;
                lectorCOM.DataBits = savedPort.data_bits;
                lectorCOM.BaudRate = savedPort.baud_rate;
                lectorCOM.Parity = (Parity)Enum.Parse(typeof(Parity), savedPort.parity);
                lectorCOM.StopBits = (StopBits)Enum.Parse(typeof(StopBits), savedPort.stop_bits);
                lectorCOM.DiscardNull = savedPort.discard_null;

                lectorCOM.Open();
            }
            catch (Exception ex) { CloseLectorCOM(); throw ex; }
        }

        public static void OpenBalanzaAsLectorCOM()
        {
            try
            {
                CloseLectorCOM();

                PuertosCOMModel portsSv = new PuertosCOMModel();
                puerto_com savedPort = portsSv.FindByUbicacion("Lector Balanza");

                lectorCOM = new SerialPort();
                lectorCOM.PortName = savedPort.port_name;
                lectorCOM.DataBits = savedPort.data_bits;
                lectorCOM.BaudRate = savedPort.baud_rate;
                lectorCOM.Parity = (Parity)Enum.Parse(typeof(Parity), savedPort.parity);
                lectorCOM.StopBits = (StopBits)Enum.Parse(typeof(StopBits), savedPort.stop_bits);
                lectorCOM.DiscardNull = savedPort.discard_null;

                lectorCOM.Open();
            }
            catch (Exception ex) { CloseLectorCOM(); throw ex; }
        }

        public static void CloseBalanzaCOM()
        {
            try
            {

                if (balanzaCOM != null && balanzaCOM.IsOpen)
                {
                    balanzaCOM.Close();
                    balanzaCOM.Dispose();
                }

            }
            catch(Exception ex) { throw ex; }
        }

        public static void CloseLectorBalanzaCOM()
        {
            try
            {
                if (balanzaLectorCOM != null && balanzaLectorCOM.IsOpen)
                {
                    balanzaLectorCOM.Close();
                    balanzaLectorCOM.Dispose();
                }
            }
            catch(Exception ex) { throw ex; }
        }

        public static void CloseLectorCOM()
        {
            try
            {
                if (lectorCOM != null && lectorCOM.IsOpen)
                {
                    lectorCOM.Close();
                    lectorCOM.Dispose();
                }
            }
            catch(Exception ex) { throw ex; }
        }

        #endregion

    }
}
