using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Rol.Queries.ListRol
{
    public class ListRolQuery : IRequest<List<RolModel>>
    {
        public ListRolQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
