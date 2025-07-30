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

namespace WahooApplication.Features.Domicilio.Commands.AddDomicilio
{
    public class CreateDomicilioCommandHandler : IRequestHandler<CreateDomicilioCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateDomicilioCommandHandler> _logger;
        public CreateDomicilioCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateDomicilioCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateDomicilioCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Domicilio>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Domicilio>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Domicilio>().AddAsync(Entity);

                _logger.LogInformation($"El domicilio fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El domicilio no fue creado");

                return resp = false;
            }
        }
    }
}
