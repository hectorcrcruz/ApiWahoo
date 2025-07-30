using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Catalogo.Commands.UpCatalogo;

namespace WahooApplication.Features.CategoriaProducto.Commands.UpCategoriaProducto
{
    public class UpdateCategoriaProductoCommandHandler : IRequestHandler<UpdateCategoriaProductoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateCategoriaProductoCommandHandler> _logger;

        public UpdateCategoriaProductoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateCategoriaProductoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateCategoriaProductoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.CategoriaProducto>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionCategoriaProducto = request.DescripcionCategoriaProducto;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.CategoriaProducto>().UpdateAsync(VerifiData);

                _logger.LogInformation($"La categoria de producto fue actualizada");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La categoria de producto no fue actualizada");

                return resp = false;
            }
        }
    }
}
