using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Entidad.Commands.UpEntidad
{
    public class UpdateEntidadCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionEntidad { get; set; }
        public int TipoEntidadId { get; set; }
        public int MedioPagoId { get; set; }
        public int Estado { get; set; }
        public string UsuarioUp { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
