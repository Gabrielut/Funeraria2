using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.BLL;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmMantProveedor : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmMantProveedor()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        #region Mantenimientos
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                CambiarEstado(MantenimientoEnum.Nuevo);
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                CambiarEstado(MantenimientoEnum.Ninguno);
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmMantProveedor_Load(object sender, EventArgs e)
        {
            llenarCombos();
            llenarDatos();
            CambiarEstado(MantenimientoEnum.Ninguno);
            toolNombre.SetToolTip(txtNombre, "Por favor digite el nombre del activo a insertar");
        }
        public void llenarDatos()
        {
            IBLLProveedores _BLLProveedores = new BLLProveedores();
            List<ProveedorDTO> lista = _BLLProveedores.GetAllProveedor();
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 50;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvDatos.DataSource = lista;

        }
        public void llenarCombos()
        {
            IBLLTipoServicio _BLLTipoServicio = new BLLTipoServicio();
            IBLLProvincia _BLLProvincia = new BLLProvincia();

            this.cboEstado.Items.Clear();
            this.cboTipoServicio.Items.Clear();
            foreach (TipoServicio item in _BLLTipoServicio.GetAllTipoServicio())
            {
                this.cboTipoServicio.Items.Add(item);
            }
            foreach (Provincia item in _BLLProvincia.GetAllProvincia())
            {
                this.cboProvincia.Items.Add(item);
            }
            this.cboEstado.Items.Add("Activo");
            this.cboEstado.Items.Add("Inactivo");
            this.cboEstado.SelectedIndex = 0;
            this.cboTipoServicio.SelectedIndex = 0;
            this.cboProvincia.SelectedIndex = 0;
        }
        private void CambiarEstado(MantenimientoEnum estado)
        {
            IBLLProveedores _BllProveedor = new BLLProveedores();
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtPropietario.Text = "";
            this.txtTelefono.Text = "";
            this.txtCelular.Text = "";
            this.txtFax.Text = "";
            this.txtCorreo.Text = "";
            this.txtPrecio.Text = "";
            this.txtCantidad.Text = "";
            this.txtOtrasSennas.Text = "";

            this.txtId.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtPropietario.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtCelular.Enabled = false;
            this.txtFax.Enabled = false;
            this.txtCorreo.Enabled = false;
            this.txtPrecio.Enabled = false;
            this.txtOtrasSennas.Enabled = false;
            this.txtCantidad.Enabled = false;
            this.cboEstado.Enabled = false;
            this.cboTipoServicio.Enabled = false;
            this.cboProvincia.Enabled = false;
            this.cboCanton.Enabled = false;
            this.cboDistrito.Enabled = false;
            this.cboBarrio.Enabled = false;

            switch (estado)
            {
                case MantenimientoEnum.Nuevo:
                    this.txtId.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtPropietario.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.txtCelular.Enabled = true;
                    this.txtFax.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.txtPrecio.Enabled = true;
                    this.txtCantidad.Enabled = true;
                    this.cboEstado.Enabled = true;
                    this.cboTipoServicio.Enabled = true;
                    this.cboProvincia.Enabled = true;
                    this.txtNombre.Focus();
                    break;
                case MantenimientoEnum.Editar:
                    this.txtId.Enabled = false;
                    this.txtNombre.Enabled = true;
                    this.txtPropietario.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.txtCelular.Enabled = true;
                    this.txtFax.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.txtPrecio.Enabled = true;
                    this.txtCantidad.Enabled = true;
                    this.cboEstado.Enabled = true;
                    this.cboTipoServicio.Enabled = true;
                    this.cboProvincia.Enabled = true;
                    this.txtNombre.Focus();
                    break;
                case MantenimientoEnum.Borrar:
                    break;
                case MantenimientoEnum.Ninguno:
                    break;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                errPro.Clear();
                if (string.IsNullOrEmpty(this.txtId.Text))
                {
                    errPro.SetError(txtId, "Id requerido");
                    this.txtId.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    errPro.SetError(txtNombre, "Nombre requerido");
                    this.txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtPropietario.Text))
                {
                    errPro.SetError(txtPropietario, "Nombre Propietario requerido");
                    this.txtPropietario.Focus();
                    return;
                }                
                if (string.IsNullOrEmpty(this.txtCorreo.Text))
                {
                    errPro.SetError(txtCorreo, "Correo requerido");
                    this.txtCorreo.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtPrecio.Text))
                {
                    errPro.SetError(txtPrecio, "Precio requerido");
                    this.txtPrecio.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtCantidad.Text))
                {
                    errPro.SetError(txtCantidad, "Cantidad requerido");
                    this.txtCantidad.Focus();
                    return;
                }

                IBLLProveedores _BllProveedores = new BLLProveedores();
                Proveedor oProveedores = new Proveedor();
                DireccionCompleta oDireccionCompleta = new DireccionCompleta();
                IBLLDireccionCompleta _BLLDireccionCompleta = new BLLDireccionCompleta();
                oProveedores.IdProveedor = int.Parse(this.txtId.Text);
                oProveedores.NomProveedor = this.txtNombre.Text;
                oProveedores.Propietario = this.txtPropietario.Text;
                oProveedores.TelCelular = this.txtCelular.Text;
                oProveedores.TelProveedor = this.txtTelefono.Text;
                oProveedores.TelFax = this.txtFax.Text;
                oProveedores.Correo = this.txtCorreo.Text;
                oProveedores.Precio = int.Parse(this.txtPrecio.Text.Replace("₡", "").Replace(",", ""));
                oProveedores.CantUni = int.Parse(this.txtCantidad.Text);
                oProveedores.IdTipoServicio = (cboTipoServicio.SelectedItem as TipoServicio).IdTipoServicio;
                oDireccionCompleta.IdDireccion = int.Parse(this.txtId.Text);
                oDireccionCompleta.Provincia = (cboProvincia.SelectedItem as Provincia).codProvincia;
                oDireccionCompleta.Canton = (cboCanton.SelectedItem as Canton).codCanton;
                oDireccionCompleta.Distrito = (cboDistrito.SelectedItem as Distrito).codDistrito;
                oDireccionCompleta.Barrio = (cboBarrio.SelectedItem as Barrio).codBarrio;
                oDireccionCompleta.OtrasSennas = txtOtrasSennas.Text;
                if (cboEstado.SelectedIndex == 0)
                {
                    oProveedores.Estado = true;
                }
                else
                {
                    oProveedores.Estado = false;
                }
                if (_BllProveedores.SaveProveedor(oProveedores) != null)
                {
                    _BLLDireccionCompleta.SaveDireccionCompleta(oDireccionCompleta);
                    llenarCombos();
                    llenarDatos();
                    CambiarEstado(MantenimientoEnum.Ninguno);
                }
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedorDTO oProveedorDTO = null;
                IBLLProveedores _BllProveedor = new BLLProveedores();

                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    CambiarEstado(MantenimientoEnum.Editar);
                    oProveedorDTO = dgvDatos.SelectedRows[0].DataBoundItem as ProveedorDTO;
                    this.txtId.Text = oProveedorDTO.IdProveedor.ToString();
                    this.txtNombre.Text = oProveedorDTO.NomProveedor;
                    this.txtPropietario.Text = oProveedorDTO.Propietario;
                    this.txtTelefono.Text = oProveedorDTO.TelProveedor;
                    this.txtCelular.Text = oProveedorDTO.TelCelular.ToString();
                    this.txtFax.Text = oProveedorDTO.TelFax.ToString();
                    this.txtCorreo.Text = oProveedorDTO.Correo.ToString();
                    this.txtPrecio.Text = oProveedorDTO.Precio.ToString();
                    this.txtCantidad.Text = oProveedorDTO.CantUni.ToString();
                    this.cboEstado.SelectedIndex = cboEstado.FindString(oProveedorDTO.Estado.ToString());
                    this.cboTipoServicio.SelectedIndex = cboTipoServicio.FindString(oProveedorDTO.IdTipoServicio.ToString());
                    this.cboProvincia.SelectedIndex = cboProvincia.FindString(oProveedorDTO.Provincia.ToString());
                    this.cboCanton.SelectedIndex = cboCanton.FindString(oProveedorDTO.Canton.ToString());
                    this.cboDistrito.SelectedIndex = cboDistrito.FindString(oProveedorDTO.Distrito.ToString());
                    this.cboBarrio.SelectedIndex = cboBarrio.FindString(oProveedorDTO.Barrio.ToString());
                    this.txtOtrasSennas.Text = oProveedorDTO.otrasSennas.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedorDTO oProveedorDTO = null;
                IBLLProveedores _BllProveedor = new BLLProveedores();
                IBLLDireccionCompleta _BllDireccionCompleta = new BLLDireccionCompleta();
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    oProveedorDTO = dgvDatos.SelectedRows[0].DataBoundItem as ProveedorDTO;
                    if (oProveedorDTO != null)
                    {
                        if (MessageBox.Show($"¿Seguro que desea borrar el registro {oProveedorDTO.IdProveedor} {oProveedorDTO.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _BllDireccionCompleta.DaleteDireccionCompleta(oProveedorDTO.IdProveedor);
                            _BllProveedor.DaleteProveedor(oProveedorDTO.IdProveedor);
                            llenarDatos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int provincia = (cboProvincia.SelectedItem as Provincia).codProvincia;
            IBLLCanton _BLLCanton = new BLLCanton();
            cboCanton.Items.Clear();
            foreach (Canton item in _BLLCanton.GetCantonById(provincia))
            {
                cboCanton.Items.Add(item);
            }
            cboCanton.Enabled = true;
            cboCanton.SelectedIndex = 0;
        }

        private void cboCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            int provincia = (cboProvincia.SelectedItem as Provincia).codProvincia;
            int canton = (cboCanton.SelectedItem as Canton).codCanton;
            IBLLDistrito _BLLDistrito = new BLLDistrito();
            cboDistrito.Items.Clear();
            foreach (Distrito item in _BLLDistrito.GetDistritoById(provincia,canton))
            {
                cboDistrito.Items.Add(item);
            }
            cboDistrito.Enabled = true;
            cboDistrito.SelectedIndex = 0;
        }
        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            int provincia = (cboProvincia.SelectedItem as Provincia).codProvincia;
            int canton = (cboCanton.SelectedItem as Canton).codCanton;
            int distrito = (cboDistrito.SelectedItem as Distrito).codDistrito;
            IBLLBarrio _BLLBarrio = new BLLBarrio();
            cboBarrio.Items.Clear();
            foreach (Barrio item in _BLLBarrio.GetBarrioById(provincia, canton, distrito))
            {
                cboBarrio.Items.Add(item);
            }
            cboBarrio.Enabled = true;
            cboBarrio.SelectedIndex = 0;
        }
        private void cboBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOtrasSennas.Enabled = true;
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
