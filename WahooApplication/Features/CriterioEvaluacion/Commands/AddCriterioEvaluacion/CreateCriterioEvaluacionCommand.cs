using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.CriterioEvaluacion.Commands.AddCriterioEvaluacion
{
    public class CreateCriterioEvaluacionCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionCriterioEvaluacion { get; set; }
        public int Estado { get; set; }
        public string UsuarioAdd { get; set; }
        public DateTime FechaAdd { get; set; }
    }
}
