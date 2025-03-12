using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.PQRS.Commands.AddPQRS;
using WahooApplication.Features.PQRS.Commands.UpPQRS;
using WahooApplication.Features.PQRS.Queries.ListPQRS;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class PQRSController : ControllerBase
    {
        private readonly ILogger<PQRSController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public PQRSController(ILogger<PQRSController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListPQRS")]
        public async Task<ActionResult<IEnumerable<PQRSModel>>> ListPQRS(int? Id)
        {
            var query = await _mediator.Send(new ListPQRSQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreatePQRS")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreatePQRS([FromBody] CreatePQRSCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdatePQRS")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdatePQRS([FromBody] UpdatePQRSCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
