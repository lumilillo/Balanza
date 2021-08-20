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
using Balanza.Forms;

namespace Balanza.Componentes
{
    public partial class FlotaCard : UserControl
    {
        OperacionesForm formPadre;

        List<proveedores> currentProveedores;
        List<clientes> currentClientes;
        List<camiones> currentCamiones;

        public FlotaCard(OperacionesForm padre)
        {
            InitializeComponent();

            formPadre = padre;

            LoadGridProveedoresFormat();
            LoadGridCamionesFormat();

            radProveedores.Checked = true;
        }

        #region LOAD

        void LoadProveedores()
        {
            ProveedorModel proveedoresSv = new ProveedorModel();
            List<proveedores> proveedores = proveedoresSv.GetAllConLocalidad();

            dataGridProveedores.DataSource = proveedores;
            currentProveedores = proveedores;
        }

        void LoadClientes()
        {
            ClientesModel clientesSv = new ClientesModel();
            List<clientes> clientes = clientesSv.GetAllConLocalidad();

            dataGridProveedores.DataSource = clientes;
            currentClientes = clientes;
        }

        void LoadCamionesByCurrentProveedor()
        {
            proveedores proveedor = (proveedores)dataGridProveedores.CurrentRow.DataBoundItem;

            CamionesModel camionesSv = new CamionesModel();
            List<camiones> camionesDelProveedor = camionesSv.GetCamionesProveedorConTipo(proveedor.id);

            if (camionesDelProveedor != null
                && camionesDelProveedor.Count > 0)
            {
                dataGridCamiones.DataSource = camionesDelProveedor;
                currentCamiones = camionesDelProveedor;
            }
            else
            {
                dataGridCamiones.DataSource = null;
                currentCamiones = null;
            }
        }

        void LoadCamionesByCurrentCliente()
        {
            clientes cliente = (clientes)dataGridProveedores.CurrentRow.DataBoundItem;

            CamionesModel camionesSv = new CamionesModel();
            List<camiones> camionesDelCliente = camionesSv.GetCamionesClienteConTipo(cliente.id);

            if (camionesDelCliente != null
                && camionesDelCliente.Count > 0)
            {
                dataGridCamiones.DataSource = camionesDelCliente;
                currentCamiones = camionesDelCliente;
            }
            else
            {
                dataGridCamiones.DataSource = null;
                currentCamiones = null;
            }
        }

        void LoadGridProveedoresFormat()
        {
            dataGridProveedores.AutoGenerateColumns = false;
            dataGridProveedores.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 16f, FontStyle.Bold);

            dataGridProveedores.RowsDefaultCellStyle.BackColor = Color.White;
        }

        void LoadGridCamionesFormat()
        {
            dataGridCamiones.AutoGenerateColumns = false;
            dataGridCamiones.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 16f, FontStyle.Bold);

            dataGridCamiones.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridCamiones.DataSource = null;
            dataGridCamiones.Invalidate();
        }

        #endregion

        #region FORMATO

        private void dataGridProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            using (Brush b = new SolidBrush(dataGridProveedores.DefaultCellStyle.BackColor))
                e.Graphics.FillRectangle(b, e.CellBounds);
            e.PaintContent(e.ClipBounds);

            //HEADERS
            if (e.RowIndex == -1)
            {
                //LAPIZ NARANJA
                e.Graphics.DrawLine(new Pen(Color.FromArgb(254, 171, 91), 4), 0, e.CellBounds.Bottom - 2,
                                    e.CellBounds.Right, e.CellBounds.Bottom - 2);

                //LAPIZ NEGRO
                e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 0, 0), 4), 0, e.CellBounds.Bottom - 6,
                e.CellBounds.Right, e.CellBounds.Bottom - 6);

            }
            //TODAS LAS ROW MENOS LOS HEADERS
            else
            {
                //LAPIZ GRIS
                e.Graphics.DrawLine(new Pen(Color.Silver, 2), 0, e.CellBounds.Bottom - 1,
                e.CellBounds.Right, e.CellBounds.Bottom - 1);

                //DA FORMATO A ROW SELECCIONADAS
                if (dataGridProveedores.Rows[e.RowIndex].Selected)
                {
                    e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 0, 0), 2), 0, e.CellBounds.Bottom - 1,
                    e.CellBounds.Right, e.CellBounds.Bottom - 1);
                }
            }

            //DESHABILITO EL FORMATO PROPIO DE LA GRID
            e.Handled = true;
        }

        private void dataGridCamiones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            using (Brush b = new SolidBrush(dataGridCamiones.DefaultCellStyle.BackColor))
                e.Graphics.FillRectangle(b, e.CellBounds);
            e.PaintContent(e.ClipBounds);

            //HEADERS
            if (e.RowIndex == -1)
            {
                //LAPIZ NARANJA
                e.Graphics.DrawLine(new Pen(Color.FromArgb(254, 171, 91), 4), 0, e.CellBounds.Bottom - 2,
                                    e.CellBounds.Right, e.CellBounds.Bottom - 2);

                //LAPIZ NEGRO
                e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 0, 0), 4), 0, e.CellBounds.Bottom - 6,
                e.CellBounds.Right, e.CellBounds.Bottom - 6);

            }
            //TODAS LAS ROW MENOS LOS HEADERS
            else
            {
                //LAPIZ GRIS
                e.Graphics.DrawLine(new Pen(Color.Silver, 2), 0, e.CellBounds.Bottom - 1,
                e.CellBounds.Right, e.CellBounds.Bottom - 1);

                //DA FORMATO A ROW SELECCIONADAS
                if (dataGridCamiones.Rows[e.RowIndex].Selected)
                {
                    e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 0, 0), 2), 0, e.CellBounds.Bottom - 1,
                    e.CellBounds.Right, e.CellBounds.Bottom - 1);
                }
            }

            //DESHABILITO EL FORMATO PROPIO DE LA GRID
            e.Handled = true;
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtBuscar_OnValueChanged(sender, e);
        }

        private void dataGridCamiones_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1
                && e.ColumnIndex != -1
                && dataGridCamiones.Columns[e.ColumnIndex] == EliminarColumn)
            {
                dataGridCamiones.Cursor = Cursors.Hand;
                dataGridCamiones.ShowCellToolTips = true;
            }
            else
            {
                dataGridCamiones.Cursor = Cursors.Arrow;
            }
        }

        private void txtBuscar_OnValueChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabProveedores)
            {
                if (txtBuscar.Text.Length > 0)
                {
                    if (radProveedores.Checked)
                    {
                        List<proveedores> proveedoresFiltrados = new List<proveedores>();

                        foreach (proveedores proveedor in currentProveedores)
                        {
                            if (proveedor.razon_social.ToUpper().Contains(txtBuscar.Text.ToUpper())
                                || proveedor.cuit.ToUpper().Contains(txtBuscar.Text.ToUpper())
                                || proveedor.domicilio.ToUpper().Contains(txtBuscar.Text.ToUpper()))
                            {
                                proveedoresFiltrados.Add(proveedor);
                            }
                        }

                        dataGridProveedores.DataSource = proveedoresFiltrados;
                    }
                    else
                    {
                        List<clientes> clientesFiltrados = new List<clientes>();

                        foreach (clientes cliente in currentClientes)
                        {
                            if (cliente.razon_social.ToUpper().Contains(txtBuscar.Text.ToUpper())
                                || cliente.cuit.ToUpper().Contains(txtBuscar.Text.ToUpper())
                                || cliente.domicilio.ToUpper().Contains(txtBuscar.Text.ToUpper()))
                            {
                                clientesFiltrados.Add(cliente);
                            }
                        }

                        dataGridProveedores.DataSource = clientesFiltrados;
                    }
                }
                else
                {
                    if (radProveedores.Checked)
                    {
                        LoadProveedores();
                    }
                    else
                    {
                        LoadClientes();
                    }
                }
            }
            else
            {
                if (txtBuscar.Text.Length > 0 && currentCamiones != null)
                {
                    List<camiones> camionesFiltrados = new List<camiones>();

                    foreach (camiones camion in currentCamiones)
                    {
                        if (camion.patente_chasis.ToUpper().Contains(txtBuscar.Text.ToUpper()))
                        {
                            camionesFiltrados.Add(camion);
                        }
                    }

                    dataGridCamiones.DataSource = camionesFiltrados;
                }
                else
                {
                    if (radProveedores.Checked)
                    {
                        LoadCamionesByCurrentProveedor();
                    }
                    else
                    {
                        LoadCamionesByCurrentCliente();
                    }
                }
            }
        }

        #endregion

        #region COMPORTAMIENTO

        private void radProveedores_CheckedChanged(object sender, EventArgs e)
        {
            tabProveedores.Name = "Proveedores";
            LoadProveedores();

        }

        private void radClientes_CheckedChanged(object sender, EventArgs e)
        {
            tabProveedores.Name = "Clientes";
            LoadClientes();

        }

        private void dataGridProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(radProveedores.Checked)
            {
                LoadCamionesByCurrentProveedor();
                tabControl1.SelectedTab = tabCamiones;
            }
            else
            {
                LoadCamionesByCurrentCliente();
                tabControl1.SelectedTab = tabCamiones;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
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

            //MODAL BUSQUEDA

            BusquedaForm busqueda = new BusquedaForm(this, "Camiones");

            if (radProveedores.Checked)
            {
                busqueda.GetProveedor((proveedores)dataGridProveedores.CurrentRow.DataBoundItem);
                busqueda.LoadBuscarCamiones();
                busqueda.ShowDialog();
                LoadCamionesByCurrentProveedor();
            }
            else
            {
                busqueda.GetCliente((clientes)dataGridProveedores.CurrentRow.DataBoundItem);
                busqueda.LoadBuscarCamiones();
                busqueda.ShowDialog();
                LoadCamionesByCurrentCliente();
            }

            //SACO EL BACKGROUND
            backGround.Dispose();
        }

        private void dataGridCamiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.RowIndex != -1 && e.ColumnIndex != -1) && dataGridCamiones.Columns[e.ColumnIndex] == EliminarColumn)
             && (dataGridCamiones.CurrentRow != null && dataGridCamiones.CurrentRow.DataBoundItem != null)
             && (dataGridProveedores.CurrentRow != null && dataGridProveedores.CurrentRow.DataBoundItem != null))
            {
                camiones camion = (camiones)dataGridCamiones.CurrentRow.DataBoundItem;

                //PROVEEDOR CAMIONES
                if (radProveedores.Checked)
                {
                    proveedores proveedor = (proveedores)dataGridProveedores.CurrentRow.DataBoundItem;
                    ProveedorCamionesModel proveedorCamionSv = new ProveedorCamionesModel();

                    //VALIDO QUE EL CAMION ESTE ASIGNADO
                    proveedor_camiones proveedorCamion = proveedorCamionSv.FindByCamionYProveedor(camion.id, proveedor.id);

                    if (proveedorCamion != null)
                    {
                        //INTENTO ELIMINAR
                        Resultado resultado = proveedorCamionSv.Eliminar(proveedorCamion);

                        if (resultado.isOk)
                        {
                            MessageBox.Show("Camion desasignado.", "DESASIGNADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCamionesByCurrentProveedor();
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
                //CLIENTE CAMIONES
                else
                {
                    clientes cliente = (clientes)dataGridProveedores.CurrentRow.DataBoundItem;
                    ClienteCamionesModel clienteCamionSv = new ClienteCamionesModel();

                    //VALIDO QUE EL CAMION ESTE ASIGNADO
                    cliente_camiones clienteCamion = clienteCamionSv.FindByCamionYCliente(camion.id, cliente.id);

                    if (clienteCamion != null)
                    {
                        //INTENTO ELIMINAR
                        Resultado resultado = clienteCamionSv.Eliminar(clienteCamion);

                        if (resultado.isOk)
                        {
                            MessageBox.Show("Camion desasignado.", "DESASIGNADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCamionesByCurrentCliente();
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
        }

        #endregion
    }
}
