using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.FaseDomicilio.Commands.AddFaseDomicilio;
using WahooApplication.Features.FaseDomicilio.Commands.UpFaseDomicilio;
using WahooApplication.Features.FaseDomicilio.Queries.ListFaseDomicilio;

using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class FaseDomicilioController : ControllerBase
    {
        private readonly ILogger<FaseDomicilioController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public FaseDomicilioController(ILogger<FaseDomicilioController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
           
        }

        [HttpGet("ListFaseDomicilio")]
        public async Task<ActionResult<IEnumerable<FaseDomicilioModel>>> ListFaseDomicilio(int? IdFaseDomicilio)
        {
            var query = await _mediator.Send(new ListFaseDomicilioQuery(IdFaseDomicilio));
            return Ok(query);
        }

        [HttpPost("CreateFaseDomicilio")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateFaseDomicilio([FromBody] CreateFaseDomicilioCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateFaseDomicilio")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateFaseDomicilio([FromBody] UpdateFaseDomicilioCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
