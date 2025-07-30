using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;

namespace WahooApplication.Features.CategoriaLog.Commands.AddCategoriaLogs
{
    public class CreateCategoriaLogCommandHandler : IRequestHandler<CreateCategoriaLogCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateCategoriaLogCommandHandler> _logger;
        public CreateCategoriaLogCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateCategoriaLogCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateCategoriaLogCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.CategoriaLog>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.CategoriaLog>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.CategoriaLog>().AddAsync(Entity);

                _logger.LogInformation($"La categoriaLog fue creada con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La categoriaLog no fue creada");

                return resp = false;
            }
        }
    }
}
