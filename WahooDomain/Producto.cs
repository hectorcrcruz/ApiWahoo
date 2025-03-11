using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain.Common;

namespace WahooDomain
{
    public class Producto : Entity
    {
        public string DescripcionProducto { get; set; }
        public int stock { get; set; }
        public decimal ValorProducto { get; set; }
        public byte ImagenProducto { get; set; }
        public int CategoriaProductoId { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }

    }
}
