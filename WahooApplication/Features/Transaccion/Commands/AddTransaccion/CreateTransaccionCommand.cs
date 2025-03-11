using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain;

namespace WahooApplication.Features.Transaccion.Commands.AddTransaccion
{
    public class CreateTransaccionCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionTransaccion { get; set; }
        public int TipoTransaccionId { get; set; }
        public int EntidadId { get; set; }
        public int DomicilioId { get; set; }
        public string DescripcionAdicional { get; set; }
        public string UsuarioAdd { get; set; }
        public int Estado { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
