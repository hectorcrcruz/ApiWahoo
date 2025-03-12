using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.MedioPago.Commands.UpMedioPago;

namespace WahooApplication.Features.TiempoFase.Commands.UpTiempoFase
{
    public class UpdateTiempoFaseCommandHandler : IRequestHandler<UpdateTiempoFaseCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateTiempoFaseCommandHandler> _logger;
        public UpdateTiempoFaseCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateTiempoFaseCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateTiempoFaseCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.TiempoFase>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DomicilioId = request.DomicilioId;
                VerifiData.HoraCambioFase = request.HoraCambioFase;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.TiempoFase>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El tiempo de fase fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El tiempo de fase no fue actualizado");

                return resp = false;
            }
        }
    }
}
