using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain;

namespace WahooApplication.Features.Entidad.Commands.AddEntidad
{
    public class CreateEntidadCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionEntidad { get; set; }
        public int TipoEntidadId { get; set; }
        public int MedioPagoId { get; set; }
        public int Estado { get; set; }
        public string UsuarioAdd { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
