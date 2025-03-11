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

namespace WahooApplication.Features.Modulo.Commands.AddMdulo
{
    public class CreateModuloCommandHandler : IRequestHandler<CreateModuloCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateModuloCommandHandler> _logger;
        public CreateModuloCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateModuloCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateModuloCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Modulo>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Modulo>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Modulo>().AddAsync(Entity);

                _logger.LogInformation($"El modulo fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El modulo no fue creado");

                return resp = false;
            }
        }
    }
}
