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

namespace WahooApplication.Features.TipoPromocion.Commands.UpTipoPromocion
{
    public class UpdateTipoPromocionCommandHandler : IRequestHandler<UpdateTipoPromocionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateTipoPromocionCommandHandler> _logger;
        public UpdateTipoPromocionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateTipoPromocionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateTipoPromocionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.TipoPromocion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionTipoPromocion = request.DescripcionTipoPromocion;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.TipoPromocion>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El tipo de promocion fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El tipo de promocion no fue actualizado");

                return resp = false;
            }
        }
    }
}
