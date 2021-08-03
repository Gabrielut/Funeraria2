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

namespace UTN.Winform.Funeraria.UI.Reportes
{
    public partial class frmReporteProveedor : Form
    {
        public frmReporteProveedor()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporteProveedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetActivo.Proveedor' table. You can move, or remove it, as needed.
            this.ProveedorTableAdapter.Fill(this.DataSetActivo.Proveedor);

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
           
               // this.ProveedorTableAdapter.FillBy(this.DataSetActivo.Proveedor, txtDescripcion.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ProveedorTableAdapter.Fill(this.DataSetActivo.Proveedor);
            this.reportViewer1.RefreshReport();
            txtDescripcion.Text = "";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.ProveedorTableAdapter.FillBy(this.DataSetActivo.Proveedor, ((int)(System.Convert.ChangeType(idToolStripTextBox.Text, typeof(double)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

    }
}
