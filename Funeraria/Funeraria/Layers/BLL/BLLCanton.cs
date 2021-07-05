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
    class BLLCanton : IBLLCanton
    {
        public List<Canton> GetCantonById(int provincia)
        {
            IDALCanton _DalCanton = new DALCanton();
            return _DalCanton.GetCantonById(provincia);
        }
    }
}
