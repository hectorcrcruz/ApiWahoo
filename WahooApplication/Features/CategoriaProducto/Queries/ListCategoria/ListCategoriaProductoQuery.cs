using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.CategoriaProducto.Queries.ListCategoria
{
    public class ListCategoriaProductoQuery : IRequest<List<CategoriaProductoModel>>
    {
        public ListCategoriaProductoQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
