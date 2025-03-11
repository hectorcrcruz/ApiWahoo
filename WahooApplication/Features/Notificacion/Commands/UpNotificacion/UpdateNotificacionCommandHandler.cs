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

namespace WahooApplication.Features.Notificacion.Commands.UpNotificacion
{
    public class UpdateNotificacionCommandHandler : IRequestHandler<UpdateNotificacionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateNotificacionCommandHandler> _logger;
        public UpdateNotificacionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateNotificacionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateNotificacionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Notificacion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionNotificacion = request.DescripcionNotificacion;
                VerifiData.Enviada = request.Enviada;
                VerifiData.UsuarioId = request.UsuarioId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Notificacion>().UpdateAsync(VerifiData);

                _logger.LogInformation($"La notificacion fue actualizada");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La notificacion no fue actualizada");

                return resp = false;
            }
        }
    }
}
