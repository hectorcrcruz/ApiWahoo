using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Log.Commands.UpLog;

namespace WahooApplication.Features.MedioPago.Commands.AddMedioPago
{
    public class CreateMedioPagoCommandHandler : IRequestHandler<CreateMedioPagoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateMedioPagoCommandHandler> _logger;
        public CreateMedioPagoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateMedioPagoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateMedioPagoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.MedioPago>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.MedioPago>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.MedioPago>().AddAsync(Entity);

                _logger.LogInformation($"El medio de pago fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El medio de pago no fue creado");

                return resp = false;
            }
        }
    }
}
