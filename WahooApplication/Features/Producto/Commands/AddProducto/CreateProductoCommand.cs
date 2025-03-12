using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain;

namespace WahooApplication.Features.Producto.Commands.AddProducto
{
    public class CreateProductoCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionProducto { get; set; }
        public int stock { get; set; }
        public decimal ValorProducto { get; set; }
        public byte ImagenProducto { get; set; }
        public int CategoriaProductoId { get; set; }
        public string UsuarioAdd { get; set; }
        public int Estado { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
