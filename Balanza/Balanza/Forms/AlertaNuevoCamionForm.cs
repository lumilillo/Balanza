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

namespace Balanza.Forms
{
    public partial class AlertaNuevoCamionForm : Form
    {
        string patente = "";
        Form padre;
        proveedores proveedor;
        clientes cliente;
        public AlertaNuevoCamionForm(Form padre, proveedores proveedor,string patente)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(padre.Location.X + 430, padre.Location.Y + 50);

            this.padre = padre;
            this.proveedor = proveedor;
            this.patente = patente;
            lblPatente.Text = patente;

            LoadTipos();
            FadeIn();
        }

        public AlertaNuevoCamionForm(Form padre, clientes cliente,string patente)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(padre.Location.X + 430, padre.Location.Y + 50);

            this.padre = padre;
            this.cliente = cliente;
            this.patente = patente;
            lblPatente.Text = patente;

            LoadTipos();
            FadeIn();
        }

        async void FadeIn()
        {
            while (this.Opacity < 1.0)
            {
                await Task.Delay(30);
                this.Opacity += 0.05;
            }
            this.Opacity = 1;
        }

        void LoadTipos()
        {
            TipoCamionesModel tipoSv = new TipoCamionesModel();
            cBoxPanelTipoCamion.DataSource = tipoSv.GetAll();
            cBoxPanelTipoCamion.DisplayMember = "codigo";
        }

        private void btnAltaCamion_Click(object sender, EventArgs e)
        {
            //CREO EL NUEVO CAMION
            CamionesModel camionesSv = new CamionesModel();
            camiones camion = new camiones();

            camion.tipo_camion_id = ((tipo_camiones)cBoxPanelTipoCamion.SelectedItem).id;
            camion.patente_chasis = patente;
            camion.created_at = DateTime.Now;
            camion.updated_at = DateTime.Now;

            camionesSv.Insertar(camion);

            int camionId = camionesSv.FindLastId();

            //CLIENTE CAMION
            if (cliente != null)
            {
                ClienteCamionesModel clienteCamionesSv = new ClienteCamionesModel();
                cliente_camiones clienteCamion = new cliente_camiones();

                clienteCamion.camion_id = camionId;
                clienteCamion.cliente_id = cliente.id;
                clienteCamion.created_at = DateTime.Now;
                clienteCamion.updated_at = DateTime.Now;

                clienteCamionesSv.Insertar(clienteCamion);
                this.Close();
            }

            //PROVEEDOR CAMION
            if (proveedor != null)
            {
                ProveedorCamionesModel proveedorCamionesSv = new ProveedorCamionesModel();
                proveedor_camiones proveedorCamion = new proveedor_camiones();

                proveedorCamion.camion_id = camionId;
                proveedorCamion.proveedor_id = proveedor.id;
                proveedorCamion.created_at = DateTime.Now;
                proveedorCamion.updated_at = DateTime.Now;

                proveedorCamionesSv.Insertar(proveedorCamion);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
