using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities.DTO
{
   public class PaqueteDTO
    {
        public int IdPaquete { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public int Cantidad { get; set; }
        public string TipoServicio { get; set; }
        public string Estado { get; set; }
    }
}
