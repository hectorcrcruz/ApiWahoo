using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.FaseDomicilio.Commands.UpFaseDomicilio;
using WahooApplication.Features.MedioPago.Commands.UpMedioPago;

namespace WahooApplication.Features.TipoTransacion.Commands.UpTipoTransaccion
{
    public class UpdateTipoTransaccionCommandHandler : IRequestHandler<UpdateTipoTransaccionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateTipoTransaccionCommandHandler> _logger;
        public UpdateTipoTransaccionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateTipoTransaccionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateTipoTransaccionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.TipoTransaccion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DecripcionTipoTransaccion = request.DecripcionTipoTransaccion;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.TipoTransaccion>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El tipo de transaccion fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El tipo de transaccion no fue actualizado");

                return resp = false;
            }
        }
    }
}
