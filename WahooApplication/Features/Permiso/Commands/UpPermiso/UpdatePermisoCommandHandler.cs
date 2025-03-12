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

namespace WahooApplication.Features.Permiso.Commands.UpPermiso
{
    public class UpdatePermisoCommandHandler : IRequestHandler<UpdatePermisoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdatePermisoCommandHandler> _logger;
        public UpdatePermisoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdatePermisoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdatePermisoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Permiso>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionPermiso = request.DescripcionPermiso;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Permiso>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El permiso fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El permiso no fue actualizado");

                return resp = false;
            }
        }
    }
}
