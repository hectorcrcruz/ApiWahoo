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

namespace WahooApplication.Features.MedioPago.Queries.ListMedioPago
{
    public class ListMedioPagoQueryHandler : IRequestHandler<ListMedioPagoQuery, List<MedioPagoModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListMedioPagoQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListMedioPagoQueryHandler(IUnitOfWork unitOfWork, ILogger<ListMedioPagoQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<MedioPagoModel>> Handle(ListMedioPagoQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.MedioPago>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<MedioPagoModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.MedioPago>().GetAllAsync();
                var entityVm = _mapper.Map<List<MedioPagoModel>>(entity);

                return entityVm;

            }
        }
    }
}
