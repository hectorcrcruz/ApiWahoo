using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Logs;
using WahooApplication.Models;
using WahooDomain;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CalificacionController : ControllerBase
    {
        private readonly ILogger<CalificacionController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public CalificacionController(ILogger<CalificacionController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpGet("ListCalificacion")]
        public async Task<ActionResult<IEnumerable<CalificacionModel>>> ListCalificacion(int? Id)
        {
            var query = await _mediator.Send(new ListCalificacionQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateCalificacion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateCalificacion([FromBody] CreateCalificacionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPut("UpdateCalificacion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateCalificacion([FromBody] UpdateCalificacionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
