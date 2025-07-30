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

namespace WahooApplication.Features.Modulo.Queries.ListModulo
{
    public class ListModuloQueryHandler : IRequestHandler<ListModuloQuery, List<ModuloModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListModuloQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListModuloQueryHandler(IUnitOfWork unitOfWork, ILogger<ListModuloQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<ModuloModel>> Handle(ListModuloQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Modulo>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<ModuloModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Modulo>().GetAllAsync();
                var entityVm = _mapper.Map<List<ModuloModel>>(entity);

                return entityVm;

            }
        }
    }
}
