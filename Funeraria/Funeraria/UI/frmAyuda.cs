using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarProoveedor_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "C:/Users/Tatooine/Documents/1. UTN/2021/Cuatri II/Practica/Entregables/manualUsuario.pdf");

            Process.Start(pdfPath);
        }
    }
}
