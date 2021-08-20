using Balanza.Forms;
using Balanza.Herramientas;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balanza
{
    public partial class Form1 : Form
    {
        #region PRIVADAS

        TableroPrincipalForm balanza;
        OperacionesForm operaciones;
        MaestrosForm maestros;
        MovimientosForm movimientos;
        AjustesForm ajustes;

        Form currentForm;

        users currentUser;
        List<permissions> permisos;

        string logPath = AppDomain.CurrentDomain.BaseDirectory + $"PuertosLog.txt";

        #endregion

        public Form1(users currentUser)
        {
            InitializeComponent();

            //SETEO USUARIO
            this.currentUser = currentUser;
            lblUsuario.Text = currentUser.name;

            //SETEO PERMISOS
            Globales.SetCurrentUser(currentUser);
            permisos = Globales.LoadPermisos();

            //APERTURA DE PUERTOS
            LoadPuertos();

            //LOAD BALANZA
            LoadBalanza();

            //MUESTRO FORM
            LoadPrimerPantalla();
        }

        #region ARRASTRAR

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picBoxLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region LOAD

        void LoadPuertos()
        {
            try
            {
                Globales.LoadPuertosByPc();
            }
            catch (Exception ex) { EscribirLogBalanza(ex.Message); }
        }

        void LoadBalanza()
        {
            balanza = new TableroPrincipalForm();
            balanza.TopLevel = false;
            balanza.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(balanza);
            panelPrincipal.Tag = balanza;
        }

        void LoadOperaciones()
        {
            operaciones = new OperacionesForm();
            operaciones.TopLevel = false;
            operaciones.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(operaciones);
            panelPrincipal.Tag = operaciones;
        }

        void LoadMaestros()
        {
            maestros = new MaestrosForm();
            maestros.TopLevel = false;
            maestros.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(maestros);
            panelPrincipal.Tag = maestros;
        }

        void LoadMovimientos()
        {
            movimientos = new MovimientosForm();
            movimientos.TopLevel = false;
            movimientos.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(movimientos);
            panelPrincipal.Tag = movimientos;
        }

        void LoadAjustes()
        {
            ajustes = new AjustesForm(balanza);
            ajustes.TopLevel = false;
            ajustes.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(ajustes);
            panelPrincipal.Tag = ajustes;
        }

        void LoadPrimerPantalla()
        {
            if (Globales.ubicacion == "balanza")
            {
                this.btnCambiarModo.Visible = true;
                this.btnCambiarModo.Text = "Cambiar a registro";

                this.lblUbicacion.Visible = true;
                this.lblUbicacion.Text = "Balanza";

                currentForm = balanza;
                balanza.Show();

                return;
            }

            if(Globales.ubicacion == "balanzaRegistro")
            {
                this.btnCambiarModo.Visible = true;
                this.btnCambiarModo.Text = "Cambiar a balanza";

                this.lblUbicacion.Visible = true;
                this.lblUbicacion.Text = "Registro";
            }

            LoadOperaciones();
            currentForm = operaciones;
            operaciones.Show();
        }

        #endregion

        #region BOTONES

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la apliación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (currentForm != null && currentForm.Visible == true) { currentForm.Hide(); }

            if (balanza.Visible == false)
            {
                currentForm = balanza;

                balanza.Show();
                balanza.BringToFront();
            }
            else
            {
                balanza.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            permissions permiso = permisos.FirstOrDefault(x => x.name == "Operaciones Off");

            if (permiso != null)
            {
                LimpiarVentanas();
                LoadOperaciones();
                currentForm = operaciones;

                operaciones.Show();
                operaciones.BringToFront();
            }
            else
            {
                Alertas.ShowError($"Usuario sin acceso a Operaciones.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            permissions permiso = permisos.FirstOrDefault(x => x.name == "Maestros Off");

            if (permiso != null)
            {
                LimpiarVentanas();
                LoadMaestros();
                currentForm = maestros;

                maestros.Show();
                maestros.BringToFront();
            }
            else
            {
                Alertas.ShowError($"Usuario sin acceso a Maestros.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarVentanas();
            LoadMovimientos();
            currentForm = movimientos;

            movimientos.Show();
            movimientos.BringToFront();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            permissions permiso = permisos.FirstOrDefault(x => x.name == "Ajustes Off");

            if (permiso != null)
            {
                LimpiarVentanas();
                LoadAjustes();
                currentForm = ajustes;

                ajustes.Show();
                ajustes.BringToFront();
            }
            else
            {
                Alertas.ShowError($"Usuario sin acceso a Ajustes.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea Salir?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCambiarModo_Click(object sender, EventArgs e)
        {
            permissions permiso = permisos.FirstOrDefault(x => x.name == "Ajustes Off");
            if (permiso != null)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

                //CAMBIO LA UBICACION EN EL CONFIG
                if (Globales.ubicacion == "balanza")
                {
                    config.AppSettings.Settings["ubicacion"].Value = "balanzaRegistro";
                    config.Save(ConfigurationSaveMode.Modified, true);
                }
                else if (Globales.ubicacion == "balanzaRegistro")
                {
                    config.AppSettings.Settings["ubicacion"].Value = "balanza";
                    config.Save(ConfigurationSaveMode.Modified, true);
                }

                Application.Exit();
                System.Diagnostics.Process.Start(Application.ExecutablePath);

                return;
            }
            Alertas.ShowError($"Usuario sin acceso a Ajustes.");
        }

        #endregion

        #region FORMATO

        void LimpiarVentanas()
        {
            balanza.Visible = false;
            if (currentForm == operaciones) { operaciones.Close(); return; }
            if (currentForm == maestros) { maestros.Close(); return; }
            if (currentForm == movimientos) { movimientos.Close(); return; }
        }

        private void btnBalanza_MouseEnter(object sender, EventArgs e)
        {
            btnBalanza.BackColor = Color.FromArgb(244,201,160);
            picBoxBalanza.BackColor = Color.FromArgb(213, 175, 140);
        }

        private void btnBalanza_MouseLeave(object sender, EventArgs e)
        {
            btnBalanza.BackColor = Color.Transparent;
            picBoxBalanza.BackColor = Color.Transparent;
        }

        private void btnOperaciones_MouseEnter(object sender, EventArgs e)
        {
            btnOperaciones.BackColor = Color.FromArgb(244, 201, 160);
            picBoxOperaciones.BackColor = Color.FromArgb(213, 175, 140);
        }

        private void btnOperaciones_MouseLeave(object sender, EventArgs e)
        {
            btnOperaciones.BackColor = Color.Transparent;
            picBoxOperaciones.BackColor = Color.Transparent;
        }

        private void btnMaestros_MouseEnter(object sender, EventArgs e)
        {
            btnMaestros.BackColor = Color.FromArgb(244, 201, 160);
            picBoxMaestros.BackColor = Color.FromArgb(213, 175, 140);
        }

        private void btnMaestros_MouseLeave(object sender, EventArgs e)
        {
            btnMaestros.BackColor = Color.Transparent;
            picBoxMaestros.BackColor = Color.Transparent;
        }

        private void btnMovimientos_MouseEnter(object sender, EventArgs e)
        {
            btnMovimientos.BackColor = Color.FromArgb(244, 201, 160);
            picBoxMovimientos.BackColor = Color.FromArgb(213, 175, 140);
        }

        private void btnMovimientos_MouseLeave(object sender, EventArgs e)
        {
            btnMovimientos.BackColor = Color.Transparent;
            picBoxMovimientos.BackColor = Color.Transparent;
        }

        private void btnAjustes_MouseEnter(object sender, EventArgs e)
        {
            btnAjustes.BackColor = Color.FromArgb(244, 201, 160);
            picBoxAjustes.BackColor = Color.FromArgb(213, 175, 140);
        }

        private void btnAjustes_MouseLeave(object sender, EventArgs e)
        {
            btnAjustes.BackColor = Color.Transparent;
            picBoxAjustes.BackColor = Color.Transparent;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(244, 201, 160);
            picBoxSalir.BackColor = Color.FromArgb(213, 175, 140);
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Transparent;
            picBoxSalir.BackColor = Color.Transparent;
        }

        private void picBoxBalanza_MouseEnter(object sender, EventArgs e)
        {
            btnBalanza.BackColor = Color.FromArgb(213, 175, 140);
            picBoxBalanza.BackColor = Color.FromArgb(213, 175, 140);
        }

        private void picBoxBalanza_MouseLeave(object sender, EventArgs e)
        {
            btnBalanza.BackColor = Color.Transparent;
            picBoxBalanza.BackColor = Color.Transparent;
        }

        private void picBoxOperaciones_MouseEnter(object sender, EventArgs e)
        {
            btnOperaciones.BackColor = Color.FromArgb(213, 175, 140);
            picBoxOperaciones.BackColor = Color.FromArgb(213, 175, 140);
        }

        private void picBoxOperaciones_MouseLeave(object sender, EventArgs e)
        {
            btnOperaciones.BackColor = Color.Transparent;
            picBoxOperaciones.BackColor = Color.Transparent;
        }

        private void picBoxMaestros_MouseEnter(object sender, EventArgs e)
        {
            btnMaestros.BackColor = Color.FromArgb(213, 175, 140);
            picBoxMaestros.BackColor = Color.FromArgb(213, 175, 140);
        }

        private void picBoxMaestros_MouseLeave(object sender, EventArgs e)
        {
            btnMaestros.BackColor = Color.Transparent;
            picBoxMaestros.BackColor = Color.Transparent;
        }

        private void picBoxMovimientos_MouseEnter(object sender, EventArgs e)
        {
            btnMovimientos.BackColor = Color.FromArgb(213, 175, 140);
            picBoxMovimientos.BackColor = Color.FromArgb(213, 175, 140);
        }

        private void picBoxMovimientos_MouseLeave(object sender, EventArgs e)
        {
            btnMovimientos.BackColor = Color.Transparent;
            picBoxMovimientos.BackColor = Color.Transparent;
        }

        private void picBoxAjustes_MouseEnter(object sender, EventArgs e)
        {
            btnAjustes.BackColor = Color.FromArgb(213, 175, 140);
            picBoxAjustes.BackColor = Color.FromArgb(213, 175, 140);
        }

        private void picBoxAjustes_MouseLeave(object sender, EventArgs e)
        {
            btnAjustes.BackColor = Color.Transparent;
            picBoxAjustes.BackColor = Color.Transparent;
        }

        private void picBoxSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(213, 175, 140);
            picBoxSalir.BackColor = Color.FromArgb(213, 175, 140);
        }

        private void picBoxSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Transparent;
            picBoxSalir.BackColor = Color.Transparent;
        }


        #endregion

        #region METODOS

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
                    tw.WriteLine("\n" + DateTime.Now.ToString() + " Aplicación: " + mensaje);
                    tw.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion


    }
}

#region PAPELERA

/*
             auth auth = new auth() { dni = 28070226, password = "12345678" };

            ApiService apiService = new ApiService();
            List<users> lista = new List<users>();

            //PRUEBA WEB
            //Datos.Servicios.Resultado resultado = await apiService.GetList<users>(urlBase, api, "/get_table_users", "4605a5d9cbdabed9c99f05ca79220e00eab5004cca95500326b84e1b62d7812895604d768efa3d55");

            //MateriasPrimasModel materiasSv = new MateriasPrimasModel();
            //List<materias_primas> material = materiasSv.GetAll();
            //Datos.Servicios.Resultado resultado = await apiService.Send<materias_primas>(urlBase, api, controler, material, "4605a5d9cbdabed9c99f05ca79220e00eab5004cca95500326b84e1b62d7812895604d768efa3d55");

            Datos.Servicios.Resultado resultado = await apiService.Auth<auth>(urlBase, api, controler, auth);

            string apiToken = (string)resultado.result;

            if (apiToken != null)
            {
                string[] split = apiToken.Split(new Char[] { '"' });
                apiToken = split[1];
                Globales.token = apiToken;
            }

            MovimientosCamionesModel materialSv = new MovimientosCamionesModel();
            List<movimientos_camiones> materiales = materialSv.GetAll();
            resultado = await apiService.Send<movimientos_camiones>(urlBase, api, controler, materiales, Globales.token);
 */
#endregion