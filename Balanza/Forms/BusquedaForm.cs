using Balanza.Componentes;
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
    public partial class BusquedaForm : Form
    {
        Control padre;
        proveedores unProveedor;
        clientes unCliente;

        List<camiones> currentCamiones;

        public BusquedaForm(Control padre, string titulo)
        {
            InitializeComponent();

            this.padre = padre;
            this.lblTitulo.Text = titulo;
        }

        #region ASIGNACION CAMIONES

        //ASIGNA CAMION A PROVEEDOR O CLIENTE
        void AsignarCamion()
        {
            if(unProveedor != null)
            {
                ProveedorCamionesModel proveedorCamionesSv = new ProveedorCamionesModel();

                proveedor_camiones proveedorCamion = new proveedor_camiones();

                proveedorCamion.camion_id = ((camiones)dataGridCamiones.CurrentRow.DataBoundItem).id;
                proveedorCamion.proveedor_id = unProveedor.id;
                proveedorCamion.created_at = DateTime.Now;
                proveedorCamion.updated_at = DateTime.Now;

                //VALIDO QUE EL CAMION NO SE ENCUENTRA YA ASIGNADO
                proveedor_camiones proveedorCamionRepetido = proveedorCamionesSv.FindByCamionYProveedor(proveedorCamion.camion_id, proveedorCamion.proveedor_id);

                if(proveedorCamionRepetido != null)
                {
                    MessageBox.Show("El camion ya esta asginado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //INTENTO INSERT
                    Resultado resultado = proveedorCamionesSv.Insertar(proveedorCamion);

                    if (resultado.isOk)
                    {
                        MessageBox.Show("Camion asignado.", "ASIGNADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridCamiones.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(16, 210, 150);
                    }
                    else
                    {
                        MessageBox.Show(resultado.error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                ClienteCamionesModel clienteCamionesSv = new ClienteCamionesModel();

                cliente_camiones clienteCamion = new cliente_camiones();

                clienteCamion.camion_id = ((camiones)dataGridCamiones.CurrentRow.DataBoundItem).id;
                clienteCamion.cliente_id = unCliente.id;
                clienteCamion.created_at = DateTime.Now;
                clienteCamion.updated_at = DateTime.Now;

                //VALIDO QUE EL CAMION NO SE ENCUENTRA YA ASIGNADO
                cliente_camiones proveedorCamionRepetido = clienteCamionesSv.FindByCamionYCliente(clienteCamion.camion_id, clienteCamion.cliente_id);

                if (proveedorCamionRepetido != null)
                {
                    MessageBox.Show("El camion ya esta asginado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //INTENTO INSERT
                    Resultado resultado = clienteCamionesSv.Insertar(clienteCamion);

                    if (resultado.isOk)
                    {
                        MessageBox.Show("Camion desasignado.", "ASIGNADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridCamiones.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(16, 210, 150);
                    }
                    else
                    {
                        MessageBox.Show(resultado.error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //BUSCA CAMIONES POR PATENTE
        void BuscarCamiones()
        {
            if(txtBuscar.Text.Length > 0)
            {
                List<camiones> camionesFiltrados = new List<camiones>();

                foreach (camiones camion in currentCamiones)
                {
                    if (camion.patente_chasis.ToUpper().Contains(txtBuscar.Text.ToUpper()) )
                    {
                        camionesFiltrados.Add(camion);
                    }
                }

                dataGridCamiones.DataSource = camionesFiltrados;
                LoadCamionesAsignados();
            }
            else
            {
                LoadCamiones();
                LoadCamionesAsignados();
            }
        }

        void LoadCamiones()
        {
            //CARGO CAMIONES EN LA GRID

            CamionesModel camionesSv = new CamionesModel();

            List<camiones> camiones = camionesSv.GetCamionesConTipo();

            dataGridCamiones.DataSource = camiones;
            currentCamiones = camiones;
        }

        void LoadGridCamionesFormat()
        {
            //FORMATO DE LA GRID
            dataGridCamiones.Visible = true;
            dataGridCamiones.AutoGenerateColumns = false;
            dataGridCamiones.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 16f, FontStyle.Bold);

            dataGridCamiones.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridCamiones.DataSource = null;

            dataGridCamiones.Invalidate();
        }

        void LoadBusquedaCamionesFormat()
        {
            //CARGO FORMATO DE LA MODAL
            lblIndicacion1.Text = "Camión asignado.";
            lblIndicacion1.Visible = true;

            panelIndicacion1.Visible = true;

            //CARGO COMPORTAMIENTO A LOS BOTONES
            btnAccion.ButtonText = "Asignar";
            btnAccion.Click += delegate (object sender, EventArgs e) { AsignarCamion(); };

            //btnAccion2.ButtonText = "Desasignar";
            //btnAccion2.Click += delegate (object sender, EventArgs e) { DesasignarCamion(); };

            //CARGO COMPORTAMIENTO AL EVENTO SHOWN
            this.Shown += delegate (object sender, EventArgs e) { LoadCamionesAsignados(); };

            //CARGO COMPORTAMIENTO AL TXT BUSQUEDA
            txtBuscar.TextChanged += delegate (object sender, EventArgs e) { BuscarCamiones(); };
        }


        public void LoadCamionesAsignados()
        {
            //CARGO CAMIONES ASIGNADOS SI TIENE
            CamionesModel camionesSv = new CamionesModel();

            if (unProveedor != null)
            {
                List<camiones> camionesAsginados = camionesSv.GetCamionesProveedorConTipo(unProveedor.id);

                if (camionesAsginados != null)
                {
                    foreach (camiones camion in camionesAsginados)
                    {
                        foreach (DataGridViewRow row in dataGridCamiones.Rows)
                        {
                            if (((camiones)row.DataBoundItem).id == camion.id)
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(16, 210, 150);
                            }
                        }
                    }
                }
            }
            else
            {
                List<camiones> camionesAsginados = camionesSv.GetCamionesClienteConTipo(unCliente.id);

                if (camionesAsginados != null)
                {
                    foreach (DataGridViewRow row in dataGridCamiones.Rows)
                    {
                        foreach (camiones camion in camionesAsginados)
                        {
                            if (((camiones)row.DataBoundItem).id == camion.id)
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(16, 210, 150);
                            }
                        }
                    }
                }
            }
        }

        //CARGO LA MODAL PARA BUSCAR Y ASIGNAR CAMIONES
        public void LoadBuscarCamiones()
        {
            LoadGridCamionesFormat();

            LoadBusquedaCamionesFormat();

            LoadCamiones();

            txtBuscar.Focus();
        }

        //AGARRA UN PROVEEDOR DE ASGINAR CAMIONES 
        public void GetProveedor(proveedores proveedor)
        {
            unProveedor = proveedor;
        }

        //AGARRA UN CLIENTE DE ASIGNAR CAMIONES
        public void GetCliente(clientes cliente)
        {
            unCliente = cliente;
        }

        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FOCUS EN TXTBUSQUEDA
        private void BusquedaForm_Activated(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

    }
}
#region PAPELERA
//DESASIGNA CAMION A PROVEEDOR O CLIENTE

/*

 void DesasignarCamion()
{
    camiones currentCamion = (camiones)dataGridCamiones.CurrentRow.DataBoundItem;

    if (unProveedor != null)
    {
        ProveedorCamionesModel proveedorCamionSv = new ProveedorCamionesModel();

        //VALIDO QUE EL CAMION ESTE ASIGNADO
        proveedor_camiones proveedorCamion = proveedorCamionSv.FindByCamionYProveedor(currentCamion.id, unProveedor.id);

        if (proveedorCamion != null)
        {
            //INTENTO ELIMINAR
            Resultado resultado = proveedorCamionSv.Eliminar(proveedorCamion);

            if (resultado.isOk)
            {
                MessageBox.Show("Camion desasignado.", "DESASIGNADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridCamiones.CurrentRow.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show(resultado.error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Camion no asignado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    else
    {
        ClienteCamionesModel clienteCamionSv = new ClienteCamionesModel();

        //VALIDO QUE EL CAMION ESTE ASIGNADO
        cliente_camiones clienteCamion = clienteCamionSv.FindByCamionYCliente(currentCamion.id, unCliente.id);

        if (clienteCamion != null)
        {
            //INTENTO ELIMINAR
            Resultado resultado = clienteCamionSv.Eliminar(clienteCamion);

            if (resultado.isOk)
            {
                MessageBox.Show("Camion desasignado.", "DESASIGNADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridCamiones.CurrentRow.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show(resultado.error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Camion no asignado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

        private void dataGridCamiones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //using (Brush b = new SolidBrush(dataGridCamiones.DefaultCellStyle.BackColor))
            //    e.Graphics.FillRectangle(b, e.CellBounds);
            //e.PaintContent(e.ClipBounds);

            ////HEADERS
            //if (e.RowIndex == -1)
            //{
            //    //LAPIZ NARANJA
            //    e.Graphics.DrawLine(new Pen(Color.FromArgb(254, 171, 91), 4), 0, e.CellBounds.Bottom - 2,
            //                        e.CellBounds.Right, e.CellBounds.Bottom - 2);

            //    //LAPIZ NEGRO
            //    e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 0, 0), 4), 0, e.CellBounds.Bottom - 6,
            //    e.CellBounds.Right, e.CellBounds.Bottom - 6);

            //}

            ////DESHABILITO EL FORMATO PROPIO DE LA GRID
            //e.Handled = true;
        }

*/

#endregion