using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.FaseDomicilio.Commands.AddFaseDomicilio
{
    public class CreateFaseDomicilioCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionFaseDomicilio { get; set; }
        public int Estado { get; set; }
        public string UsuarioAdd { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
