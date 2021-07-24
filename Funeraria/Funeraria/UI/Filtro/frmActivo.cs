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

namespace UTN.Winform.Funeraria.UI.Filtro
{
    public partial class frmActivo : Form
    {
      //  public Activo oActivo { get; private set; } = null;
        public frmActivo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmActivo frmActivo = new frmActivo();
            frmActivo.ShowDialog();

            IBLLActivo _BLLCliente = new BLLActivo();
            String filtro = txtFiltro.Text;
            filtro.Replace(" ", "%");
            filtro = "%" + filtro + "%";
            dgrvActivo.AutoGenerateColumns = false;
            //dgrvDatos.DataSource = _BLLCliente.GetActivoByFilter(filtro);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
