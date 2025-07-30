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

namespace WahooApplication.Features.TipoPromocion.Queries.ListTipoPromocion
{
    public class ListTipoPromocionQueryHandler : IRequestHandler<ListTipoPromocionQuery, List<TipoPromocionModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListTipoPromocionQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListTipoPromocionQueryHandler(IUnitOfWork unitOfWork, ILogger<ListTipoPromocionQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<TipoPromocionModel>> Handle(ListTipoPromocionQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.TipoPromocion>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<TipoPromocionModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.TipoPromocion>().GetAllAsync();
                var entityVm = _mapper.Map<List<TipoPromocionModel>>(entity);

                return entityVm;

            }
        }
    }
}
