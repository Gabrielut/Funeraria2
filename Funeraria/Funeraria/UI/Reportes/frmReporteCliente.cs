using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN.Winform.Funeraria.UI.Reportes
{
    public partial class frmReporteCliente : Form
    {
        public frmReporteCliente()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            toolTCedula.SetToolTip(txtCedula, "Por favor digite la cédula a buscar");
            toolTLimpiar.SetToolTip(btnBuscar, "Buscar");
            toolTBuscar.SetToolTip(btnLimpiar, "Limpiar selección");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporteCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetActivo.Cliente' table. You can move, or remove it, as needed.
            this.ClienteTableAdapter.Fill(this.DataSetActivo.Cliente);

            this.reportViewer1.RefreshReport();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClienteTableAdapter.FillBy(this.DataSetActivo.Cliente, ((int)(System.Convert.ChangeType(txtCedula.Text, typeof(int)))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                // this.ClienteTableAdapter.FillBy2(this.DataSetActivo.Cliente);
                this.ClienteTableAdapter.Fill(this.DataSetActivo.Cliente);

                this.reportViewer1.RefreshReport();
                txtCedula.Text = "";
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        
    }
}
