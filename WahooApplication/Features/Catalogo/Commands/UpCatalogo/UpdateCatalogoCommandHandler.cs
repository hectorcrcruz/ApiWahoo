using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;

namespace WahooApplication.Features.Catalogo.Commands.UpCatalogo
{
    public class UpdateCatalogoCommandHandler : IRequestHandler<UpdateCatalogoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateCatalogoCommandHandler> _logger;

        public UpdateCatalogoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateCatalogoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateCatalogoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Catalogo>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionCatalogo = request.DescripcionCatalogo;
                VerifiData.ItemId = request.ItemId;
                VerifiData.EntidadId = request.EntidadId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Catalogo>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El catalogo fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El catalogo no fue actualizado");

                return resp = false;
            }
        }
    }
}
