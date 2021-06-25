using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    class Proveedor
    {
        public int IdProveedor { get; set; }
        public string NomProveedor { get; set; }
        public string Propietario { get; set; }
        public string TelCelular { get; set; }
        public string TelProveedor { get; set; }
        public string TelFax { get; set; }
        public string Correo { get; set; }
        public int IdTipoServicio { get; set; }
        public int CantUni { get; set; }
        public float Precio { get; set; }
        public bool Estado { get; set; }
    }
}
