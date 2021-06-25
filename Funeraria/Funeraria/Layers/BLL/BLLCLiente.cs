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
    class BLLCLiente : IBLLCliente
    {
        public bool DeleteCliente(int pId)
        {

            IDALCliente _DalCliente = new DALCliente();
            return _DalCliente.DeleteCliente(pId);

        }

        public List<Cliente> GetAllCliente()
        {

            IDALCliente _DalCliente = new DALCliente();
            return _DalCliente.GetAllCliente();
        }

        public List<Cliente> GetClienteByFilter(string pCorreo)
        {
            IDALCliente _DalCliente = new DALCliente();
            return _DalCliente.GetClienteByFilter(pCorreo);
        }

        public Cliente GetClienteById(int pId)
        {
            IDALCliente _DalCliente = new DALCliente();
            return _DalCliente.GetClienteById(pId);
        }

        public int GetNextNumeroCliente()
        {
            IDALCliente _DalCliente = new DALCliente();
            return _DalCliente.GetNextNumeroCliente();
        }

        public Cliente SaveCliente(Cliente pCliente)
        {
            IDALCliente _DalCliente = new DALCliente();
            Cliente oCliente = null;
            if (_DalCliente.GetClienteById(pCliente.IdCliente) == null)
            {
                oCliente = _DalCliente.SaveCliente(pCliente);
            }
            else
            {
                oCliente = _DalCliente.UpdateCliente(pCliente);
            }

            return oCliente;
        }
    }
}

