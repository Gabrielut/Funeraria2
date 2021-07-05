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
    class BLLBarrio : IBLLBarrio
    {
        public List<Barrio> GetBarrioById(int provincia, int canton, int distrito)
        {
            IDALBarrio _DalBarrio = new DALBarrio();
            return _DalBarrio.GetBarrioById(provincia,canton,distrito);
        }

    }
}
