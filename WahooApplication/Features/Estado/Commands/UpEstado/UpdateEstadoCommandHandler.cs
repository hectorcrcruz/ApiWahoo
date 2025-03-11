using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Chat.Commands.UpChat;

namespace WahooApplication.Features.Estado.Commands.UpEstado
{
    public class UpdateEstadoCommandHandler : IRequestHandler<UpdateEstadoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateEstadoCommandHandler> _logger;
        public UpdateEstadoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateEstadoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateEstadoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Estado>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionEstado = request.DescripcionEstado;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Estado>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El estado fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El estado no fue actualizado");

                return resp = false;
            }
        }
    }
}
