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
    public partial class AltaMaterialCard : UserControl
    {
        MaterialesCard cardPadre;

        public AltaMaterialCard(MaterialesCard cardPadre)
        {
            InitializeComponent();
          
            this.cardPadre = cardPadre;

            LoadUnidadesMedidas();
        }

        #region LOAD

        void LoadUnidadesMedidas()
        {
            UnidadesMedidasModel unidadesSv = new UnidadesMedidasModel();
            List<unidades_medidas> unidades = unidadesSv.GetAll();

            cBoxUnidadMedida.DataSource = unidades;
            cBoxUnidadMedida.DisplayMember = "codigo";
            cBoxUnidadMedida.ValueMember = "id";
        }


        #endregion

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

        #region BOTONES

        //INTENTA INGRESAR UN NUEVO MATERIAL
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MateriasPrimasModel materialSv = new MateriasPrimasModel();
            materias_primas material = new materias_primas();

            if(!checkBoxMaterialVenta.Checked && !checkBoxMateriaPrima.Checked)
            {
                Alertas.ShowError("Tipo Material es requerido.");
                return;
            }

            material.codigo = txtCodigo.Text;
            material.descripcion = txtDescripcion.Text;
            material.unidades_medida_id = ((unidades_medidas)cBoxUnidadMedida.SelectedItem).id;
            material.materia_prima_sn = checkBoxMateriaPrima.Checked;
            material.material_venta = checkBoxMaterialVenta.Checked;
            material.created_at = DateTime.Now;
            material.updated_at = DateTime.Now;

            Resultado resultado = materialSv.Insertar(material);

            if(resultado.isOk)
            {
                Alertas.ShowExito("Material Creado.");
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

        private void AltaMaterialCard_Load(object sender, EventArgs e)
        {
            checkBoxMateriaPrima.Focus();
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                 btnFinalizar_Click(sender, e);

            }
        }
    }
}
