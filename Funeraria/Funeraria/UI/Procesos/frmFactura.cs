using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN.Winform.Funeraria.UI.Procesos
{
    public partial class frmFactura : Form
    {
        int numFac =0;

        public frmFactura(int numFac)
        {
            InitializeComponent();
            this.numFac = numFac;
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetActivo.FacturaFinal' table. You can move, or remove it, as needed.
            this.facturaFinalTableAdapter.Fill(this.dataSetActivo.FacturaFinal);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();


            try
            {
                this.facturaFinalTableAdapter.FillBy(this.dataSetActivo.FacturaFinal, numFac);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
