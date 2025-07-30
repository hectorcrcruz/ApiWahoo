using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.CategoriaProducto.Queries.ListCategoria;

namespace WahooApplication.Features.Horario.Commands.AddHorario
{
    public class CreateHorarioCommandHandler : IRequestHandler<CreateHorarioCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateHorarioCommandHandler> _logger;
        private readonly IMapper _mapper;

        public CreateHorarioCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateHorarioCommandHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateHorarioCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Horario>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Horario>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Horario>().AddAsync(Entity);

                _logger.LogInformation($"El horario fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El horario no fue creado");

                return resp = false;
            }
        }
    }
}
