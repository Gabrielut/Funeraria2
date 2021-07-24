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
    public partial class frmPaquete : Form
    {
        public PaqueteDTO oPaqueteDTO { get; private set; } = null;
        public frmPaquete()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IBLLPaquete _BLLPaquete = new BLLPaquete();
            String filtro = txtFiltro.Text;
            filtro.Replace(" ", "%");
            filtro = "%" + filtro + "%";
            dgrvDatos.AutoGenerateColumns = false;
            dgrvDatos.DataSource = _BLLPaquete.GetPaqueteByFilter(filtro);
        }

        private void dgrvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrvDatos.CurrentCell.Selected)
            {
                oPaqueteDTO = dgrvDatos.SelectedRows[0].DataBoundItem as PaqueteDTO;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
