using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProveedorPrecioProducto
{
    public class Proveedor
    {
        public int Proveedor_id { get; set; }
        public string Nombre { get; set; }
        public IEnumerable<Oferta> ListaOfertas { get; set; }
    }
}
