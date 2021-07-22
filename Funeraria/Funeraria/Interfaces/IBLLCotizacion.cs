using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.Interfaces
{
    interface IBLLCotizacion
    {
        List<Cotizacion> GetAllCotizacion();
        Cotizacion SaveCotizacion(Cotizacion pCotizacion);
    }
}
