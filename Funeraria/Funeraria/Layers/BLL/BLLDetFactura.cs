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
    class BLLDetFactura : IBLLDetFactura
    {
        public List<DetFactura> GetAllDetFactura()
        {
            throw new NotImplementedException();
        }

        public int GetNumeroFactura()
        {
            IDALDetFactura _DalDetFactura = new DALDetFactura();
            return _DalDetFactura.GetNumeroFactura();
        }

        public bool SaveDetFactura(DetFactura pDetFactura)
        {
            IDALDetFactura _DalDetFactura = new DALDetFactura();
            return _DalDetFactura.SaveDetFactura(pDetFactura);
        }
    }
}
