using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Transaccion.Commands.UpTransaccion
{
    public class UpdateTransaccionCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionTransaccion { get; set; }
        public int TipoTransaccionId { get; set; }
        public int EntidadId { get; set; }
        public int DomicilioId { get; set; }
        public string DescripcionAdicional { get; set; }
        public string UsuarioUp { get; set; }
        public int Estado { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
