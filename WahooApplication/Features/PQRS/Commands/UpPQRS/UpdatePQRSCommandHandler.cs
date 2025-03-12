using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Log.Commands.AddLog;

namespace WahooApplication.Features.PQRS.Commands.UpPQRS
{
    public class UpdatePQRSCommandHandler : IRequestHandler<UpdatePQRSCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdatePQRSCommandHandler> _logger;
        public UpdatePQRSCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdatePQRSCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdatePQRSCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.PQRS>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionPQRS = request.DescripcionPQRS;
                VerifiData.TipoPQRSId = request.TipoPQRSId;
                VerifiData.UsuarioId = request.UsuarioId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.PQRS>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El PQRS fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El PQRS no fue actualizado");

                return resp = false;
            }
        }
    }
}
