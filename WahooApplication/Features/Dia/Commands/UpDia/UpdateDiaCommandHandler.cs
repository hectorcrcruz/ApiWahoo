using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Chat.Commands.AddChat;

namespace WahooApplication.Features.Dia.Commands.UpDia
{
    public class UpdateDiaCommandHandler : IRequestHandler<UpdateDiaCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateDiaCommandHandler> _logger;
        public UpdateDiaCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateDiaCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateDiaCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Dia>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionDiaLaboral = request.DescripcionDiaLaboral;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Dia>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El dia fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El dia no fue actualizado");

                return resp = false;
            }
        }
    }
}
