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
    class BLLProvincia : IBLLProvincia
    {
        public List<Provincia> GetAllProvincia()
        {
            IDALProvincia _DalProvincia = new DALProvincia();
            return _DalProvincia.GetAllProvincia();
        }
    }
}
