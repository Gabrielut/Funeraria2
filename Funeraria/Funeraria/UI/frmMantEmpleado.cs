using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.BLL;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmMantEmpleado : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmMantEmpleado()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        #region Mantenimientos
        private void iconButton2_Click(object sender, EventArgs e)
        {
            CambiarEstado(MantenimientoEnum.Ninguno);
        }
        private void frmMantEmpleado_Load(object sender, EventArgs e)
        {
            llenarCombos();
            llenarDatos();
            CambiarEstado(MantenimientoEnum.Ninguno);

        }
        public void llenarDatos()
        {
            IBLLUsuarios _BLLUsuarios = new BLLUsuarios();
            IBLLRol _BLLRol = new BLLRol();
            List<Usuarios> lista = _BLLUsuarios.GetAllUsuarios();
            List<Rol> listaTipo = _BLLRol.GetAllRol();
            List<UsuariosDTO> listaUsuariosDTO = new List<UsuariosDTO>();
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 50;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            String desc = "";
            foreach (Usuarios item in lista)
            {
                UsuariosDTO oUsuariosDTO = new UsuariosDTO();
                foreach (Rol act in listaTipo)
                {
                    if (act.IDRol == item.IdRol)
                    {
                        desc = act.Descripcion;
                    }
                }
                oUsuariosDTO.IDUsuario = item.IDUsuario;
                oUsuariosDTO.Nombre = item.Nombre;
                oUsuariosDTO.PrimerApellido = item.PrimerApellido;
                oUsuariosDTO.SegundoApellido = item.SegundoApellido;
                oUsuariosDTO.Telefono = item.Telefono;
                oUsuariosDTO.IdRol = desc;
                oUsuariosDTO.Correo = item.Correo;
                //item.Precio.ToString("₡" + "#,##0");
                oUsuariosDTO.FechaNacimiento = item.FechaNacimiento.ToShortDateString();
                oUsuariosDTO.Direccion = item.Direccion;
                if (item.Estado == true)
                {
                    oUsuariosDTO.Estado = "Activo";
                }
                else
                {
                    oUsuariosDTO.Estado = "Inactivo";
                }
                if (item.Sexo == 1)
                {
                    oUsuariosDTO.Sexo = "Masculino";
                }
                else
                {
                    oUsuariosDTO.Sexo = "Femenino";
                }

                listaUsuariosDTO.Add(oUsuariosDTO);
            }
            dgvDatos.DataSource = listaUsuariosDTO;
        }
        public void llenarCombos()
        {
            IBLLSexo _BLLSexo = new BLLSexo();
            IBLLRol _BLLRol = new BLLRol();
            this.cboSexo.Items.Clear();
            this.cboRol.Items.Clear();
            foreach (Sexo item in _BLLSexo.GetAllSexo())
            {
                this.cboSexo.Items.Add(item);
            }
            foreach (Rol item in _BLLRol.GetAllRol())
            {
                this.cboRol.Items.Add(item);
            }
            this.cboSexo.SelectedIndex = 0;
            this.cboRol.SelectedIndex = 0;
        }
        private void CambiarEstado(MantenimientoEnum estado)
        {
            this.txtCedula.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido1.Text = "";
            this.txtApellido2.Text = "";
            this.txtCorreo.Text = "";
            this.txtContrasenna.Text = "";
            this.txtTelefono.Text = "";
            this.txtDireccion.Text = "";

            this.txtCedula.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtApellido1.Enabled = false;
            this.txtApellido2.Enabled = false;
            this.txtCorreo.Enabled = false;
            this.txtContrasenna.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.cboSexo.SelectedIndex = 0;
            this.cboRol.SelectedIndex = 0;
            this.cboSexo.Enabled = false;
            this.cboRol.Enabled = false;
            this.dtpFechaNac.Value = DateTime.Now;
            this.dtpFechaNac.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.rdbHabilitar.Enabled = false;
            this.rdbDesabilitar.Enabled = false;

            switch (estado)
            {
                case MantenimientoEnum.Nuevo:
                    this.txtCedula.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.txtContrasenna.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.txtDireccion.Enabled = true;
                    this.cboSexo.Enabled = true;
                    this.cboRol.Enabled = true;
                    this.dtpFechaNac.Enabled = true;
                    this.txtCedula.Focus();
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.rdbHabilitar.Enabled = true;
                    this.rdbDesabilitar.Enabled = true;
                    break;
                case MantenimientoEnum.Editar:
                    this.txtCedula.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = false;
                    this.txtContrasenna.Enabled = false;
                    this.txtTelefono.Enabled = true;
                    this.txtDireccion.Enabled = true;
                    this.cboSexo.Enabled = true;
                    this.cboRol.Enabled = true;
                    this.dtpFechaNac.Enabled = true;
                    this.txtCedula.Focus();
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.rdbHabilitar.Enabled = true;
                    this.rdbDesabilitar.Enabled = true;
                    break;
                case MantenimientoEnum.Borrar:
                    break;
                case MantenimientoEnum.Ninguno:
                    break;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                errPro.Clear();
                if (string.IsNullOrEmpty(this.txtCedula.Text))
                {
                    errPro.SetError(txtCedula, "Identificacion requerido");
                    this.txtCedula.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtApellido1.Text))
                {
                    errPro.SetError(txtApellido1, "Apellido requerido");
                    this.txtApellido1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtApellido2.Text))
                {
                    errPro.SetError(txtApellido2, "Apellido requerido");
                    this.txtApellido2.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtTelefono.Text))
                {
                    errPro.SetError(txtTelefono, "Telefono requerido");
                    this.txtTelefono.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtDireccion.Text))
                {
                    errPro.SetError(txtDireccion, "Direccion requerido");
                    this.txtDireccion.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtCorreo.Text))
                {
                    errPro.SetError(txtCorreo, "Correo requerido");
                    this.txtCorreo.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtContrasenna.Text))
                {
                    errPro.SetError(txtContrasenna, "Contraseña requerido");
                    this.txtContrasenna.Focus();
                    return;
                }
                IBLLUsuarios _BllUsuario = new BLLUsuarios();
                Usuarios oUsuarios = new Usuarios();
                //if (Regex.Match(this.txtContrasenna.Text, "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$").Success)
                //{
                //    MessageBox.Show("Siiiuuuu");
                //}
                //else
                //{
                //    throw new Exception();
                //}

                oUsuarios.IDUsuario = this.txtCedula.Text;
                oUsuarios.Nombre = this.txtNombre.Text;
                oUsuarios.PrimerApellido = this.txtApellido1.Text;
                oUsuarios.SegundoApellido = this.txtApellido2.Text;
                oUsuarios.Correo = this.txtCorreo.Text;                
                oUsuarios.Contrasenna = this.txtContrasenna.Text;
                oUsuarios.Telefono = this.txtTelefono.Text;
                oUsuarios.Sexo = (cboSexo.SelectedItem as Sexo).IdSexo;
                oUsuarios.IdRol = (cboRol.SelectedItem as Rol).IDRol;
                oUsuarios.FechaNacimiento = dtpFechaNac.Value;
                if (rdbHabilitar.Checked)
                {
                    oUsuarios.Estado = true;
                }
                else
                {
                    oUsuarios.Estado = false;
                }
              
                oUsuarios.Direccion = txtDireccion.Text;
                oUsuarios.Token = "";
                if (_BllUsuario.SaveUsuarios(oUsuarios) != null)
                {
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
                UsuariosDTO oUsuarios = null;
                IBLLUsuarios _BllUsuario = new BLLUsuarios();

                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    CambiarEstado(MantenimientoEnum.Editar);
                    oUsuarios = dgvDatos.SelectedRows[0].DataBoundItem as UsuariosDTO;
                    this.txtCedula.Text = oUsuarios.IDUsuario;
                    this.txtNombre.Text = oUsuarios.Nombre;
                    this.txtApellido1.Text = oUsuarios.PrimerApellido;
                    this.txtApellido2.Text = oUsuarios.SegundoApellido;
                    this.txtCorreo.Text = oUsuarios.Correo;
                    this.txtContrasenna.Text = oUsuarios.Contrasenna;
                    this.txtTelefono.Text = oUsuarios.Telefono;
                    cboSexo.SelectedIndex  = cboSexo.FindString(oUsuarios.Sexo.ToString());
                    cboRol.SelectedIndex = cboRol.FindString(oUsuarios.IdRol.ToString());
                    dtpFechaNac.Value = DateTime.Parse(oUsuarios.FechaNacimiento.ToString());
                    this.txtDireccion.Text = oUsuarios.Direccion.ToString();
                    if (oUsuarios.Estado.Equals("Activo"))
                    {
                        rdbHabilitar.Checked = true;
                    }
                    else
                    {
                        rdbDesabilitar.Checked = true;
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
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios oUsuarios = null;
                IBLLUsuarios _BllUsuario = new BLLUsuarios();
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    oUsuarios = dgvDatos.SelectedRows[0].DataBoundItem as Usuarios;
                    if (oUsuarios != null)
                    {
                        if (MessageBox.Show($"¿Seguro que desea borrar el registro {oUsuarios.IDUsuario} {oUsuarios.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _BllUsuario.DaleteUsuarios(oUsuarios.IDUsuario);
                            llenarDatos();
                        } 
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
            Close();
        }
        #endregion

        private void toolStripContainer1_ContentPanel_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
