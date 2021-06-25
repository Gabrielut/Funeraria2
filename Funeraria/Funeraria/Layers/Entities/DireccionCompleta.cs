using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    class DireccionCompleta
    {
        public int IdCliente { get; set; }
        public int Provincia { set; get; }
        public int Canton { set; get; }
        public int Distrito { set; get; }
        public int Barrio { set; get; }
        public string OtrasSennas { set; get; }
       

        public override string ToString()
        {
            return Barrio + " " + OtrasSennas;
        }
    }
}
