using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.MedioPago.Commands.UpMedioPago;
using WahooApplication.Models;

namespace WahooApplication.Features.Promocion.Commands.UpPromocion
{
    public class UpdatePromocionCommandHandler : IRequestHandler<UpdatePromocionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdatePromocionCommandHandler> _logger;
        public UpdatePromocionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdatePromocionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdatePromocionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Promocion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionPromocion = request.DescripcionPromocion;
                VerifiData.ProductoId = request.ProductoId;
                VerifiData.FechaFinPromocion = request.FechaFinPromocion;
                VerifiData.FechaInicioPromocion = request.FechaInicioPromocion;
                VerifiData.ImagenPromocion = request.ImagenPromocion;
                VerifiData.CodigoPromocional = request.CodigoPromocional;
                VerifiData.TipoPromocionId = request.TipoPromocionId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Promocion>().UpdateAsync(VerifiData);

                _logger.LogInformation($"La promocion fue actualizada");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La promocion no fue actualizada");

                return resp = false;
            }
        }
    }
}
