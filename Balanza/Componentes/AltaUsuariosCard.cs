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
    public partial class AltaUsuariosCard : UserControl
    {
        UsuariosCard cardPadre;
        public AltaUsuariosCard(UsuariosCard padre)
        {
            InitializeComponent();

            cardPadre = padre;
        }

        #region METODOS

        bool ValidarContrasena()
        {
            if(txtContrasena.Text != txtRepitaContrasena.Text)
            {
                return false;
            }
            return true;
        }
        bool ValidarEmail()
        {
            Regex emailValido = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");

            if(!emailValido.IsMatch(txtEmail.Text))
            {
                return false;
            }
            return true;
        }

        void MostrarAlerta(Panel alerta)
        {
            btnFinalizar.Enabled = false;


            alerta.BringToFront();
            alertaTransition.Show(alerta);
            alerta.Focus();
        }

        void EsconderAlerta(Panel alerta)
        {
            btnFinalizar.Enabled = true;


            alertaTransition.Hide(alerta);
        }

        #endregion

        #region FORMATO

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña...")
            {
                txtContrasena.Text = null;
                txtContrasena.UseSystemPasswordChar = true;
                txtContrasena.PasswordChar = '\u25CF';
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                txtContrasena.UseSystemPasswordChar = false;
                txtContrasena.PasswordChar = '\0';
                txtContrasena.Text = "Contraseña...";
            }
        }
            
        private void txtRepitaContrasena_Enter(object sender, EventArgs e)
        {
            if (txtRepitaContrasena.Text == "Repita la Contraseña...")
            {
                txtRepitaContrasena.Text = null;
                txtRepitaContrasena.UseSystemPasswordChar = true;
                txtRepitaContrasena.PasswordChar = '\u25CF';
            }
        }

        private void txtRepitaContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRepitaContrasena.Text))
            {
                txtRepitaContrasena.UseSystemPasswordChar = false;
                txtRepitaContrasena.PasswordChar = '\0';
                txtRepitaContrasena.Text = "Repita la Contraseña...";
            }
        }

        #endregion

        #region BOTONES

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            cardPadre.ShowABM();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string errores = "";

            UsersModel usuarioSv = new UsersModel();
            users usuario = new users();

            //VALIDACIONES
            if (!ValidarEmail())
            {
                errores += "Email invalido.\n";
            }
            if (!ValidarContrasena())
            {
                errores += "Las contraseñas no coinciden.\n";
            }
            if(!int.TryParse(txtDni.Text, out int DNI) || txtDni.Text.Length != 8)
            {
                errores += "DNI solo admite números.\n";
            }

            users usuarioRepetido = usuarioSv.FindByDni(DNI);
            if(usuarioRepetido != null)
            {
                errores += "DNI en uso.\n";
            }

            if (!int.TryParse(txtLegajo.Text, out int LEGAJO))
            {
                errores += "Legajo solo admite números.\n";
            }

            if(errores != "")
            {
                Alertas.ShowError(errores);

                errores = "";
                return;
            }

            //CARGO DATOS DE USUARIO
            usuario.name = txtNombre.Text;
            usuario.dni = DNI;
            usuario.legajo = LEGAJO;
            usuario.email = txtEmail.Text;
            usuario.password = txtContrasena.Text;
            usuario.created_at = DateTime.Now;

            //INTENTO INSERT
            Resultado resultado = usuarioSv.Insertar(usuario);

            if(resultado.isOk)
            {
                Alertas.ShowExito("Usuario Creado.");
                cardPadre.ShowABM();
            }
            else
            {
                Alertas.ShowError(resultado.error);
            }
        }

        #endregion

    }
}