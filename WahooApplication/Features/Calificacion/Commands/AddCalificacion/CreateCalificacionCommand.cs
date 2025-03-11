using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain;

namespace WahooApplication.Features.Calificacion.Commands.CreateCalificacion
{
    public class CreateCalificacionCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int PuntajeCalificacion { get; set; }
        public int ParametroEvaluacionId { get; set; }
        public int CriterioEvaluacionId { get; set; }
        public int UsuarioId { get; set; }
        public int Estado { get; set; }
        public string UsuarioAdd { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
