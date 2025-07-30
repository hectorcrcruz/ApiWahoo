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

namespace WahooApplication.Features.TipoIdentificacion.Commands.UpTipoIdentificacion
{
    public class UpdateTipoIdentificacionCommandHandler : IRequestHandler<UpdateTipoIdentificacionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateTipoIdentificacionCommandHandler> _logger;
        public UpdateTipoIdentificacionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateTipoIdentificacionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateTipoIdentificacionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.TipoIdentificacion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionTipoIdentificacion = request.DescripcionTipoIdentificacion;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.TipoIdentificacion>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El tipo de identificacion fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El tipo de identificacion no fue actualizado");

                return resp = false;
            }
        }
    }
}
