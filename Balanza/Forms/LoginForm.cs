using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Modelos;
using Entidades.Entidades;
using Balanza.Herramientas;
using System.Configuration;
using BCrypt.Net;

namespace Balanza.Forms
{
    public partial class LoginForm : Form
    {
        static BCrypt.Net.BCrypt bCrypt;
        public LoginForm()
        {
            InitializeComponent();
            bCrypt = new BCrypt.Net.BCrypt();

            Globales.SetCurrentPc(ConfigurationManager.AppSettings["ubicacion"]);
        }

        #region FORMATO

        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.FromArgb(247, 67, 0);
            btnIngresar.ForeColor = Color.Black;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.FromArgb(250, 129, 36);
            btnIngresar.ForeColor = Color.White;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Silver;
            btnSalir.ForeColor = Color.Black;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.White;
            btnSalir.ForeColor = Color.FromArgb(250, 129, 36);
        }

        private void txtContrasena_Enter_1(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = null;
                txtContrasena.UseSystemPasswordChar = true;
                txtContrasena.PasswordChar = '\u25CF';
            }
        }

        private void txtContrasena_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                txtContrasena.UseSystemPasswordChar = false;
                txtContrasena.PasswordChar = '\0';
                txtContrasena.Text = "Contraseña";
            }
        }

        private void txtDniDato_Enter(object sender, EventArgs e)
        {
            if (txtDniDato.Text == "DNI")
            {
                txtDniDato.Text = null;
            }
        }

        private void txtDniDato_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDniDato.Text))
            {
                txtDniDato.Text = "DNI";
            }
        }

        #endregion

        #region METODOS

        void BalanzaLogin()
        {
            UsersModel usuarioSv = new UsersModel();
            users usuario = usuarioSv.FindByDni(40404040);

            Form1 pantallaPrincipal = new Form1(usuario);
            pantallaPrincipal.Show();
            this.Hide();
        }

        #endregion

        #region BOTONES

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsersModel usuarioSv = new UsersModel();

            if(!int.TryParse(txtDniDato.Text, out int DNI))
            {
                lblError.Text = "El campo DNI solo admite números.";
                lblError.Visible = true;
            }
            else
            {
                users usuario = usuarioSv.FindByDni(DNI);

                if(usuario == null)
                {
                    lblError.Text = "DNI inválido.";
                    lblError.Visible = true;
                }
                else
                {
                    if (!BCrypt.Net.BCrypt.Verify(txtContrasena.Text, usuario.password))
                    {
                        lblError.Text = "Contraseña inválida.";
                        lblError.Visible = true;
                    }
                    else
                    {
                        Form1 pantallaPrincipal = new Form1(usuario);
                        pantallaPrincipal.Show();
                        this.Hide();
                    }
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region EVENTOS

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            if (Globales.ubicacion != null && (Globales.ubicacion == "balanza" || Globales.ubicacion == "balanzaRegistro")) { BalanzaLogin(); }
        }

        #endregion
    }
}
