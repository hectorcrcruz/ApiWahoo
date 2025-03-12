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

namespace WahooApplication.Features.Pais.Queries.ListPais
{
    public class ListPaisQueryHandler : IRequestHandler<ListPaisQuery, List<PaisModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListPaisQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListPaisQueryHandler(IUnitOfWork unitOfWork, ILogger<ListPaisQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<PaisModel>> Handle(ListPaisQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Pais>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<PaisModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Pais>().GetAllAsync();
                var entityVm = _mapper.Map<List<PaisModel>>(entity);

                return entityVm;

            }
        }
    }
}
