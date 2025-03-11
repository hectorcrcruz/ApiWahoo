using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Models;

namespace WahooApplication.Features.Chat.Queries.ListChat
{
    public class ListChatQuery : IRequest<List<ChatModel>>
    {
        public ListChatQuery(int? id)
        {
            id = Id;
        }
        public int? Id { get; set; }
    }
}
