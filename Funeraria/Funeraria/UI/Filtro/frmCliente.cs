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
using UTN.Winform.Funeraria.Layers.DAL;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.UI.Filtro
{
    public partial class frmCliente : Form
    {
        public Cliente oCliente { get; private set; } = null;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IBLLCliente _BLLCliente = new BLLCLiente();
            String filtro = txtFiltro.Text;
            filtro.Replace(" ", "%");
            filtro = "%" + filtro + "%";
            dgrvDatos.AutoGenerateColumns = false;
            dgrvDatos.DataSource = _BLLCliente.GetClienteByFilter(filtro);

        }

        private void dgrvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrvDatos.CurrentCell.Selected)
            {
                oCliente = dgrvDatos.SelectedRows[0].DataBoundItem as Cliente;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
