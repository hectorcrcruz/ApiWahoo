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

namespace WahooApplication.Features.Notificacion.Queries.ListNotificacion
{
    public class ListNotificacionQueryHandler : IRequestHandler<ListNotificacionQuery, List<NotificacionModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListNotificacionQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListNotificacionQueryHandler(IUnitOfWork unitOfWork, ILogger<ListNotificacionQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<NotificacionModel>> Handle(ListNotificacionQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Notificacion>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<NotificacionModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Notificacion>().GetAllAsync();
                var entityVm = _mapper.Map<List<NotificacionModel>>(entity);

                return entityVm;

            }
        }
    }
}
