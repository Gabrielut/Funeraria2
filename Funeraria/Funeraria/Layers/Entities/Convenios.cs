using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    class Convenios
    {
        public int IdConvenio { get; set; }
        public string NomEmpresa { get; set; }
        public string ubicacion { get; set; }
        public string TelCelular { get; set; }
        public string TelEmpresa { get; set; }
        public string TelFax { get; set; }
        public int TipoServicio { get; set; }
        public int Descuento { get; set; }
        public bool Estado { get; set; }
        public string Comentarios { get; set; }

        public override string ToString()
        {
            return NomEmpresa;
        }
    }
}
