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
    public partial class frmReporteUsuario : Form
    {
        public frmReporteUsuario()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmReporteUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetActivo.UsuarioTipoUsuario' table. You can move, or remove it, as needed.
            this.UsuarioTipoUsuarioTableAdapter.Fill(this.DataSetActivo.UsuarioTipoUsuario);

            this.reportViewer1.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
