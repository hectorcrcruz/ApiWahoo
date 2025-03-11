using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.TiempoFase.Commands.AddTiempoFase
{
    public class CreateTiempoFaseCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public DateTime HoraCambioFase { get; set; }
        public int DomicilioId { get; set; }
        public string UsuarioAdd { get; set; }
        public int Estado { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
