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
    class BLLCotizacion : IBLLCotizacion
    {
        public List<Cotizacion> GetAllCotizacion()
        {
            IDALCotizacion _DalCotizacion = new DALCotizacion();
            return _DalCotizacion.GetAllCotizacion();
        }

        public List<Cotizacion> GetCotizacionById(int id)
        {
            IDALCotizacion _DalCotizacion = new DALCotizacion();
            return _DalCotizacion.GetCotizacionById(id);
        }

        public List<CotizacionDTO> GetCotizacionByIdDTO(int id)
        {
            IDALCotizacion _DalCotizacion = new DALCotizacion();
            return _DalCotizacion.GetCotizacionByIdDTO(id);
        }

        public int nextValue()
        {
            IDALCotizacion _DalCotizacion = new DALCotizacion();
            return _DalCotizacion.nextValue();
        }

        public Cotizacion SaveCotizacion(Cotizacion pCotizacion)
        {
            IDALCotizacion _DalCotizacion = new DALCotizacion();
            return _DalCotizacion.SaveCotizacion(pCotizacion);
        }

    }
}
