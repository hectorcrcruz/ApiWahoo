using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Chat.Commands.UpChat;

namespace WahooApplication.Features.FaseDomicilio.Commands.UpFaseDomicilio
{
    public class UpdateFaseDomicilioCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string DescripcionFaseDomicilio { get; set; }
        public int Estado { get; set; }
        public string UsuarioUp { get; set; }
        public DateTime FechaUp { get; set; }
    }
}
