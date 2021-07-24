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
    public partial class frmMantCliente : Form
    {
        public frmMantCliente()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                errPro.Clear();
                if (string.IsNullOrEmpty(this.txtId.Text))
                {
                    errPro.SetError(txtId, "Cedula requerido");
                    this.txtId.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    errPro.SetError(txtNombre, "Nombre requerido");
                    this.txtNombre.Focus();
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
                if (string.IsNullOrEmpty(this.txtCorreo.Text))
                {
                    errPro.SetError(txtCorreo, "Correo requerido");
                    this.txtCorreo.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtTelefono.Text))
                {
                    errPro.SetError(txtTelefono, "Telefono requerido");
                    this.txtTelefono.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.rTxtDireccion.Text))
                {
                    errPro.SetError(rTxtDireccion, "Direccion requerido");
                    this.rTxtDireccion.Focus();
                    return;
                }
                IBLLCliente _BllCliente = new BLLCLiente();

                Cliente oCliente = new Cliente();

                oCliente.IdCliente = int.Parse(this.txtId.Text.Replace("-",""));
                oCliente.Nombre = this.txtNombre.Text;
                oCliente.PrimerApellido = this.txtApellido1.Text;
                oCliente.SegundoApellido = this.txtApellido2.Text;             
                oCliente.Correo = this.txtCorreo.Text;
                oCliente.Telefono = this.txtTelefono.Text;
                if (this.cBoxSexo.SelectedIndex == 0)
                {
                    oCliente.Sexo = false;
                }
                else
                {
                    oCliente.Sexo = true;
                }
                
                oCliente.Direccion = this.rTxtDireccion.Text;

                oCliente = _BllCliente.SaveCliente(oCliente);

                if (oCliente != null)
                {
                    this.CargarDatos();
                    CambiarEstado(MantenimientoEnum.Ninguno);

                }
            }
            catch (Exception)
            {

                throw;
            }           
        }

        public void CargarDatos()
        {
            IBLLCliente _BllCliente = new BLLCLiente();
            IBLLSexo _BLLSexo = new BLLSexo();

            CambiarEstado(MantenimientoEnum.Ninguno);
            List<Cliente> lista = _BllCliente.GetAllCliente();
            List<ClienteDTO> listaDTO = new List<ClienteDTO>();
            dtGVListadoClientes.AutoGenerateColumns = false;
            dtGVListadoClientes.RowTemplate.Height = 50;
            dtGVListadoClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            String sexo = "";
            foreach (Cliente item in lista)
            {               
               
                if (item.Sexo == false)
                {
                    sexo = "Masculino";
                }
                else
                {
                    sexo = "Femenino";
                }
                ClienteDTO oCliente = new ClienteDTO();
                oCliente.IdCliente = item.IdCliente.ToString("#-####-####");
                oCliente.Nombre = item.Nombre;
                oCliente.PrimerApellido = item.PrimerApellido;
                oCliente.SegundoApellido = item.SegundoApellido;
                oCliente.Correo = item.Correo;
                oCliente.Telefono = item.Telefono;
                oCliente.Direccion = item.Direccion;
                oCliente.Sexo = sexo;

                listaDTO.Add(oCliente);
            }
            dtGVListadoClientes.DataSource = listaDTO;
           
            this.cBoxSexo.Items.Clear();

            foreach (Sexo item in _BLLSexo.GetAllSexo())
            {
                this.cBoxSexo.Items.Add(item);
            }

            this.cBoxSexo.SelectedIndex = 0;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ClienteDTO oCliente = null;
            try
            {
                if (this.dtGVListadoClientes.SelectedRows.Count > 0)
                {
                  
                    CambiarEstado(MantenimientoEnum.Editar);
                   
                    oCliente = this.dtGVListadoClientes.SelectedRows[0].DataBoundItem as ClienteDTO;

                    this.txtId.Text = oCliente.IdCliente.ToString();
                    this.txtNombre.Text = oCliente.Nombre.ToString();
                    this.txtApellido1.Text = oCliente.PrimerApellido.ToString();
                    this.txtApellido2.Text = oCliente.SegundoApellido.ToString();
                    this.txtCorreo.Text = oCliente.Correo.ToString();
                    this.txtTelefono.Text = oCliente.Telefono.ToString();
                    this.cBoxSexo.SelectedIndex = cBoxSexo.FindString(oCliente.Sexo.ToString());
                    this.rTxtDireccion.Text = oCliente.Direccion.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione un registro a editar!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
              

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            IBLLCliente _BllCliente = new BLLCLiente();
            try
            {
                //ClienteDTO oCliente = null;

                CambiarEstado(MantenimientoEnum.Borrar);
                if (this.dtGVListadoClientes.SelectedRows.Count > 0)
                {
                    Cliente oCliente = dtGVListadoClientes.SelectedRows[0].DataBoundItem as Cliente;
                    if (oCliente != null)
                    {
                        if (MessageBox.Show($"¿Seguro que desea borrar el registro {oCliente.IdCliente} {oCliente.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _BllCliente.DeleteCliente(oCliente.IdCliente);
                            CargarDatos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
            catch (Exception er)
            {

            }
        }

        private void CambiarEstado(MantenimientoEnum estado)
        {
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido1.Text = "";
            this.txtApellido2.Text = "";
            this.txtCorreo.Text = "";
            this.txtTelefono.Text = "";
            this.rTxtDireccion.Text = "";
            this.cBoxSexo.SelectedIndex = -1;

            this.txtId.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtApellido1.Enabled = false;
            this.txtApellido2.Enabled = false;
            this.txtCorreo.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.rTxtDireccion.Enabled = false;
            this.cBoxSexo.Enabled = false;


            switch (estado)
            {
                case MantenimientoEnum.Nuevo:
                    this.txtId.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.rTxtDireccion.Enabled = true;
                    this.cBoxSexo.Enabled = true;
                    this.cBoxSexo.SelectedIndex = 0;
                    this.txtId.Focus();
                    break;
                case MantenimientoEnum.Editar:
                    this.txtId.Enabled = false;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.rTxtDireccion.Enabled = true;
                    this.cBoxSexo.Enabled = true;
                    this.txtNombre.Focus();
                    break;
                case MantenimientoEnum.Borrar:
                    break;
                case MantenimientoEnum.Ninguno:
                    break;
            }


        }

        private void frmMantCliente_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoFunerariaVirgenAngelesDataSet.Cliente' table. You can move, or remove it, as needed.

            CargarDatos();
            CambiarEstado(MantenimientoEnum.Ninguno);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
