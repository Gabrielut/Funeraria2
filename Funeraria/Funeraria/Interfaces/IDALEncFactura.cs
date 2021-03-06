using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.Interfaces
{
    interface IDALEncFactura
    {
        List<EncFactura> GetAllEncFactura();
        EncFactura SaveEncFactura(EncFactura pEncFactura);
        EncFactura GetEncFacturaById(int id);
    }
}
