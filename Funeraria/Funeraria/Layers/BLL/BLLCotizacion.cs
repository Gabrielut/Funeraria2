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
    class BLLCotizacion : IBLLCotizacion
    {
        public List<Cotizacion> GetAllCotizacion()
        {
            IDALCotizacion _DalCotizacion = new DALCotizacion();
            return _DalCotizacion.GetAllCotizacion();
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
