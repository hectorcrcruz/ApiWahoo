using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;

namespace WahooApplication.Features.Catalogo.Commands.AddCatalogo
{
    public class CreateCatalogoCommandHandler : IRequestHandler<CreateCatalogoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateCatalogoCommandHandler> _logger;

        public CreateCatalogoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateCatalogoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateCatalogoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Catalogo>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Catalogo>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Catalogo>().AddAsync(Entity);

                _logger.LogInformation($"El catalogo fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El catalogo no fue creado");

                return resp = false;
            }

        }
    }
}
