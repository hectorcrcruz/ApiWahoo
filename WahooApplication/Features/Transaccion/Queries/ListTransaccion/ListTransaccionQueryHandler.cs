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

namespace WahooApplication.Features.Transaccion.Queries.ListTransaccion
{
    public class ListTransaccionQueryHandler : IRequestHandler<ListTransaccionQuery, List<TransaccionModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListTransaccionQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListTransaccionQueryHandler(IUnitOfWork unitOfWork, ILogger<ListTransaccionQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<TransaccionModel>> Handle(ListTransaccionQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Transaccion>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<TransaccionModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Transaccion>().GetAllAsync();
                var entityVm = _mapper.Map<List<TransaccionModel>>(entity);

                return entityVm;

            }
        }
    }
}
