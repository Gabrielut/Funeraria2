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
        public frmCotizacion()
        {
            InitializeComponent();
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

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
            List<ProveedorDTO> list = new List<ProveedorDTO>();
            if (frmProveedor.DialogResult == DialogResult.OK)
            {
                ProveedorDTO = frmProveedor.oProveedoresDTO;
                list.Add(ProveedorDTO);
                dgrvProveedor.DataSource = list;
            }
        }

        private void btnSalvarCotizacion_Click(object sender, EventArgs e)
        {
            IBLLCotizacion _BLLCotizacion = new BLLCotizacion();
            Cotizacion cotizacion = new Cotizacion();
            List<ProveedorDTO> listProveedorDTO = new List<ProveedorDTO>();
            List<PaqueteDTO> listPaqueteDTO = new List<PaqueteDTO>();
            List<Cliente> listCliente = new List<Cliente>();
            List<ConveniosDTO> listConveniosDTO = new List<ConveniosDTO>();

            listProveedorDTO =  (List<ProveedorDTO>)dgrvProveedor.DataSource;
            listPaqueteDTO =  (List<PaqueteDTO>)dgrvPaquete.DataSource;
            listConveniosDTO = (List<ConveniosDTO>)dgrvConvenio.DataSource;
            listCliente = (List<Cliente>)dgrvCliente.DataSource;
            double total = 0;
            if (listProveedorDTO == null && listPaqueteDTO == null && listConveniosDTO == null)
            {
                MessageBox.Show("Debe de seleccionar almenos 1 Paquete ó Servicio", "Atencion",MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cotizacion.IdProveedores = item.IdProveedor;
                    total += double.Parse(item.Precio);
                }

            }
            if (listPaqueteDTO != null)
            {
                foreach (PaqueteDTO item in listPaqueteDTO)
                {
                    cotizacion.IdPaquete = item.IdPaquete;
                    total += double.Parse(item.Precio);
                }
            }
    
            if (listConveniosDTO != null)
            {
                foreach (ConveniosDTO item in listConveniosDTO)
                {
                    cotizacion.IdConvenio = item.IdConvenio;
                }
            }
            cotizacion.Comentarios = txtComentarios.Text;
            DialogResult dialogResult = MessageBox.Show("El total es de: ₡" + total.ToString("###,###"), "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _BLLCotizacion.SaveCotizacion(cotizacion);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }        
        }
    }
}
