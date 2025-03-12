using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.CriterioEvaluacion.Queries.ListCriterioEvaluacion
{
    public class ListCriterioEvaluacionQuery : IRequest<List<CriterioEvaluacionModel>>
    {
        public ListCriterioEvaluacionQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
