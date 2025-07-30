using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Logs;
using WahooDomain;

namespace WahooApplication.Features.Calificacion.Commands.CreateCalificacion
{
    public class CreateCalificacionCommandHandler : IRequestHandler<CreateCalificacionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateCalificacionCommandHandler> _logger;
        public CreateCalificacionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateCalificacionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateCalificacionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Calificacion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Calificacion>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Calificacion>().AddAsync(Entity);

                _logger.LogInformation($"La calificacion fue creada con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La calificacion no fue creada");

                return resp = false;
            }
        }
    }
}
