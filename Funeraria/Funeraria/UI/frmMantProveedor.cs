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
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
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
            IBLLTipoServicio _BLLTipoServicio = new BLLTipoServicio();
            List<Proveedor> lista = _BLLProveedores.GetAllProveedor();
            List<TipoServicio> listaTipo = _BLLTipoServicio.GetAllTipoServicio();
            List<ProveedorDTO> listaProveedorDTO = new List<ProveedorDTO>();
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 50;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            String desc = "";
            foreach (Proveedor item in lista)
            {
                ProveedorDTO oActivoDto = new ProveedorDTO();
                foreach (TipoServicio act in listaTipo)
                {
                    if (act.IdTipoServicio == item.IdTipoServicio)
                    {
                        desc = act.Descripcion;
                    }
                }
                oActivoDto.IdProveedor = item.IdProveedor;
                oActivoDto.NomProveedor = item.NomProveedor;
                oActivoDto.Propietario = item.Propietario;
                oActivoDto.TelCelular = item.TelCelular; ;
                oActivoDto.TelProveedor = item.TelProveedor;
                oActivoDto.TelFax = item.TelFax;
                oActivoDto.Correo = item.Correo;
                oActivoDto.Precio = item.Precio.ToString("₡" + "#,##0");
                oActivoDto.CantUni = item.CantUni;
                oActivoDto.Servicio = desc;

                if (item.Estado == true)
                {
                    oActivoDto.Estado = "Activo";
                }
                else
                {
                    oActivoDto.Estado = "Inactivo";
                }
                listaProveedorDTO.Add(oActivoDto);
            }
            dgvDatos.DataSource = listaProveedorDTO;

        }
        public void llenarCombos()
        {
            IBLLTipoServicio _BLLTipoServicio = new BLLTipoServicio();

            this.cboEstado.Items.Clear();
            this.cboTipoServicio.Items.Clear();
            foreach (TipoServicio item in _BLLTipoServicio.GetAllTipoServicio())
            {
                this.cboTipoServicio.Items.Add(item);
            }
            this.cboEstado.Items.Add("Activo");
            this.cboEstado.Items.Add("Inactivo");
            this.cboEstado.SelectedIndex = 0;
            this.cboTipoServicio.SelectedIndex = 0;
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

            this.txtId.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtPropietario.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtCelular.Enabled = false;
            this.txtFax.Enabled = false;
            this.txtCorreo.Enabled = false;
            this.txtPrecio.Enabled = false;
            this.txtCantidad.Enabled = false;
            this.cboEstado.Enabled = false;
            this.cboTipoServicio.Enabled = false;

            switch (estado)
            {
                case MantenimientoEnum.Nuevo:
                    this.txtId.Text = _BllProveedor.GetNextNumeroActivo().ToString();
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
                oProveedores.IdProveedor = int.Parse(this.txtId.Text);
                oProveedores.NomProveedor = this.txtNombre.Text;
                oProveedores.Propietario = this.txtPropietario.Text;
                oProveedores.TelCelular = this.txtCelular.Text;
                oProveedores.TelProveedor = this.txtTelefono.Text;
                oProveedores.TelFax = this.txtFax.Text;
                oProveedores.Correo = this.txtCorreo.Text;
                oProveedores.Precio = int.Parse(this.txtPrecio.Text);
                oProveedores.CantUni = int.Parse(this.txtCantidad.Text);
                oProveedores.IdTipoServicio = (cboTipoServicio.SelectedItem as TipoServicio).IdTipoServicio;
               
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
                    llenarCombos();
                    llenarDatos();
                    CambiarEstado(MantenimientoEnum.Ninguno);
                }
            }
            catch (Exception)
            {

                throw;
            }
            llenarCombos();
            llenarDatos();
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
                    this.cboTipoServicio.SelectedIndex = cboTipoServicio.FindString(oProveedorDTO.Servicio.ToString());
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception er)
            {

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedorDTO oProveedorDTO = null;
                IBLLProveedores _BllProveedor = new BLLProveedores();
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    oProveedorDTO = dgvDatos.SelectedRows[0].DataBoundItem as ProveedorDTO;
                    if (oProveedorDTO != null)
                    {
                        if (MessageBox.Show($"¿Seguro que desea borrar el registro {oProveedorDTO.IdProveedor} {oProveedorDTO.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
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

            }
        }

        #endregion

       
    }
}
