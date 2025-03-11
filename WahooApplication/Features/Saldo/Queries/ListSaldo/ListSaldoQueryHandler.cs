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

namespace WahooApplication.Features.Saldo.Queries.ListSaldo
{
    public class ListSaldoQueryHandler : IRequestHandler<ListSaldoQuery, List<SaldoModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListSaldoQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListSaldoQueryHandler(IUnitOfWork unitOfWork, ILogger<ListSaldoQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<SaldoModel>> Handle(ListSaldoQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Saldo>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<SaldoModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Saldo>().GetAllAsync();
                var entityVm = _mapper.Map<List<SaldoModel>>(entity);

                return entityVm;

            }
        }
    }
}
