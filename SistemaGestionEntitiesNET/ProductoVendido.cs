using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class ProductoVendido
    {
        public int Id { get; set; }
        public string IdProducto { get; set; }
        public double Stock { get; set; }
        public string IdVenta { get; set; }

    }
}