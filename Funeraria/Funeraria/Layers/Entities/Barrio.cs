using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    class Barrio
    {
        public int codProvincia { set; get; }
        public int codCanton { set; get; }
        public int codDistrito { set; get; }
        public int codBarrio { set; get; }
        public string dscBarrio { set; get; }
        public int logActivo { set; get; }

        public override string ToString()
        {
            return codBarrio + " " + dscBarrio;
        }
    }
}
