﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Funeraria.Layers.Entities
{
    class Cotizacion
    {

        public int IdCotizacion { get; set; }
        public int IdCliente { get; set; }
        public int IdPaquete { get; set; }
        public int IdFuneraria { get; set; }
        public int IdConvenio { get; set; }
        public int IdProveedores { get; set; }
        public int IdActivo { get; set; }
        public string Comentarios { get; set; }
    }
}
