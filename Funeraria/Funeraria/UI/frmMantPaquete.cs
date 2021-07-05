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
    public partial class frmMantPaquete : Form
    {
        public frmMantPaquete()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        #region Mantenimeintos
        private void frmMantPaquete_Load(object sender, EventArgs e)
        {
            llenarCombos();
            llenarDatos();
            CambiarEstado(MantenimientoEnum.Ninguno);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
        public void llenarDatos()
        {
            IBLLPaquete _BLLPaquete = new BLLPaquete();
            IBLLTipoPaquete _BLLTipoPaquete = new BLLTipoPaquete();
            List<Paquete> lista = _BLLPaquete.GetAllPaquete();
            List<TipoPaquete> listaTipo = _BLLTipoPaquete.GetAllTipoPaquete();
            List<PaqueteDTO> listaActivosDTO = new List<PaqueteDTO>();
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 50;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            String desc = "";
            foreach (Paquete item in lista)
            {
                PaqueteDTO oActivoDto = new PaqueteDTO();
                foreach (TipoPaquete act in listaTipo)
                {
                    if (act.IdTipoPaquete == item.IdTipoPaquete)
                    {
                        desc = act.Descripcion;
                    }
                }
                oActivoDto.IdPaquete = item.IdPaquete;
                oActivoDto.Nombre = item.Nombre;
                oActivoDto.Descripcion = item.Descripcion;
                oActivoDto.Precio = item.Precio.ToString("₡" + "#,##0");
                oActivoDto.Cantidad = item.Cantidad;
                oActivoDto.Paquete = desc;              
                if (item.Estado == true)
                {
                    oActivoDto.Estado = "Activo";
                }
                else
                {
                    oActivoDto.Estado = "Inactivo";
                }
                listaActivosDTO.Add(oActivoDto);
            }
            dgvDatos.DataSource = listaActivosDTO;
        }
        public void llenarCombos()
        {
            IBLLTipoPaquete _BLLTipoPaquete = new BLLTipoPaquete();

            this.cboestado.Items.Clear();
            this.cboTipoPaquete.Items.Clear();
            foreach (TipoPaquete item in _BLLTipoPaquete.GetAllTipoPaquete())
            {
                this.cboTipoPaquete.Items.Add(item);
            }
            this.cboestado.Items.Add("Activo");
            this.cboestado.Items.Add("Inactivo");
            this.cboestado.SelectedIndex = 0;
            this.cboTipoPaquete.SelectedIndex = 0;
        }
        private void CambiarEstado(MantenimientoEnum estado)
        {
            IBLLProveedores _BllProveedor = new BLLProveedores();
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtDescripcion.Text = "";
            this.txtPrecio.Text = "";
            this.txtCantidad.Text = "";
            this.cboestado.SelectedIndex = 0;
            this.cboTipoPaquete.SelectedIndex = 0;

            this.txtId.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtDescripcion.Enabled = false;
            this.txtPrecio.Enabled = false;
            this.txtCantidad.Enabled = false;
            this.cboestado.Enabled = false;
            this.cboTipoPaquete.Enabled = false;

            switch (estado)
            {
                case MantenimientoEnum.Nuevo:
                    this.txtId.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtDescripcion.Enabled = true;
                    this.txtPrecio.Enabled = true;
                    this.txtCantidad.Enabled = true;
                    this.cboestado.Enabled = true;
                    this.cboTipoPaquete.Enabled = true;
                    this.txtNombre.Focus();
                    break;
                case MantenimientoEnum.Editar:
                    this.txtNombre.Enabled = true;
                    this.txtDescripcion.Enabled = true;
                    this.txtPrecio.Enabled = true;
                    this.txtCantidad.Enabled = true;
                    this.cboestado.Enabled = true;
                    this.cboTipoPaquete.Enabled = true;
                    this.txtNombre.Focus();
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
                if (string.IsNullOrEmpty(this.txtDescripcion.Text))
                {
                    errPro.SetError(txtDescripcion, "Descripcion requerido");
                    this.txtDescripcion.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtPrecio.Text))
                {
                    errPro.SetError(txtPrecio, "Precio requerido");
                    this.txtPrecio.Focus();
                    return;
                }               
                IBLLPaquete _BllPaquete = new BLLPaquete();
                Paquete oPaquete = new Paquete();
                oPaquete.IdPaquete = int.Parse(this.txtId.Text);
                oPaquete.Nombre = this.txtNombre.Text;
                oPaquete.Descripcion = this.txtDescripcion.Text;
                oPaquete.Precio = (float.Parse(this.txtPrecio.Text));
                oPaquete.Cantidad = (int)this.txtCantidad.Value;
                oPaquete.IdTipoPaquete = (cboTipoPaquete.SelectedItem as TipoPaquete).IdTipoPaquete;
                if (cboestado.SelectedIndex == 0)
                {
                    oPaquete.Estado = true;
                }
                else
                {
                    oPaquete.Estado = false;
                }
                if (_BllPaquete.SavePaquete(oPaquete) != null)
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
                PaqueteDTO oPaqueteDTO = null;
                IBLLPaquete _BllPaquete = new BLLPaquete();

                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    CambiarEstado(MantenimientoEnum.Editar);
                    oPaqueteDTO = dgvDatos.SelectedRows[0].DataBoundItem as PaqueteDTO;
                    this.txtId.Text = oPaqueteDTO.IdPaquete.ToString();
                    this.txtNombre.Text = oPaqueteDTO.Nombre;
                    this.txtDescripcion.Text = oPaqueteDTO.Descripcion;
                    this.txtPrecio.Text = oPaqueteDTO.Precio.ToString();
                    this.txtCantidad.Value = oPaqueteDTO.Cantidad;
                    this.cboestado.SelectedIndex = cboestado.FindString(oPaqueteDTO.Estado.ToString());
                    this.cboTipoPaquete.SelectedIndex = cboTipoPaquete.FindString(oPaqueteDTO.Paquete.ToString());
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
                PaqueteDTO oPaqueteDTO = null;
                IBLLPaquete _BllPaquete = new BLLPaquete();
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    oPaqueteDTO = dgvDatos.SelectedRows[0].DataBoundItem as PaqueteDTO;
                    if (oPaqueteDTO != null)
                    {
                        if (MessageBox.Show($"¿Seguro que desea borrar el registro {oPaqueteDTO.IdPaquete} {oPaqueteDTO.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _BllPaquete.DaletePaquete(oPaqueteDTO.IdPaquete);
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
        #endregion
    }
}
