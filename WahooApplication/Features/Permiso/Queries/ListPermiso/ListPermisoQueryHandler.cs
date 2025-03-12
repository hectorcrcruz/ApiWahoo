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

namespace WahooApplication.Features.Permiso.Queries.ListPermiso
{
    public class ListPermisoQueryHandler : IRequestHandler<ListPermisoQuery, List<PermisoModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListPermisoQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListPermisoQueryHandler(IUnitOfWork unitOfWork, ILogger<ListPermisoQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<PermisoModel>> Handle(ListPermisoQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Permiso>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<PermisoModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Permiso>().GetAllAsync();
                var entityVm = _mapper.Map<List<PermisoModel>>(entity);

                return entityVm;

            }
        }
    }
}
