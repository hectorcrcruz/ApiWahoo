using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Models;
using WahooApplication.Services;

namespace WahooApplication.Features.AzureBlob.Commands.Upload
{
    public class AzureBlobUploadCommandHandler : IRequestHandler<AzureBlobUploadCommand, AzureBlobModel>
    {
        private readonly IAzureStorageService _azureBlob;
        private readonly ILogger<AzureBlobUploadCommandHandler> _logger;

        public AzureBlobUploadCommandHandler(IAzureStorageService azureBlob, ILogger<AzureBlobUploadCommandHandler> logger)
        {
            _azureBlob = azureBlob;
            _logger = logger;
        }
        public async Task<AzureBlobModel> Handle(AzureBlobUploadCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var urlFile = await _azureBlob.UploadFileAsync(request.Url, "appwahooimages");

                return (new AzureBlobModel
                {
                    url = urlFile,
                    Response = "Carga Exitosa"
                });
            }
            catch (Exception ex)
            {
                return (new AzureBlobModel
                {
                    url = "",
                    Response = "Carga No Exitosa. Motivo : " + ex.Message
                });
            }
        }
    }
}
