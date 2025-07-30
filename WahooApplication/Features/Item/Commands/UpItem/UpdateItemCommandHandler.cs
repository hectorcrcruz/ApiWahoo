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

namespace WahooApplication.Features.Item.Commands.UpItem
{
    public class UpdateItemCommandHandler : IRequestHandler<UpdateItemCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateItemCommandHandler> _logger;
        public UpdateItemCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateItemCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Item>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.DescripcionItem = request.DescripcionItem;
                VerifiData.CantidadItem = request.CantidadItem;
                VerifiData.UnidadMedidaItem = request.UnidadMedidaItem;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Item>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El item fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El item no fue actualizado");

                return resp = false;
            }
        }
    }
}
