using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.CategoriaProducto.Commands.AddCategoriaProducto;

namespace WahooApplication.Features.Chat.Commands.AddChat
{
    public class CreateChatCommandHandler : IRequestHandler<CreateChatCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateChatCommandHandler> _logger;
        public CreateChatCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateChatCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateChatCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Chat>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Chat>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Chat>().AddAsync(Entity);

                _logger.LogInformation($"El chat fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El chat no fue creado");

                return resp = false;
            }
        }
    }
}
