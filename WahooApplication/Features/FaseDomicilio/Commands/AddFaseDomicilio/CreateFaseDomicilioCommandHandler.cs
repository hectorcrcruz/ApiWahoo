using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Chat.Commands.UpChat;
using WahooApplication.Features.Estado.Commands.UpEstado;
using WahooApplication.Features.FaseDomicilio.Commands.UpFaseDomicilio;

namespace WahooApplication.Features.FaseDomicilio.Commands.AddFaseDomicilio
{
    public class CreateFaseDomicilioCommandHandler : IRequestHandler<CreateFaseDomicilioCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateFaseDomicilioCommandHandler> _logger;
        public CreateFaseDomicilioCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateFaseDomicilioCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateFaseDomicilioCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.FaseDomicilio>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.FaseDomicilio>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.FaseDomicilio>().AddAsync(Entity);

                _logger.LogInformation($"La fase de domicilio fue creada con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La fase del domicilio no fue creada");

                return resp = false;
            }
        }
    }
}
