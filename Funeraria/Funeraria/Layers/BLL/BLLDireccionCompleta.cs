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
    class BLLDireccionCompleta : IBLLDireccionCompleta
    {
        public bool DaleteDireccionCompleta(int pId)
        {
            IDALDireccionCompleta _DalDireccionCompleta = new DALDireccionCompleta();
            return _DalDireccionCompleta.DaleteDireccionCompleta(pId);
        }

        public List<DireccionCompleta> GetAllDireccionCompleta()
        {
            IDALDireccionCompleta _DalDireccionCompleta = new DALDireccionCompleta();
            return _DalDireccionCompleta.GetAllDireccionCompleta();
        }

        public List<DireccionCompleta> GetDireccionCompletaByFilter(string pDescripcion)
        {
            IDALDireccionCompleta _DalDireccionCompleta = new DALDireccionCompleta();
            return _DalDireccionCompleta.GetDireccionCompletaByFilter(pDescripcion);
        }

        public DireccionCompleta GetDireccionCompletaById(int pProovedor)
        {
            IDALDireccionCompleta _DalDireccionCompleta = new DALDireccionCompleta();
            return _DalDireccionCompleta.GetDireccionCompletaById(pProovedor);
        }

        public DireccionCompleta SaveDireccionCompleta(DireccionCompleta pDireccionCompleta)
        {
            IDALDireccionCompleta _DALDireccionCompleta = new DALDireccionCompleta();
            DireccionCompleta oDireccionCompleta = null;
            if (_DALDireccionCompleta.GetDireccionCompletaById(pDireccionCompleta.IdDireccion) == null)
            {
                oDireccionCompleta = _DALDireccionCompleta.SaveDireccionCompleta(pDireccionCompleta);
            }
            else
            {
                oDireccionCompleta = _DALDireccionCompleta.UpdateDireccionCompleta(pDireccionCompleta);
            }

            return oDireccionCompleta;
        }
    }
}
