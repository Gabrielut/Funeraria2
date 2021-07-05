using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    class Canton
    {
        public int codProvincia { set; get; }
        public int codCanton { set; get; }       
        public string dscCanton { set; get; }
        public int logActivo { set; get; }

        public override string ToString()
        {
            return dscCanton;
        }
    }
}
