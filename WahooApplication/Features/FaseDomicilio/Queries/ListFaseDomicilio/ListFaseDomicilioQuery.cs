using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.FaseDomicilio.Queries.ListFaseDomicilio
{
    public class ListFaseDomicilioQuery : IRequest<List<FaseDomicilioModel>>
    {
        public ListFaseDomicilioQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
