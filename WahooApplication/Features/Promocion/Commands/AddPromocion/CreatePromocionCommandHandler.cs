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

namespace WahooApplication.Features.Promocion.Commands.AddPromocion
{
    public class CreatePromocionCommandHandler : IRequestHandler<CreatePromocionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreatePromocionCommandHandler> _logger;
        private readonly IMapper _mapper;

        public CreatePromocionCommandHandler(IUnitOfWork unitOfWork, ILogger<CreatePromocionCommandHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreatePromocionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Promocion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                var Entity = _mapper.Map<WahooDomain.Promocion>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Promocion>().AddAsync(Entity);

                _logger.LogInformation($"La promocion fue creada con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La promocion no fue creada");

                return resp = false;
            }
        }
    }
}
