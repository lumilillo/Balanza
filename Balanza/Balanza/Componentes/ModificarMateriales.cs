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
using Balanza.Herramientas;

namespace Balanza.Componentes
{
    public partial class ModificarMateriales : UserControl
    {
        MaterialesCard cardPadre;
        materias_primas materialEditando;

        public ModificarMateriales(MaterialesCard padre, materias_primas material)
        {
            InitializeComponent();

            cardPadre = padre;
            materialEditando = material;

            LoadUnidadesMedidas();
            LoadModificacion();
        }

        #region METODOS

        void MostrarAlerta(Panel alerta)
        {
            checkBoxMateriaPrima.Enabled = false;
            checkBoxMaterialVenta.Enabled = false;
            cBoxUnidadMedida.Enabled = false;
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;

            alerta.BringToFront();
            alertaTransition.Show(alerta);
        }

        void OcultarAlerta(Panel alerta)
        {
            checkBoxMateriaPrima.Enabled = false;
            checkBoxMaterialVenta.Enabled = false;
            cBoxUnidadMedida.Enabled = true;
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;

            alertaTransition.Hide(alerta);
        }

        #endregion

        #region LOAD

        void LoadUnidadesMedidas()
        {
            UnidadesMedidasModel unidadesSv = new UnidadesMedidasModel();
            List<unidades_medidas> unidades = unidadesSv.GetAll();

            cBoxUnidadMedida.DataSource = unidades;
            cBoxUnidadMedida.DisplayMember = "codigo";
            cBoxUnidadMedida.ValueMember = "id";
        }

        void LoadModificacion()
        {
            if (materialEditando != null)
            {

                btnModificar.Visible = true;
                lblCodigo.Visible = true;
                lblDescripcion.Visible = true;
                lblModificar.Visible = true;

                checkBoxMateriaPrima.Checked = materialEditando.materia_prima_sn;
                checkBoxMaterialVenta.Checked = materialEditando.material_venta;
                cBoxUnidadMedida.SelectedValue = materialEditando.unidades_medida_id;
                txtCodigo.Text = materialEditando.codigo;
                txtDescripcion.Text = materialEditando.descripcion;
            }
        }

        #endregion

        #region BOTONES

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MateriasPrimasModel materialSv = new MateriasPrimasModel();

            materialEditando.codigo = txtCodigo.Text;
            materialEditando.descripcion = txtDescripcion.Text;
            materialEditando.unidades_medida_id = ((unidades_medidas)cBoxUnidadMedida.SelectedItem).id;
            materialEditando.materia_prima_sn = checkBoxMateriaPrima.Checked;
            materialEditando.material_venta = checkBoxMaterialVenta.Checked;
            materialEditando.updated_at = DateTime.Now;

            Resultado resultado = materialSv.Editar(materialEditando);

            if (resultado.isOk)
            {
                Alertas.ShowExito("Material Modificado.");
                cardPadre.ShowABM();
            }
            else
            {
                Alertas.ShowError(resultado.error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            cardPadre.ShowABM();
        }

        #endregion

        #region COMPORTAMIENTO

        private void txtCodigo_OnValueChanged(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Length > 0)
            {
                lblCodigo.Visible = true;
            }
            else
            {
                lblCodigo.Visible = false;
            }
        }

        private void txtDescripcion_OnValueChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Length > 0)
            {
                lblDescripcion.Visible = true;
            }
            else
            {
                lblDescripcion.Visible = false;
            }
        }

        #endregion

        private void ModificarMateriales_Load(object sender, EventArgs e)
        {
            txtTipo.Width = cBoxUnidadMedida.Width;
            txtCodigo.Width = cBoxUnidadMedida.Width;
            txtDescripcion.Width = cBoxUnidadMedida.Width;
            txtUnidadMedida.Width = cBoxUnidadMedida.Width;
        }
    }
}
