using Balanza.Forms;
using Balanza.Herramientas;
using Entidades.Entidades;
using Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Balanza.Componentes
{
    public partial class AsigntarTarjetaControl : UserControl
    {
        #region Atributos

        OperacionesForm formPadre;
        string dataInTarjeta;
        bool CongelarEvento;

        #endregion
        
        public AsigntarTarjetaControl(OperacionesForm padre)
        {
            InitializeComponent();

            SetPuertos();

            formPadre = padre;

            LoadMateriaPrima();
            LoadProveedoresClientes();
            LoadTipoCamiones();
        }

        #region LOAD

        //CARGA DE DATOS
        void LoadMateriaPrima()
        {
            List<materias_primas> materias = new List<materias_primas>();
            MateriasPrimasModel materiasSv = new MateriasPrimasModel();

            materias = materiasSv.GetMateriasPrimas();

            cBoxMateriales.DataSource = materias;
            cBoxMateriales.DisplayMember = "codigo";
            cBoxMateriales.ValueMember = "id";
        }
        void LoadMateriaVenta()
        {
            List<materias_primas> materias = new List<materias_primas>();
            MateriasPrimasModel materiasSv = new MateriasPrimasModel();

            materias = materiasSv.GetMateriasVenta();

            cBoxMateriales.DataSource = materias;
            cBoxMateriales.DisplayMember = "codigo";
            cBoxMateriales.ValueMember = "id";
        }
        void LoadProveedoresClientes()
        {
            List<proveedores> proveedores = new List<proveedores>();
            ProveedorModel proveedorSv = new ProveedorModel();

            proveedores = proveedorSv.GetAll();

            cBoxProveedor.DataSource = proveedores;
            cBoxProveedor.DisplayMember = "razon_social";
            cBoxProveedor.ValueMember = "id";
            cBoxProveedor.SelectedIndex = -1;
            cBoxProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cBoxProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;

            List<clientes> clientes = new List<clientes>();
            ClientesModel clientesSV = new ClientesModel();

            clientes = clientesSV.GetAll();

            cBoxCliente.DataSource = clientes;
            cBoxCliente.DisplayMember = "razon_social";
            cBoxCliente.ValueMember = "id";
            cBoxCliente.SelectedIndex = -1;
            cBoxCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cBoxCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        void LoadTipoCamiones()
        {
            List<tipo_camiones> tiposCamiones = new List<tipo_camiones>();
            TipoCamionesModel tipoCamionesSv = new TipoCamionesModel();

            tiposCamiones = tipoCamionesSv.GetAll();

            cBoxTipoCamion.DataSource = tiposCamiones;
            cBoxTipoCamion.DisplayMember = "codigo";
            cBoxTipoCamion.ValueMember = "id";
            cBoxTipoCamion.SelectedIndex = -1;
        }

        #endregion

        #region BOTONES

        //NAVEGACION ENTRE TABS
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabProveedor)
            {
                ValidarCamion();
                ValidarPatenteAcoplado();
            }

            if (!CongelarEvento)
            {
                if (tabControl1.SelectedTab != tabControl1.TabPages[tabControl1.TabCount - 1])
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.SelectedIndex + 1];
                }
            }
        }
        //NAVEGACION ENTRE TABS
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (!CongelarEvento)
            {
                if (tabControl1.SelectedTab != tabControl1.TabPages[0])
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.SelectedIndex - 1];
                }
            }
        }

        //BOTON ASIGNAR TARJETA
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            RegistrosTarjetasModelo registroSv = new RegistrosTarjetasModelo();
            registros_tarjetas unRegistro = registroSv.FindUltimoRegistro(txtTarjeta.Text);

            if (unRegistro != null && unRegistro.fecha.Date == DateTime.Today.Date)
            {
                Alertas.ShowError("La tarjeta ya ha sido asignada.");
                //UpdateRegistro(unRegistro);
            }
            else
            {
                IngresarNuevoRegistro();
            }
        }

        #endregion

        #region METODOS

        //ABRO COMUNICACION CON LECTOR
        void SetPuertos()
        {
            this.lectorCOM = Globales.lectorCOM;
            if (lectorCOM != null)
            {
                switchLectorTarjeta.Value = false;

                if (lectorCOM.IsOpen)
                {
                    Globales.lectorCOM.DataReceived += new SerialDataReceivedEventHandler(lectorCOM_DataReceived);
                    switchLectorTarjeta.Value = true;
                }
            }
            else
            {
                switchLectorTarjeta.Value = false;
            }
        }

        //VACIO CAMPOS
        void LimpiarCampos()
        {
            radCarga.Checked = false;
            radDescarga.Checked = true;
            raddevolucion.Checked = false;

            cBoxMateriales.SelectedIndex = -1;

            cBoxCliente.Visible = false;
            cBoxProveedor.Visible = true;
            cBoxCliente.SelectedIndex = -1;
            cBoxProveedor.SelectedIndex = -1;

            cBoxTipoCamion.SelectedIndex = -1;

            txtNombre.Text = null;
            txtPatente.Text = null;
            txtObservaciones.Text = null;
        }

        //ALTA DE NUEVO REGISTRO
        void IngresarNuevoRegistro()
        {
            //VALIDACIONES

            //VALIDA QUE HAYA UN CLIENTE O PROVEEDOR
            if (cBoxCamiones.SelectedItem == null)
            {
                Alertas.ShowError("Camión es requerido");
                return;
            }

            if (cBoxMateriales.SelectedItem == null)
            {
                Alertas.ShowError("Material es requerido");
                return;
            }

            if (string.IsNullOrEmpty(txtTarjeta.Text))
            {
                Alertas.ShowError("Tarjeta es requerido");
                return;
            }

            //DATOS DEL NUEVO REGISTRO

            registros_tarjetas nuevoRegistro = new registros_tarjetas();

            nuevoRegistro.fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            nuevoRegistro.nro_tarjeta = txtTarjeta.Text.ToUpper();

            if (radCliente.Checked && cBoxCamiones.SelectedItem != null)
            {
                ClienteCamionesModel clienteCamionSv = new ClienteCamionesModel();
                cliente_camiones clienteCamion = clienteCamionSv.FindByCamionYCliente( ((camiones)cBoxCamiones.SelectedItem).id,  ((clientes)cBoxCliente.SelectedItem).id );

                nuevoRegistro.cliente_id = clienteCamion.cliente_id;
                nuevoRegistro.camion_id = clienteCamion.camion_id;
            }

            if (radProveedor.Checked && cBoxCamiones.SelectedItem != null)
            {
                ProveedorCamionesModel proveedorCamionesSv = new ProveedorCamionesModel();
                proveedor_camiones proveedorCamion = proveedorCamionesSv.FindByCamionYProveedor(((camiones)cBoxCamiones.SelectedItem).id, ((proveedores)cBoxProveedor.SelectedItem).id);

                nuevoRegistro.proveedor_id = proveedorCamion.proveedor_id;
                nuevoRegistro.camion_id = proveedorCamion.camion_id;
            }

            nuevoRegistro.patente_acoplado = txtPatente.Text.ToUpper();
            nuevoRegistro.materias_primas_id = ((materias_primas)cBoxMateriales.SelectedItem).id;
            nuevoRegistro.carga_sn = radCarga.Checked;
            nuevoRegistro.descarga_sn = radDescarga.Checked;
            nuevoRegistro.devolucion_sn = raddevolucion.Checked;
            nuevoRegistro.nombre = txtNombre.Text;
            nuevoRegistro.observacion_planta = txtBoxObservaciones.Text;
            nuevoRegistro.habilitado_sn = true;
            nuevoRegistro.created_at = DateTime.Now;
            nuevoRegistro.updated_at = DateTime.Now;

            users usuarioLogeado = Globales.GetCurrentUser();
            nuevoRegistro.user_id = usuarioLogeado.id;

            //RESULTADO DEL INSERT
            RegistrosTarjetasModelo registroSv = new RegistrosTarjetasModelo();
            Resultado resultado = registroSv.Insertar(nuevoRegistro);

            if (!resultado.isOk)
            {
                Alertas.ShowError(resultado.error);
                return;
            }

            Alertas.ShowExito("Tarjeta Asignada!");
            formPadre.ShowOperaciones();
        }

        //ACTUALIZO REGISTRO
        void UpdateRegistro(registros_tarjetas unRegistro)
        {
            //VALIDA QUE HAYA UN CLIENTE O PROVEEDOR
            if (cBoxCamiones.SelectedItem == null)
            {
                Alertas.ShowError("Camión es requerido");
                return;
            }

            if (string.IsNullOrEmpty(txtTarjeta.Text))
            {
                Alertas.ShowError("Tarjeta es requerido");
                return;

            }

            unRegistro.fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            unRegistro.nro_tarjeta = txtTarjeta.Text.ToUpper();

            if (radCliente.Checked && cBoxCamiones.SelectedItem != null)
            {
                ClienteCamionesModel clienteCamionSv = new ClienteCamionesModel();
                cliente_camiones clienteCamion = clienteCamionSv.FindByCamionYCliente(((camiones)cBoxCamiones.SelectedItem).id, ((clientes)cBoxCliente.SelectedItem).id);

                unRegistro.proveedor_id = null;
                unRegistro.cliente_id = clienteCamion.cliente_id;
                unRegistro.camion_id = clienteCamion.camion_id;
            }

            if (radProveedor.Checked && cBoxCamiones.SelectedItem != null)
            {
                ProveedorCamionesModel proveedorCamionesSv = new ProveedorCamionesModel();
                proveedor_camiones proveedorCamion = proveedorCamionesSv.FindByCamionYProveedor(((camiones)cBoxCamiones.SelectedItem).id, ((proveedores)cBoxProveedor.SelectedItem).id);

                unRegistro.cliente_id = null;
                unRegistro.proveedor_id = proveedorCamion.proveedor_id;
                unRegistro.camion_id = proveedorCamion.camion_id;
            }

            unRegistro.patente_acoplado = txtPatente.Text.ToUpper();
            unRegistro.materias_primas_id = ((materias_primas)cBoxMateriales.SelectedItem).id;
            unRegistro.carga_sn = radCarga.Checked;
            unRegistro.descarga_sn = radDescarga.Checked;
            unRegistro.devolucion_sn = raddevolucion.Checked;
            unRegistro.nombre = txtNombre.Text;
            unRegistro.observacion_planta = txtBoxObservaciones.Text;
            unRegistro.habilitado_sn = true;
            unRegistro.created_at = DateTime.Now;
            unRegistro.updated_at = DateTime.Now;

            users usuarioLogeado = Globales.GetCurrentUser();
            unRegistro.user_id = usuarioLogeado.id;

            //RESULTADO DEL EDITAR
            RegistrosTarjetasModelo registroSv = new RegistrosTarjetasModelo();
            Resultado resultado = registroSv.Editar(unRegistro);

            if (!resultado.isOk)
            {
                Alertas.ShowError(resultado.error);
                return;
            }

            Alertas.ShowExito("Tarjeta Asignada!");
            formPadre.ShowOperaciones();
        }

        //VERIFICA LA PATENTE
        bool ValidarPatente(string patente)
        {
            Regex patenteVieja = new Regex("^[A-Z]{3}[0-9]{3}$");
            Regex patenteNueva = new Regex("[A-Z]{2}[0-9]{3}[A-Z]{2}$");

            if (!patenteVieja.IsMatch(patente) && !patenteNueva.IsMatch(patente))
            {
                Alertas.ShowError("Patente no válida.\nEjemplos:\n ABC321\n AB123CD");
                return false;
            }
            else
            {
                return true;
            }
        }

        //VERIFICA LA PATENTE DEL ACOPLADO
        void ValidarPatenteAcoplado()
        {
            if(!string.IsNullOrEmpty(txtPatente.Text))
            {
                string patente = txtPatente.Text.ToUpper();

                if(!ValidarPatente(patente))
                {
                    txtPatente.Text = null;
                }
            }
        }
        //VERIFICA EL CAMION
        void ValidarCamion()
        {
            if (cBoxCamiones.SelectedItem == null
                && !string.IsNullOrEmpty(cBoxCamiones.Text))
            {
                CamionesModel camionesSv = new CamionesModel();
                camiones camion = new camiones();


                //VALIDO PATENTE
                string patente = cBoxCamiones.Text.ToUpper();

                if(!ValidarPatente(patente))
                {
                    cBoxCamiones.Text = null;
                    return;
                }

                //BUSCO POR PATENTE
                camion = camionesSv.FindByPatente(patente);

                //INGRESO CAMION SI NO EXISTE
                if (camion == null)
                {
                    if(radProveedor.Checked)
                    {
                        //MUESTRO ALERTA CREAR CAMION
                        Alertas.ShowCrearCamion(patente, (proveedores)cBoxProveedor.SelectedItem);
                        UpdateCamionesProveedor();
                    }
                    else
                    {
                        //MUESTRO ALERTA CREAR CAMION
                        Alertas.ShowCrearCamion(patente, (clientes)cBoxCliente.SelectedItem);
                        UpdateCamionesCliente();
                    }
                    //SELECCIONO EL INGRESADO
                    cBoxCamiones.SelectedIndex = cBoxCamiones.Items.Count - 1;
                }
                //SI EXISTE VEO SI ESTA ASGINADO O NO
                else
                {
                    //VEO SI ES PARA UN PROVEEDOR O UN CLIENTE
                    if (radProveedor.Checked)
                    {
                        ProveedorCamionesModel proveedorCamionSv = new ProveedorCamionesModel();
                        proveedor_camiones proveedorCamion = new proveedor_camiones();

                        //BUSCO SI EXISTE EL PROVEEDOR CAMION
                        proveedorCamion = proveedorCamionSv.FindByCamionYProveedor(camion.id, ((proveedores)cBoxProveedor.SelectedItem).id);

                        if (proveedorCamion == null)
                        {
                            //MUESTRO ALERTA ASIGNAR CAMION
                            Alertas.ShowAsignarCamion(camion, (proveedores)cBoxProveedor.SelectedItem);
                            UpdateCamionesProveedor();
                        }
                    }

                    if (radCliente.Checked)
                    {
                        ClienteCamionesModel clienteCamionSv = new ClienteCamionesModel();
                        cliente_camiones clienteCamion = new cliente_camiones();

                        //BUSCO SI EXISTE EL CLIENTE CAMION
                        clienteCamion = clienteCamionSv.FindByCamionYCliente(camion.id, ((clientes)cBoxCliente.SelectedItem).id);

                        if (clienteCamion == null)
                        {
                            //MUESTRO ALERTA ASIGNAR CAMION
                            Alertas.ShowAsignarCamion(camion, (clientes)cBoxCliente.SelectedItem);
                            UpdateCamionesCliente();
                        }
                    }

                    //SELECCIONO EL ASIGNADO
                    cBoxCamiones.SelectedIndex = cBoxCamiones.Items.Count - 1;
                }
            }
        }
        //SELECCIONA PROVEEDOR
        void UpdateEntidadProveedor()
        {
            radProveedor.Checked = true;
            radCliente.Checked = false;
        }

        //SELECCIONA CLIENTE
        void UpdateEntidadCliente()
        {
            radCliente.Checked = true;
            radProveedor.Checked = false;
        }

        //FILL DE CBOX CAMIONES PROVEEDOR
        void UpdateCamionesProveedor()
        {
            if (cBoxProveedor.SelectedItem != null)
            {
                proveedores proveedor = (proveedores)cBoxProveedor.SelectedItem;

                CamionesModel camionesSV = new CamionesModel();
                List<camiones> camiones = new List<camiones>();

                camiones = camionesSV.GetCamionesByProveedor(proveedor.id);

                cBoxCamiones.Enabled = true;
                cBoxCamiones.DataSource = camiones;
                cBoxCamiones.DisplayMember = "patente_chasis";
                cBoxCamiones.ValueMember = "id";
                cBoxCamiones.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cBoxCamiones.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else
            {
                cBoxCamiones.Enabled = false;
                cBoxCamiones.DataSource = null;
            }
        }

        //FILL DE CBOX CAMIONES CLIENTES
        void UpdateCamionesCliente()
        {
            if (cBoxCliente.SelectedItem != null)
            {
                clientes cliente = (clientes)cBoxCliente.SelectedItem;

                CamionesModel camionesSV = new CamionesModel();
                List<camiones> camiones = new List<camiones>();

                camiones = camionesSV.GetCamionesByCliente(cliente.id);

                cBoxCamiones.Enabled = true;
                cBoxCamiones.DataSource = camiones;
                cBoxCamiones.DisplayMember = "patente_chasis";
                cBoxCamiones.ValueMember = "id";
                cBoxCamiones.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cBoxCamiones.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else
            {
                cBoxCamiones.Enabled = false;
                cBoxCamiones.DataSource = null;
            }
        }

        #endregion

        #region COMPORTAMIENTO

        //CHECK RAD PROVEEDORES
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtProveedores.Text = "Proveedores";

            cBoxProveedor.Visible = true;
            cBoxCliente.Visible = false;

            UpdateCamionesProveedor();
        }

        //CHECK RAD CLIENTES
        private void radCliente_CheckedChanged(object sender, EventArgs e)
        {
            txtProveedores.Text = "Clientes";

            cBoxProveedor.Visible = false;
            cBoxCliente.Visible = true;

            UpdateCamionesCliente();
        }

        //UPDATE TIPO CAMION SEGUN CAMION SELECCIONADO
        private void cBoxCamiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxCamiones.SelectedItem != null)
            {
                TipoCamionesModel tipoCamionSv = new TipoCamionesModel();
                tipo_camiones tipoCamion = new tipo_camiones();

                tipoCamion = tipoCamionSv.FindById(((camiones)cBoxCamiones.SelectedItem).tipo_camion_id);

                if (tipoCamion != null)
                {
                    cBoxTipoCamion.SelectedValue = tipoCamion.id;
                }
            }
        }

        //UPDATE COMBO BOX CAMIONES PROVEEDORES
        private void cBoxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCamionesProveedor();
        }

        //UPDATE COMBO BOX CAMIONES CLIENTES
        private void cBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCamionesCliente();
        }

        //CHEK DE RADS PARA TIPO DE MOVIMIENTO
        //CARGA
        private void radCarga_CheckedChanged(object sender, EventArgs e)
        {
            LoadMateriaVenta();
            UpdateEntidadCliente();
        }
        //DEVOLUCION
        private void raddevolucion_CheckedChanged(object sender, EventArgs e)
        {
            LoadMateriaVenta();
            UpdateEntidadCliente();
        }
        //DESCARGA
        private void radDescarga_CheckedChanged(object sender, EventArgs e)
        {
            LoadMateriaPrima();
            UpdateEntidadProveedor();
        }

        //LECTURA DE COMBO CAMIONES, SI NO EXISTE LO CREO, SI NO ESTA ASIGNADO LO ASIGNO
        private void cBoxCamiones_Leave(object sender, EventArgs e)
        {
            if (!CongelarEvento)
            {
                ValidarCamion();
            }
        }

        //LECTURA PATENTE ACOPLADO
        private void txtPatente_Leave(object sender, EventArgs e)
        {
            if (!CongelarEvento && !string.IsNullOrEmpty(txtPatente.Text))
            {
                string patente = txtPatente.Text.ToUpper();
                if (!ValidarPatente(patente))
                {
                    txtPatente.Text = null;
                    return;
                }
            }
        }
        #endregion

        #region FORMATO

        private void radCarga_MouseEnter(object sender, EventArgs e)
        {
            txtTipoMovimiento.LineIdleColor = Color.FromArgb(250, 129, 36);
        }

        private void radCarga_MouseLeave(object sender, EventArgs e)
        {
            txtTipoMovimiento.LineIdleColor = Color.Gray;
        }

        private void cBoxMateriales_MouseEnter(object sender, EventArgs e)
        {
            txtMaterial.LineIdleColor = Color.FromArgb(250, 129, 36);
        }

        private void cBoxMateriales_MouseLeave(object sender, EventArgs e)
        {
            txtMaterial.LineIdleColor = Color.Gray;
        }

        private void panelEntidad_MouseEnter(object sender, EventArgs e)
        {
            txtEntidad.LineIdleColor = Color.FromArgb(250, 129, 36);
        }

        private void txtEntidad_MouseLeave(object sender, EventArgs e)
        {
            txtEntidad.LineIdleColor = Color.Gray;
        }

        private void panelClienteProveedor_MouseEnter(object sender, EventArgs e)
        {
            txtProveedores.LineIdleColor = Color.FromArgb(250, 129, 36);
        }

        private void panelClienteProveedor_MouseLeave(object sender, EventArgs e)
        {
            txtProveedores.LineIdleColor = Color.Gray;
        }

        private void panelCBoxCamion_MouseEnter(object sender, EventArgs e)
        {
            txtCamion.LineIdleColor = Color.FromArgb(250, 129, 36);
        }

        private void panelCBoxCamion_MouseLeave(object sender, EventArgs e)
        {
            txtCamion.LineIdleColor = Color.Gray;
        }

        private void panel1_MouseEnter_1(object sender, EventArgs e)
        {
            txtTipoCamion.LineIdleColor = Color.FromArgb(250, 129, 36);
        }

        private void panel1_MouseLeave_1(object sender, EventArgs e)
        {
            txtTipoCamion.LineIdleColor = Color.Gray;
        }

        private void txtNombre_MouseEnter(object sender, EventArgs e)
        {
            txtNombre.LineIdleColor = Color.FromArgb(250, 129, 36);
        }

        private void txtNombre_MouseLeave(object sender, EventArgs e)
        {
            txtNombre.LineIdleColor = Color.Gray;
        }

        private void txtPatente_MouseEnter(object sender, EventArgs e)
        {
            txtPatente.LineIdleColor = Color.FromArgb(250, 129, 36);
        }

        private void txtPatente_MouseLeave(object sender, EventArgs e)
        {
            txtPatente.LineIdleColor = Color.Gray;
        }


        private void btnFinalizar_Enter(object sender, EventArgs e)
        {
            btnFinalizar.IdleForecolor = Color.FromArgb(250, 129, 36);
            btnFinalizar.IdleLineColor = Color.FromArgb(250, 129, 36);
            btnFinalizar.IdleBorderThickness = 2;
        }

        private void btnFinalizar_Leave(object sender, EventArgs e)
        {
            btnFinalizar.IdleForecolor = Color.Gray;
            btnFinalizar.IdleLineColor = Color.Gray;
            btnFinalizar.IdleBorderThickness = 1;
        }

        #endregion

        #region PUERTOS

        void LoadUltimoRegistro()
        {
            RegistrosTarjetasModelo registroSv = new RegistrosTarjetasModelo();
            registros_tarjetas ultimoRegistro = registroSv.FindUltimoRegistro(txtTarjeta.Text);

            if (ultimoRegistro != null)
            {
                lblSinRegistro.Visible = false;

                //AUTO FILL DE DATOS
                radCarga.Checked = ultimoRegistro.carga_sn;
                radDescarga.Checked = ultimoRegistro.descarga_sn;
                raddevolucion.Checked = ultimoRegistro.devolucion_sn;
                cBoxMateriales.SelectedValue = ultimoRegistro.materias_primas_id;
                txtNombre.Text = ultimoRegistro.nombre;
                txtPatente.Text = ultimoRegistro.patente_acoplado;

                if (ultimoRegistro.proveedor_id != null)
                {
                    ProveedorCamionesModel proveedorCamionSv = new ProveedorCamionesModel();
                    proveedor_camiones proveedorCamion = proveedorCamionSv.FindByCamionYProveedor(ultimoRegistro.camion_id, (int)ultimoRegistro.proveedor_id);

                    if (proveedorCamion != null)
                    {
                        cBoxProveedor.SelectedValue = proveedorCamion.proveedor_id;
                        cBoxCamiones.SelectedValue = proveedorCamion.camion_id;
                    }
                    else
                    {
                        cBoxProveedor.SelectedIndex = -1;
                        cBoxCamiones.SelectedItem = -1;
                    }
                }
                else
                {
                    ClienteCamionesModel clienteCamionSv = new ClienteCamionesModel();
                    cliente_camiones clienteCamion = clienteCamionSv.FindByCamionYCliente(ultimoRegistro.camion_id, (int)ultimoRegistro.cliente_id);

                    if (clienteCamion != null)
                    {
                        cBoxCliente.SelectedValue = clienteCamion.cliente_id;
                        cBoxCamiones.SelectedValue = clienteCamion.camion_id;
                    }
                    else
                    {
                        cBoxProveedor.SelectedIndex = -1;
                        cBoxCamiones.SelectedItem = -1;
                    }
                }
            }
            else
            {
                //VACIO CAMPOS
                lblSinRegistro.Visible = true;
                LimpiarCampos();
            }
        }

        void LeerTarjeta(object sender, EventArgs e)
        {
            try
            {
                lblTarjetaError.Visible = false;
                dataInTarjeta = "";
                dataInTarjeta = lectorCOM.ReadExisting();
                EscribirLogLector(dataInTarjeta);

                Regex ex = new Regex("^[a-zA-Z0-9]+$");

                if (!string.IsNullOrEmpty(dataInTarjeta))
                {
                    Regex regex = new Regex("^[A-Z0-9]+$");
                    string nroFiltrado = "";

                    foreach (char ch in dataInTarjeta)
                    {
                        if (regex.IsMatch(ch.ToString()))
                        {
                            nroFiltrado += ch;
                        }
                    }

                    txtTarjeta.Text = nroFiltrado;
                    LoadUltimoRegistro();
                }
                else
                {
                    //VACIO CAMPOS
                    lblTarjetaError.Visible = true;
                    txtTarjeta.Text = null;
                    LimpiarCampos();
                }
            }
            catch (Exception ex) { Alertas.ShowError("Error en el lector de tarjetas."); }
            finally
            {
                lectorCOM.DiscardInBuffer();
                lectorCOM.DiscardOutBuffer();
            }
        }

        //CONEXION PUERTO LECTOR TARJETA
        public void TarjetaCOM(string portName, int baudRate, int dataBit, StopBits stopBits, Parity parityBits)
        {
            lectorCOM.PortName = portName;
            lectorCOM.BaudRate = baudRate;
            lectorCOM.DataBits = dataBit;
            lectorCOM.StopBits = stopBits;
            lectorCOM.Parity = parityBits;

            lectorCOM.Open();
            switchLectorTarjeta.Value = true;
        }

        public void EndTarjetaCOM()
        {
            if(lectorCOM != null && lectorCOM.IsOpen)
            {
                switchLectorTarjeta.Value = false;
                lectorCOM.Close();
            }
        }

        private void bunifuSeparator5_Click(object sender, EventArgs e)
        {
            //PuertosForm puertosForm = new PuertosForm(this);

            ////FADE BAKGROUND
            //Form backGround = new Form();

            //backGround.StartPosition = FormStartPosition.Manual;
            //backGround.Location = new Point(Form1.ActiveForm.Location.X, Form1.ActiveForm.Location.Y);
            //backGround.Size = new Size(1128, 717);
            //backGround.FormBorderStyle = FormBorderStyle.None;
            //backGround.Opacity = .70d;
            //backGround.BackColor = Color.Black;
            //backGround.ShowInTaskbar = false;

            //backGround.Show();

            //puertosForm.ShowDialog();

            //backGround.Close();
            //backGround.Dispose();
        }

        //LEE PUERTO SERIE
        private void lectorCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (IsHandleCreated)
            {
                if (InvokeRequired)
                {
                    this.Invoke(new EventHandler(LeerTarjeta));
                }
            }
        }

        #endregion

        #region AUXILIAR

        void EscribirLogLector(string mensaje)
        {
            string logPath = AppDomain.CurrentDomain.BaseDirectory + $"PuertosLog.txt";
            try
            {
                if (!File.Exists(logPath))
                {
                    File.Create(logPath);
                }

                using (StreamWriter tw = new StreamWriter(logPath, true))
                {
                    tw.WriteLine("\n" + DateTime.Now.ToString() + " Puerto Lector Despacho: " + mensaje);
                    tw.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void picActualizar_Click(object sender, EventArgs e)
        {
            SetPuertos();
        }

        #endregion
    }
}

