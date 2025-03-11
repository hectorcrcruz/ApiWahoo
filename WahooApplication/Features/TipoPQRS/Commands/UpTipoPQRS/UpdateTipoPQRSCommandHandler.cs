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

namespace WahooApplication.Features.TipoPQRS.Commands.UpTipoPQRS
{
    public class UpdateTipoPQRSCommandHandler : IRequestHandler<UpdateTipoPQRSCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateTipoPQRSCommandHandler> _logger;
        public UpdateTipoPQRSCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateTipoPQRSCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateTipoPQRSCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.TipoPQRS>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionTipoPQRS = request.DescripcionTipoPQRS;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.TipoPQRS>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El tipo de PQRS fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El tipo de PQRS no fue actualizado");

                return resp = false;
            }
        }
    }
}
