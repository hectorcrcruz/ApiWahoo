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

namespace WahooApplication.Features.Domicilio.Commands.UpDomicilio
{
    public class UpdateDomicilioCommandHandler : IRequestHandler<UpdateDomicilioCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateDomicilioCommandHandler> _logger;
        public UpdateDomicilioCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateDomicilioCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateDomicilioCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Domicilio>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionDomicilio = request.DescripcionDomicilio;
                VerifiData.UsuarioId = request.UsuarioId;
                VerifiData.FaseDomicilioId = request.FaseDomicilioId;
                VerifiData.FechaAceptaDomiciliario = request.FechaAceptaDomiciliario;
                VerifiData.FechaAceptaEntidad = request.FechaAceptaEntidad;
                VerifiData.FechaEntrega = request.FechaEntrega;
                VerifiData.AceptaEntidad = request.AceptaEntidad;
                VerifiData.AceptaDomiciliario = request.AceptaDomiciliario;
                VerifiData.DomicilioExitoso = request.DomicilioExitoso;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Domicilio>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El domicilio fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El domicilio no fue actualizado");

                return resp = false;
            }
        }
    }
}
