using Azure.Storage.Blobs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.AzureBlob.Commands.Upload;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Models;
using WahooApplication.Services;
using WahooDomain;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AzureBlobController : ControllerBase
    {
        private readonly IAzureStorageService _blobStorageService;
        private readonly ILogger<CalificacionController> _logger;
        private readonly IMediator _mediator;
        public AzureBlobController(ILogger<CalificacionController> logger, IConfiguration configuration, IMediator mediator, IAzureStorageService blobStorageService)
        {
            _blobStorageService = blobStorageService;
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost("UploadFile")]
        public async Task<ActionResult<IEnumerable<AzureBlobModel>>> UploadFile(IFormFile file)
        {
            var query = await _mediator.Send(new AzureBlobUploadCommand(file));
            return Ok(query);
        }
    }
}
