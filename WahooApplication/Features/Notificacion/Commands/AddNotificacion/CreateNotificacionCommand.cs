using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Notificacion.Commands.AddNotificacion
{
    public class CreateNotificacionCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionNotificacion { get; set; }
        public bool Enviada { get; set; }
        public int UsuarioId { get; set; }
        public string UsuarioAdd { get; set; }
        public int Estado { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
