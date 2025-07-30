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

namespace WahooApplication.Features.TipoEntidad.Commands.UpTipoEntidad
{
    public class UpdateTipoEntidadCommandHandler : IRequestHandler<UpdateTipoEntidadCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateTipoEntidadCommandHandler> _logger;
        public UpdateTipoEntidadCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateTipoEntidadCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateTipoEntidadCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.TipoEntidad>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionTipoEntidad = request.DescripcionTipoEntidad;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.TipoEntidad>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El tipo de entidad fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El tipo de entidad no fue actualizado");

                return resp = false;
            }
        }
    }
}
