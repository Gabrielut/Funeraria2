using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.Interfaces
{
    interface IBLLDireccionCompleta
    {
        List<DireccionCompleta> GetAllDireccionCompleta();
        DireccionCompleta GetDireccionCompletaById(int pProovedor);
        DireccionCompleta SaveDireccionCompleta(DireccionCompleta pDireccionCompleta);
        List<DireccionCompleta> GetDireccionCompletaByFilter(string pDescripcion);
        bool DaleteDireccionCompleta(int pId);
    }
}
