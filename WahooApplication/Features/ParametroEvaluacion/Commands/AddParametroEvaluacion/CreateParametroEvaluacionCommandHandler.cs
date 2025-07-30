using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Log.Queries.ListLog;

namespace WahooApplication.Features.ParametroEvaluacion.Commands.AddParametroEvaluacion
{
    public class CreateParametroEvaluacionCommandHandler : IRequestHandler<CreateParametroEvaluacionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateParametroEvaluacionCommandHandler> _logger;
        private readonly IMapper _mapper;

        public CreateParametroEvaluacionCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateParametroEvaluacionCommandHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateParametroEvaluacionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.ParametroEvaluacion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.ParametroEvaluacion>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.ParametroEvaluacion>().AddAsync(Entity);

                _logger.LogInformation($"El parametro de evaluacion fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El parametro de evaluacion no fue creado");

                return resp = false;
            }
        }
    }
}
