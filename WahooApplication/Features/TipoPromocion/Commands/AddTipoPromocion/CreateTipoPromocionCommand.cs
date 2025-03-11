using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.TipoPromocion.Commands.AddTipoPromocion
{
    public class CreateTipoPromocionCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionTipoPromocion { get; set; }
        public string UsuarioAdd { get; set; }
        public int Estado { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
