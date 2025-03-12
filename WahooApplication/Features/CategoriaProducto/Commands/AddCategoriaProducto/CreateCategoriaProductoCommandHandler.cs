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

namespace WahooApplication.Features.CategoriaProducto.Commands.AddCategoriaProducto
{
    public class CreateCategoriaProductoCommandHandler : IRequestHandler<CreateCategoriaProductoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateCategoriaProductoCommandHandler> _logger;
        public CreateCategoriaProductoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateCategoriaProductoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateCategoriaProductoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.CategoriaProducto>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.CategoriaProducto>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.CategoriaProducto>().AddAsync(Entity);

                _logger.LogInformation($"La categoria de producto fue creada con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La categoria de producto no fue creada");

                return resp = false;
            }
        }
    }
}
