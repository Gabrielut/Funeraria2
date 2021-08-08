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

namespace UTN.Winform.Funeraria.UI.Filtro
{
    public partial class frmActivo : Form
    {
        public ActivoDTO oActivo { get; private set; } = null;
        public frmActivo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IBLLActivo _BLLCliente = new BLLActivo();
            String filtro = txtFiltro.Text;
            filtro.Replace(" ", "%");
            filtro = "%" + filtro + "%";
           
            dgrvActivo.AutoGenerateColumns = false;
            dgrvActivo.DataSource = detallesParaMostrar(_BLLCliente.GetActivoByFilter(filtro));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgrvActivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private List<ActivoDTO> detallesParaMostrar(List<ActivoDTO> pList)
        {
            List<ActivoDTO> list = new List<ActivoDTO>();
            foreach (ActivoDTO item in pList)
            {
                ActivoDTO oActivoDto = new ActivoDTO();
     
                oActivoDto.IdActivo = item.IdActivo;
                oActivoDto.Nombre = item.Nombre;
                oActivoDto.Descripcion = item.Descripcion;
                oActivoDto.TipoActivo = item.TipoActivo;
                oActivoDto.Cantidad = item.Cantidad;
                oActivoDto.Costo = String.Format("{0}", item.Costo);
                oActivoDto.Precio = String.Format("{0}", item.Precio);
                oActivoDto.InformacionAdicional = item.InformacionAdicional;
                oActivoDto.Img = item.Img;
                if (item.Estado.Equals("True"))
                {
                    oActivoDto.Estado = "Activo";
                }
                else
                {
                    oActivoDto.Estado = "Inactivo";
                }
                list.Add(oActivoDto);
            }

            return list;
        }

        private void dgrvActivo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrvActivo.CurrentCell.Selected)
            {
                oActivo = dgrvActivo.SelectedRows[0].DataBoundItem as ActivoDTO;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
