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

namespace WahooApplication.Features.Producto.Commands.AddProducto
{
    public class CreateProductoCommandHandler : IRequestHandler<CreateProductoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductoCommandHandler> _logger;
        private readonly IMapper _mapper;

        public CreateProductoCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductoCommandHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateProductoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Producto>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Producto>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Producto>().AddAsync(Entity);

                _logger.LogInformation($"El producto fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El producto no fue creado");

                return resp = false;
            }
        }
    }
}
