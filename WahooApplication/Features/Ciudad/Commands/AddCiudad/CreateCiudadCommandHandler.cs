using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.CategoriaProducto.Queries.ListCategoria;

namespace WahooApplication.Features.Ciudad.Commands.AddCiudad
{
    public class CreateCiudadCommandHandler : IRequestHandler<CreateCiudadCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateCiudadCommandHandler> _logger;
        private readonly IMapper _mapper;

        public CreateCiudadCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateCiudadCommandHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateCiudadCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Chat>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Ciudad>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Ciudad>().AddAsync(Entity);

                _logger.LogInformation($"La ciudad fue creada con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La ciudad no fue creada");

                return resp = false;
            }
        }
    }
}
