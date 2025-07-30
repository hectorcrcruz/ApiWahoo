using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.CategoriaProducto.Commands.UpCategoriaProducto;
using WahooApplication.Models;

namespace WahooApplication.Features.Entidad.Queries.ListEntidad
{
    public class ListEntidadQueryHandler : IRequestHandler<ListEntidadQuery, List<EntidadModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<ListEntidadQueryHandler> _logger;

        public ListEntidadQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<ListEntidadQueryHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<List<EntidadModel>> Handle(ListEntidadQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Entidad>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<EntidadModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Entidad>().GetAllAsync();
                var entityVm = _mapper.Map<List<EntidadModel>>(entity);

                return entityVm;

            }
        }
    }
}
