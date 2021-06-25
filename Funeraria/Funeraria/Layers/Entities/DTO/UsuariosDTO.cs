using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities.DTO
{
    class UsuariosDTO
    {
        public string IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string IdRol { get; set; }
        public string Contrasenna { get; set; }
        public string Sexo { get; set; }
        public string FechaNacimiento { get; set; }
        public string Estado { get; set; }
        public string Direccion { get; set; }
        public string Token { get; set; }

        public override string ToString() => $"{Nombre} {PrimerApellido} {SegundoApellido}";
    }
}
