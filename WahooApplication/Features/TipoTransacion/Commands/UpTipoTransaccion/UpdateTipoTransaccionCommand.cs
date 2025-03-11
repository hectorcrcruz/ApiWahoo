using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.TipoTransacion.Commands.UpTipoTransaccion
{
    public class UpdateTipoTransaccionCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DecripcionTipoTransaccion { get; set; }
        public string UsuarioUp { get; set; }
        public int Estado { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
