using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.MedioPago.Queries.ListMedioPago
{
    public class ListMedioPagoQuery : IRequest<List<MedioPagoModel>>
    {
        public ListMedioPagoQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }

    }
}
