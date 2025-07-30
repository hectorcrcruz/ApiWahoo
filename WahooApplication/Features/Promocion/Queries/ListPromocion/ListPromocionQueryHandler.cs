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

namespace WahooApplication.Features.Promocion.Queries.ListPromocion
{
    public class ListPromocionQueryHandler : IRequestHandler<ListPromocionQuery, List<PromocionModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListPromocionQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListPromocionQueryHandler(IUnitOfWork unitOfWork, ILogger<ListPromocionQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<PromocionModel>> Handle(ListPromocionQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Promocion>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<PromocionModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Promocion>().GetAllAsync();
                var entityVm = _mapper.Map<List<PromocionModel>>(entity);

                return entityVm;

            }
        }
    }
}
