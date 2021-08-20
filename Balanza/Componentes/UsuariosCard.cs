using Balanza.Forms;
using Balanza.Herramientas;
using Entidades.Entidades;
using Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Balanza.Componentes
{
    public partial class UsuariosCard : UserControl
    {
        MaestrosForm formPadre;
        Control currentControl;
        AltaUsuariosCard altaCard;
        ModificarUsuarioCard modificarCard;

        List<users> currentUsuarios;
        public UsuariosCard(MaestrosForm padre)
        {
            InitializeComponent();

            formPadre = padre;
            currentControl = cardMenu;

            DataGridFormat();
            LoadUsuarios();
        }

        #region LOAD

        //BOOL PARA INDICAR SI SE VA A EDITAR O AGREGAR, EN CASO DE TRUE EL CAMION CONTIENE EL OBJETO A EDITAR
        void LoadAlta(bool edicion, users usuario)
        {
            altaCard = new AltaUsuariosCard(this);
            altaCard.Parent = panelABM;
            altaCard.Location = currentControl.Location;

            panelABM.Controls.Add(altaCard);
            panelABM.Tag = altaCard;
            currentControl = altaCard;
        }

        void LoadEditar()
        {
            if (dataGridCamiones.CurrentRow != null
                && dataGridCamiones.CurrentRow.DataBoundItem != null)
            {
                users usuario = (users)dataGridCamiones.CurrentRow.DataBoundItem;

                modificarCard = new ModificarUsuarioCard(this, usuario);
                modificarCard.Parent = panelABM;
                modificarCard.Location = currentControl.Location;

                panelABM.Controls.Add(modificarCard);
                panelABM.Tag = modificarCard;
                currentControl = modificarCard;
            }
        }

        void LoadUsuarios()
        {
            UsersModel usuarioSv = new UsersModel();

            List<users> usuarios = usuarioSv.GetAll();
            dataGridCamiones.DataSource = usuarios;

            currentUsuarios = usuarios;
        }

        void LoadFormatoAlerta()
        {
            btnFinalizarError.BackColor = Color.FromArgb(233, 133, 153);
            btnFinalizarAlta.BackColor = Color.FromArgb(155, 220, 170);
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

            LoadUsuarios();

            currentControl = cardMenu;

            fadeTransition.Show(currentControl);
        }

        #endregion

        #region FORMATO

        void DataGridFormat()
        {
            dataGridCamiones.AutoGenerateColumns = false;
            dataGridCamiones.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 16f, FontStyle.Bold);
            dataGridCamiones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;

            dataGridCamiones.RowsDefaultCellStyle.BackColor = Color.White;
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

        #endregion

        #region COMPORTAMIENTO

        private void dataGridCamiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1 && e.ColumnIndex != -1)
                 && dataGridCamiones.Columns[e.ColumnIndex] == EditarColumn)
            {
                if (dataGridCamiones.CurrentRow != null)
                {
                    //ABRE VENTANA MODIFICAR

                    fadeTransition.Hide(currentControl);

                    LoadEditar();

                    fadeTransition.Show(modificarCard);
                }
            }

            //if ((e.RowIndex != -1 && e.ColumnIndex != -1)
            //     && dataGridCamiones.Columns[e.ColumnIndex] == EliminarColumn)
            //{
            //    if (dataGridCamiones.SelectedRows.Count > 0
            //        && dataGridCamiones.CurrentRow != null)
            //    {
            //        //INTENTA DAR DE BAJA

            //        UsersModel usuarioSv = new UsersModel();
            //        users usuario = (users)dataGridCamiones.CurrentRow.DataBoundItem;

            //        Resultado resultado = usuarioSv.Eliminar(usuario);

            //        if (resultado.isOk)
            //        {
            //            Alertas.ShowExito("Usuario Eliminado.");
            //            LoadUsuarios();
            //        }
            //        else
            //        {
            //            Alertas.ShowError(resultado.error);
            //        }
            //    }
            //}
        }

        //CAMBIO DE IMAGEN EL CURSOR AL ENTRAR EN EDITAR O ELIMINAR
        private void dataGridCamiones_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1
                && e.ColumnIndex != -1
                && (dataGridCamiones.Columns[e.ColumnIndex] == EditarColumn
                /*|| dataGridCamiones.Columns[e.ColumnIndex] == EliminarColumn*/))
            {
                dataGridCamiones.Cursor = Cursors.Hand;
                dataGridCamiones.ShowCellToolTips = true;
            }
            else
            {
                dataGridCamiones.Cursor = Cursors.Arrow;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtBuscar_TextChanged(sender, e);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                lblBuscar.Visible = false;

                List<users> usuariosFiltrados = new List<users>();

                foreach (users user in currentUsuarios)
                {
                    if ( user.name.ToUpper().Contains(txtBuscar.Text.ToUpper())
                         || user.dni.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper())
                         || user.legajo.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper())
                         || user.email.ToUpper().Contains(txtBuscar.Text.ToUpper()) )
                    {
                        usuariosFiltrados.Add(user);
                    }
                }

                dataGridCamiones.DataSource = usuariosFiltrados;
            }
            else
            {
                lblBuscar.Visible = true;
                LoadUsuarios();
            }
        }

        #endregion

        #region BOTONES

        private void btnAlta_Click(object sender, EventArgs e)
        {
            fadeTransition.Hide(currentControl);

            LoadAlta(false, null);

            fadeTransition.Show(altaCard);
        }

        private void btnFinalizarAlta_Click(object sender, EventArgs e)
        {
            LoadUsuarios();
            Esconderalerta(alertaExito);
        }

        private void btnFinalizarError_Click(object sender, EventArgs e)
        {
            Esconderalerta(alertaError);
        }

        #endregion
    }
}
