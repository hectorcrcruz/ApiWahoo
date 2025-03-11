using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Departamento.Queries.ListDepartamento
{
    public class ListDepartamentoQuery : IRequest<List<DepartamentoModel>>
    {
        public ListDepartamentoQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
