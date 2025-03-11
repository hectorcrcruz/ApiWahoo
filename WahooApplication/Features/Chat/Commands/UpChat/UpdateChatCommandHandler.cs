using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Chat.Commands.AddChat;

namespace WahooApplication.Features.Chat.Commands.UpChat
{
    public class UpdateChatCommandHandler : IRequestHandler<UpdateChatCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateChatCommandHandler> _logger;
        public UpdateChatCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateChatCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateChatCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Chat>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.Mensaje = request.Mensaje;
                VerifiData.DocumentoSoporte = request.DocumentoSoporte;
                VerifiData.Emisor = request.Emisor;
                VerifiData.Receptor = request.Receptor;
                VerifiData.Documento = request.Documento;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Chat>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El chat fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El chat no fue actualizado");

                return resp = false;
            }
        }
    }
}
