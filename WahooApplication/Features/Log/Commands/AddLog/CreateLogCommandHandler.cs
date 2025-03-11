using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Item.Commands.AddItem;

namespace WahooApplication.Features.Log.Commands.AddLog
{
    public class CreateLogCommandHandler : IRequestHandler<CreateLogCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateLogCommandHandler> _logger;
        public CreateLogCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateLogCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateLogCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Log>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Log>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Log>().AddAsync(Entity);

                _logger.LogInformation($"El log fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El log no fue creado");

                return resp = false;
            }
        }
    }
}
