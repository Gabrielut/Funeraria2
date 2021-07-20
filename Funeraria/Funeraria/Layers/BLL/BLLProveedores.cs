using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Interfaces;
using UTN.Winform.Funeraria.Layers.DAL;
using UTN.Winform.Funeraria.Layers.Entities;
using UTN.Winform.Funeraria.Layers.Entities.DTO;

namespace UTN.Winform.Funeraria.Layers.BLL
{
    class BLLProveedores : IBLLProveedores
    {
        public bool DaleteProveedor(int pId)
        {
            IDALProveedores _DalProveedores = new DALProveedores();
            return _DalProveedores.DaleteProveedor(pId);
        }

        public int GetNextNumeroActivo()
        {
            IDALProveedores _DalProveedores = new DALProveedores();
            return _DalProveedores.GetNextNumeroActivo();
        }

        public List<ProveedorDTO> GetProveedorByFilter(string pDescripcion)
        {
            IDALProveedores _DalProveedores = new DALProveedores();
            return _DalProveedores.GetProveedorByFilter(pDescripcion);
        }

        public Proveedor GetProveedorById(int pProveedor)
        {
            IDALProveedores _DalProveedores = new DALProveedores();
            return _DalProveedores.GetProveedorById(pProveedor);
        }

        public Proveedor SaveProveedor(Proveedor pProveedor)
        {
            IDALProveedores _DALProveedor = new DALProveedores();
            Proveedor oProveedor = null;
            if (_DALProveedor.GetProveedorById(pProveedor.IdProveedor) == null)
            {
                oProveedor = _DALProveedor.SaveProveedor(pProveedor);
            }
            else
            {
                oProveedor = _DALProveedor.UpdateProveedor(pProveedor);
            }

            return oProveedor;
        }

        public Proveedor UpdateProveedor(Proveedor pProveedor)
        {
            IDALProveedores _DalProveedores = new DALProveedores();
            return _DalProveedores.UpdateProveedor(pProveedor);
        }

        List<ProveedorDTO> IBLLProveedores.GetAllProveedor()
        {
            IDALProveedores _DalProveedores = new DALProveedores();
            return _DalProveedores.GetAllProveedor();
        }
    }
}
