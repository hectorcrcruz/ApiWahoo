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

namespace WahooApplication.Features.TipoIdentificacion.Queries.ListTipoIdentificacion
{
    public class ListTipoIdentificacionQueryHandler : IRequestHandler<ListTipoIdentificacionQuery, List<TipoIdentificacionModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListTipoIdentificacionQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListTipoIdentificacionQueryHandler(IUnitOfWork unitOfWork, ILogger<ListTipoIdentificacionQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<TipoIdentificacionModel>> Handle(ListTipoIdentificacionQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.TipoIdentificacion>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<TipoIdentificacionModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.TipoIdentificacion>().GetAllAsync();
                var entityVm = _mapper.Map<List<TipoIdentificacionModel>>(entity);

                return entityVm;

            }
        }
    }
}
