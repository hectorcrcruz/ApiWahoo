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

namespace WahooApplication.Features.Saldo.Commands.UpSaldo
{
    public class UpdateSaldoCommandHandler : IRequestHandler<UpdateSaldoCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateSaldoCommandHandler> _logger;
        public UpdateSaldoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateSaldoCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateSaldoCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Saldo>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.SaldoFinal = request.SaldoFinal;
                VerifiData.SaldoInicial = request.SaldoInicial;
                VerifiData.SaldoActual = request.SaldoActual;
                VerifiData.UsuarioId = request.UsuarioId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Saldo>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El saldo fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El saldoo no fue actualizado");

                return resp = false;
            }
        }
    }
}
