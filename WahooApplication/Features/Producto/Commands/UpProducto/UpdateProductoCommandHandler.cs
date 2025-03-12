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

namespace WahooApplication.Features.Producto.Commands.UpProducto
{
    public class UpdateProductoCommandHandler : IRequestHandler<UpdateProductoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateProductoCommandHandler> _logger;
        public UpdateProductoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateProductoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateProductoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Producto>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionProducto = request.DescripcionProducto;
                VerifiData.stock = request.stock;
                VerifiData.ValorProducto = request.ValorProducto;
                VerifiData.ImagenProducto = request.ImagenProducto;
                VerifiData.CategoriaProductoId = request.CategoriaProductoId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Producto>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El producto fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El producto no fue actualizado");

                return resp = false;
            }
        }
    }
}
