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

namespace WahooApplication.Features.Producto.Queries.ListProducto
{
    public class ListProductoQueryHandler : IRequestHandler<ListProductoQuery, List<ProductoModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListProductoQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListProductoQueryHandler(IUnitOfWork unitOfWork, ILogger<ListProductoQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<ProductoModel>> Handle(ListProductoQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Producto>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<ProductoModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Producto>().GetAllAsync();
                var entityVm = _mapper.Map<List<ProductoModel>>(entity);

                return entityVm;

            }
        }
    }
}
