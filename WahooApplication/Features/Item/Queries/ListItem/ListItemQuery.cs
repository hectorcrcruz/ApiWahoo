using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Item.Queries.ListItem
{
    public class ListItemQuery : IRequest<List<ItemModel>>
    {
        public ListItemQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
