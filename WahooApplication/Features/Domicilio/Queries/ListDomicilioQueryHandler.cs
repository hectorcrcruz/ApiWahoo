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

namespace WahooApplication.Features.Domicilio.Queries
{
    public class ListDomicilioQueryHandler : IRequestHandler<ListDomicilioQuery, List<DomicilioModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListDomicilioQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListDomicilioQueryHandler(IUnitOfWork unitOfWork, ILogger<ListDomicilioQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<DomicilioModel>> Handle(ListDomicilioQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Domicilio>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<DomicilioModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Domicilio>().GetAllAsync();
                var entityVm = _mapper.Map<List<DomicilioModel>>(entity);

                return entityVm;

            }
        }
    }
}
