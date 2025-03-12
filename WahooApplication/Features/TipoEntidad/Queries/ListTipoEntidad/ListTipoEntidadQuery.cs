using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.TipoEntidad.Queries.ListTipoEntidad
{
    public class ListTipoEntidadQuery : IRequest<List<TipoEntidadModel>>
    {
        public ListTipoEntidadQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
