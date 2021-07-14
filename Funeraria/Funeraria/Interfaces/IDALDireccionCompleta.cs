using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.Interfaces
{
    interface IDALDireccionCompleta
    {
        List<DireccionCompleta> GetAllDireccionCompleta();
        DireccionCompleta GetDireccionCompletaById(int pProovedor);
        DireccionCompleta SaveDireccionCompleta(DireccionCompleta pDireccionCompleta);
        List<DireccionCompleta> GetDireccionCompletaByFilter(string pDescripcion);
        DireccionCompleta UpdateDireccionCompleta(DireccionCompleta pDireccionCompleta);
        bool DaleteDireccionCompleta(int pId);
    }
}
