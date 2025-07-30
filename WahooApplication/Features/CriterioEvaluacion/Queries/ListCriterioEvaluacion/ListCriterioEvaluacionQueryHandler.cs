using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Chat.Queries.ListChat;
using WahooApplication.Models;

namespace WahooApplication.Features.CriterioEvaluacion.Queries.ListCriterioEvaluacion
{
    public class ListCriterioEvaluacionQueryHandler : IRequestHandler<ListCriterioEvaluacionQuery, List<CriterioEvaluacionModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListCriterioEvaluacionQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListCriterioEvaluacionQueryHandler(IUnitOfWork unitOfWork, ILogger<ListCriterioEvaluacionQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<CriterioEvaluacionModel>> Handle(ListCriterioEvaluacionQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.CriterioEvaluacion>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<CriterioEvaluacionModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.CriterioEvaluacion>().GetAllAsync();
                var entityVm = _mapper.Map<List<CriterioEvaluacionModel>>(entity);

                return entityVm;

            }
        }
    }
}
