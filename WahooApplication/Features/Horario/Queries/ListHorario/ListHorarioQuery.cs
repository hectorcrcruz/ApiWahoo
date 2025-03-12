using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Horario.Queries.ListHorario
{
    public class ListHorarioQuery : IRequest<List<HorarioModel>>
    {
        public ListHorarioQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
