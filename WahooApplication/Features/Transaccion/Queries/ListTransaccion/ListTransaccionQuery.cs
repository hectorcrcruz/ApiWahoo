using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Transaccion.Queries.ListTransaccion
{
    public class ListTransaccionQuery : IRequest<List<TransaccionModel>>
    {
        public ListTransaccionQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
