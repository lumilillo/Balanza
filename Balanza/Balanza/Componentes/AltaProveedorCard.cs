using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Negocio.Modelos;
using Negocio.Herramientas;
using Datos.Repositorios;
using Entidades.Entidades;
using Balanza.Forms;
using System.Text.RegularExpressions;
using Balanza.Herramientas;

namespace Balanza.Componentes
{
    public partial class AltaProveedorCard : UserControl
    {
        ProveedorCard cardPadre;
        BunifuCards currentCard;

        bool congelarEvento;

        public AltaProveedorCard(ProveedorCard padre)
        {
            InitializeComponent();

            cardPadre = padre;

            currentCard = cardMovimiento;

            LoadProvincias();
        }

        #region ALERTAS

        void MostrarAlerta(Panel alerta)
        {
            alerta.BringToFront();
            alertaTransition.Show(alerta);
        }

        void OcultarAlerta(Panel alerta)
        {
            alertaTransition.Hide(alerta);
        }

        #endregion

        #region LOAD

        void LoadProvincias()
        {
            ProvinciasModel provinciasSv = new ProvinciasModel();
            List<provincias> provincias = provinciasSv.GetAll();

            cBoxProvincia.DataSource = provincias;
            cBoxProvincia.DisplayMember = "provincia";
            cBoxProvincia.ValueMember = "id";
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

        #endregion

        #region BOTONES

        //NAVEGACION
        private void btnVolver_Click(object sender, EventArgs e)
        {
            cardPadre.ShowABM(true);
        }

        //NAVEGACION
        private void btnVolver2_Click(object sender, EventArgs e)
        {
            cardPadre.ShowABM(true);
        }
        
        //ALTA DE NUEVO PROVEEDOR / CLIENTE
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //VALIDO CUIT
            if(!ValidarCuit(txtCuitDato.Text))
            {
                Alertas.ShowError("CUIT Invalido.");
                return;
            }

            //VEO SI ES CLIENTE O PROVEEDOR
            if (radProveedor.Checked)
            {
                ProveedorModel proveedorSv = new ProveedorModel();
                proveedores nuevoProveedor = new proveedores();

                nuevoProveedor.razon_social = txtRazonSocial.Text;
                nuevoProveedor.domicilio = txtDomicilio.Text;
                nuevoProveedor.cp = txtCP.Text;
                nuevoProveedor.localidad_id = ((localidades)cBoxLocalidad.SelectedItem).id;
                nuevoProveedor.cuit = txtCuitDato.Text;
                nuevoProveedor.created_at = DateTime.Now;
                nuevoProveedor.updated_at = DateTime.Now;

                //DESHARCODEAR
                nuevoProveedor.user_id = 1;

                //INSERT
                Resultado resultado = proveedorSv.Insertar(nuevoProveedor);

                if (resultado.isOk)
                {
                    Alertas.ShowExito("Proveedor Creado.");
                    cardPadre.ShowABM(true);
                }
                else
                {
                    Alertas.ShowError(resultado.error);
                }
            }
            else
            {
                ClientesModel clienteSv = new ClientesModel();
                clientes nuevoCliente = new clientes();

                nuevoCliente.razon_social = txtRazonSocial.Text;
                nuevoCliente.domicilio = txtDomicilio.Text;
                nuevoCliente.cp = txtCP.Text;
                nuevoCliente.localidad_id = ((localidades)cBoxLocalidad.SelectedItem).id;
                nuevoCliente.cuit = txtCuitDato.Text;
                nuevoCliente.created_at = DateTime.Now;
                nuevoCliente.updated_at = DateTime.Now;

                //DESHARCODEAR
                nuevoCliente.user_id = 1;

                //INSERT
                Resultado resultado = clienteSv.Insertar(nuevoCliente);

                if (resultado.isOk)
                {
                    Alertas.ShowExito("Cliente Creado.");
                    cardPadre.ShowABM(false);
                }
                else
                {
                    Alertas.ShowError(resultado.error);
                }
            }
        }

        #endregion

        #region COMPORTAMIENTO

        //BUSCA LOCALIDADES POR PROVINCIA
        private void cBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBoxProvincia.SelectedItem != null)
            {
                cBoxLocalidad.Enabled = true;

                LocalidadesModel localidadesSv = new LocalidadesModel();
                List<localidades> localidades = localidadesSv.GetByProvincia(((provincias)cBoxProvincia.SelectedItem).id);

                cBoxLocalidad.DataSource = localidades;
                cBoxLocalidad.DisplayMember = "localidad";
                cBoxLocalidad.ValueMember = "id";
            }
        }

        #endregion

        #region FORMATO

        private void txtDomicilio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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

        private void cardMovimiento_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
