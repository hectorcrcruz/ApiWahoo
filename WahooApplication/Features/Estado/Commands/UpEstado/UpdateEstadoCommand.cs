using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Estado.Commands.UpEstado
{
    public class UpdateEstadoCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionEstado { get; set; }
        public int Estado { get; set; }
        public string UsuarioUp { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
