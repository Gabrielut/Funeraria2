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
    class BLLTipoPaquete : IBLLTipoPaquete
    {
        public List<TipoPaquete> GetAllTipoPaquete()
        {
            IDALTipoPaquete _DALTipoPaquete = new DALTipoPaquete();
            return _DALTipoPaquete.GetAllTipoPaquete();
        }
    }
}
