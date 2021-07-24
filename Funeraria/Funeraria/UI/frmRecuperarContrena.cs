using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmRecuperarContrena : Form

    {
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(

          int nLeft,
          int nTop,
          int nBottom,
          int nRight,
          int nWidthEllipse,
          int nHeightEllipse
          );

        public frmRecuperarContrena()
        {
         
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ;
           
        }

      

        private void btnToken_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Revise su correo electrónico para verificar su token");           
            this.DialogResult = DialogResult.OK;           
            frmValidarToken ofrmToken = new frmValidarToken();
            this.Hide();

            ofrmToken.Show();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
               this.Close();
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
