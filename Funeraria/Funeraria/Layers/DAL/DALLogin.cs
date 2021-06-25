using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Interfaces;

namespace UTN.Winform.Funeraria.Layers.DAL
{
    class DALLogin : IDALLogin
    {
        public bool Login(string pUsuario, string pContrasena)
        {
            try
            {


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(pUsuario, pContrasena)))
                {
                    // Si esto da error es porque el usuario no existe! 
                }

                return true;
            }
            catch (Exception er)
            {
                throw er;
            }
        }
    }
}
