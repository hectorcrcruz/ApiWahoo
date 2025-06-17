using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models.CommonVm;
using WahooDomain;

namespace WahooApplication.Models
{
    public class ProductoModel : CommonModel
    {
        public string DescripcionProducto { get; set; }
        public int stock { get; set; }
        public decimal ValorProducto { get; set; }
        public string ImagenProducto { get; set; }
        public int CategoriaProductoId { get; set; }
        public string DetalleProducto { get; set; }

    }
}
