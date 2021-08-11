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
using UTN.Winform.Funeraria.UI.Filtro;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmCotizacion : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        List<ProveedorDTO> list = new List<ProveedorDTO>();
        public frmCotizacion()
        {
            InitializeComponent();
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {
            //toolTNombreConvenio.SetToolTip(txtUsuario, "Por favor ingrese el nombre del usuario");
            toolTBuscar.SetToolTip(btnBuscarCliente, "Buscar Clientes");
            toolTListadoCli.SetToolTip(dgrvCliente, "Listado de clientes seleccionados");
            toolTGenerar.SetToolTip(btnGuardar2, "Generar cotización");
            toolTBuscar2.SetToolTip(btnBuscarProoveedor, "Buscar proveedores disponibles");
            toolTListaServ.SetToolTip(dgrvConvenio, "Listado de convenios seleccionados");
            toolTBuscar3.SetToolTip(btnBuscarPaquete, "Buscar paquetes disponibles");
            toolTListaPaquet.SetToolTip(dgrvPaquete, "Listado de paquetes seleccionados");
            toolTBuscar4.SetToolTip(btnBuscarConvenio, "Buscar convenios disponibles");
            toolTListaConvenio.SetToolTip(dgrvConvenio, "Listado de convenios seleccionados");
            toolTCerrar.SetToolTip(btnCerrar, "Cerrar la ventana actual");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarConvenio_Click(object sender, EventArgs e)
        {
            frmConvenio frmConvenio = new frmConvenio();
            frmConvenio.ShowDialog();
            ConveniosDTO convenios = new ConveniosDTO();
            List<ConveniosDTO> list = new List<ConveniosDTO>();
            if (frmConvenio.DialogResult == DialogResult.OK)
            {
                convenios = frmConvenio.oConveniosDTO;
                list.Add(convenios);

                dgrvConvenio.DataSource = list;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.ShowDialog();
            Cliente cliente = new Cliente();
            List<Cliente> list = new List<Cliente>();
            if (frmCliente.DialogResult == DialogResult.OK)
            {
                cliente = frmCliente.oCliente;
                list.Add(cliente);
                dgrvCliente.AutoGenerateColumns = false;
                dgrvCliente.DataSource = list;
            }
        }

        private void btnBuscarPaquete_Click(object sender, EventArgs e)
        {
            frmPaquete frmPaquete = new frmPaquete();
            frmPaquete.ShowDialog();
            PaqueteDTO PaqueteDTO = new PaqueteDTO();
            List<PaqueteDTO> list = new List<PaqueteDTO>();
            if (frmPaquete.DialogResult == DialogResult.OK)
            {
                PaqueteDTO = frmPaquete.oPaqueteDTO;
                list.Add(PaqueteDTO);
                dgrvPaquete.DataSource = list;
            }
        }

        private void btnBuscarProoveedor_Click(object sender, EventArgs e)
        {
            frmProveedor frmProveedor = new frmProveedor();
            frmProveedor.ShowDialog();
            ProveedorDTO ProveedorDTO = new ProveedorDTO();
            if (frmProveedor.DialogResult == DialogResult.OK)
            {
                ProveedorDTO = frmProveedor.oProveedoresDTO;
                dgrvProveedor.DataSource = null;
                list.Add(ProveedorDTO);
                //this.dgrvProveedor.Rows.Add(ProveedorDTO.IdProveedor, ProveedorDTO.NomProveedor, ProveedorDTO.IdTipoServicio,
                //    ProveedorDTO.Propietario, ProveedorDTO.Correo, ProveedorDTO.TelCelular, ProveedorDTO.TelProveedor, ProveedorDTO.TelFax,
                //    ProveedorDTO.Precio, ProveedorDTO.CantUni, ProveedorDTO.Provincia, ProveedorDTO.Canton, ProveedorDTO.Distrito,
                //    ProveedorDTO.Barrio, ProveedorDTO.otrasSennas, ProveedorDTO.Estado);
                dgrvProveedor.DataSource = list;
                
            }
        }

        private void btnSalvarCotizacion_Click(object sender, EventArgs e)
        {
            try
            {

           

            IBLLCotizacion _BLLCotizacion = new BLLCotizacion();
            Cotizacion cotizacion = new Cotizacion();
            List<ProveedorDTO> listProveedorDTO = new List<ProveedorDTO>();
            List<PaqueteDTO> listPaqueteDTO = new List<PaqueteDTO>();
            List<Cliente> listCliente = new List<Cliente>();
            List<ConveniosDTO> listConveniosDTO = new List<ConveniosDTO>();
            List<ActivoDTO> listActivoDTO = new List<ActivoDTO>();
            listProveedorDTO =  (List<ProveedorDTO>)dgrvProveedor.DataSource;
            listPaqueteDTO =  (List<PaqueteDTO>)dgrvPaquete.DataSource;
            listConveniosDTO = (List<ConveniosDTO>)dgrvConvenio.DataSource;
            listCliente = (List<Cliente>)dgrvCliente.DataSource;
            listActivoDTO = (List<ActivoDTO>)dgrvActivo.DataSource;
            double total = 0;
            int numCoti = _BLLCotizacion.nextValue();
            if (listProveedorDTO == null && listPaqueteDTO == null && listConveniosDTO == null && listActivoDTO == null)
            {
                MessageBox.Show("Debe de seleccionar almenos 1 Paquete, Servicio, Convenio o Activo", "Atencion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (listCliente == null)
            {
                MessageBox.Show("Debe de seleccionar almenos un cliente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                foreach (Cliente item in listCliente)
                {
                    cotizacion.IdCliente = item.IdCliente;
                }
            }
            if (listProveedorDTO != null)
            {
                foreach (ProveedorDTO item in listProveedorDTO)
                {
                   
                    total += double.Parse(item.Precio);
                }

            }
            if (listPaqueteDTO != null)
            {
                foreach (PaqueteDTO item in listPaqueteDTO)
                {
                    
                    total += double.Parse(item.Precio);
                }
            }
            if (listActivoDTO != null)
            {
                foreach (ActivoDTO item in listActivoDTO)
                {

                    total += double.Parse(item.Precio);
                }
            }

            DialogResult dialogResult = MessageBox.Show("El subtotal es de: ₡" + total.ToString("###,###"), "Cotización #" + numCoti, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (listProveedorDTO != null)
                {
                    foreach (ProveedorDTO item in listProveedorDTO)
                    {
                        cotizacion.IdCotizacion = numCoti;
                        cotizacion.IdProveedores = item.IdProveedor;
                        cotizacion.IdPaquete = 0;
                        cotizacion.Comentarios = txtComentarios.Text;
                        _BLLCotizacion.SaveCotizacion(cotizacion);
                    }
                }
                if (listPaqueteDTO != null)
                {
                    foreach (PaqueteDTO item in listPaqueteDTO)
                    {
                        cotizacion.IdCotizacion = numCoti;
                        cotizacion.IdPaquete = item.IdPaquete;
                        cotizacion.IdProveedores = 0;
                        cotizacion.Comentarios = "";
                        _BLLCotizacion.SaveCotizacion(cotizacion);
                    }
                }

                if (listConveniosDTO != null)
                {
                    foreach (ConveniosDTO item in listConveniosDTO)
                    {
                        cotizacion.IdCotizacion = numCoti;
                        cotizacion.IdPaquete = 0;
                        cotizacion.IdProveedores = 0;
                        cotizacion.IdConvenio = item.IdConvenio;
                        cotizacion.Comentarios = "";
                        _BLLCotizacion.SaveCotizacion(cotizacion);
                    }
                }
                if (listActivoDTO != null)
                {
                    foreach (ActivoDTO item in listActivoDTO)
                    {
                        cotizacion.IdCotizacion = numCoti;
                        cotizacion.IdPaquete = 0;
                        cotizacion.IdProveedores = 0;
                        cotizacion.IdConvenio = 0;
                        cotizacion.Comentarios = "";
                        cotizacion.IdActivo = item.IdActivo;
                        _BLLCotizacion.SaveCotizacion(cotizacion);
                    }
                }

                MessageBox.Show("Cotizacion guardada exitosamente!");
                limpiar();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarLocalizacion_Click(object sender, EventArgs e)
        {
            //frmProveedor frmProveedor = new frmProveedor();
            //frmProveedor.ShowDialog();
            //ProveedorDTO ProveedorDTO = new ProveedorDTO();
            //List<ProveedorDTO> list = new List<ProveedorDTO>();
            //if (frmProveedor.DialogResult == DialogResult.OK)
            //{
            //    ProveedorDTO = frmProveedor.oProveedoresDTO;
            //    list.Add(ProveedorDTO);
            //    dgrvProveedor.DataSource = list;
            //}
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           
        }

        private void limpiar()
        {
            dgrvCliente.DataSource = null;
            dgrvPaquete.DataSource = null;
            dgrvActivo.DataSource = null;
            dgrvConvenio.DataSource = null;
            dgrvProveedor.DataSource = null;
        }

        private void btnBuscarActivo_Click(object sender, EventArgs e)
        {

            frmActivo frmActivo = new frmActivo();
            frmActivo.ShowDialog();
            ActivoDTO activo = new ActivoDTO();
            List<ActivoDTO> list = new List<ActivoDTO>();
            if (frmActivo.DialogResult == DialogResult.OK)
            {
                activo = frmActivo.oActivo;
                list.Add(activo);
                dgrvActivo.AutoGenerateColumns = false;
                dgrvActivo.DataSource = list;
            }
        }
    }
}
