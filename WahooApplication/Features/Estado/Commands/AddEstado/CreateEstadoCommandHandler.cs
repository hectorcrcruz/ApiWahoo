using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Chat.Commands.AddChat;

namespace WahooApplication.Features.Estado.Commands.AddEstado
{
    public class CreateEstadoCommandHandler : IRequestHandler<CreateEstadoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateEstadoCommandHandler> _logger;
        public CreateEstadoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateEstadoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateEstadoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Estado>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Estado>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Estado>().AddAsync(Entity);

                _logger.LogInformation($"El estado fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El estado no fue creado");

                return resp = false;
            }
        }
    }
}
