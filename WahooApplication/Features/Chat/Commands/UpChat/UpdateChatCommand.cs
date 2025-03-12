using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Features.Chat.Commands.UpChat
{
    public class UpdateChatCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public byte DocumentoSoporte { get; set; }
        public int Emisor { get; set; }
        public int Receptor { get; set; }
        public byte Documento { get; set; }
        public int Estado { get; set; }
        public string UsuarioUp { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
