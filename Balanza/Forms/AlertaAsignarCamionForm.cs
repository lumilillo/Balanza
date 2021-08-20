using Entidades.Entidades;
using Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balanza.Forms
{
    public partial class AlertaAsignarCamionForm : Form
    {
        Form padre;
        proveedores proveedor;
        clientes cliente;
        camiones camion;

        public AlertaAsignarCamionForm(Form padre, proveedores proveedor, camiones camion)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(padre.Location.X + 430, padre.Location.Y + 50);

            this.padre = padre;
            this.proveedor = proveedor;
            this.camion = camion;

            lblPatente.Text = camion.patente_chasis;
            lblEntidad.Text = proveedor.razon_social;

            FadeIn();
        }

        public AlertaAsignarCamionForm(Form padre, clientes cliente, camiones camion)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(padre.Location.X + 430, padre.Location.Y + 50);

            this.padre = padre;
            this.cliente = cliente;
            this.camion = camion;

            lblPatente.Text = camion.patente_chasis;
            lblEntidad.Text = cliente.razon_social;

            FadeIn();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnAltaCamion_Click(object sender, EventArgs e)
        {
            if (proveedor != null)
            {
                ProveedorCamionesModel proveedorCamionesSv = new ProveedorCamionesModel();
                proveedor_camiones proveedorCamion = new proveedor_camiones();

                proveedorCamion.camion_id = camion.id;
                proveedorCamion.proveedor_id = proveedor.id;
                proveedorCamion.created_at = DateTime.Now;
                proveedorCamion.updated_at = DateTime.Now;

                proveedorCamionesSv.Insertar(proveedorCamion);

                this.Close();
            }

            if(cliente != null)
            {
                ClienteCamionesModel clienteCamionesSv = new ClienteCamionesModel();
                cliente_camiones clienteCamion = new cliente_camiones();

                clienteCamion.camion_id = camion.id;
                clienteCamion.cliente_id = cliente.id;
                clienteCamion.created_at = DateTime.Now;
                clienteCamion.updated_at = DateTime.Now;

                clienteCamionesSv.Insertar(clienteCamion);

                this.Close();
            }
        }

    }
}
