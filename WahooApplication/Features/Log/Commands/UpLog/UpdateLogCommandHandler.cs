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

namespace WahooApplication.Features.Log.Commands.UpLog
{
    public class UpdateLogCommandHandler : IRequestHandler<UpdateLogCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateLogCommandHandler> _logger;
        public UpdateLogCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateLogCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateLogCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Log>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionLog = request.DescripcionLog;
                VerifiData.CategoriaLogId = request.CategoriaLogId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Log>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El log fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El log no fue actualizado");

                return resp = false;
            }
        }
    }
}
