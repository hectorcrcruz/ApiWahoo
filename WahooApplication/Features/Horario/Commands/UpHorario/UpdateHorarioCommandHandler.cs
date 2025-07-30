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

namespace WahooApplication.Features.Horario.Commands.UpHorario
{
    public class UpdateHorarioCommandHandler : IRequestHandler<UpdateHorarioCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateHorarioCommandHandler> _logger;
        public UpdateHorarioCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateHorarioCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateHorarioCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Horario>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionHorario = request.DescripcionHorario;
                VerifiData.FranjaHorario = request.FranjaHorario;
                VerifiData.HoraInicio = request.HoraInicio;
                VerifiData.HoraFin = request.HoraFin;
                VerifiData.UsuarioId = request.UsuarioId;
                VerifiData.DiaId = request.DiaId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Horario>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El horario fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El horario no fue actualizado");

                return resp = false;
            }
        }
    }
}
