using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Parametrizacion.Queries.ListParametrizacion
{
    public class ListParametrizacionQuery : IRequest<List<ParametrizacionModel>>
    {
        public ListParametrizacionQuery(int? id)
        {
            Id = id;
        }
        public int? Id { get; set; }
    }
}
