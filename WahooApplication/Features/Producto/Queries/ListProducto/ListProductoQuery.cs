using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Producto.Queries.ListProducto
{
    public class ListProductoQuery : IRequest<List<ProductoModel>>
    {
        public ListProductoQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
