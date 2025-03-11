using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.TipoPQRS.Queries.ListTipoPQRS
{
    public class ListTipoPQRSQuery : IRequest<List<TipoPQRSModel>>
    {
        public ListTipoPQRSQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
