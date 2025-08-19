using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Login.Commands.AddLogin;
using WahooApplication.Models;

namespace WahooApplication.Features.Login.Commands.RecoverPassword
{
    public class RecoverPasswordCommandHandler : IRequestHandler<RecoverPasswordCommand, RecoverPasswordModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<RecoverPasswordCommandHandler> _logger;
        public RecoverPasswordCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<RecoverPasswordCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<RecoverPasswordModel> Handle(RecoverPasswordCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Usuario>().GetFirstOrDefaultAsync(x => x.Login == request.Login);

            if (VerifiData != null)
            {
                var Entity = _mapper.Map<RecoverPasswordModel>(VerifiData);

                _logger.LogInformation($"{VerifiData.Login} fue logueado");

                return Entity;

            }
            else
            {
                _logger.LogInformation($"{request.Login} no fue logueado");

                return null;
            }
        }
    }
}
