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

namespace WahooApplication.Features.PQRS.Commands.AddPQRS
{
    public class CreatePQRSCommandHandler : IRequestHandler<CreatePQRSCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreatePQRSCommandHandler> _logger;
        public CreatePQRSCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreatePQRSCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreatePQRSCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.PQRS>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.PQRS>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.PQRS>().AddAsync(Entity);

                _logger.LogInformation($"El PQRS fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El PQRS no fue creado");

                return resp = false;
            }
        }
    }
}
