using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    class EncFactura
    {
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdConvenio { get; set; }
        public float Subtotal { get; set; }
        public float IVA { get; set; }
        public float Total { get; set; }
        public Cotizacion IdCotizacion { get; set; }
        public bool Estado { get; set; }

    }
}
