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

namespace WahooApplication.Features.Departamento.Commands.UpDepartamento
{
    public class UpdateDepartamentoCommandHandler : IRequestHandler<UpdateDepartamentoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateDepartamentoCommandHandler> _logger;
        public UpdateDepartamentoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateDepartamentoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateDepartamentoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Departamento>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.NombreDepartamento = request.NombreDepartamento;
                VerifiData.PaisId = request.PaisId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Departamento>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El departamento fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El departamento no fue actualizado");

                return resp = false;
            }
        }
    }
}
