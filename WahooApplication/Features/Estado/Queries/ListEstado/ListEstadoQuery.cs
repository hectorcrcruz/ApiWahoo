using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Estado.Queries.ListEstado
{
    public class ListEstadoQuery : IRequest<List<EstadoModel>>
    {
        public ListEstadoQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
