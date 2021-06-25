using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    class TipoPaquete
    {
        public int IdTipoPaquete { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
