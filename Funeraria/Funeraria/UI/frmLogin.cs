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
using UTN.Winform.Funeraria.Properties;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmLogin : Form
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

        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                IBLLUsuarios _BLLUsuarios = new BLLUsuarios();
                Usuarios oUsuarios = _BLLUsuarios.LoginUsuarios(this.txtUsuario.Text);
                errPro.Clear();

                if (string.IsNullOrEmpty(this.txtUsuario.Text))
                {
                    errPro.SetError(txtUsuario, "Usuario requerido");
                    this.txtUsuario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtContrasena.Text))
                {
                    errPro.SetError(txtContrasena, "Contraseñá requerida");
                    this.txtContrasena.Focus();
                    return;
                }

                if (oUsuarios.Correo == null && oUsuarios.Contrasenna == null || oUsuarios.Correo.Equals("") && oUsuarios.Contrasenna.Equals(""))
                {
                    MessageBox.Show("El usuario no existe o los datos ingresados son incorrectos");
                    txtUsuario.Focus();
                }
                else
                {
                    if (oUsuarios.Correo.Equals(this.txtUsuario.Text, StringComparison.CurrentCultureIgnoreCase) && oUsuarios.Contrasenna.Equals(this.txtContrasena.Text, StringComparison.CurrentCultureIgnoreCase))
                    {

                        this.DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe o los datos ingresados son incorrectos");
                        txtUsuario.Focus();
                    }
                }            

            }
            catch (Exception er)
            {
               
                throw er;

            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 5, 5));
            
            pnlLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlLogin.Width, pnlLogin.Height, 20, 25));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}
