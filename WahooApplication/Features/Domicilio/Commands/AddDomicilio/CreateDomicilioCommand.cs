using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain;

namespace WahooApplication.Features.Domicilio.Commands.AddDomicilio
{
    public class CreateDomicilioCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionDomicilio { get; set; }
        public int UsuarioId { get; set; }
        public int ProductoId { get; set; }
        public int FaseDomicilioId { get; set; }
        public DateTime? FechaAceptaDomiciliario { get; set; }
        public DateTime? FechaAceptaEntidad { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public int? AceptaEntidad { get; set; }
        public int? AceptaDomiciliario { get; set; }
        public bool? DomicilioExitoso { get; set; }
        public int Estado { get; set; }
        public string UsuarioAdd { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
