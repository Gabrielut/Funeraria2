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
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.BLL;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmValidarToken : Form
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

        public frmValidarToken()


        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmValidarToken_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            IBLLUsuarios _BLLUsuarios = new BLLUsuarios();
            if (txtContrasenna.Text.Equals(txtConfirmacion.Text))
            {
                Usuarios usuario =_BLLUsuarios.GetUsuariosByCorreo(txtUsuario.Text);
                if (usuario.Token.Equals(txtToken.Text))
                {
                    usuario.Contrasenna = txtContrasenna.Text;
                    if (_BLLUsuarios.SaveUsuarios(usuario) != null)
                    {
                        MessageBox.Show("Contraseña cambiada exitosamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema, porfavor intente mas tarde");
                    }
                    

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
