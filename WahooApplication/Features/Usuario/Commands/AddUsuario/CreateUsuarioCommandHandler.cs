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
using WahooApplication.Services;

namespace WahooApplication.Features.Usuario.Commands.AddUsuario
{
    public class CreateUsuarioCommandHandler : IRequestHandler<CreateUsuarioCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateUsuarioCommandHandler> _logger;
        private readonly BlobStorageService _blobStorageService;
        public CreateUsuarioCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateUsuarioCommandHandler> logger, BlobStorageService blobStorageService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
            _blobStorageService = blobStorageService;
        }
        public async Task<bool> Handle(CreateUsuarioCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Usuario>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData == null)
            {
                string? urlImagen = null;
                if (request.ProfilePhoto != null)
                {
                    urlImagen = await _blobStorageService.UploadAsync(request.ProfilePhoto);
                }
                var Entity = _mapper.Map<WahooDomain.Usuario>(request);
                var EntityAdd = await _unitOfWork.Repository<WahooDomain.Usuario>().AddAsync(Entity);

                _logger.LogInformation($"El usuario fue creado con el id {EntityAdd.Id}");
                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El usuario no fue creado");

                return resp = false;
            }
        }
    }
}
