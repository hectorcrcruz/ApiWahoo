using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.TipoIdentificacion.Queries.ListTipoIdentificacion
{
    public class ListTipoIdentificacionQuery : IRequest<List<TipoIdentificacionModel>>
    {
        public ListTipoIdentificacionQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
