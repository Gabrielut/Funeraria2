using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.Interfaces
{
    interface IDALPaquete
    {
        List<Paquete> GetAllPaquete();
        Paquete GetPaqueteById(int pPaquete);
        Paquete SavePaquete(Paquete pPaquete);
        List<PaqueteDTO> GetPaqueteByFilter(string pDescripcion);
        bool DaletePaquete(int pId);
        Paquete UpdatePaquete(Paquete pPaquete);
        int GetNextNumeroActivo();
    }
}
