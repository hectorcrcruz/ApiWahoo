using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Models;

namespace WahooApplication.Features.Login.Commands.AddLogin
{
    public class CreateLoginCommandHandler : IRequestHandler<CreateLoginCommand, LoginModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateLoginCommandHandler> _logger;
        public CreateLoginCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateLoginCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<LoginModel> Handle(CreateLoginCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Usuario>().GetFirstOrDefaultAsync(x => x.Login == request.Username && x.Password == request.Password);

            if (VerifiData != null)
            {
                var Entity = _mapper.Map<LoginModel>(VerifiData);

                _logger.LogInformation($"{VerifiData.Login} fue logueado");

                return Entity;

            }
            else
            {
                _logger.LogInformation($"{request.Username} no fue logueado");

                return null;
            }
        }
    }
}
