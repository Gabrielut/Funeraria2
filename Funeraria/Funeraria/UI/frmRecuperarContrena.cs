using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.BLL;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.UI
{
    public partial class frmRecuperarContrena : Form{
        
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        String token = "";
        
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
            
           
        }

      

        private void btnToken_Click(object sender, EventArgs e)
        {
            IBLLUsuarios _BLLUsuario = new BLLUsuarios();
            Usuarios usuario =_BLLUsuario.GetUsuariosByCorreo(txtUsuario.Text);
            if (usuario != null)
            {
                generarToken();
                usuario.Token = token;
                if (enviarToken(txtUsuario.Text))
                {                    
                    _BLLUsuario.SaveUsuarios(usuario);
                    MessageBox.Show("Revise su correo electrónico para verificar su token");
                    this.DialogResult = DialogResult.OK;
                    frmValidarToken ofrmToken = new frmValidarToken();
                    this.Hide();
                    ofrmToken.Show();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema, porfavor intente mas tarde");
                }

            }
            else
            {
                MessageBox.Show("Usuario no encontrado, verifique la informacion");
                txtUsuario.Focus();
            }
        }
        public bool enviarToken(string pCorreo)
        {
            bool sent = false;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("mrs.oz.2730@gmail.com");
                mail.To.Add(pCorreo);
                mail.Subject = "Recuperacion de Contraseña";
                mail.Body = token;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new
                System.Net.NetworkCredential("mrs.oz.2730@gmail.com", "Queso13Queso");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                sent = true;
                return sent;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sent;
        }
        private String generarToken()
        {

            Random random = new Random();
            string[] listaLetras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int[] listaNumeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i <= 2; i++)
            {

                token += listaLetras[random.Next(0, 25)];
            }
            for (int i = 0; i <= 2; i++)
            {
                token += listaNumeros[random.Next(0, 8)];
            }
            return token;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
               this.Close();
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRecuperarContrena_Load(object sender, EventArgs e)
        {
            toolTCorreo.SetToolTip(txtUsuario, "Por favor digite el nombre del usuario");
            toolTCancel.SetToolTip(btnCancelar, "Cancelar");
            toolTGenToken.SetToolTip(btnToken, "Generar un nuevo token");
            toolTVolver.SetToolTip(btnSalir, "Salir");
        }
    }
}
