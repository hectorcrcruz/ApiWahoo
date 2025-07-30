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

namespace WahooApplication.Features.TipoPQRS.Queries.ListTipoPQRS
{
    public class ListTipoPQRSQueryHandler : IRequestHandler<ListTipoPQRSQuery, List<TipoPQRSModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListTipoPQRSQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListTipoPQRSQueryHandler(IUnitOfWork unitOfWork, ILogger<ListTipoPQRSQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<TipoPQRSModel>> Handle(ListTipoPQRSQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.TipoPQRS>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<TipoPQRSModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.TipoPQRS>().GetAllAsync();
                var entityVm = _mapper.Map<List<TipoPQRSModel>>(entity);

                return entityVm;

            }
        }
    }
}
