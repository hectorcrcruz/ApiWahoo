using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Horario.Commands.UpHorario
{
    public class UpdateHorarioCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionHorario { get; set; }
        public string FranjaHorario { get; set; }
        public string DiasLaborales { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public int UsuarioId { get; set; }
        public int DiaId { get; set; }
        public int Estado { get; set; }
        public string UsuarioUp { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
