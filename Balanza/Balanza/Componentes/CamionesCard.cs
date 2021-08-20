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
using Negocio.Herramientas;
using Balanza.Forms;
using Balanza.Herramientas;

namespace Balanza.Componentes
{
    public partial class CamionesCard : UserControl
    {
        MaestrosForm formPadre;
        Control currentControl;
        AltaCamionCard altaCard;

        List<camiones> currentCamiones;

        public CamionesCard(MaestrosForm padre)
        {
            InitializeComponent();

            formPadre = padre;
            currentControl = cardMenu;

            LoadGridFormat();
            LoadCamiones();
        }

        #region LOAD

        void LoadFormatoAlerta()
        {
            //btnFinalizarError.BackColor = Color.FromArgb(233, 133, 153);
            //btnFinalizarAlta.BackColor = Color.FromArgb(155, 220, 170);
        }

        void LoadCamiones()
        {
            CamionesModel camionesSv = new CamionesModel();
            List<camiones> camiones = camionesSv.GetCamionesConTipo();

            dataGridCamiones.DataSource = camiones;
            currentCamiones = camiones;
        }

        void LoadGridFormat()
        {
            dataGridCamiones.AutoGenerateColumns = false;
            dataGridCamiones.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            dataGridCamiones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;



            dataGridCamiones.RowsDefaultCellStyle.BackColor = Color.White;
        }

        //BOOL PARA INDICAR SI SE VA A EDITAR O AGREGAR, EN CASO DE TRUE EL CAMION CONTIENE EL OBJETO A EDITAR
        void LoadAlta(bool edicion, camiones camion)
        {
            altaCard = new AltaCamionCard(this, edicion, camion);
            altaCard.Parent = panelABM;
            altaCard.Location = currentControl.Location;

            panelABM.Controls.Add(altaCard);
            panelABM.Tag = altaCard;
            currentControl = altaCard;
        }

        #endregion

        #region METODOS

        void MostrarAlerta(Panel alerta)
        {
            btnAlta.Enabled = false;
            dataGridCamiones.Enabled = false;
            txtBuscar.Enabled = false;

            alerta.BringToFront();
            alertaTransition.Show(alerta);
        }

        void Esconderalerta(Panel alerta)
        {
            btnAlta.Enabled = true;
            dataGridCamiones.Enabled = true;
            txtBuscar.Enabled = true;

            alertaTransition.Hide(alerta);
        }

        //VUELVE A LA GRID ABM
        public void ShowABM()
        {
            fadeTransition.HideSync(currentControl);
            panelABM.Controls.Remove(currentControl);

            LoadCamiones();

            currentControl = cardMenu;

            fadeTransition.Show(currentControl);
        }

        #endregion

        #region COMPORTAMIENTO

        //BUSCADOR POR PATENTE Y TIPO CAMION
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text.Length > 0)
            {
                lblBuscar.Visible = false;

                List<camiones> camionesFiltrados = new List<camiones>();

                foreach(camiones camion in currentCamiones)
                {
                    if(camion.patente_chasis.ToUpper().Contains(txtBuscar.Text.ToUpper())
                        || camion.tipoCamion.ToUpper().Contains(txtBuscar.Text.ToUpper()))
                    {
                        camionesFiltrados.Add(camion);
                    }
                }

                dataGridCamiones.DataSource = camionesFiltrados;
            }
            else
            {
                lblBuscar.Visible = true;
                LoadCamiones();
            }
        }

        //CAMBIO IMAGEN DEL CURSOR AL ENTRAR EN EDITAR O ELIMINAR
        private void dataGridCamiones_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1
                && e.ColumnIndex != -1
                && (dataGridCamiones.Columns[e.ColumnIndex] == EditarColumn
                || dataGridCamiones.Columns[e.ColumnIndex] == EliminarColumn))
            {
                dataGridCamiones.Cursor = Cursors.Hand;
                dataGridCamiones.ShowCellToolTips = true;
            }
            else
            {
                dataGridCamiones.Cursor = Cursors.Arrow;
            }
        }

        private void dataGridCamiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1 && e.ColumnIndex != -1)
                 && dataGridCamiones.Columns[e.ColumnIndex] == EditarColumn)
            {
                if (dataGridCamiones.CurrentRow != null)
                {
                    //ABRE VENTANA MODIFICAR

                    fadeTransition.Hide(currentControl);

                    camiones camionEditando = (camiones)dataGridCamiones.CurrentRow.DataBoundItem;

                    LoadAlta(true, camionEditando);

                    fadeTransition.Show(altaCard);
                }
            }

            if ((e.RowIndex != -1 && e.ColumnIndex != -1)
                && dataGridCamiones.Columns[e.ColumnIndex] == EliminarColumn)
            {
                if (dataGridCamiones.SelectedRows.Count > 0
                    && dataGridCamiones.CurrentRow != null)
                {
                    //INTENTA DAR DE BAJA

                    CamionesModel camionesSv = new CamionesModel();
                    camiones camion = (camiones)dataGridCamiones.CurrentRow.DataBoundItem;

                    Resultado resultado = camionesSv.Eliminar(camion);

                    if (resultado.isOk)
                    {
                        Alertas.ShowExito("Camión Eliminado.");
                        LoadCamiones();
                    }
                    else
                    {
                        Alertas.ShowError(resultado.error);
                    }
                }
            }
        }

        #endregion

        #region BOTONES

        //ABRE VENTANA ALTA
        private void button1_Click(object sender, EventArgs e)
        {
            fadeTransition.Hide(currentControl);

            LoadAlta(false, null);

            fadeTransition.Show(altaCard);
        }

        //CERRAR ALERTA EXITOSA
        //private void btnFinalizarAlta_Click(object sender, EventArgs e)
        //{
        //    Esconderalerta(alertaExito);
        //    LoadCamiones();
        //}

        //CERRAR ALERTA ERRORES
        //private void btnFinalizarError_Click(object sender, EventArgs e)
        //{
        //    Esconderalerta(alertaError);
        //}

        #endregion

        #region FORMATO

        private void dataGridCamiones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {    
            //using (Brush b = new SolidBrush(dataGridCamiones.DefaultCellStyle.BackColor))
            //                 e.Graphics.FillRectangle(b, e.CellBounds);
            //                 e.PaintContent(e.ClipBounds);

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
            //    if (dataGridCamiones.Rows[e.RowIndex].Selected)
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

        private void CamionesCard_Load(object sender, EventArgs e)
        {
            btnAlta.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtBuscar_TextChanged(sender, e);
        }
    }
}
