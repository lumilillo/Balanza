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
using Balanza.Herramientas;

namespace Balanza.Componentes
{
    public partial class MaterialesCard : UserControl
    {
        AltaMaterialCard altaCard;
        ModificarMateriales modificarCard;

        Control currentControl;

        MaestrosForm formPadre;
        List<materias_primas> currentMateriales;

        public MaterialesCard(MaestrosForm padre)
        {
            InitializeComponent();

            formPadre = padre;

            currentControl = cardMenu;

            LoadGridFormat();

            LoadMateriales();
        }

        #region LOAD

        void LoadGridFormat()
        {
            dataGridMateriales.AutoGenerateColumns = false;
            dataGridMateriales.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 16f, FontStyle.Bold);

            dataGridMateriales.RowsDefaultCellStyle.BackColor = Color.White;
        }

        void LoadMateriales()
        {
            MateriasPrimasModel materialesSv = new MateriasPrimasModel();
            List<materias_primas> materiales = materialesSv.GetMateriasConUnidad();

            dataGridMateriales.DataSource = materiales;
            currentMateriales = materiales;
        }

        void LoadAlta()
        {
            altaCard = new AltaMaterialCard(this);
            altaCard.Parent = panelABM;
            altaCard.Location = currentControl.Location;

            panelABM.Controls.Add(altaCard);
            panelABM.Tag = altaCard;
            currentControl = altaCard;
        }

        void LoadEdicion()
        {
            materias_primas materialEditanto = (materias_primas)dataGridMateriales.CurrentRow.DataBoundItem;

            if(materialEditanto != null)
            {
                modificarCard = new ModificarMateriales(this, materialEditanto);
                modificarCard.Parent = panelABM;
                modificarCard.Location = currentControl.Location;

                panelABM.Controls.Add(modificarCard);
                panelABM.Tag = modificarCard;
                currentControl = modificarCard;
            }
        }

        #endregion

        #region METODOS

        void MostrarAlerta(Panel alerta)
        {
            btnAlta.Enabled = false;
            txtBuscar.Enabled = false;
            dataGridMateriales.Enabled = false;

            alerta.BringToFront();
            alertaTransition.Show(alerta);
        }

        void OcultarAlerta(Panel alerta)
        {
            btnAlta.Enabled = true;
            txtBuscar.Enabled = true;
            dataGridMateriales.Enabled = true;

            alertaTransition.Hide(alerta);
        }

        public void ShowABM()
        {
            fadeTransition.HideSync(currentControl);
            panelABM.Controls.Remove(currentControl);

            LoadMateriales();

            currentControl = cardMenu;

            fadeTransition.Show(currentControl);
        }

        #endregion

        #region COMPORTAMIENTO

        //BUSCA MATERIAL POR CODIO O UNIDAD DE MEDIDA
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                lblBuscar.Visible = false;

                List<materias_primas> materialesFiltrados = new List<materias_primas>();

                foreach (materias_primas material in currentMateriales)
                {
                    if (material.codigo.ToUpper().Contains(txtBuscar.Text.ToUpper())
                        || material.unidadMedida.ToUpper().Contains(txtBuscar.Text.ToUpper()))
                    {
                        materialesFiltrados.Add(material);
                    }
                }

                dataGridMateriales.DataSource = materialesFiltrados;
            }
            else
            {
                lblBuscar.Visible = true;
                LoadMateriales();
            }
        }

        private void dataGridMateriales_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1
                && e.ColumnIndex != -1
                && (dataGridMateriales.Columns[e.ColumnIndex] == EditarColumn
                || dataGridMateriales.Columns[e.ColumnIndex] == EliminarColumn))
            {
                dataGridMateriales.Cursor = Cursors.Hand;
                dataGridMateriales.ShowCellToolTips = true;
            }
            else
            {
                dataGridMateriales.Cursor = Cursors.Arrow;
            }
        }

        //ALTA NUEVO MATERIAL
        private void button1_Click(object sender, EventArgs e)
        {
            fadeTransition.Hide(currentControl);

            LoadAlta();

            fadeTransition.Show(altaCard);
        }

        //BOTONES DE LA GRID
        private void dataGridMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1 && e.ColumnIndex != -1)
                 && dataGridMateriales.Columns[e.ColumnIndex] == EditarColumn)
            {
                if (dataGridMateriales.CurrentRow != null)
                {
                    //ABRE VENTANA MODIFICAR

                    fadeTransition.Hide(currentControl);

                    LoadEdicion();

                    fadeTransition.Show(modificarCard);
                }
            }

            if ((e.RowIndex != -1 && e.ColumnIndex != -1)
                && dataGridMateriales.Columns[e.ColumnIndex] == EliminarColumn)
            {
                if (dataGridMateriales.SelectedRows.Count > 0
                    && dataGridMateriales.CurrentRow != null)
                {
                    //INTENTA DAR DE BAJA

                    MateriasPrimasModel materialesSv = new MateriasPrimasModel();
                    materias_primas material = (materias_primas)dataGridMateriales.CurrentRow.DataBoundItem;

                    if (material != null)
                    {
                        Resultado resultado = materialesSv.Eliminar(material);

                        if (resultado.isOk)
                        {
                            Alertas.ShowExito("Material Eliminado.");
                            LoadMateriales();
                        }
                        else
                        {
                            Alertas.ShowError(resultado.error);
                        }
                    }
                }
            }
        }

        #endregion

        private void MaterialesCard_Load(object sender, EventArgs e)
        {
            btnAlta.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtBuscar_TextChanged(sender, e);
        }
    }
}
