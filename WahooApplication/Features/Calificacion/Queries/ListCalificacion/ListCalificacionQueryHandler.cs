using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Models;
using WahooDomain;

namespace WahooApplication.Features.Calificacion.Queries.ListCalificacion
{
    public class ListCalificacionQueryHandler : IRequestHandler<ListCalificacionQuery, List<CalificacionModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListCalificacionQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListCalificacionQueryHandler(IUnitOfWork unitOfWork, ILogger<ListCalificacionQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<CalificacionModel>> Handle(ListCalificacionQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Calificacion>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<CalificacionModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Calificacion>().GetAllAsync();
                var entityVm = _mapper.Map<List<CalificacionModel>>(entity);

                return entityVm;

            }
        }
    }
}
