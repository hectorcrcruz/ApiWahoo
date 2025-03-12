using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Notificacion.Queries.ListNotificacion
{
    public class ListNotificacionQuery : IRequest<List<NotificacionModel>>
    {
        public ListNotificacionQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
