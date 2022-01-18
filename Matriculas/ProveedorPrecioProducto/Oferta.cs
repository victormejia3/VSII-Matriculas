using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProveedorPrecioProducto
{
    public class Oferta
    {
        public int Precio_Id { get; set; }
        public Producto producto { get; set; }
        public Proveedor proveedor { get; set; }
        public decimal precio { get; set; }
        public float LoteMinimo { get; set; }
    }
}
