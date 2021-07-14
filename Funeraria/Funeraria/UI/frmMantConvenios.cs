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
    public partial class frmMantConvenios : Form
    {
        public frmMantConvenios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            try
            {
                errPro.Clear();

                if (string.IsNullOrEmpty(this.txtIdConvenio.Text))
                {
                    errPro.SetError(txtIdConvenio, "Id requerido");
                    this.txtIdConvenio.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    errPro.SetError(txtNombre, "Nombre requerido");
                    this.txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtUbicacion.Text))
                {
                    errPro.SetError(txtUbicacion, "Ubicacion requerida");
                    this.txtUbicacion.Focus();
                    return;
                }
                
                if (string.IsNullOrEmpty(this.txtDescuento.Text))
                {
                    errPro.SetError(txtDescuento, "Descuento requerido");
                    this.txtDescuento.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtComentario.Text))
                {
                    errPro.SetError(txtComentario, "Comentario requerido");
                    this.txtComentario.Focus();
                    return;
                }

                IBLLConvenios _BllConvenios = new BLLConvenios();
                Convenios oConvenios = new Convenios();
                oConvenios.IdConvenio = int.Parse(this.txtIdConvenio.Text);
                oConvenios.NomEmpresa = this.txtNombre.Text;
                oConvenios.ubicacion = this.txtUbicacion.Text;
                oConvenios.TelCelular = this.txtTelCelular.Text;
                oConvenios.TelEmpresa = this.txtTelEmpresa.Text;
                oConvenios.TelFax = this.txtTelFax.Text;
                oConvenios.TipoServicio = (cboTipoServicio.SelectedItem as TipoServicio).IdTipoServicio;
                oConvenios.Comentarios = this.txtComentario.Text;
                oConvenios.Descuento = int.Parse(this.txtDescuento.Text);
                if (cboEstado.SelectedIndex == 0)
                {
                    oConvenios.Estado = true;
                }
                else
                {
                    oConvenios.Estado = false;
                }
                if (_BllConvenios.SaveConvenios(oConvenios) != null)
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

        }

        private void frmMantConvenios_Load(object sender, EventArgs e)
        {
            llenarCombos();
            llenarDatos();
            CambiarEstado(MantenimientoEnum.Ninguno);
        }
        public void llenarDatos()
        {
            IBLLConvenios _BLLConvenios = new BLLConvenios();
            List<ConveniosDTO> lista = new List<ConveniosDTO>();
            lista = _BLLConvenios.GetAllConvenios();
            dtGVListado.AutoGenerateColumns = false;
            dtGVListado.RowTemplate.Height = 50;
            dtGVListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dtGVListado.DataSource = _BLLConvenios.GetAllConvenios(); ;
        }
        public void llenarCombos()
        {
            IBLLTipoServicio _BLLTipoServicio = new BLLTipoServicio();

            this.cboTipoServicio.Items.Clear();
            this.cboEstado.Items.Clear();
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
            IBLLActivo _BllActivo = new BLLActivo();
            this.txtIdConvenio.Text = "";
            this.txtNombre.Text = "";
            this.txtUbicacion.Text = "";
            this.txtTelCelular.Text = "";
            this.txtTelEmpresa.Text = "";
            this.txtTelFax.Text = "";
            this.txtDescuento.Text = "1";
            this.txtComentario.Text = "";
            this.cboTipoServicio.SelectedIndex = 0;
            this.cboEstado.SelectedIndex = 0;


            this.txtIdConvenio.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtUbicacion.Enabled = false;
            this.txtTelCelular.Enabled = false;
            this.txtTelEmpresa.Enabled = false;
            this.txtTelFax.Enabled = false;
            this.txtDescuento.Enabled = false;
            this.txtComentario.Enabled = false;
            this.cboTipoServicio.Enabled = false;
            this.cboEstado.Enabled = false;

            switch (estado)
            {
                case MantenimientoEnum.Nuevo:
                    this.txtIdConvenio.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtUbicacion.Enabled = true;
                    this.txtTelCelular.Enabled = true;
                    this.txtTelEmpresa.Enabled = true;
                    this.txtTelFax.Enabled = true;
                    this.txtDescuento.Enabled = true;
                    this.txtComentario.Enabled = true;
                    this.cboTipoServicio.Enabled = true;
                    this.cboEstado.Enabled = true;

                    this.txtIdConvenio.Focus();
                    break;
                case MantenimientoEnum.Editar:
                    this.txtIdConvenio.Enabled = false;
                    this.txtNombre.Enabled = true;
                    this.txtUbicacion.Enabled = true;
                    this.txtTelCelular.Enabled = true;
                    this.txtTelEmpresa.Enabled = true;
                    this.txtTelFax.Enabled = true;
                    this.txtDescuento.Enabled = true;
                    this.txtComentario.Enabled = true;
                    this.cboTipoServicio.Enabled = true;
                    this.cboEstado.Enabled = true;
                    this.txtNombre.Focus();
                    break;
                case MantenimientoEnum.Borrar:
                    break;
                case MantenimientoEnum.Ninguno:
                    break;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ConveniosDTO oConveniosDTO = null;
                IBLLConvenios _BllConvenios = new BLLConvenios();

                if (this.dtGVListado.SelectedRows.Count > 0)
                {
                    CambiarEstado(MantenimientoEnum.Editar);
                    oConveniosDTO = dtGVListado.SelectedRows[0].DataBoundItem as ConveniosDTO;
                    this.txtIdConvenio.Text = oConveniosDTO.IdConvenio.ToString();
                    this.txtNombre.Text = oConveniosDTO.NomEmpresa;
                    this.txtUbicacion.Text = oConveniosDTO.ubicacion;
                    this.txtTelCelular.Text = oConveniosDTO.TelCelular;
                    this.txtTelEmpresa.Text = oConveniosDTO.TelEmpresa;
                    this.txtTelFax.Text = oConveniosDTO.TelFax;
                    this.txtDescuento.Text = oConveniosDTO.Descuento.ToString();
                    this.txtComentario.Text = oConveniosDTO.Comentarios.ToString();
                    this.cboEstado.SelectedIndex = cboEstado.FindString(oConveniosDTO.Estado.ToString());
                    this.cboTipoServicio.SelectedIndex = cboTipoServicio.FindString(oConveniosDTO.TipoServicio.ToString());
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ConveniosDTO oConvenios = null;
                IBLLConvenios _BllConvenios = new BLLConvenios();
                if (this.dtGVListado.SelectedRows.Count > 0)
                {
                    oConvenios = dtGVListado.SelectedRows[0].DataBoundItem as ConveniosDTO;
                    if (oConvenios != null)
                    {
                        if (MessageBox.Show($"¿Seguro que desea borrar el registro {oConvenios.IdConvenio} {oConvenios.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _BllConvenios.DaleteConvenios(oConvenios.IdConvenio);
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
    }
}
