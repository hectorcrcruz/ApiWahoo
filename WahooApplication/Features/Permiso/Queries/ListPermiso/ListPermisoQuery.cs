using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Permiso.Queries.ListPermiso
{
    public class ListPermisoQuery : IRequest<List<PermisoModel>>
    {
        public ListPermisoQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
