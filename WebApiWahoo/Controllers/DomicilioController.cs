using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Domicilio.Commands.AddDomicilio;
using WahooApplication.Features.Domicilio.Commands.UpDomicilio;
using WahooApplication.Features.Domicilio.Queries;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class DomicilioController : ControllerBase
    {
        private readonly ILogger<DomicilioController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public DomicilioController(ILogger<DomicilioController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListDomicilio")]
        public async Task<ActionResult<IEnumerable<DomicilioModel>>> ListDomicilio(int? Id)
        {
            var query = await _mediator.Send(new ListDomicilioQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateDomicilio")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateDomicilio([FromBody] CreateDomicilioCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateDomicilio")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateDomicilio([FromBody] UpdateDomicilioCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
