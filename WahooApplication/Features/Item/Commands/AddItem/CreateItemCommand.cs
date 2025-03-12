using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Item.Commands.AddItem
{
    public class CreateItemCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionItem { get; set; }
        public int CantidadItem { get; set; }
        public string UnidadMedidaItem { get; set; }
        public int Estado { get; set; }
        public string UsuarioAdd { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
