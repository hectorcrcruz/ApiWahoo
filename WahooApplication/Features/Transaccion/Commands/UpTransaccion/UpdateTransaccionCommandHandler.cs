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

namespace WahooApplication.Features.Transaccion.Commands.UpTransaccion
{
    public class UpdateTransaccionCommandHandler : IRequestHandler<UpdateTransaccionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateTransaccionCommandHandler> _logger;
        public UpdateTransaccionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateTransaccionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateTransaccionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Transaccion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionTransaccion = request.DescripcionTransaccion;
                VerifiData.TipoTransaccionId = request.TipoTransaccionId;
                VerifiData.EntidadId = request.EntidadId;
                VerifiData.DomicilioId = request.DomicilioId;
                VerifiData.DescripcionAdicional = request.DescripcionAdicional;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Transaccion>().UpdateAsync(VerifiData);

                _logger.LogInformation($"La transaccion fue actualizada");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La transaccion no fue actualizada");

                return resp = false;
            }
        }
    }
}
