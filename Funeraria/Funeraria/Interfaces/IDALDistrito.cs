using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.Interfaces
{
    interface IDALDistrito
    {
        List<Distrito> GetDistritoById(int provincia, int canton);
    }
}
