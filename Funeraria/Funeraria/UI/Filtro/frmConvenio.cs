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
    public partial class frmConvenio : Form
    {
        public ConveniosDTO oConveniosDTO { get; private set; } = null;
        public frmConvenio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IBLLConvenios _BLLConvenio = new BLLConvenios();
            String filtro = txtFiltro.Text;
            filtro.Replace(" ", "%");
            filtro = "%" + filtro + "%";
            dgrvDatos.AutoGenerateColumns = false;
            dgrvDatos.DataSource = _BLLConvenio.GetConveniosByFilter(filtro);
        }

        private void dgrvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrvDatos.CurrentCell.Selected)
            {
                oConveniosDTO = dgrvDatos.SelectedRows[0].DataBoundItem as ConveniosDTO;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
