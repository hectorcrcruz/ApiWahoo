using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Calificacion.Queries.ListCalificacion
{
    public class ListCalificacionQuery : IRequest<List<CalificacionModel>>
    {
        public ListCalificacionQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
