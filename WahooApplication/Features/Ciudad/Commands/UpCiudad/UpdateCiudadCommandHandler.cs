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

namespace WahooApplication.Features.Ciudad.Commands.UpCiudad
{
    public class UpdateCiudadCommandHandler : IRequestHandler<UpdateCiudadCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateCiudadCommandHandler> _logger;
        public UpdateCiudadCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateCiudadCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateCiudadCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Ciudad>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DepartamentoId = request.DepartamentoId;
                VerifiData.NombreCiudad = request.NombreCiudad;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Ciudad>().UpdateAsync(VerifiData);

                _logger.LogInformation($"La ciudad fue actualizada");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La ciudad no fue actualizada");

                return resp = false;
            }
        }
    }
}
