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

namespace WahooApplication.Features.TipoPromocion.Commands.AddTipoPromocion
{
    public class CreateTipoPromocionCommandHandler : IRequestHandler<CreateTipoPromocionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateTipoPromocionCommandHandler> _logger;
        public CreateTipoPromocionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateTipoPromocionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(CreateTipoPromocionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.TipoPromocion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.TipoPromocion>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.TipoPromocion>().AddAsync(Entity);

                _logger.LogInformation($"El tipo de promocion fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El tipo de promocion no fue creado");

                return resp = false;
            }
        }
    }
}
