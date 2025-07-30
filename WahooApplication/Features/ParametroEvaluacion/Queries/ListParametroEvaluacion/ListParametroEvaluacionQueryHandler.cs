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
using WahooApplication.Models;

namespace WahooApplication.Features.ParametroEvaluacion.Queries.ListParametroEvaluacion
{
    public class ListParametroEvaluacionQueryHandler : IRequestHandler<ListParametroEvaluacionQuery, List<ParametroEvaluacionModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListParametroEvaluacionQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListParametroEvaluacionQueryHandler(IUnitOfWork unitOfWork, ILogger<ListParametroEvaluacionQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<ParametroEvaluacionModel>> Handle(ListParametroEvaluacionQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.ParametroEvaluacion>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<ParametroEvaluacionModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.ParametroEvaluacion>().GetAllAsync();
                var entityVm = _mapper.Map<List<ParametroEvaluacionModel>>(entity);

                return entityVm;

            }
        }
    }
}
