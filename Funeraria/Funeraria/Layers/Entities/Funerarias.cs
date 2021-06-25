using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    class Funerarias
    {
        public int IdFuneraria { get; set; }
        public String Nombre { get; set; }
        public String Propietario { get; set; }
        public String Encargado { get; set; }
        public int codProvincia { get; set; }
        public int CodCanton { get; set; }
        public int CodDistrito { get; set; }
        public int CodBarrio { get; set; }
        public String Correo { get; set; }
        public String TelCelular { get; set; }
        public String TelEmpresa { get; set; }
        public String TelFax { get; set; }
        public bool Estado { get; set; }
    }
}
