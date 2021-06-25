using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    public class Usuarios
    {

        public string IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int IdRol { get; set; }
        public string Contrasenna { get; set; }
        public int Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Estado { get; set; }

        public string Direccion { get; set; }
        public string Token { get; set; }

        public Rol Rol
        {
            get => default;
            set
            {
            }
        }

        public override string ToString() => $"{Nombre} {PrimerApellido} {SegundoApellido}";
        
    }
}
