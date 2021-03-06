using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.Interfaces
{
    interface IDALConvenios
    {
        List<ConveniosDTO> GetAllConvenios();
        Convenios GetConvenioById(int pConvenios);
        Convenios SaveConvenios(Convenios pConvenios);
        List<ConveniosDTO> GetConveniosByFilter(string pDescripcion);
        bool DaleteConvenios(int pId);
        Convenios UpdateConvenios(Convenios pConvenios);
    }
}
