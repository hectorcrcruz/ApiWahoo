using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Saldo.Queries.ListSaldo
{
    public class ListSaldoQuery : IRequest<List<SaldoModel>>
    {
        public ListSaldoQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
