using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.DAL;

namespace UTN.Winform.Funeraria.Layers.BLL
{
    class BLLLogin : IBLLLogin
    {
        public bool Login(string pUsuario, string pContrasena)
        {
            IDALLogin _DALLogin = new DALLogin();
            return _DALLogin.Login(pUsuario, pContrasena);
        }
    }
}
