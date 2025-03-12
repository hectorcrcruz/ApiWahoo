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

namespace WahooApplication.Features.TipoEntidad.Commands.AddTipoEntidad
{
    public class CreateTipoEntidadCommandHandler : IRequestHandler<CreateTipoEntidadCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateTipoEntidadCommandHandler> _logger;
        private readonly IMapper _mapper;

        public CreateTipoEntidadCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateTipoEntidadCommandHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateTipoEntidadCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.TipoEntidad>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.TipoEntidad>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.TipoEntidad>().AddAsync(Entity);

                _logger.LogInformation($"El tipo de entidad fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El tipo de entidad no fue creado");

                return resp = false;
            }
        }
    }
}
