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

namespace WahooApplication.Features.CriterioEvaluacion.Commands.UpCriterioEvaluacion
{
    public class UpdateCriterioEvaluacionCommandHandler : IRequestHandler<UpdateCriterioEvaluacionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateCriterioEvaluacionCommandHandler> _logger;
        public UpdateCriterioEvaluacionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateCriterioEvaluacionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateCriterioEvaluacionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.CriterioEvaluacion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionCriterioEvaluacion = request.DescripcionCriterioEvaluacion;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.CriterioEvaluacion>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El criterio de evaluacion fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El criterio de evaluacion no fue actualizado");

                return resp = false;
            }
        }
    }
}
