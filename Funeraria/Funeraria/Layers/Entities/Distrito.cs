using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    class Distrito
    {
        public int codProvincia { set; get; }
        public int codCanton { set; get; }
        public int codDistrito { get; set; }
        public string dscDistrito { set; get; }
        public int logActivo { set; get; }

        public override string ToString()
        {
            return dscDistrito;
        }
    }
}
