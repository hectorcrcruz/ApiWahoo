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

namespace WahooApplication.Features.Item.Commands.AddItem
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateItemCommandHandler> _logger;
        public CreateItemCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateItemCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Item>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Item>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Item>().AddAsync(Entity);

                _logger.LogInformation($"El item fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El item no fue creado");

                return resp = false;
            }
        }
    }
}
