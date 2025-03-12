using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Promocion.Queries.ListPromocion
{
    public class ListPromocionQuery : IRequest<List<PromocionModel>>
    {
        public ListPromocionQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
