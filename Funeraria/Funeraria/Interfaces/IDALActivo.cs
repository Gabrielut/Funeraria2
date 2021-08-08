using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.Interfaces
{
    interface IDALActivo
    {
        List<Activo> GetAllActivos();
        Activo GetActivoById(int pActivo);
        Activo SaveActivo(Activo pActivo);
        List<ActivoDTO> GetActivoByFilter(string pDescripcion);
        bool DaleteActivo(int pId);
        Activo UpdateActivo(Activo pActivo);
        int GetNextNumeroActivo();
    }
}
