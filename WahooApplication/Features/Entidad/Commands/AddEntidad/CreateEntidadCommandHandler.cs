using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.CategoriaProducto.Commands.UpCategoriaProducto;

namespace WahooApplication.Features.Entidad.Commands.AddEntidad
{
    public class CreateEntidadCommandHandler : IRequestHandler<CreateEntidadCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateEntidadCommandHandler> _logger;

        public CreateEntidadCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateEntidadCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateEntidadCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Entidad>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Entidad>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Entidad>().AddAsync(Entity);

                _logger.LogInformation($"La entidad fue creada con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La entidad no fue creada");

                return resp = false;
            }
        }
    }
}
