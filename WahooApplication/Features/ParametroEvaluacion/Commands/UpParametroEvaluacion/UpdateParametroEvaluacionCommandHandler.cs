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

namespace WahooApplication.Features.ParametroEvaluacion.Commands.UpParametroEvaluacion
{
    public class UpdateParametroEvaluacionCommandHandler : IRequestHandler<UpdateParametroEvaluacionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateParametroEvaluacionCommandHandler> _logger;
        public UpdateParametroEvaluacionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateParametroEvaluacionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateParametroEvaluacionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.ParametroEvaluacion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionParametro = request.DescripcionParametro;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.ParametroEvaluacion>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El parametro de evaluacion fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El parametro de evaluacion no fue actualizado");

                return resp = false;
            }
        }
    }
}
