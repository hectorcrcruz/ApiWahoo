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

namespace WahooApplication.Features.Departamento.Queries.ListDepartamento
{
    public class ListDepartamentoQueryHandler : IRequestHandler<ListDepartamentoQuery, List<DepartamentoModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListDepartamentoQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListDepartamentoQueryHandler(IUnitOfWork unitOfWork, ILogger<ListDepartamentoQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<DepartamentoModel>> Handle(ListDepartamentoQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Departamento>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<DepartamentoModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Departamento>().GetAllAsync();
                var entityVm = _mapper.Map<List<DepartamentoModel>>(entity);

                return entityVm;

            }
        }
    }
}
