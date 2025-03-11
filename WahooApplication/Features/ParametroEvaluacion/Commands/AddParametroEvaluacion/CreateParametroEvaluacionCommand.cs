using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.ParametroEvaluacion.Commands.AddParametroEvaluacion
{
    public class CreateParametroEvaluacionCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionParametro { get; set; }
        public string UsuarioAdd { get; set; }
        public int Estado { get; set; }
        public DateTime FechaAdd { get; set; }

    }
}
