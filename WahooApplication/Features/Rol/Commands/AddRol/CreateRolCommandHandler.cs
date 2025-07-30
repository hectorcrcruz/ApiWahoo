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

namespace WahooApplication.Features.Rol.Commands.AddRol
{
    public class CreateRolCommandHandler : IRequestHandler<CreateRolCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateRolCommandHandler> _logger;
        private readonly IMapper _mapper;

        public CreateRolCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateRolCommandHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateRolCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Rol>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Rol>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Rol>().AddAsync(Entity);

                _logger.LogInformation($"El rol fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El rol no fue creado");

                return resp = false;
            }
        }
    }
}
