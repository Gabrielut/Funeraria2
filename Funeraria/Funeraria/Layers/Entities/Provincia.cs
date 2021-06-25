using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    class Provincia
    {
        public int codProvincia { set; get; }
        public string dscCortaProvincia { set; get; }
        public string dscProvincia { set; get; }
        public int logActivo { set; get; }

        public override string ToString()
        {
            return codProvincia + " " + dscProvincia;
        }
    }
}
