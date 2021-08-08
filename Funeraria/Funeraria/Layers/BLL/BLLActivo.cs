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
    class BLLActivo : IBLLActivo
    {
        public bool DaleteActivo(int pId)
        {
            IDALActivo _DalActivo = new DALActivo();
            return _DalActivo.DaleteActivo(pId);
        }
        public List<ActivoDTO> GetActivoByFilter(string pDescripcion)
        {
            IDALActivo _DalActivo = new DALActivo();
            return _DalActivo.GetActivoByFilter(pDescripcion);
        }
        public Activo GetActivoById(int pActivo)
        {
            IDALActivo _DalActivo = new DALActivo();
            return _DalActivo.GetActivoById(pActivo);
        }
        public int GetNextNumeroActivo()
        {
            IDALActivo _DalActivo = new DALActivo();
            return _DalActivo.GetNextNumeroActivo();
        }
        public Activo SaveActivo(Activo pActivo)
        {
            IDALActivo _DALActivo = new DALActivo();
            Activo oActivo = null;
            if (_DALActivo.GetActivoById(pActivo.IdActivo) == null)
            {
                oActivo = _DALActivo.SaveActivo(pActivo);
            }
            else
            {
                oActivo = _DALActivo.UpdateActivo(pActivo);
            }

            return oActivo;
        }
        List<Activo> IBLLActivo.GetAllActivos()
        {
            IDALActivo _DalActivo = new DALActivo();
            return _DalActivo.GetAllActivos();
        }
    }
}
