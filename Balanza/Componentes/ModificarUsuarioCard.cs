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
    public partial class ModificarUsuarioCard : UserControl
    {
        UsuariosCard cardPadre;
        users usuarioEditando;

        public ModificarUsuarioCard(UsuariosCard padre, users usuario)
        {
            InitializeComponent();

            cardPadre = padre;
            usuarioEditando = usuario;

            LoadData();
        }

        #region METODOS

        void LoadData()
        {
            if(usuarioEditando != null)
            {
                txtNombre.Text = usuarioEditando.name;
                txtDni.Text = usuarioEditando.dni.ToString();
                txtLegajo.Text = usuarioEditando.legajo.ToString();
                txtEmail.Text = usuarioEditando.email;
                //txtContrasena.Text = usuarioEditando.password;
                //txtRepitaContrasena.Text = usuarioEditando.password;
            }
        }

        //void MostrarAlerta(Panel alerta)
        //{
        //    //btnFinalizar.Enabled = false;


        //    alerta.BringToFront();
        //    alertaTransition.Show(alerta);
        //    alerta.Focus();
        //}

        //void EsconderAlerta(Panel alerta)
        //{
        //    //btnFinalizar.Enabled = true;


        //    alertaTransition.Hide(alerta);
        //}

        //bool ValidarEmail()
        //{
        //    Regex emailValido = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");

        //    if (!emailValido.IsMatch(txtEmail.Text))
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        //bool ValidarContrasena()
        //{
        //    if (txtContrasena.Text != txtRepitaContrasena.Text)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        #endregion

        #region BOTONES

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            cardPadre.ShowABM();
        }

        //private void btnFinalizar_Click(object sender, EventArgs e)
        //{
        //    string errores = "";

        //    UsersModel usuarioSv = new UsersModel();

        //    //VALIDACIONES
        //    if (!ValidarEmail())
        //    {
        //        errores += "Email invalido.\n";
        //    }

        //    if (!ValidarContrasena())
        //    {
        //        errores += "Las contraseñas no coinciden.\n";
        //    }

        //    if (!int.TryParse(txtDni.Text, out int DNI) || txtDni.Text.Length != 8)
        //    {
        //        errores += "DNI solo admite números.\n";
        //    }

        //    users usuarioRepetido = usuarioSv.FindByDni(DNI);
        //    if (usuarioRepetido != null && usuarioRepetido.id != usuarioEditando.id)
        //    {
        //        errores += "DNI en uso.\n";
        //    }

        //    if (!int.TryParse(txtLegajo.Text, out int LEGAJO))
        //    {
        //        errores += "Legajo solo admite números.\n";
        //    }

        //    if (errores != "")
        //    {
        //        Alertas.ShowError(errores);

        //        errores = "";
        //        return;
        //    }

        //    //CARGO DATOS DE USUARIO
        //    usuarioEditando.name = txtNombre.Text;
        //    usuarioEditando.dni = DNI;
        //    usuarioEditando.legajo = LEGAJO;
        //    usuarioEditando.email = txtEmail.Text;
        //    usuarioEditando.password = txtContrasena.Text;
        //    usuarioEditando.created_at = DateTime.Now;

        //    //INTENTO INSERT
        //    Resultado resultado = usuarioSv.Editar(usuarioEditando);

        //    if (resultado.isOk)
        //    {
        //        Alertas.ShowExito("Usuario Modificado.");
        //        cardPadre.ShowABM();
        //    }
        //    else
        //    {
        //        Alertas.ShowError(resultado.error);
        //    }
        //}

        #endregion

        #region FORMATO

        private void txtNombre_OnValueChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                lblNombre.Visible = true;
            }
            else
            {
                lblNombre.Visible = false;
            }
        }

        private void txtLegajo_OnValueChanged(object sender, EventArgs e)
        {
            if (txtLegajo.Text.Length > 0)
            {
                lblLegajo.Visible = true;
            }
            else
            {
                lblLegajo.Visible = false;
            }
        }

        //private void txtContrasena_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtContrasena.Text.Length > 0)
        //    {
        //        lblContrasena.Visible = true;
        //    }
        //    else
        //    {
        //        lblContrasena.Visible = false;
        //    }
        //}

        //private void txtRepitaContrasena_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtRepitaContrasena.Text.Length > 0)
        //    {
        //        lblRepetirContrasena.Visible = true;
        //    }
        //    else
        //    {
        //        lblRepetirContrasena.Visible = false;
        //    }
        //}

        private void txtDni_OnValueChanged(object sender, EventArgs e)
        {
            if (txtDni.Text.Length > 0)
            {
                lblDni.Visible = true;
            }
            else
            {
                lblDni.Visible = false;
            }
        }

        private void txtEmail_OnValueChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0)
            {
                lblEmail.Visible = true;
            }
            else
            {
                lblEmail.Visible = false;
            }
        }

        #endregion

    }
}
