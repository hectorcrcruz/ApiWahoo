using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Log.Commands.AddLog;

namespace WahooApplication.Features.TipoIdentificacion.Commands.AddTipoIdentificacion
{
    public class CreateTipoIdentificacionCommandHandler : IRequestHandler<CreateTipoIdentificacionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateTipoIdentificacionCommandHandler> _logger;
        public CreateTipoIdentificacionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateTipoIdentificacionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async  Task<bool> Handle(CreateTipoIdentificacionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.TipoIdentificacion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.TipoIdentificacion>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.TipoIdentificacion>().AddAsync(Entity);

                _logger.LogInformation($"El tipo de identificacion fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El tipo de identificacion no fue creado");

                return resp = false;
            }
        }
    }
}
