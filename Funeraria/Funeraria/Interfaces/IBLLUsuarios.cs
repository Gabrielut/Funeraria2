using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.Interfaces
{
    public interface IBLLUsuarios
    {
        List<Usuarios> GetAllUsuarios();
        Usuarios GetUsuariosById(string pUsuarios);
        Usuarios GetUsuariosByCorreo(string pUsuarios);
        Usuarios SaveUsuarios(Usuarios pUsuarios);
        List<Usuarios> GetUsuariosByFilter(string pDescripcion);
        bool DaleteUsuarios(string pId);
        Usuarios LoginUsuarios(string pCorreo);
        Usuarios updatePassword(Usuarios pUsuarios);

    }
}
