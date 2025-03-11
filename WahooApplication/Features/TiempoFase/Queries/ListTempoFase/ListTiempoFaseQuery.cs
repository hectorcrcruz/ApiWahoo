using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.TiempoFase.Queries.ListTempoFase
{
    public class ListTiempoFaseQuery : IRequest<List<TiempoFaseModel>>
    {
        public ListTiempoFaseQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
