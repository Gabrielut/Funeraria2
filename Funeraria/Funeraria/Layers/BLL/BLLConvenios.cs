using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.DAL;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.Layers.BLL
{
    class BLLConvenios : IBLLConvenios
    {
        public bool DaleteConvenios(int pId)
        {
            IDALConvenios _DalConvenios = new DALConvenios();
            return _DalConvenios.DaleteConvenios(pId);
        }

        public List<ConveniosDTO> GetAllConvenios()
        {
            IDALConvenios _DalConvenios = new DALConvenios();
            return _DalConvenios.GetAllConvenios();
        }

        public Convenios GetConvenioById(int pConvenios)
        {
            IDALConvenios _DalConvenios = new DALConvenios();
            return _DalConvenios.GetConvenioById(pConvenios);
        }

        public List<ConveniosDTO> GetConveniosByFilter(string pDescripcion)
        {
            IDALConvenios _DalConvenios = new DALConvenios();
            return _DalConvenios.GetConveniosByFilter(pDescripcion);
        }

        public Convenios SaveConvenios(Convenios pConvenios)
        {
            IDALConvenios _DALConvenios = new DALConvenios();
            Convenios oConvenios = null;
            if (_DALConvenios.GetConvenioById(pConvenios.IdConvenio) == null)
            {
                oConvenios = _DALConvenios.SaveConvenios(pConvenios);
            }
            else
            {
                oConvenios = _DALConvenios.UpdateConvenios(pConvenios);
            }

            return oConvenios;
        }
    }
}
