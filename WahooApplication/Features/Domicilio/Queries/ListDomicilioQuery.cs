using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Domicilio.Queries
{
    public class ListDomicilioQuery : IRequest<List<DomicilioModel>>
    {
        public ListDomicilioQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
