using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.Interfaces
{
    interface IBLLProveedores
    {
        List<ProveedorDTO> GetAllProveedor();
        Proveedor GetProveedorById(int pProveedor);
        Proveedor SaveProveedor(Proveedor pProveedor);
        List<Proveedor> GetProveedorByFilter(string pDescripcion);
        bool DaleteProveedor(int pId);
        Proveedor UpdateProveedor(Proveedor pProveedor);
        int GetNextNumeroActivo();
    }
}
