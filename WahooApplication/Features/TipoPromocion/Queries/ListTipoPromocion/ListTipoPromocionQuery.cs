using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.TipoPromocion.Queries.ListTipoPromocion
{
    public class ListTipoPromocionQuery : IRequest<List<TipoPromocionModel>>
    {
        public ListTipoPromocionQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
