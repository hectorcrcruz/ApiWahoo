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

namespace WahooApplication.Features.Notificacion.Commands.AddNotificacion
{
    public class CreateNotificacionCommandHandler : IRequestHandler<CreateNotificacionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateNotificacionCommandHandler> _logger;
        private readonly IMapper _mapper;

        public CreateNotificacionCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateNotificacionCommandHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateNotificacionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Notificacion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Notificacion>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Notificacion>().AddAsync(Entity);

                _logger.LogInformation($"La notificacion fue creada con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La notificacion no fue creada");

                return resp = false;
            }
        }
    }
}
