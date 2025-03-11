using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.PQRS.Commands.UpPQRS
{
    public class UpdatePQRSCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionPQRS { get; set; }
        public int UsuarioId { get; set; }
        public int TipoPQRSId { get; set; }
        public string UsuarioUp { get; set; }
        public int Estado { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
