using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.Interfaces
{
    interface IDALCotizacion
    {
        List<Cotizacion> GetAllCotizacion();
        List<Cotizacion> GetCotizacionById(int id);
        List<CotizacionDTO> GetCotizacionByIdDTO(int id);
        Cotizacion SaveCotizacion(Cotizacion pCotizacion);
        int nextValue();
    }
}
