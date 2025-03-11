using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Item.Queries.ListItem;
using WahooApplication.Models;

namespace WahooApplication.Features.Log.Queries.ListLog
{
    public class ListLogQueryHandler : IRequestHandler<ListLogQuery, List<LogModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListLogQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListLogQueryHandler(IUnitOfWork unitOfWork, ILogger<ListLogQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async  Task<List<LogModel>> Handle(ListLogQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Log>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<LogModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Log>().GetAllAsync();
                var entityVm = _mapper.Map<List<LogModel>>(entity);

                return entityVm;

            }
        }
    }
}
