using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Producto.Commands.UpProducto
{
    public class UpdateProductoCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionProducto { get; set; }
        public int stock { get; set; }
        public decimal ValorProducto { get; set; }
        public byte ImagenProducto { get; set; }
        public int CategoriaProductoId { get; set; }
        public string UsuarioUp { get; set; }
        public int Estado { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
