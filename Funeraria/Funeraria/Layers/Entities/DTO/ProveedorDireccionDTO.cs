using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities.DTO
{
    class ProveedorDireccionDTO
    {
        public int IdProveedor { get; set; }
        public string NomProveedor { get; set; }
        public string Propietario { get; set; }
        public string TelCelular { get; set; }
        public string TelProveedor { get; set; }
        public string TelFax { get; set; }
        public string Correo { get; set; }
        public string Servicio { get; set; }
        public int CantUni { get; set; }
        public string Precio { get; set; }
        public bool Estado { get; set; }
        public int Provincia { set; get; }
        public int Canton { set; get; }
        public int Distrito { set; get; }
        public int Barrio { set; get; }
        public string OtrasSennas { set; get; }
    }
}
