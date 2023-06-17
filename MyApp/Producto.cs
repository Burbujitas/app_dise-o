using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
   public class Producto
    {
        public String codigo { get; set; }
        public String categoria { get; set; }
        public int stock { get; set; }
        public double precio { get; set; }
        public String descripcion { get; set; }
        public bool activo { get; set; }
    }
}
