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

namespace WahooApplication.Features.Estado.Queries.ListEstado
{
    public class ListEstadoQueryHandler : IRequestHandler<ListEstadoQuery, List<EstadoModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListEstadoQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListEstadoQueryHandler(IUnitOfWork unitOfWork, ILogger<ListEstadoQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<EstadoModel>> Handle(ListEstadoQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Estado>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<EstadoModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Estado>().GetAllAsync();
                var entityVm = _mapper.Map<List<EstadoModel>>(entity);

                return entityVm;

            }
        }
    }
}
