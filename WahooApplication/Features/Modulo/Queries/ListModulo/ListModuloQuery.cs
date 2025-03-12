using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Modulo.Queries.ListModulo
{
    public class ListModuloQuery : IRequest<List<ModuloModel>>
    {
        public ListModuloQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
