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

namespace WahooApplication.Features.Permiso.Commands.AddPermiso
{
    public class CreatePermisoCommandHandler : IRequestHandler<CreatePermisoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreatePermisoCommandHandler> _logger;
        public CreatePermisoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreatePermisoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreatePermisoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Permiso>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Permiso>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Permiso>().AddAsync(Entity);

                _logger.LogInformation($"El permiso fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El permiso no fue creado");

                return resp = false;
            }
        }
    }
}
