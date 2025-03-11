using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.PQRS.Queries.ListPQRS
{
    public class ListPQRSQuery : IRequest<List<PQRSModel>>
    {
        public ListPQRSQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
