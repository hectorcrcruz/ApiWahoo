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

namespace WahooApplication.Features.CriterioEvaluacion.Commands.AddCriterioEvaluacion
{
    public class CreateCriterioEvaluacionCommandHandler : IRequestHandler<CreateCriterioEvaluacionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateCriterioEvaluacionCommandHandler> _logger;
        public CreateCriterioEvaluacionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateCriterioEvaluacionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateCriterioEvaluacionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Chat>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.CriterioEvaluacion>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.CriterioEvaluacion>().AddAsync(Entity);

                _logger.LogInformation($"El criterio de evaluacion fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El criterio de evaluacion no fue creado");

                return resp = false;
            }
        }
    }
}
