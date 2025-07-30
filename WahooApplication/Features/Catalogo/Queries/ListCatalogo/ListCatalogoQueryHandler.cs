using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Models;
using WahooDomain;

namespace WahooApplication.Features.Catalogo.Queries.ListCatalogo
{
    public class ListCatalogoQueryHandler : IRequestHandler<ListCatalogoQuery, List<CatalogoModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListCatalogoQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListCatalogoQueryHandler(IUnitOfWork unitOfWork, ILogger<ListCatalogoQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async  Task<List<CatalogoModel>> Handle(ListCatalogoQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Catalogo>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<CatalogoModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Catalogo>().GetAllAsync();
                var entityVm = _mapper.Map<List<CatalogoModel>>(entity);

                return entityVm;

            }
        }
    }
}
