using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Funeraria.Layers.Entities;

namespace UTN.Winform.Funeraria.Interfaces
{
    public interface IDALUsuarios
    {
        List<Usuarios> GetAllUsuarios();
        Usuarios GetUsuariosById(string pUsuarios);
        Usuarios GetUsuariosByCorreo(string pUsuarios);
        Usuarios SaveUsuarios(Usuarios pUsuarios);
        List<Usuarios> GetUsuariosByFilter(string pDescripcion);
        bool DeleteUsuarios(string pId);
        Usuarios UpdateUsuarios(Usuarios pUsuarios);
        Usuarios LoginUsuarios(string pCorreo);
        Usuarios updatePassword(Usuarios pUsuarios);

    }
}
