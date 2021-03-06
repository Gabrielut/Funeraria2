using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
   public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Sexo { get; set; }
        public string Direccion { get; set; }

        public override string ToString() => $"{Nombre}  {PrimerApellido} ";
    }
}
