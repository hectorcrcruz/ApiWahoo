using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Ciudad.Queries.ListCiudad
{
    public class ListCiudadQuery : IRequest<List<CiudadModel>>
    {
        public ListCiudadQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
