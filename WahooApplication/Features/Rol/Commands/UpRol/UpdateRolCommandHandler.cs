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

namespace WahooApplication.Features.Rol.Commands.UpRol
{
    public class UpdateRolCommandHandler : IRequestHandler<UpdateRolCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateRolCommandHandler> _logger;
        public UpdateRolCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateRolCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateRolCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Rol>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionRol = request.DescripcionRol;
                VerifiData.ModuloId = request.ModuloId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Rol>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El rol fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El rol no fue actualizado");

                return resp = false;
            }
        }
    }
}
