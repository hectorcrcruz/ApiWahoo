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

namespace WahooApplication.Features.Entidad.Commands.UpEntidad
{
    public class UpdateEntidadCommandHandler : IRequestHandler<UpdateEntidadCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateEntidadCommandHandler> _logger;
        public UpdateEntidadCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateEntidadCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateEntidadCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Entidad>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionEntidad = request.DescripcionEntidad;
                VerifiData.TipoEntidadId = request.TipoEntidadId;
                VerifiData.MedioPagoId = request.MedioPagoId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Entidad>().UpdateAsync(VerifiData);

                _logger.LogInformation($"La categoria de producto fue actualizada");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La categoria de producto no fue actualizada");

                return resp = false;
            }
        }
    }
}
