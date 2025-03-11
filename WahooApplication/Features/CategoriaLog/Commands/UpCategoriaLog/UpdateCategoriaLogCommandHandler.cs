using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;

namespace WahooApplication.Features.CategoriaLog.Commands.UpCategoriaLog
{
    public class UpdateCategoriaLogCommandHandler : IRequestHandler<UpdateCategoriaLogCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateCategoriaLogCommandHandler> _logger;
        public UpdateCategoriaLogCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateCategoriaLogCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateCategoriaLogCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.CategoriaLog>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionCategoriaLog = request.DescripcionCategoriaLog;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.UsuarioUp = request.UsuarioUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.CategoriaLog>().UpdateAsync(VerifiData);

                _logger.LogInformation($"La categoriaLog fue actualizada");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La categoriaLog no fue actualizada");

                return resp = false;
            }
        }
    }
}
