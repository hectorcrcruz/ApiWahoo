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

namespace WahooApplication.Features.Rol.Queries.ListRol
{
    public class ListRolQueryHandler : IRequestHandler<ListRolQuery, List<RolModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListRolQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListRolQueryHandler(IUnitOfWork unitOfWork, ILogger<ListRolQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<RolModel>> Handle(ListRolQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Rol>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<RolModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Rol>().GetAllAsync();
                var entityVm = _mapper.Map<List<RolModel>>(entity);

                return entityVm;

            }
        }
    }
}
