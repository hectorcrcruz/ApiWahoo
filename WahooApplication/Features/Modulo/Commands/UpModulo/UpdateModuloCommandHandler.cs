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

namespace WahooApplication.Features.Modulo.Commands.UpModulo
{
    public class UpdateModuloCommandHandler : IRequestHandler<UpdateModuloCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateModuloCommandHandler> _logger;
        public UpdateModuloCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateModuloCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateModuloCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Modulo>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionModulo = request.DescripcionModulo;
                VerifiData.PermisoId = request.PermisoId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Modulo>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El modulo fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El modulo no fue actualizado");

                return resp = false;
            }
        }
    }
}
