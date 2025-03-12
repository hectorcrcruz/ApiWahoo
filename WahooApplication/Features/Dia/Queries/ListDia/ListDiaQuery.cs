using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Dia.Queries.ListDia
{
    public class ListDiaQuery : IRequest<List<DiaModel>>
    {
        public ListDiaQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
