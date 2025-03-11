using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Entidad.Queries.ListEntidad
{
    public class ListEntidadQuery : IRequest<List<EntidadModel>>
    {
        public ListEntidadQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
