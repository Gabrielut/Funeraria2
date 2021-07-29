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
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.UI.Filtro
{
    public partial class frmProveedor : Form
    {
        public ProveedorDTO oProveedoresDTO { get; private set; } = null;
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IBLLProveedores _BLLProveedores = new BLLProveedores();
            String filtro = txtFiltro.Text;
            filtro.Replace(" ", "%");
            filtro = "%" + filtro + "%";
            dgrvDatos.AutoGenerateColumns = false;
            dgrvDatos.DataSource = _BLLProveedores.GetProveedorByFilter(filtro);
        }
        private void dgrvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrvDatos.CurrentCell.Selected)
            {
                oProveedoresDTO = dgrvDatos.SelectedRows[0].DataBoundItem as ProveedorDTO;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
