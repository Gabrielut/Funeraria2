using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities.DTO
{
    public class ProveedorDTO
    {
        public int IdProveedor { get; set; }
        public string NomProveedor { get; set; }
        public string Propietario { get; set; }
        public string TelCelular { get; set; }
        public string TelProveedor { get; set; }
        public string TelFax { get; set; }
        public string Correo { get; set; }
        public string IdTipoServicio { get; set; }
        public int CantUni { get; set; }
        public string Precio { get; set; }
        public string Estado { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Barrio { get; set; }
        public string otrasSennas { get; set; }

        public override string ToString() => $"{NomProveedor} ";
    }
}
