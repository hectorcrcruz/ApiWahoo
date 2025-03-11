using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Log.Queries.ListLog
{
    public class ListLogQuery : IRequest<List<LogModel>>
    {
        public ListLogQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
