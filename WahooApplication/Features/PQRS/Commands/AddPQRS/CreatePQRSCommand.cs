using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain;

namespace WahooApplication.Features.PQRS.Commands.AddPQRS
{
    public class CreatePQRSCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionPQRS { get; set; }
        public int UsuarioId { get; set; }
        public int TipoPQRSId { get; set; }
        public string UsuarioAdd { get; set; }
        public int Estado { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
