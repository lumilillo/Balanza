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
using System.Globalization;
using Bunifu.Framework.UI;
using Balanza.Componentes;
using Balanza.Herramientas;

namespace Balanza.Forms
{
    public partial class MovimientosForm : Form
    {
        #region ATRIBUTOS

        List<permissions> permisos;
        List<registros_tarjetas> currentRegistros;
        List<movimientos_camiones> currentMovimientos;
 
        Control currentControl;
        ModificarMovimientoCard modificarCard;
        AltaMovimientoCard altaCard;

        registros_tarjetas currentRegistro;

        bool movimientosIncoherentes;
        int currentRow;

        #endregion

        public MovimientosForm()
        {
            InitializeComponent();

            permisos = Globales.LoadPermisos();

            LoadGridFormat();
            LoadDtFormat();
            LoadRegistrosByFecha();
            LoadMovimientosByFecha();
            Loadestados();

            currentControl = cardMenu;
            timer1.Start();
        }

        #region METODOS

        void Loadestados()
        {
            EstadosModel estadoSv = new EstadosModel();

            estados estadoIncompleto = estadoSv.FindByCodigo("INCOMPLETO");
            estados estadoIncoherente = estadoSv.FindByCodigo("INCOHERENTE");
            estados estadoComentado = estadoSv.FindByCodigo("COMENTADO");
 
            this.lblIncompletos.Text = estadoIncompleto.descripcion;
            this.lblIncoherentes.Text = estadoIncoherente.descripcion;
            this.lblComentados.Text = estadoComentado.descripcion;
            this.lblComentadosRegistros.Text = estadoComentado.descripcion;

            this.lblIncompletos.ForeColor = ColorTranslator.FromHtml(estadoIncompleto.color);
            this.lblIncoherentes.ForeColor = ColorTranslator.FromHtml(estadoIncoherente.color);
            this.lblComentados.ForeColor = ColorTranslator.FromHtml(estadoComentado.color);
            this.lblComentadosRegistros.ForeColor = ColorTranslator.FromHtml(estadoComentado.color);

            this.panelIncompletos.BackColor = ColorTranslator.FromHtml(estadoIncompleto.color);
            this.panelIncoherentes.BackColor = ColorTranslator.FromHtml(estadoIncoherente.color);
            this.panelComentados.BackColor = ColorTranslator.FromHtml(estadoComentado.color);
            this.panelComentadosRegistros.BackColor = ColorTranslator.FromHtml(estadoComentado.color);
        }

        void LoadRegistrosByFecha()
        {
            DateTime dtDesde = dateTimePicker1.Value;
            DateTime dtHasta = dateTimePicker2.Value;

            DateTime desde = new DateTime(dtDesde.Year, dtDesde.Month, dtDesde.Day, 00, 00, 00);
            DateTime hasta = new DateTime(dtHasta.Year, dtHasta.Month, dtHasta.Day, 23, 59, 59);

            RegistrosTarjetasModelo registroSv = new RegistrosTarjetasModelo();

            List<registros_tarjetas> registros = registroSv.GetAllRegistros(desde, hasta);

            dataGridTarjetas.DataSource = registros;

            currentRegistros = registros;
        }

        void LoadMovimientosByFecha()
        {
            DateTime dtDesde = dateTimePicker1.Value;
            DateTime dtHasta = dateTimePicker2.Value;

            DateTime desde = new DateTime(dtDesde.Year, dtDesde.Month, dtDesde.Day, 00, 00, 00);
            DateTime hasta = new DateTime(dtHasta.Year, dtHasta.Month, dtHasta.Day, 23, 59, 59);

            MovimientosCamionesModel movimientosSv = new MovimientosCamionesModel();

            //List<movimientos_camiones> movimientos = movimientosSv.GetAllMovimientosByDate(desde, hasta);
            List<movimientos_camiones> movimientos = movimientosSv.GetAllMovimientosFiltrados(desde, hasta, null);

            currentMovimientos = movimientos;
            dataGridCamiones.DataSource = movimientos;
        }

        void LoadMovimientosByCurrentRegistro()
        {
            MovimientosCamionesModel movimientosSv = new MovimientosCamionesModel();
            //List<movimientos_camiones> movimientos = movimientosSv.GetAllMovimientosByRegistro(currentRegistro.id);
            List<movimientos_camiones> movimientos = movimientosSv.GetAllMovimientosFiltrados(null, null, currentRegistro.id);

            currentMovimientos = movimientos;
            dataGridCamiones.DataSource = movimientos;
        }

        void LoadMovimientosIncoherentes()
        {
            MovimientosCamionesModel movimientosSv = new MovimientosCamionesModel();

            List<movimientos_camiones> movimientos = movimientosSv.GetAllMovimientosIncoherentes();

            currentMovimientos = movimientos;
            dataGridCamiones.DataSource = movimientos;
        }

        void LoadModificar()
        {
            movimientos_camiones movimiento = (movimientos_camiones)dataGridCamiones.CurrentRow.DataBoundItem;

            modificarCard = new ModificarMovimientoCard(this, movimiento);
            modificarCard.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(modificarCard);
            panelPrincipal.Tag = modificarCard;
            currentControl = modificarCard;
        }

        void LoadAlta()
        {
            registros_tarjetas movimiento = (registros_tarjetas)dataGridTarjetas.CurrentRow.DataBoundItem;

            altaCard = new AltaMovimientoCard(this, movimiento);
            altaCard.Parent = panelPrincipal;

            panelPrincipal.Controls.Add(altaCard);
            panelPrincipal.Tag = altaCard;
            currentControl = altaCard;
        }

        void GenerarTotal(List<movimientos_camiones> movimientos)
        {
            if (movimientos == null || movimientos.Count < 1) { lblTotal.Text = $"Diferencia Total(Tn.): 0"; return; }

            decimal? total = 0;
            int viajes = 0;

            foreach (movimientos_camiones movimiento in movimientos)
            {
                if (movimiento.pesoFinal != null)
                {
                    total += decimal.Round((decimal)movimiento.pesoFinal, 2, MidpointRounding.AwayFromZero);
                }
                viajes++;
            }

            lblTotal.Text = $"Total(Tn.): {total}";
            lblTotal.Visible = true;

            lblViajes.Text = $"Movimientos: {viajes}";
            lblViajes.Visible = true;
        }

        #endregion

        #region FORMATO

        void LoadDtFormat()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        void LoadGridFormat()
        {
            dataGridTarjetas.AutoGenerateColumns = false;
            dataGridTarjetas.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dataGridTarjetas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
            dataGridTarjetas.RowsDefaultCellStyle.BackColor = Color.White;

            dataGridCamiones.AutoGenerateColumns = false;
            dataGridCamiones.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dataGridCamiones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
            dataGridCamiones.RowsDefaultCellStyle.BackColor = Color.White;
        }

        private void txtBuscar_OnValueChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabTarjetas)
            {
                if (txtBuscar.Text.Length > 0
                    && currentRegistros != null)
                {
                    List<registros_tarjetas> registrosFiltrados = new List<registros_tarjetas>();

                    foreach (registros_tarjetas registro in currentRegistros)
                    {
                        if (registro.nro_tarjeta.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || registro.razon_social.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || registro.tipo.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || registro.material.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || registro.patente.ToUpper().Contains(txtBuscar.Text.ToUpper()))
                        {
                            registrosFiltrados.Add(registro);
                        }
                    }

                    dataGridTarjetas.DataSource = registrosFiltrados;
                }
                else
                {
                    LoadRegistrosByFecha();
                }
            }
            else
            {
                if (txtBuscar.Text.Length > 0
                    && currentMovimientos != null)
                {
                    List<movimientos_camiones> movimientosFiltrados = new List<movimientos_camiones>();

                    foreach (movimientos_camiones movimiento in currentMovimientos)
                    {
                        if (movimiento.tarjeta.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || movimiento.razon_social.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || movimiento.material.ToUpper().Contains(txtBuscar.Text.ToUpper())
                            || movimiento.patente.ToUpper().Contains(txtBuscar.Text.ToUpper()))
                        {
                            movimientosFiltrados.Add(movimiento);
                        }
                    }

                    currentMovimientos = movimientosFiltrados;
                    dataGridCamiones.DataSource = movimientosFiltrados;
                }
                else
                {
                    if (currentRegistro != null)
                    {
                        LoadMovimientosByCurrentRegistro();
                    }
                    else
                    {
                        LoadMovimientosByFecha();
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
            currentRegistro = null;
            movimientosIncoherentes = false;
        }

        public void ShowMenuAsync()
        {
            fadeTransition.Show(currentControl);
        }

        public void HideMenuSync()
        {
            fadeTransition.HideSync(currentControl);

            if (currentControl != cardMenu)
            {
                this.Controls.Remove(currentControl);
                currentControl.Dispose();
            }
        }

        public void ShowMovimientos()
        {
            HideMenuSync();

            dataGridCamiones.Invalidate();
            currentControl = cardMenu;

            ShowMenuAsync();
        }

        public void ShowMovimientosByRegistro()
        {
            HideMenuSync();

            if (movimientosIncoherentes)
            {
                LoadMovimientosIncoherentes();
            }
            else
            {
                if (currentRegistro != null)
                {
                    LoadMovimientosByCurrentRegistro();
                }
                else
                {
                    LoadMovimientosByFecha();
                }
            }

            tabControl1.SelectedTab = tabCamiones;
            currentControl = cardMenu;

            ShowMenuAsync();
        }

        private void dataGridCamiones_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1
                && e.ColumnIndex != -1
                && (dataGridCamiones.Columns[e.ColumnIndex] == EditarColumn))
            {
                dataGridCamiones.Cursor = Cursors.Hand;
            }
            else if (e.RowIndex != -1
                    && e.ColumnIndex != -1
                    && (dataGridCamiones.Columns[e.ColumnIndex] == EstadoColumn)
                    && ((movimientos_camiones)dataGridCamiones.Rows[e.RowIndex].DataBoundItem).editado_sn )
            {
                dataGridCamiones.Cursor = Cursors.Hand;
            }
            else

            {
                dataGridCamiones.Cursor = Cursors.Arrow;
            }
        }

        private void dataGridTarjetas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1
                && e.ColumnIndex != -1
                && (dataGridTarjetas.Columns[e.ColumnIndex] == ObsColumn))
            {
                dataGridTarjetas.Cursor = Cursors.Hand;
            }
            else
            {
                dataGridTarjetas.Cursor = Cursors.Arrow;
            }
        }

        #endregion

        #region COMPORTAMIENTO

        private void timer1_Tick(object sender, EventArgs e)
        {
            //LoadRegistrosByFecha();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabTarjetas)
            {
                LoadRegistrosByFecha();
            }
            else
            {
                LoadMovimientosByFecha();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }

        private void dataGridTarjetas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridTarjetas.SelectedRows.Count > 0
                && dataGridTarjetas.CurrentRow.DataBoundItem != null)
            {
                registros_tarjetas registro = (registros_tarjetas)dataGridTarjetas.CurrentRow.DataBoundItem;

                MovimientosCamionesModel movimientosSv = new MovimientosCamionesModel();
                List<movimientos_camiones> movimientos = movimientosSv.GetAllMovimientosFiltrados(null, null, registro.id);

                currentMovimientos = movimientos;
                dataGridCamiones.DataSource = movimientos;
                currentRegistro = registro;
                movimientosIncoherentes = false;

                tabControl1.SelectedTab = tabCamiones;
            }
        }

        #endregion

        #region BOTONES

        private void dataGridCamiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1 && e.ColumnIndex != -1)
                  && dataGridCamiones.Columns[e.ColumnIndex] == EditarColumn)
            {
                permissions permiso = permisos.FirstOrDefault(x => x.name == "Movimientos Off");

                if (permiso != null)
                {
                    if (dataGridCamiones.CurrentRow.DataBoundItem != null)
                    {
                        //ABRE VENTANA MODIFICAR

                        fadeTransition.Hide(currentControl);

                        currentRow = dataGridCamiones.CurrentRow.Index;
                        LoadModificar();

                        fadeTransition.Show(modificarCard);
                    }
                }
                else
                {
                    Alertas.ShowError("Usuario sin acceso a Editar Movimientos.");
                }
            }

            if ((e.RowIndex != -1 && e.ColumnIndex != -1)
                && dataGridCamiones.Columns[e.ColumnIndex] == EstadoColumn)
            {
                if(dataGridCamiones.CurrentRow.DataBoundItem != null)
                {
                    movimientos_camiones movimiento = (movimientos_camiones)dataGridCamiones.CurrentRow.DataBoundItem;

                    if(movimiento.editado_sn)
                    {
                        permissions permiso = permisos.FirstOrDefault(x => x.name == "Movimientos Off");

                        if(permiso != null)
                        {
                            //ABRE VENTANA MODIFICAR

                            fadeTransition.Hide(currentControl);

                            currentRow = dataGridCamiones.CurrentRow.Index;
                            LoadModificar();

                            fadeTransition.Show(modificarCard);
                        }
                        else
                        {
                           Alertas.ShowError("Usuario sin acceso a Editar Movimientos.");
                        }
                    }
                }
            }
        }

        private void dataGridTarjetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1 && e.ColumnIndex != -1)
                 && dataGridTarjetas.Columns[e.ColumnIndex] == ObsColumn)
            {
                registros_tarjetas registro = ((registros_tarjetas)dataGridTarjetas.CurrentRow.DataBoundItem);
                if ( registro != null)
                {
                    Alertas.ShowObservaciones(registro, registro.observacion_planta, registro.observacion_web);
                }
            }
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            permissions permiso = permisos.FirstOrDefault(x => x.name == "Movimientos Off");

            if (permiso != null)
            {
                if (dataGridTarjetas.SelectedRows.Count > 0
                    && dataGridTarjetas.CurrentRow.DataBoundItem != null)
                {
                    movimientosIncoherentes = false;

                    fadeTransition.Hide(currentControl);

                    LoadAlta();

                    fadeTransition.Show(altaCard);
                }
                else
                {
                    Alertas.ShowError("Seleccione un Registro.");
                }
            }
            else
            {
                Alertas.ShowError("Usuario sin acceso a Alta Movimientos.");
            }
        }

        private void dataGridCamiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1 && e.ColumnIndex != -1))
            {
                permissions permiso = permisos.FirstOrDefault(x => x.name == "Movimientos Off");

                if (permiso != null)
                {
                    if (dataGridCamiones.CurrentRow.DataBoundItem != null)
                    {
                        //ABRE VENTANA MODIFICAR

                        fadeTransition.Hide(currentControl);

                        currentRow = dataGridCamiones.CurrentRow.Index;
                        LoadModificar();

                        fadeTransition.Show(modificarCard);
                    }
                }
                else
                {
                    Alertas.ShowError("Usuario sin acceso a Editar Movimientos.");
                }
            }
        }

        #endregion

        #region FORMATO GRIDS

        private void dataGridCamiones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (currentMovimientos != null
                && dataGridCamiones.Rows[e.RowIndex].DataBoundItem != null)
            {
                EstadosModel estadoSv = new EstadosModel();
                estados estado = estadoSv.FindById(((movimientos_camiones)dataGridCamiones.Rows[e.RowIndex].DataBoundItem).estado_id);

                if ((estado.codigo != "CORRECTO"))
                {
                    dataGridCamiones.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml(estado.color);
                }

                dataGridCamiones.Rows[e.RowIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void dataGridCamiones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GenerarTotal(currentMovimientos);

            foreach(DataGridViewRow row in dataGridCamiones.Rows)
            {
                if (((movimientos_camiones)row.DataBoundItem).editado_sn)
                {
                    row.Cells["EstadoColumn"].Value = Properties.Resources.icons8_editar_el_historial_de_chat_50__1_;
                }
                else
                {
                    row.Cells["EstadoColumn"].Value = new Bitmap(1, 1);
                }
            }
        }

        private void dataGridTarjetas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridTarjetas.Rows)
            {
                if (((registros_tarjetas)row.DataBoundItem).alerta_sn)
                {
                    row.Cells["ColumnEstado"].Value = Properties.Resources.icons8_atención_50;
                }
                else
                {
                    row.Cells["ColumnEstado"].Value = new Bitmap(1, 1);
                }
            }
        }

        private void dataGridTarjetas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (currentRegistros != null
                && dataGridTarjetas.Rows[e.RowIndex].DataBoundItem != null)
            {
                EstadosModel estadoSv = new EstadosModel();
                estados estado = estadoSv.FindByCodigo("COMENTADO");

                registros_tarjetas registro = (registros_tarjetas)dataGridTarjetas.Rows[e.RowIndex].DataBoundItem;
                if (!string.IsNullOrEmpty(registro.observacion_web) || !string.IsNullOrEmpty(registro.observacion_planta))
                {
                    dataGridTarjetas.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml(estado.color);
                }
            }
        }

        #endregion

    }
}