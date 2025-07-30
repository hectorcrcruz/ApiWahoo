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

namespace WahooApplication.Features.Dia.Queries.ListDia
{
    public class ListDiaQueryHandler : IRequestHandler<ListDiaQuery, List<DiaModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListDiaQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListDiaQueryHandler(IUnitOfWork unitOfWork, ILogger<ListDiaQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<DiaModel>> Handle(ListDiaQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Dia>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<DiaModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Dia>().GetAllAsync();
                var entityVm = _mapper.Map<List<DiaModel>>(entity);

                return entityVm;

            }
        }
    }
}
