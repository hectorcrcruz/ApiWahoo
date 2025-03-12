using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.TiempoFase.Commands.UpTiempoFase
{
    public class UpdateTiempoFaseCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public DateTime HoraCambioFase { get; set; }
        public int DomicilioId { get; set; }
        public string UsuarioUp { get; set; }
        public int Estado { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
