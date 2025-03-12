using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.ParametroEvaluacion.Queries.ListParametroEvaluacion
{
    public class ListParametroEvaluacionQuery : IRequest<List<ParametroEvaluacionModel>>
    {
        public ListParametroEvaluacionQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
