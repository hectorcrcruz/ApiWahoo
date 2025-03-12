using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.CategoriaProducto.Queries.ListCategoria;
using WahooApplication.Models;

namespace WahooApplication.Features.FaseDomicilio.Queries.ListFaseDomicilio
{
    public class ListFaseDomicilioQueryHandler : IRequestHandler<ListFaseDomicilioQuery, List<FaseDomicilioModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListFaseDomicilioQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListFaseDomicilioQueryHandler(IUnitOfWork unitOfWork, ILogger<ListFaseDomicilioQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<FaseDomicilioModel>> Handle(ListFaseDomicilioQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.FaseDomicilio>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<FaseDomicilioModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.FaseDomicilio>().GetAllAsync();
                var entityVm = _mapper.Map<List<FaseDomicilioModel>>(entity);

                return entityVm;

            }
        }
    }
}
