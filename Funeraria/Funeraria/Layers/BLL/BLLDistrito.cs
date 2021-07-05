using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.DAL;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.Layers.BLL
{
    class BLLDistrito : IBLLDistrito
    {
        public List<Distrito> GetDistritoById(int provincia, int canton)
        {
            IDALDistrito _DalDistrito = new DALDistrito();
            return _DalDistrito.GetDistritoById(provincia,canton);
        }
    }
}
