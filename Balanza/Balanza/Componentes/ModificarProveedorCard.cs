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
    public partial class ModificarProveedorCard : UserControl
    {
        ProveedorCard cardPadre;
        proveedores proveedor;
        clientes cliente;

        public ModificarProveedorCard(ProveedorCard padre, proveedores proveedor, clientes cliente)
        {
            InitializeComponent();

            cardPadre = padre;
            this.proveedor = proveedor;
            this.cliente = cliente;

            LoadProvincias();
            LoadFormatoCard();
        }

        #region LOAD

        void LoadProvincias()
        {
            ProvinciasModel provinciasSv = new ProvinciasModel();
            List<provincias> provincias = provinciasSv.GetAll();

            cBoxProvincia.DataSource = provincias;
            cBoxProvincia.DisplayMember = "provincia";
            cBoxProvincia.ValueMember = "id";
        }

        void LoadFormatoCard()
        {
            if(proveedor != null)
            {
                txtRazonSocial.Text = proveedor.razon_social;
                txtDomicilio.Text = proveedor.domicilio;
                txtCP.Text = proveedor.cp;
                txtCuitDato.Text = proveedor.cuit;

                if (proveedor.localidad_id != null)
                {
                    LocalidadesModel localidadSv = new LocalidadesModel();
                    localidades localidad = localidadSv.FindById((int)proveedor.localidad_id);


                    ProvinciasModel provinciaSv = new ProvinciasModel();
                    provincias provincia = provinciaSv.FindById(localidad.provincia_id);

                    cBoxProvincia.SelectedValue = provincia.id;
                    cBoxLocalidad.SelectedValue = localidad.id;

                }
                else
                {
                    cBoxProvincia.SelectedIndex = 0;
                    cBoxLocalidad.SelectedIndex = 0;
                }

            }
            else
            {
                txtRazonSocial.Text = cliente.razon_social;
                txtDomicilio.Text = cliente.domicilio;
                txtCP.Text = cliente.cp;
                txtCuitDato.Text = cliente.cuit;

                if (cliente.localidad_id != null)
                {
                    LocalidadesModel localidadSv = new LocalidadesModel();
                    localidades localidad = localidadSv.FindById((int)cliente.localidad_id);

                    ProvinciasModel provinciaSv = new ProvinciasModel();
                    provincias provincia = provinciaSv.FindById(localidad.provincia_id);


                    cBoxProvincia.SelectedValue = provincia.id;
                    cBoxLocalidad.SelectedValue = localidad.id;
                }
                else
                {
                    cBoxProvincia.SelectedIndex = 0;
                    cBoxLocalidad.SelectedIndex = 0;
                }
            }
        }

        #endregion

        #region METODOS

        bool ValidarCuit(string cuit)
        {
            Regex ex = new Regex("^[0-9]{2}-[0-9]{8}-[0-9]{1}$");

            if (!ex.IsMatch(cuit))
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
            alerta.BringToFront();
            alertaTransition.Show(alerta);
        }
        void EsconderAlerta(Panel alerta)
        {
            alertaTransition.Hide(alerta);
        }

        #endregion

        #region BOTONES

        //INTENTA MODIFICAR UN PROVEEDOR O CLIENTE
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //VALIDO CUIT
            if (!ValidarCuit(txtCuitDato.Text))
            {
                Alertas.ShowError("CUIT Invalido.");
                return;
            }

            if (proveedor != null)
            {
                proveedor.razon_social = txtRazonSocial.Text;
                proveedor.domicilio = txtDomicilio.Text;
                proveedor.cp = txtCP.Text;
                proveedor.localidad_id = ((localidades)cBoxLocalidad.SelectedItem).id;
                proveedor.cuit = txtCuitDato.Text;
                proveedor.updated_at = DateTime.Now;

                //DESHARCODEAR
                proveedor.user_id = 1;

                //MODIFICAR
                ProveedorModel proveedorSv = new ProveedorModel();
                Resultado resultado = proveedorSv.Editar(proveedor);

                if(!resultado.isOk)
                {
                    Alertas.ShowError(resultado.error);
                }
                else
                {
                    Alertas.ShowExito("Proveedor Modificado.");
                    cardPadre.ShowABM(true);
                }
            }
            else
            {
                cliente.razon_social = txtRazonSocial.Text;
                cliente.domicilio = txtDomicilio.Text;
                cliente.cp = txtCP.Text;
                cliente.localidad_id = ((localidades)cBoxLocalidad.SelectedItem).id;
                cliente.cuit = txtCuitDato.Text;
                cliente.updated_at = DateTime.Now;

                //DESHARCODEAR
                cliente.user_id = 1;

                //MODIFICAR
                ClientesModel clienteSv = new ClientesModel();
                Resultado resultado = clienteSv.Editar(cliente);

                if (!resultado.isOk)
                {
                    Alertas.ShowError(resultado.error);
                }
                else
                {
                    Alertas.ShowExito("Cliente Modificado.");
                    cardPadre.ShowABM(false);
                }
            }
        }

        //VUELVE AL ABM
        private void btnVolver_Click(object sender, EventArgs e)
        {
            if(proveedor != null)
            {
                cardPadre.ShowABM(true);
            }
            else
            {
                cardPadre.ShowABM(false);
            }
        }

        #endregion

        #region COMPORTAMIENTO

        //ACTUALIZA LOCALIDADES SEGUN PROVINCIA
        private void cBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxProvincia.SelectedItem != null)
            {
                cBoxLocalidad.Enabled = true;

                LocalidadesModel localidadesSv = new LocalidadesModel();
                List<localidades> localidades = localidadesSv.GetByProvincia(((provincias)cBoxProvincia.SelectedItem).id);

                cBoxLocalidad.DataSource = localidades;
                cBoxLocalidad.DisplayMember = "localidad";
                cBoxLocalidad.ValueMember = "id";
            }
        }

        //ESCONDE O MUESTRA LABEL AYUDA
        private void txtDomicilio_OnValueChanged(object sender, EventArgs e)
        {
            if(txtDomicilio.Text.Length > 0)
            {
                lblDomicilio.Visible = true;
            }
            else
            {
                lblDomicilio.Visible = false;
            }
        }

        //ESCONDE O MUESTRA LABEL AYUDA
        private void txtCuit_OnValueChanged(object sender, EventArgs e)
        {
            if (txtCuit.Text.Length > 0)
            {
                lblCUIT.Visible = true;
            }
            else
            {
                lblCUIT.Visible = false;
            }
        }

        //ESCONDE O MUESTRA LABEL AYUDA
        private void txtCP_OnValueChanged(object sender, EventArgs e)
        {
            if (txtCP.Text.Length > 0)
            {
                lblCP.Visible = true;
            }
            else
            {
                lblCP.Visible = false;
            }
        }

        //ESCONDE O MUESTRA LABEL AYUDA
        private void txtRazonSocial_OnValueChanged(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text.Length > 0)
            {
                lblRazonSocial.Visible = true;
            }
            else
            {
                lblRazonSocial.Visible = false;
            }
        }

        #endregion

        #region FORMATO

        private void ModificarProveedorCard_Load(object sender, EventArgs e)
        {
            txtRazonSocial.Focus();
        }

        private void txtCP_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnFinalizar_Click(sender, e);
            }
        }

        private void txtCuitDato_Enter(object sender, EventArgs e)
        {
            if (txtCuitDato.Text == "Cuit...")
            {
                txtCuitDato.Text = null;
            }
        }


        private void txtCuitDato_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuitDato.Text))
            {
                txtCuitDato.Text = "Cuit...";
            }
        }

        private void txtCuitDato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back)
            {
                if (txtCuitDato.Text.Length == 2)
                {
                    txtCuitDato.Text += "-";
                    txtCuitDato.SelectionStart = txtCuitDato.Text.Length;
                }

                if (txtCuitDato.Text.Length == 11)
                {
                    txtCuitDato.Text += "-";
                    txtCuitDato.SelectionStart = txtCuitDato.Text.Length;
                }
            }
        }

        #endregion
    }
}
