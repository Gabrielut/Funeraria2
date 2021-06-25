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
    class BLLTipoActivo : IBLLTipoActivo
    {
        public List<TipoActivo> GetAllTipoActivo()
        {
            IDALTipoActivo _DALTipoActivo = new DALTipoActivo();
            return _DALTipoActivo.GetAllTipoActivo();
        }
    }
}
