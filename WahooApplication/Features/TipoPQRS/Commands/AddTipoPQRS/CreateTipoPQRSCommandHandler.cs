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

namespace WahooApplication.Features.TipoPQRS.Commands.AddTipoPQRS
{
    public class CreateTipoPQRSCommandHandler : IRequestHandler<CreateTipoPQRSCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateTipoPQRSCommandHandler> _logger;
        private readonly IMapper _mapper;

        public CreateTipoPQRSCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateTipoPQRSCommandHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateTipoPQRSCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.TipoPQRS>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.TipoPQRS>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.TipoPQRS>().AddAsync(Entity);

                _logger.LogInformation($"El tipo de PQRS fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El tipo de PQRS no fue creado");

                return resp = false;
            }
        }
    }
}
