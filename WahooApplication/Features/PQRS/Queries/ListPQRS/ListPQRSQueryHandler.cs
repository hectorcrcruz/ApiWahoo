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

namespace WahooApplication.Features.PQRS.Queries.ListPQRS
{
    public class ListPQRSQueryHandler : IRequestHandler<ListPQRSQuery, List<PQRSModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListPQRSQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListPQRSQueryHandler(IUnitOfWork unitOfWork, ILogger<ListPQRSQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<PQRSModel>> Handle(ListPQRSQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.PQRS>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<PQRSModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.PQRS>().GetAllAsync();
                var entityVm = _mapper.Map<List<PQRSModel>>(entity);

                return entityVm;

            }
        }
    }
}
