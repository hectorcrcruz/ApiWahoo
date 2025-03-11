using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Pais.Queries.ListPais
{
    public class ListPaisQuery : IRequest<List<PaisModel>>
    {
        public ListPaisQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
