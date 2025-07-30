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

namespace WahooApplication.Features.CategoriaProducto.Queries.ListCategoria
{
    public class ListCategoriaProductoQueryHandler : IRequestHandler<ListCategoriaProductoQuery, List<CategoriaProductoModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListCategoriaProductoQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListCategoriaProductoQueryHandler(IUnitOfWork unitOfWork, ILogger<ListCategoriaProductoQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<CategoriaProductoModel>> Handle(ListCategoriaProductoQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.CategoriaProducto>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<CategoriaProductoModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.CategoriaProducto>().GetAllAsync();
                var entityVm = _mapper.Map<List<CategoriaProductoModel>>(entity);

                return entityVm;

            }
        }
    }
}
