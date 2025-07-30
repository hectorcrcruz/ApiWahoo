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
    public class UpdateFaseDomicilioCommandHandler : IRequestHandler<UpdateFaseDomicilioCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateFaseDomicilioCommandHandler> _logger;
        public UpdateFaseDomicilioCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateFaseDomicilioCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateFaseDomicilioCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.FaseDomicilio>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionFaseDomicilio = request.DescripcionFaseDomicilio;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.FaseDomicilio>().UpdateAsync(VerifiData);

                _logger.LogInformation($"La fase de domicilio fue actualizada");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La fase de domicilio no fue actualizada");

                return resp = false;
            }
        }
    }
}
