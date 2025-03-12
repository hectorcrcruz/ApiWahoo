using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Catalogo.Queries.ListCatalogo;
using WahooApplication.Models;

namespace WahooApplication.Features.CategoriaLog.Queries.ListCategoriaLog
{
    public class ListCategoriaLogQueryHandler : IRequestHandler<ListCategoriaLogQuery, List<CategoriaLogModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListCategoriaLogQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListCategoriaLogQueryHandler(IUnitOfWork unitOfWork, ILogger<ListCategoriaLogQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<CategoriaLogModel>> Handle(ListCategoriaLogQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.CategoriaLog>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<CategoriaLogModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.CategoriaLog>().GetAllAsync();
                var entityVm = _mapper.Map<List<CategoriaLogModel>>(entity);

                return entityVm;

            }
        }
    }
}
