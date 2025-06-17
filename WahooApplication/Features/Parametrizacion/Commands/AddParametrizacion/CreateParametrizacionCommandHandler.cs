using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Pais.Commands.AddPais;

namespace WahooApplication.Features.Parametrizacion.Commands.AddParametrizacion
{
    public class CreateParametrizacionCommandHandler : IRequestHandler<CreateParametrizacionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateParametrizacionCommandHandler> _logger;
        private readonly IMapper _mapper;
        public CreateParametrizacionCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateParametrizacionCommandHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateParametrizacionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Parametrizacion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Parametrizacion>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Parametrizacion>().AddAsync(Entity);

                _logger.LogInformation($"La parametrizacion fue creada con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La parametrizacion no fue creada");

                return resp = false;
            }
        }
    }
}
