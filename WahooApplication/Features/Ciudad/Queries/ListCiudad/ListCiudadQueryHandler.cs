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

namespace WahooApplication.Features.Ciudad.Queries.ListCiudad
{
    public class ListCiudadQueryHandler : IRequestHandler<ListCiudadQuery, List<CiudadModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListCiudadQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListCiudadQueryHandler(IUnitOfWork unitOfWork, ILogger<ListCiudadQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<CiudadModel>> Handle(ListCiudadQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Ciudad>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<CiudadModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Ciudad>().GetAllAsync();
                var entityVm = _mapper.Map<List<CiudadModel>>(entity);

                return entityVm;

            }
        }
    }
}
