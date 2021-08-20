using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Balanza.Forms;
using Balanza.Componentes;
using Entidades.Entidades;
using Negocio.Modelos;
using Balanza.Herramientas;

namespace Balanza.Componentes
{
    public partial class ProveedorCard : UserControl
    {
        #region PRIVADAS

        MaestrosForm formPadre;

        Control currentControl;
        AltaProveedorCard altaCard;
        ModificarProveedorCard modificarCard;

        List<proveedores> currentProveedores;
        List<clientes> currentClientes;

        #endregion
        public ProveedorCard(MaestrosForm padre)
        {
            InitializeComponent();

            LoadGridFormat();

            //HAGO CHECK EN EL CONSTRUCTOR PARA CARGAR LOS PROVEEDORES DE UNA
            radProveedores.Checked = true;

            formPadre = padre;
            currentControl = cardMenu;
        }

        #region LOAD

        void LoadProveedores()
        {
            ProveedorModel proveedorSv = new ProveedorModel();
            List<proveedores> proveedores = proveedorSv.GetAllConLocalidad();

            dataGridProveedores.DataSource = proveedores;
            currentProveedores = proveedores;
        }
        void LoadClientes()
        {
            ClientesModel clienteSv = new ClientesModel();
            List<clientes> clientes = clienteSv.GetAllConLocalidad();

            dataGridProveedores.DataSource = clientes;
            currentClientes = clientes;
        }
        void LoadAlta()
        {
            altaCard = new AltaProveedorCard(this);
            altaCard.Parent = panelABM;
            altaCard.Location = currentControl.Location;

            panelABM.Controls.Add(altaCard);
            panelABM.Tag = altaCard;

            currentControl = altaCard;

        }
        void LoadModificar(proveedores proveedor, clientes cliente)
        {
            modificarCard = new ModificarProveedorCard(this, proveedor, cliente);
            modificarCard.Parent = panelABM;
            modificarCard.Location = currentControl.Location;

            panelABM.Controls.Add(modificarCard);
            panelABM.Tag = modificarCard;

            currentControl = modificarCard;
        }
        void LoadGridFormat()
        {
            dataGridProveedores.AutoGenerateColumns = false;
            dataGridProveedores.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14f, FontStyle.Bold);

            dataGridProveedores.RowsDefaultCellStyle.BackColor = Color.White;
        }

        #endregion

        #region METODOS

        void MostrarAlerta(Panel alerta)
        {
            dataGridProveedores.Enabled = false;
            radClientes.Enabled = false;
            radProveedores.Enabled = false;

            alerta.BringToFront();
            alertaTransition.Show(alerta);
        }
        void Esconderalerta(Panel alerta)
        {
            dataGridProveedores.Enabled = true;
            radClientes.Enabled = true;
            radProveedores.Enabled = true;

            alertaTransition.Hide(alerta);
        }

        public void HideVentana()
        {
            fadeTransition.Hide(currentControl);

            if(currentControl != null)
            {
                panelABM.Controls.Remove(currentControl);
                currentControl.Dispose();
            }
        }

        public void ShowABM(bool esProveedor)
        {
            fadeTransition.HideSync(currentControl);
            panelABM.Controls.Remove(currentControl);

            if(esProveedor)
            {
                LoadProveedores();
                radProveedores.Checked = true;
                radClientes.Checked = false;
            }
            else
            {
                LoadClientes();
                radClientes.Checked = true;
                radProveedores.Checked = false;
            }

            currentControl = cardMenu;

            fadeTransition.Show(currentControl);
        }

        #endregion
  
        #region BOTONES

        //ALTA NUEVO PROVEEDOR
        private void button1_Click(object sender, EventArgs e)
        {
            fadeTransition.Hide(currentControl);

            LoadAlta();

            fadeTransition.Show(altaCard);
        }

        #endregion

        #region COMPORTAMIENTO

        private void radProveedores_CheckedChanged(object sender, EventArgs e)
        {
            LoadProveedores();
        }

        private void radClientes_CheckedChanged(object sender, EventArgs e)
        {
            LoadClientes();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            if (radProveedores.Checked)
            {
                if (txtBuscar.Text.Length > 0)
                {
                    lblBuscar.Visible = false;

                    List<proveedores> proveedoresFiltrados = new List<proveedores>();

                    foreach (proveedores proveedor in currentProveedores)
                    {
                        if (proveedor.razon_social.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || proveedor.domicilio.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || proveedor.cp.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || proveedor.cuit.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || proveedor.localidad.ToUpper().Contains(txtBuscar.Text.ToUpper()))
                        {
                            proveedoresFiltrados.Add(proveedor);
                        }
                    }

                    dataGridProveedores.DataSource = proveedoresFiltrados;
                }
                else
                {
                    lblBuscar.Visible = true;
                    LoadProveedores();
                }
            }
            else
            {
                if (txtBuscar.Text.Length > 0)
                {
                    lblBuscar.Visible = false;

                    List<clientes> clientesFiltrados = new List<clientes>();

                    foreach (clientes cliente in currentClientes)
                    {
                        if (cliente.razon_social.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || cliente.domicilio.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || cliente.cp.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || cliente.cuit.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || cliente.localidad.ToUpper().Contains(txtBuscar.Text.ToUpper()))
                        {
                            clientesFiltrados.Add(cliente);
                        }
                    }

                    dataGridProveedores.DataSource = clientesFiltrados;
                }
                else
                {
                    lblBuscar.Visible = true;
                    LoadClientes();
                }
            }

        }

        //CAMBIO IMAGEN DEL CURSOR AL ENTRAR EN EDITAR O ELIMINAR
        private void dataGridProveedores_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1
                && e.ColumnIndex != -1
                && (dataGridProveedores.Columns[e.ColumnIndex] == EditarColumn
                || dataGridProveedores.Columns[e.ColumnIndex] == EliminarColumn))
            {
                dataGridProveedores.Cursor = Cursors.Hand;
                dataGridProveedores.ShowCellToolTips = true;
            }
            else
            {
                dataGridProveedores.Cursor = Cursors.Arrow;
            }
        }

        private void dataGridProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //BOTON ELIMINAR
            if ((e.RowIndex != -1 && e.ColumnIndex != -1)
                  && dataGridProveedores.Columns[e.ColumnIndex] == EliminarColumn)
            {
                if (dataGridProveedores.SelectedRows.Count > 0
                    && dataGridProveedores.CurrentRow != null)
                {
                    //INTENTA DAR DE BAJA

                    //SI ES PROVEEDOR
                    if (radProveedores.Checked)
                    {
                        ProveedorModel proveedorSv = new ProveedorModel();
                        proveedores proveedor = (proveedores)dataGridProveedores.CurrentRow.DataBoundItem;

                        Resultado resultado = proveedorSv.Eliminar(proveedor);

                        if (!resultado.isOk)
                        {
                            Alertas.ShowError(resultado.error);
                        }
                        else
                        {
                            Alertas.ShowExito("Proveedor Eliminado.");
                            LoadProveedores();
                        }
                    }
                    //SI ES LCIENTE
                    else
                    {
                        ClientesModel clienteSc = new ClientesModel();
                        clientes cliente = (clientes)dataGridProveedores.CurrentRow.DataBoundItem;

                        Resultado resultado = clienteSc.Eliminar(cliente);

                        if (!resultado.isOk)
                        {
                            Alertas.ShowError(resultado.error);
                        }
                        else
                        {
                            Alertas.ShowExito("Cliente Eliminado.");
                            LoadClientes();
                        }
                    }
                }
            }

            //BOTON MODIFICAR
            if ((e.RowIndex != -1 && e.ColumnIndex != -1)
                  && dataGridProveedores.Columns[e.ColumnIndex] == EditarColumn)
            {
                if (dataGridProveedores.SelectedRows.Count > 0)
                {
                    if (dataGridProveedores.CurrentRow.DataBoundItem is proveedores)
                    {
                        proveedores proveedor = (proveedores)dataGridProveedores.CurrentRow.DataBoundItem;

                        fadeTransition.Hide(currentControl);

                        LoadModificar(proveedor, null);

                        fadeTransition.Show(modificarCard);
                    }

                    if (dataGridProveedores.CurrentRow.DataBoundItem is clientes)
                    {
                        clientes cliente = (clientes)dataGridProveedores.CurrentRow.DataBoundItem;

                        fadeTransition.Hide(currentControl);

                        LoadModificar(null, cliente);

                        fadeTransition.Show(modificarCard);
                    }
                }
            }
        }

        #endregion

        #region FORMATO

        private void dataGridProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //using (Brush b = new SolidBrush(dataGridProveedores.DefaultCellStyle.BackColor))
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
            ////TODAS LAS ROW MENOS LOS HEADERS
            //else
            //{
            //    //LAPIZ GRIS
            //    e.Graphics.DrawLine(new Pen(Color.Silver, 2), 0, e.CellBounds.Bottom - 1,
            //    e.CellBounds.Right, e.CellBounds.Bottom - 1);

            //    //DA FORMATO A ROW SELECCIONADAS
            //    if (dataGridProveedores.Rows[e.RowIndex].Selected)
            //    {
            //        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
            //        e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 0, 0), 2), 0, e.CellBounds.Bottom - 1,
            //        e.CellBounds.Right, e.CellBounds.Bottom - 1);
            //    }
            //}

            ////DESHABILITO EL FORMATO PROPIO DE LA GRID
            //e.Handled = true;
        }

        #endregion

        private void ProveedorCard_Load(object sender, EventArgs e)
        {
            btnAlta.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtBuscar_TextChanged(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
