using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities.DTO
{
    public class CotizacionDTO
    {
        public int IdCotizacion { get; set; }
        public String cliente { get; set; }
        public String paquete { get; set; }
        public String funeraria { get; set; }
        public String convenio { get; set; }
        public String proveedores { get; set; }
        public String activo { get; set; }
        public string comentariosProveedores { get; set; }
        public string omentariosPaquete { get; set; }
    }
}
