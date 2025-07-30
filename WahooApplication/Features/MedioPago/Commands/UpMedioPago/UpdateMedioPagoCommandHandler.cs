using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.MedioPago.Commands.AddMedioPago;

namespace WahooApplication.Features.MedioPago.Commands.UpMedioPago
{
    public class UpdateMedioPagoCommandHandler : IRequestHandler<UpdateMedioPagoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateMedioPagoCommandHandler> _logger;
        public UpdateMedioPagoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateMedioPagoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateMedioPagoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.MedioPago>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionMedioPago = request.DescripcionMedioPago;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.MedioPago>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El medio de pago fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El medio de pago no fue actualizado");

                return resp = false;
            }
        }
    }
}
