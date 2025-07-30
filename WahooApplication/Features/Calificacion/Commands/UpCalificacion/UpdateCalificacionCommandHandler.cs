using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooDomain;

namespace WahooApplication.Features.Calificacion.Commands.UpCalificacion
{
    public class UpdateCalificacionCommandHandler : IRequestHandler<UpdateCalificacionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateCalificacionCommandHandler> _logger;

        public UpdateCalificacionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateCalificacionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateCalificacionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Calificacion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.CriterioEvaluacionId = request.CriterioEvaluacionId;
                VerifiData.ParametroEvaluacionId = request.ParametroEvaluacionId;
                VerifiData.FechaUp = request.FechaUp;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.UsuarioId = request.UsuarioId;
                VerifiData.Estado = request.Estado;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Calificacion>().UpdateAsync(VerifiData);

                _logger.LogInformation($"La calificacion fue actualizada");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La calificacion no fue actualizada");

                return resp = false;
            }
        }
    }
}
