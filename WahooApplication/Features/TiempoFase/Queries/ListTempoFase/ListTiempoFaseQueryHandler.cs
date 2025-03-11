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

namespace WahooApplication.Features.TiempoFase.Queries.ListTempoFase
{
    public class ListTiempoFaseQueryHandler : IRequestHandler<ListTiempoFaseQuery, List<TiempoFaseModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListTiempoFaseQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListTiempoFaseQueryHandler(IUnitOfWork unitOfWork, ILogger<ListTiempoFaseQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<TiempoFaseModel>> Handle(ListTiempoFaseQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.TiempoFase>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<TiempoFaseModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.TiempoFase>().GetAllAsync();
                var entityVm = _mapper.Map<List<TiempoFaseModel>>(entity);

                return entityVm;

            }
        }
    }
}
