using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Log.Commands.AddLog;

namespace WahooApplication.Features.Transaccion.Commands.AddTransaccion
{
    public class CreateTransaccionCommandHandler : IRequestHandler<CreateTransaccionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateTransaccionCommandHandler> _logger;
        public CreateTransaccionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateTransaccionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateTransaccionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Transaccion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Transaccion>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Transaccion>().AddAsync(Entity);

                _logger.LogInformation($"La transaccion fue creada con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La transaccion no fue creada");

                return resp = false;
            }
        }
    }
}
