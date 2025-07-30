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

namespace WahooApplication.Features.Dia.Commands.AddDia
{
    public class CreateDiaCommandHandler : IRequestHandler<CreateDiaCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateDiaCommandHandler> _logger;
        public CreateDiaCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateDiaCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateDiaCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Chat>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Dia>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Dia>().AddAsync(Entity);

                _logger.LogInformation($"El dia fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El dia no fue creado");

                return resp = false;
            }
        }
    }
}
