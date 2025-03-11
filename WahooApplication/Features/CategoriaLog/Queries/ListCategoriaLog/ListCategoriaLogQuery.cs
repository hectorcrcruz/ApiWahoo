using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.CategoriaLog.Queries.ListCategoriaLog
{
    public class ListCategoriaLogQuery : IRequest<List<CategoriaLogModel>>
    {
        public ListCategoriaLogQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
