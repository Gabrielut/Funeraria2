using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    public class Activo
    {
        public int IdActivo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int TipoActivo { get; set; }
        public int Cantidad { get; set; }
        public float Costo { get; set; }
        public float Precio { get; set; }
        public bool Estado { get; set; }
        public string InformacionAdicional { get; set; }
        public byte[] Img { get; set; }


        public override string ToString() => $"{Nombre} ";


    }
}
