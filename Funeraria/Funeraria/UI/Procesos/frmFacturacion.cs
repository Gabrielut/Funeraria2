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
using UTN.Winform.Funeraria.UI.Procesos;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmFacturacion : Form
    {
        List<Cotizacion> list = new List<Cotizacion>();
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            IBLLCotizacion _BLLCotizacion = new BLLCotizacion();
            list = _BLLCotizacion.GetCotizacionById(int.Parse(txtIdCotizacion.Text));
            dgrFactura.AutoGenerateColumns = false;
            dgrFactura.RowTemplate.Height = 50;
            dgrFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            if (_BLLCotizacion.GetCotizacionById(int.Parse(txtIdCotizacion.Text)).Count == 0)
            {
                MessageBox.Show("No existe una cotizacion con el numero " + txtIdCotizacion.Text);
                return;
            }
            else
            {
                dgrFactura.DataSource = buscar(_BLLCotizacion.GetCotizacionById(int.Parse(txtIdCotizacion.Text)));
                montos(_BLLCotizacion.GetCotizacionById(int.Parse(txtIdCotizacion.Text)));
            }            
        }

        private List<CotizacionDTO> buscar(List<Cotizacion> pListCotizacion)
        {
            List<CotizacionDTO> list = new List<CotizacionDTO>();
            IBLLPaquete _BLLPaquete = new BLLPaquete();
            IBLLProveedores _BLLProveedores = new BLLProveedores();
            IBLLCliente _BLLCliente = new BLLCLiente();
            IBLLConvenios _BLLConvenio = new BLLConvenios();
            IBLLActivo _BLLActivo = new BLLActivo();
            foreach (Cotizacion item in pListCotizacion)
            {
                CotizacionDTO oCotizacionDTO = new CotizacionDTO();
                lblNumero.Text = "N° " + item.IdCotizacion;
                    
                txtNombreCliente.Text = _BLLCliente.GetClienteById(item.IdCliente).Nombre + " " +
                                _BLLCliente.GetClienteById(item.IdCliente).PrimerApellido + " " +
                                _BLLCliente.GetClienteById(item.IdCliente).SegundoApellido;
                if (item.IdPaquete != 0)
                {
                    oCotizacionDTO.paquete = _BLLPaquete.GetPaqueteById(item.IdPaquete).Nombre;
                    //oCotizacionDTO.precioPaquete = _BLLPaquete.GetPaqueteById(item.IdPaquete).Precio;
                }
                if (item.IdProveedores != 0)
                {
                    oCotizacionDTO.proveedores = _BLLProveedores.GetProveedorById(item.IdProveedores).NomProveedor;
                    oCotizacionDTO.comentariosProveedores = item.Comentarios;
                }
                if (item.IdConvenio != 0)
                {
                    oCotizacionDTO.convenio = _BLLConvenio.GetConvenioById(item.IdConvenio).NomEmpresa;
                    //txtDescuento.Text = _BLLConvenio.GetConvenioById(item.IdConvenio).Descuento.ToString();
                }
                if (item.IdActivo != 0)
                {
                    oCotizacionDTO.activo = _BLLActivo.GetActivoById(item.IdActivo).Nombre;
                    //txtDescuento.Text = _BLLConvenio.GetConvenioById(item.IdConvenio).Descuento.ToString();
                }
                list.Add(oCotizacionDTO);
            }
            return list;
        }
        private void montos(List<Cotizacion> pListCotizacion)
        {
            IBLLPaquete _BLLPaquete = new BLLPaquete();
            IBLLProveedores _BLLProveedores = new BLLProveedores();
            IBLLConvenios _BLLConvenio = new BLLConvenios();
            IBLLActivo _BLLActivo = new BLLActivo();
            double total = 0;
            double descuento = 0;
            foreach (Cotizacion item in pListCotizacion)
            {
                
                if (item.IdPaquete != 0)
                {
                    total += _BLLPaquete.GetPaqueteById(item.IdPaquete).Precio;
                }
                if (item.IdProveedores != 0)
                {
                    total += _BLLProveedores.GetProveedorById(item.IdProveedores).Precio;

                }
                if (item.IdActivo != 0)
                {
                    total += _BLLActivo.GetActivoById(item.IdActivo).Precio;

                }
                if (item.IdConvenio != 0)
                {
                    
                    descuento = (_BLLConvenio.GetConvenioById(item.IdConvenio).Descuento);
                    txtDescuento.Text = descuento + "%";
                }
            }
            txtSubTotal.Text = String.Format("{0:n}", total);
                      
            if (descuento > 0)
            {
                total = ((total * descuento) / 100) ;
                txtIVA.Text = String.Format("{0:n}", calcIVA(total));
                total += calcIVA(total);
                txtTotal.Text = String.Format("{0:n}", total);

            }
            else
            {
                txtIVA.Text = String.Format("{0:n}", calcIVA(total));
                txtTotal.Text = String.Format("{0:n}", (total + calcIVA(total)));
                
            }
            

        }
        private double calcIVA(double pMonto)
        {
           return pMonto * 0.13;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            int numFac = 0;
            IBLLEncFactura _BLLFactura = new BLLEncFactura();
            IBLLDetFactura _BLLDetFactura = new BLLDetFactura();
            IBLLPaquete _BLLPaquete = new BLLPaquete();
            IBLLProveedores _BLLProveedores = new BLLProveedores();
            IBLLActivo _BLLActivo = new BLLActivo();
            List<DetFactura> detalleList = new List<DetFactura>();
            if (dgrFactura.DataSource == null)
            {
                MessageBox.Show("Debe de ingresar la cotizacion para realizar al factura");
                return;
            }
            EncFactura factura = new EncFactura();
            factura.Fecha = DateTime.Now;
            foreach (Cotizacion item in list)
            {
                factura.IdCliente = item.IdCliente;
                break;
            }
            factura.IdConvenio = 0;
            factura.Estado = true;
            //txtIVA.Text.Replace(",", "").Replace(" ","");
            //txtTotal.Text.Replace(",", "").Replace("$", "").Replace(".", "").Replace(" ", "");
            //txtSubTotal.Text.Replace(",", "").Replace(" ", "");
            factura.Subtotal = float.Parse(txtSubTotal.Text.Replace("%",""));
            factura.IVA = float.Parse(txtIVA.Text);
            factura.Total = float.Parse(txtTotal.Text);
            factura.IdCotizacion = int.Parse(txtIdCotizacion.Text);
            _BLLFactura.SaveEncFactura(factura);
            
            foreach (Cotizacion item in list)
            {
                DetFactura detalle = new DetFactura();
                if (item.IdPaquete != 0)
                {
                    detalle.IdFactura = _BLLDetFactura.GetNumeroFactura();
                    detalle.IdPaquete = item.IdPaquete;
                    detalle.IdConvenio = 0;
                    detalle.IdActivo = 0;
                    detalle.IdProveedores = 0;
                    detalle.Precio = _BLLPaquete.GetPaqueteById(item.IdPaquete).Precio;
                    detalle.Cantidad = _BLLPaquete.GetPaqueteById(item.IdPaquete).Cantidad;
                    _BLLDetFactura.SaveDetFactura(detalle);
                }
                if (item.IdConvenio != 0)
                {
                    detalle.IdFactura = _BLLDetFactura.GetNumeroFactura();
                    detalle.IdPaquete = 0;
                    detalle.IdConvenio = item.IdConvenio;
                    detalle.IdActivo = 0;
                    detalle.IdProveedores = 0;
                    detalle.Precio = float.Parse(txtTotal.Text);
                    detalle.Cantidad = 1;
                    _BLLDetFactura.SaveDetFactura(detalle);
                }
                if (item.IdProveedores != 0)
                {
                    detalle.IdFactura = _BLLDetFactura.GetNumeroFactura();
                    detalle.IdPaquete = 0;
                    detalle.IdConvenio = 0;
                    detalle.IdActivo = 0;
                    detalle.IdProveedores = item.IdProveedores;
                    detalle.Precio = _BLLProveedores.GetProveedorById(item.IdProveedores).Precio;
                    detalle.Cantidad = _BLLProveedores.GetProveedorById(item.IdProveedores).CantUni;
                    _BLLDetFactura.SaveDetFactura(detalle);
                }
                if (item.IdActivo != 0)
                {
                    detalle.IdFactura = _BLLDetFactura.GetNumeroFactura();
                    detalle.IdPaquete = 0;
                    detalle.IdConvenio = 0;
                    detalle.IdActivo = item.IdActivo;
                    detalle.IdProveedores = 0;
                    detalle.Precio = _BLLActivo.GetActivoById(item.IdActivo).Precio;
                    _BLLDetFactura.SaveDetFactura(detalle);
                }

                numFac = detalle.IdFactura;
            }
            //Aqui va mensaje de Success
            MessageBox.Show("Factura creada con éxito");
            //Limpiar Info
            Limpiar();
            //Abrir Frame del reporte

            


            frmFactura ofrmFactura = new frmFactura(numFac);
            ofrmFactura.Show();

        }

        public void Limpiar()
        {
            txtIdCotizacion.Text = "";
            txtNombreCliente.Text = "";
            txtSubTotal.Text = "";
            txtIVA.Text = "";
            txtDescuento.Text = "";
            txtTotal.Text = "";
            dgrFactura.DataSource = null;
            lblNumero.Text = "N°";
        }
    }
}

