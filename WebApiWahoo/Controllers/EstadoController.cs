using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Estado.Commands.AddEstado;
using WahooApplication.Features.Estado.Commands.UpEstado;
using WahooApplication.Features.Estado.Queries.ListEstado;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class EstadoController : ControllerBase
    {
        private readonly ILogger<EstadoController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public EstadoController(ILogger<EstadoController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListEstado")]
        public async Task<ActionResult<IEnumerable<EstadoModel>>> ListEstado(int? Id)
        {
            var query = await _mediator.Send(new ListEstadoQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateEstado")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateEstado([FromBody] CreateEstadoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateEstado")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateEstado([FromBody] UpdateEstadoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
