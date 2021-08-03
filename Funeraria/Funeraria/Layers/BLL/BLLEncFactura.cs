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
    class BLLEncFactura : IBLLEncFactura
    {
        public List<EncFactura> GetAllEncFactura()
        {
            throw new NotImplementedException();
        }

        public EncFactura GetEncFacturaById(int id)
        {
            IDALEncFactura _DalEncFactura = new DALEncFactura();
            return _DalEncFactura.GetEncFacturaById(id);
        }

        public EncFactura SaveEncFactura(EncFactura pEncFactura)
        {
            IDALEncFactura _DalEncFactura = new DALEncFactura();
            return _DalEncFactura.SaveEncFactura(pEncFactura);
        }
    }
}
