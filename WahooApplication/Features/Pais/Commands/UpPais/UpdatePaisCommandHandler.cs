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

namespace WahooApplication.Features.Pais.Commands.UpPais
{
    public class UpdatePaisCommandHandler : IRequestHandler<UpdatePaisCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdatePaisCommandHandler> _logger;
        public UpdatePaisCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdatePaisCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdatePaisCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Pais>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.NombrePais = request.NombrePais;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Pais>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El pais fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El pais no fue actualizado");

                return resp = false;
            }
        }
    }
}
