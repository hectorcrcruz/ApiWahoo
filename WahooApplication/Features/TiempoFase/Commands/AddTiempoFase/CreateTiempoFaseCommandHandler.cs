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

namespace WahooApplication.Features.TiempoFase.Commands.AddTiempoFase
{
    public class CreateTiempoFaseCommandHandler : IRequestHandler<CreateTiempoFaseCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateTiempoFaseCommandHandler> _logger;
        private readonly IMapper _mapper;

        public CreateTiempoFaseCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateTiempoFaseCommandHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateTiempoFaseCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.TiempoFase>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.TiempoFase>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.TiempoFase>().AddAsync(Entity);

                _logger.LogInformation($"El tiempo de fase fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El tiempo de fase no fue creado");

                return resp = false;
            }
        }
    }
}
