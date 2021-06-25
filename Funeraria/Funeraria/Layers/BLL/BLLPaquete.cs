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
    class BLLPaquete : IBLLPaquete
    {
        public bool DaletePaquete(int pId)
        {
            IDALPaquete _DalPaquete = new DALPaquete();
            return _DalPaquete.DaletePaquete(pId);
        }

        public List<Paquete> GetAllPaquete()
        {
            IDALPaquete _DalPaquete = new DALPaquete();
            return _DalPaquete.GetAllPaquete();
        }

        public int GetNextNumeroActivo()
        {
            IDALPaquete _DalPaquete = new DALPaquete();
            return _DalPaquete.GetNextNumeroActivo();
        }

        public List<Paquete> GetPaqueteByFilter(string pDescripcion)
        {
            IDALPaquete _DalPaquete = new DALPaquete();
            return _DalPaquete.GetPaqueteByFilter(pDescripcion);
        }

        public Paquete GetPaqueteById(int pPaquete)
        {
            IDALPaquete _DalPaquete = new DALPaquete();
            return _DalPaquete.GetPaqueteById(pPaquete);
        }

        public Paquete SavePaquete(Paquete pPaquete)
        {
            IDALPaquete _DALPaquete = new DALPaquete();
            Paquete oPaquete = null;
            if (_DALPaquete.GetPaqueteById(pPaquete.IdPaquete) == null)
            {
                oPaquete = _DALPaquete.SavePaquete(pPaquete);
            }
            else
            {
                oPaquete = _DALPaquete.UpdatePaquete(pPaquete);
            }

            return oPaquete;
        }

        public Paquete UpdatePaquete(Paquete pPaquete)
        {
            IDALPaquete _DalPaquete = new DALPaquete();
            return _DalPaquete.UpdatePaquete(pPaquete);
        }
    }
}
