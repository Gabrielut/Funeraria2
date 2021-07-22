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
    public partial class frmReporteActivo : Form
    {
        public frmReporteActivo()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            toolTActivo.SetToolTip(txtDescripcion, "Por favor digite el tipo de Activo a buscar");
            toolTLimpiar.SetToolTip(btnBuscar, "Buscar");
            toolTBuscar.SetToolTip(btnLimpiar, "Limpiar selección");
            toolTRefresh.SetToolTip(btnRefresh, "Refrescar Pantalla");
        }

        private void frmReporteActivo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetActivo.ActivoTipoActivo' table. You can move, or remove it, as needed.
            this.ActivoTipoActivoTableAdapter.Fill(this.DataSetActivo.ActivoTipoActivo);

            this.reportViewer1.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ActivoTipoActivoTableAdapter.Fill(this.DataSetActivo.ActivoTipoActivo);
            this.reportViewer1.RefreshReport();
            txtDescripcion.Text="";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActivoTipoActivoTableAdapter.FillBy(this.DataSetActivo.ActivoTipoActivo, txtDescripcion.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ActivoTipoActivoTableAdapter.Fill(this.DataSetActivo.ActivoTipoActivo);
            this.reportViewer1.RefreshReport();
            txtDescripcion.Text = "";
        }
    }
}
