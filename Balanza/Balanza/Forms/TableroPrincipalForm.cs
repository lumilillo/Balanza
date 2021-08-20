using Balanza.Herramientas;
using Entidades.Entidades;
using Negocio.Modelos;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balanza.Forms
{
    public partial class TableroPrincipalForm : Form
    {
        #region ATRIBUTOS

        PortAccessAPI puertoParalelo;
        string dataInBalanza = "";
        string dataInTarjeta = "";
        string nroTarjeta = "";
        string log = "";
        string logPath = AppDomain.CurrentDomain.BaseDirectory + $"PuertosLog.txt";
        bool registrando;
        int peso = 0;
        int minPeso = 0;

        #endregion
        
        public TableroPrincipalForm()
        {
            InitializeComponent();

            //TIMER PARA LIMPIAR MENSAJE DE ESTADO
            estadoTimer.Start();

            //ABRO PUERTO PARALELO
            SetPuertoParalelo();

            //ABRO PUERTOS COM
            SetPuertos();

            //CARGO PARAMETRO PESO MINIMO
            SetPesoMin();
        }
        
        #region FORMATO
        //COLORES
        private void bunifuCards2_MouseEnter(object sender, EventArgs e)
        {
            this.nroTarjetaCard.color = Color.FromArgb(250, 129, 36);
        }

        private void nroTarjetaCard_MouseLeave(object sender, EventArgs e)
        {
            this.nroTarjetaCard.color = Color.Gray;
        }

        private void pesoCard_MouseEnter(object sender, EventArgs e)
        {
            this.pesoCard.color = Color.FromArgb(250, 129, 36);
        }

        private void pesoCard_MouseLeave(object sender, EventArgs e)
        {
            this.pesoCard.color = Color.Gray;
        }

        private void msjEstadoCard_MouseEnter(object sender, EventArgs e)
        {
            this.msjEstadoCard.color = Color.FromArgb(250, 129, 36);
        }

        private void msjEstadoCard_MouseLeave(object sender, EventArgs e)
        {
            this.msjEstadoCard.color = Color.Gray;
        }

        private void bunifuCards2_MouseEnter_1(object sender, EventArgs e)
        {
            this.semaforoCard.color = Color.FromArgb(250, 129, 36);
        }

        private void bunifuCards2_MouseLeave(object sender, EventArgs e)
        {
            this.semaforoCard.color = Color.Gray;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.semaforoCard.color = Color.FromArgb(250, 129, 36);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.semaforoCard.color = Color.Gray;
        }

        private void bunifuCards2_MouseEnter_2(object sender, EventArgs e)
        {
            this.bunifuCards2.color = Color.FromArgb(250, 129, 36);
        }

        private void bunifuCards2_MouseLeave_1(object sender, EventArgs e)
        {
            this.bunifuCards2.color = Color.Gray;
        }

        #endregion

        #region METODOS

        void SemaforoPesando()
        {
            this.picBoxSemaforoVerde.Visible = false;
            this.picBoxSemaforoRojo.Visible = true;
        }

        void SemaforoLibre()
        {
            this.picBoxSemaforoVerde.Visible = true;
            this.picBoxSemaforoRojo.Visible = false;
        }
  
        void Pesar(object sender, EventArgs e)
        {
            try
            {
                //LEO BUFFER DEL PUERTO BALANZA
                dataInBalanza = balancaCOM.ReadExisting();
                //EscribirLogBalanza(dataInBalanza);

                //VALIDO TAMAÑO DEL INPUT
                if (!string.IsNullOrEmpty(dataInBalanza) && dataInBalanza.Length >= 10)
                {
                    //ME QUEDO CON EL PESO DEL INPUT
                    string pesoString = dataInBalanza.Substring(dataInBalanza.IndexOf('\u0002') + 4, 6);
                    string dataInt = "";

                    //FILTRO SOLO NUMEROS POR SI EL INPUT NO LLEGA EN EL FORMATO CORRECTO
                    for (int i = 0; i < pesoString.Length; i++)
                    {
                        if (Char.IsDigit(pesoString[i]))
                            dataInt += pesoString[i];
                    }

                    //FILTRO QUE SEA UN NUMERO CORRECTO
                    if (int.TryParse(dataInt, out peso))
                    {
                        //SI EL PESO ES IGUAL AL PESO ANTERIOR NO VUELVO A MOSTRARLO (GENERA UN PARPADEO EN EL LABEL)
                        if (peso.ToString() != lblPeso.Text)
                        {
                            lblPeso.Text = peso.ToString();
                        }

                        //SI EL PESO SUPERA EL PARAMETRO PESO MINIMO CAMBIO EL ESTADO A PESANDO
                        if (peso > minPeso)
                        {
                            SemaforoPesando();
                        }
                        else
                        {
                            SemaforoLibre();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                //MUESTRO ERROR AL PESAR Y GUARDO EL MENSAJE EN EL LOG (DONDE ESTA EL .EXE)
                this.lblMensaje.Text = "ERROR AL PESAR";
                this.lblMensaje.ForeColor = Color.Crimson;
                EscribirLogBalanza($"Error: {ex.Message}");
            }

            finally
            {
                //LUEGO DE CADA COMUNICACION CON LA BALANZA, LIMPIO AMBOS BUFFER Y ACTUALIZO LA CONEXION
                balancaCOM.DiscardInBuffer();
                balancaCOM.DiscardOutBuffer();
                balancaCOM.Close();
                balancaCOM.Open();
            }
        }
        
        void LeerTarjeta(object sender, EventArgs e)
        {
            try
            {
                //LEO EL BUFFER DEL PUERTO TARJETA
                dataInTarjeta = lectorCOM.ReadExisting();
                //EscribirLogLector(dataInTarjeta);

                //VALIDO QUE NO SEA NULO
                if (!string.IsNullOrEmpty(dataInTarjeta))
                {
                    Regex regex = new Regex("^[A-Z0-9]+$");
                    string nroFiltrado = "";

                    //FILTRO SOLO LETRAS MAYUSCULAS Y NUMEROS
                    foreach (char ch in dataInTarjeta)
                    {
                        if (regex.IsMatch(ch.ToString()))
                        {
                            nroFiltrado += ch;
                        }
                    }

                    //MUESTRO LA TERJETA LEIDA
                    nroTarjeta = nroFiltrado;
                    lblNroTarjeta.Text = nroTarjeta;
                    //COMIENZO EL REGISTRO DEL MOVIMIENTO
                    Registrar();
                }
            }

            catch (Exception ex) 
            {
                //MUESTRO ERROR DE TARJETA INVALIDA Y GUARDO EL MENSAJE EN EL LOG (DONDE ESTA EL .EXE)
                nroTarjeta = "";
                lblMensaje.ForeColor = Color.Crimson;
                lblMensaje.Text = "TARJETA INVÁLIDA";
                EscribirLogLector($"Error: {ex.Message}");
            }

            finally
            {
                //LIMPIO BUFFER DEL PUERTO
                lectorCOM.DiscardInBuffer();
            }
        }

        async void Registrar ()
        {
            registrando = true;
            EscribirLogBalanza("***Comienzo Registro***");

            if (peso > minPeso)
            {
                //COMIENZO REGISTRO
                lblMensaje.ForeColor = Color.LimeGreen;
                lblMensaje.Text = "REGISTRANDO";

                //BUSCO EL ULTIMO REGISTRO POR NUMERO DE TARJETA
                RegistrosTarjetasModelo registroSv = new RegistrosTarjetasModelo();
                registros_tarjetas ultimoRegistro = registroSv.FindUltimoRegistro(nroTarjeta);

                //VALIDA QUE EXISTA UN REGISTRO Y QUE SEA DE HOY
                if (ultimoRegistro == null
                    || (ultimoRegistro.fecha.Date != DateTime.Today.Date))
                {
                    lblMensaje.ForeColor = Color.Crimson;
                    lblMensaje.Text = "TARJETA NO HABILITADA";
                    registrando = false;

                    //SUENO LA CHICHARRA 3 VECES PARA AVISAR QUE LA TARJETA NO ESTA HABILITADA
                    EscribirLogBalanza("Tarjeta no habilitada: 3 chicharras");
                    #region CHICHARRA

                    puertoParalelo.Write(3);
                    Application.DoEvents();
                    await Task.Delay(Convert.ToInt32(ConfigurationManager.AppSettings["tiempo"]));

                    puertoParalelo.Read();
                    puertoParalelo.Write(0);
                    await Task.Delay(Convert.ToInt32(ConfigurationManager.AppSettings["tiempo"]));

                    puertoParalelo.Write(3);
                    Application.DoEvents();
                    await Task.Delay(Convert.ToInt32(ConfigurationManager.AppSettings["tiempo"]));

                    puertoParalelo.Read();
                    puertoParalelo.Write(0);
                    await Task.Delay(Convert.ToInt32(ConfigurationManager.AppSettings["tiempo"]));

                    puertoParalelo.Write(3);
                    Application.DoEvents();
                    await Task.Delay(Convert.ToInt32(ConfigurationManager.AppSettings["tiempo"]));

                    puertoParalelo.Read();
                    puertoParalelo.Write(0);
                    await Task.Delay(Convert.ToInt32(ConfigurationManager.AppSettings["tiempo"]));

                    #endregion

                    return;
                }
                else
                {
                    MovimientosCamionesModel movimientoSv = new MovimientosCamionesModel();
                    movimientos_camiones movimiento = movimientoSv.FindUltimoMovimientoByRegistro(ultimoRegistro.id);

                    //DETECTO DUPLICIDAD
                    if (DetectarDuplicidad(movimiento))
                    {
                        lblMensaje.ForeColor = Color.Crimson;
                        lblMensaje.Text = "DUPLICIDAD DE MARCACIÓN";
                        registrando = false;

                        //SUENO LA CHICHARRA 2 VECES PARA AVISAR QUE ESTAN DUPLICANDO EL MOVIMIENTO
                        EscribirLogBalanza("Movimiento duplicado: 2 chicharras");
                        #region CHICHARRA

                        puertoParalelo.Write(3);
                        Application.DoEvents();
                        await Task.Delay(Convert.ToInt32(ConfigurationManager.AppSettings["tiempo"]));
                        puertoParalelo.Read();
                        puertoParalelo.Write(0);
                        await Task.Delay(Convert.ToInt32(ConfigurationManager.AppSettings["tiempo"]));

                        puertoParalelo.Write(3);
                        Application.DoEvents();
                        await Task.Delay(Convert.ToInt32(ConfigurationManager.AppSettings["tiempo"]));
                        puertoParalelo.Read();
                        puertoParalelo.Write(0);
                        await Task.Delay(Convert.ToInt32(ConfigurationManager.AppSettings["tiempo"]));

                        #endregion

                        return;
                    }
                    try
                    {
                        //SI NO EXISTE UN MOVIMIENTO PREVIO, CON SALIDA NO NULA REGISTRO UN NUEVO MOVIMIENTO
                        if (movimiento == null || (movimiento != null && (movimiento.balanza_salida_sn != null)))
                        {
                            EscribirLogBalanza($"Entrada de: {nroTarjeta} a las {DateTime.Now}");
                            EscribirLogBalanza($"Peso: {peso}");
                            //NUEVO MOVIMIENTO
                            movimientos_camiones nuevoMovimiento = new movimientos_camiones();

                            nuevoMovimiento.registros_tarjeta_id = ultimoRegistro.id;
                            nuevoMovimiento.balanza_entrada_sn = true;
                            nuevoMovimiento.fecha_entrada = DateTime.Now;
                            nuevoMovimiento.peso_entrada = peso;
                            nuevoMovimiento.balanza_salida_sn = null;
                            nuevoMovimiento.fecha_salida = null;
                            nuevoMovimiento.peso_salida = 0;
                            nuevoMovimiento.created_at = DateTime.Now;
                            nuevoMovimiento.updated_at = DateTime.Now;

                            EstadosModel estadoSv = new EstadosModel();
                            estados estado = estadoSv.FindByCodigo("INCOMPLETO");
                            nuevoMovimiento.estado_id = estado.id;

                            users usuarioLogeado = Globales.GetCurrentUser();
                            nuevoMovimiento.user_id = usuarioLogeado.id;

                            EscribirLogBalanza($"Entro a insertar");

                            Resultado resultado = movimientoSv.Insertar(nuevoMovimiento);

                            EscribirLogBalanza($"Salio de insertar");
                            EscribirLogBalanza($"Resultado: {resultado.isOk}");

                            if (!resultado.isOk || nuevoMovimiento == null)
                            {
                                this.lblMensaje.Text = "ERROR AL REGISTRAR";
                                this.lblMensaje.ForeColor = Color.Crimson;
                                registrando = false;
                                return;
                            }
                        }
                        //SI EXISTE UN MOVIMIENTO PREVIO CON SALIDA NULA, ACTUALIZO EL MOVIMIENTO
                        else if (movimiento.balanza_salida_sn == null)
                        {
                            EscribirLogBalanza($"Salida de: {nroTarjeta} a las {DateTime.Now}");
                            EscribirLogBalanza($"Peso: {peso}");
                            //SALIDA 
                            movimiento.balanza_salida_sn = true;
                            movimiento.fecha_salida = DateTime.Now;
                            movimiento.peso_salida = peso;
                            movimiento.updated_at = DateTime.Now;

                            EstadosModel estadoSv = new EstadosModel();
                            estados estadoCorrecto = estadoSv.FindByCodigo("CORRECTO");
                            movimiento.estado_id = estadoCorrecto.id;

                            //EVALUO EL TIPO DE MOVIMIENTO CONTRA EL PESO DE ENTRADA Y SALIDA PARA SABER SI ES INCOHERENTE
                            if (ultimoRegistro.descarga_sn && movimiento.peso_salida > movimiento.peso_entrada
                                || (ultimoRegistro.devolucion_sn && movimiento.peso_salida > movimiento.peso_entrada)
                                || (ultimoRegistro.carga_sn && movimiento.peso_salida < movimiento.peso_entrada))
                            {
                                estados estadoIncoherente = estadoSv.FindByCodigo("INCOHERENTE");
                                movimiento.estado_id = estadoIncoherente.id;
                            }

                            EscribirLogBalanza($"Entro a modificar");

                            Resultado resultado = movimientoSv.Editar(movimiento);

                            EscribirLogBalanza($"Salio de modificar");
                            EscribirLogBalanza($"Resultado: {resultado.isOk}");

                            if (!resultado.isOk || movimiento == null)
                            {
                                this.lblMensaje.Text = "ERROR AL REGISTRAR";
                                this.lblMensaje.ForeColor = Color.Crimson;
                                registrando = false;
                                return;
                            }
                        }

                        //SUENO LA CHICHARRA 1 VEZ PARA AVISAR QUE SE REGISTRO EL MOVIMIENTO CORRECTAMENTE
                        EscribirLogBalanza("Movimiento creado: 1 chicharras");
                        #region CHICHARRA

                        puertoParalelo.Write(3);
                        Application.DoEvents();
                        await Task.Delay(Convert.ToInt32(ConfigurationManager.AppSettings["tiempo"]));

                        puertoParalelo.Read();
                        puertoParalelo.Write(0);
                        await Task.Delay(Convert.ToInt32(ConfigurationManager.AppSettings["tiempo"]));

                        #endregion

                        lblMensaje.ForeColor = Color.LimeGreen;
                        lblMensaje.Text = "MOVIMIENTO REGISTRADO";
                    }
                    catch(Exception ex) { EscribirLogBalanza(ex.Message); return; }
                }

                //APAGO LA CHICHARRA
                #region CHICHARRA

                puertoParalelo.Read();
                puertoParalelo.Write(0);

                #endregion

                //LIMPIO LOS BUFFER
                if (balancaCOM.IsOpen)
                {
                    balancaCOM.DiscardInBuffer();
                    balancaCOM.DiscardOutBuffer();
                }
                if (lectorCOM.IsOpen)
                {
                    lectorCOM.DiscardInBuffer();
                    lectorCOM.DiscardOutBuffer();
                }

                registrando = false;
                EscribirLogBalanza("***Fin del registro***");
            }
        }

        bool DetectarDuplicidad(movimientos_camiones movimiento)
        {
            bool duplicado = false;
            DateTime? date = null;

            //SI ES UNA SALIDA TOMO COMO FECHA LA FECHA DE SALIDA
            if ((movimiento != null && (movimiento.balanza_entrada_sn && movimiento.balanza_salida_sn != null)))
            {
                date = movimiento.fecha_salida;
            }

            //SI ES UNA ENTRADA TOMO COMO FECHA LA FECHA DE ENTRADA
            if (movimiento != null && movimiento.balanza_entrada_sn && movimiento.balanza_salida_sn == null)
            {
                date = movimiento.fecha_entrada;
            }

            if (date != null)
            {
                //CONVIERTO A SEGUNDOS LA FECHA
                double secCreated = (date.Value.Hour * 3600)
                                  + (date.Value.Minute * 60)
                                  + (date.Value.Second);

                //CONVIERTO A SEGUNDOS LA FECHA ACTUAL
                double secNow = (DateTime.Now.Hour * 3600)
                              + (DateTime.Now.Minute * 60)
                              + (DateTime.Now.Second);

                //VALIDO QUE HAYAN PASADO AL MENOS 30 SEGUNDOS DE LA FECHA A LA FECHA ACTUAL
                if (secCreated + 30 > secNow) { duplicado = true; }
            }

            return duplicado;
        }

        #endregion

        #region BOTONES

        private void picActualizar_Click(object sender, EventArgs e)
        {
            SetPuertos();
        }

        #endregion
     
        #region PUERTOS

        public void SetPuertoParalelo()
        {
            try
            {
                puertoParalelo = new PortAccessAPI(Convert.ToInt16(ConfigurationManager.AppSettings["puerto"]));
                puertoParalelo.Write(0);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void SetPuertos()
        {
            try
            {
                this.balancaCOM = Globales.balanzaCOM;
                this.lectorCOM = Globales.balanzaLectorCOM;

                switchBalanza.Value = false;
                switchLectorTarjeta.Value = false;

                if (balancaCOM != null && lectorCOM != null)
                {
                    if (balancaCOM.IsOpen)
                    {
                        Globales.balanzaCOM.DataReceived += new SerialDataReceivedEventHandler(balancaCOM_DataReceived);
                        switchBalanza.Value = true;
                    }
                    if (lectorCOM.IsOpen)
                    {
                        Globales.balanzaLectorCOM.DataReceived += new SerialDataReceivedEventHandler(lectorCOM_DataReceived);
                        switchLectorTarjeta.Value = true;
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void SetPesoMin()
        {
            try
            {
                ParametrosGeneralesModel paramSv = new ParametrosGeneralesModel();
                parametros_generales pesoMin = paramSv.FindByCodigo("PESO_MIN");
                minPeso = Convert.ToInt32(pesoMin.valor);
            }
            catch(Exception ex) { MessageBox.Show("Error al cargar el peso mínimo."); this.minPeso = 1000; }
        }

        private void balancaCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //SI ALGUIEN PASA LA TERJA (COMIENZA EL REGISTRO), DEJO DE LEER LA BALANZA PARA QUE EL PESO NO CAMBIE
            try
            {
                if (IsHandleCreated)
                    if (!registrando)
                    {
                        this.BeginInvoke(new EventHandler(Pesar));
                    }
            }
            catch(Exception ex) { EscribirLogBalanza(ex.Message); }
        }

        private void lectorCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (IsHandleCreated)
                    if (!registrando)
                    {
                        this.BeginInvoke(new EventHandler(LeerTarjeta));
                    }
            }
            catch(Exception ex) { EscribirLogLector(ex.Message); }
        }

        #endregion

        #region LOG

        void EscribirLogBalanza(string mensaje)
        {
            try
            {
                if (!File.Exists(logPath))
                {
                    File.Create(logPath);
                }

                using (StreamWriter tw = new StreamWriter(logPath, true))
                {
                    tw.WriteLine("\n" + DateTime.Now.ToString() + " Puerto Balanza: " + mensaje);
                    tw.Close();
                }
            }
            catch (Exception ex)
            {
                log += ex.Message;
            }
        }

        void EscribirLogLector(string mensaje)
        {
            try
            {
                if (!File.Exists(logPath))
                {
                    File.Create(logPath);
                }

                using (StreamWriter tw = new StreamWriter(logPath, true))
                {
                    tw.WriteLine("\n" + DateTime.Now.ToString() + " Puerto Lector: " + mensaje);
                    tw.Close();
                }
            }
            catch (Exception ex)
            {
                log += ex.Message;
            }
        }

        #endregion

        private void estadoTimer_Tick(object sender, EventArgs e)
        {
            if(registrando) { return; }

            lblMensaje.ForeColor = Color.LimeGreen;
            lblMensaje.Text = "DISPONIBLE";
        }
    }

    #region DOCUMENTACION PUERTO PARALELO
    /*INT->BINARIO
     * 0 -> 0000
     * 1 -> 0001
     * 2 -> 0010
     * 3- > 0011
     * ...
     * 255 -> 11111111 (todos prendidos)
     * 
     *puertoParalelo.Write(X) -> envia un INT al inpout32.dll, este lo convierte a binario y lo envia al puerto paralelo
     *puertoParalelo.Read() -> lee el buffer del puerto paralelo (y quita el control al sistema operativo)
     *Application.DoEvents() -> delego el control al sistema operativo, el cual se encarga de comunicarse con el puerto paralelo y hardware
     *await Task.Delay(X) ->
     *
     *
     */
    #endregion

    #region PAPELERA

    /*
             private void bunifuCards2_DoubleClick(object sender, EventArgs e)
    {
        PuertosForm puertosForm = new PuertosForm(this);

        //FADE BAKGROUND
        Form backGround = new Form();

        backGround.StartPosition = FormStartPosition.Manual;
        backGround.Location = new Point(Form1.ActiveForm.Location.X, Form1.ActiveForm.Location.Y);
        backGround.Size = new Size(1128, 717);
        backGround.FormBorderStyle = FormBorderStyle.None;
        backGround.Opacity = .70d;
        backGround.BackColor = Color.Black;
        backGround.ShowInTaskbar = false;

        backGround.Show();

        puertosForm.ShowDialog();

        backGround.Close();
        backGround.Dispose();
    }

     */

    #endregion

    public class PortAccessAPI
    {
        #region DLL

        //inpout32.dll

        [DllImport("inpout32.dll")]
        private static extern UInt32 IsInpOutDriverOpen();

        [DllImport("inpout32.dll")]
        private static extern void Out32(short PortAddress, short Data);

        [DllImport("inpout32.dll")]
        private static extern char Inp32(short PortAddress);

        [DllImport("inpout32.dll")]
        private static extern void DlPortWritePortUshort(short PortAddress, ushort Data);

        [DllImport("inpout32.dll")]
        private static extern ushort DlPortReadPortUshort(short PortAddress);

        [DllImport("inpout32.dll")]
        private static extern void DlPortWritePortUlong(int PortAddress, uint Data);

        [DllImport("inpout32.dll")]
        private static extern uint DlPortReadPortUlong(int PortAddress);

        [DllImport("inpoutx64.dll")]
        private static extern bool GetPhysLong(ref int PortAddress, ref uint Data);

        [DllImport("inpoutx64.dll")]
        private static extern bool SetPhysLong(ref int PortAddress, ref uint Data);

        #endregion

        private short _PortAddress;

        public PortAccessAPI(short PortAddress)
        {
            _PortAddress = PortAddress;

            try
            {
                uint nResult = 0;
                try
                {
                    nResult = IsInpOutDriverOpen();
                }

                catch (BadImageFormatException)
                {

                }

                if (nResult == 0)
                {
                    throw new ArgumentException("Unable to open InpOut32 driver");
                }
            }
            catch (DllNotFoundException)
            {
                throw new ArgumentException("Unable to find InpOut32.dll");
            }
        }

        public void Write(short Data)
        {
            Out32(_PortAddress, Data);
        }

        public byte Read()
        {
            return (byte)Inp32(_PortAddress);
        }

        public ushort ReadShort()
        {
            return DlPortReadPortUshort(_PortAddress);
        }

        public uint ReadLong()
        {
            return DlPortReadPortUlong(_PortAddress);
        }
    }
}


