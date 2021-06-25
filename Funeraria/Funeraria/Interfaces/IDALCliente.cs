using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.Interfaces
{
    interface IDALCliente
    {
        List<Cliente> GetAllCliente();
        Cliente GetClienteById(int pId);
        Cliente SaveCliente(Cliente pCliente);
        List<Cliente> GetClienteByFilter(string pCorreo);
        bool DeleteCliente(int pId);
        Cliente UpdateCliente(Cliente pCliente);
        int GetNextNumeroCliente();
    }
}
