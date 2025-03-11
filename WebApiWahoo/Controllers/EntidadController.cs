using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Entidad.Commands.AddEntidad;
using WahooApplication.Features.Entidad.Commands.UpEntidad;
using WahooApplication.Features.Entidad.Queries.ListEntidad;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class EntidadController : ControllerBase
    {
        private readonly ILogger<EntidadController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public EntidadController(ILogger<EntidadController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        
        }

        [HttpGet("ListEntidad")]
        public async Task<ActionResult<IEnumerable<EntidadModel>>> ListEntidad(int? Id)
        {
            var query = await _mediator.Send(new ListEntidadQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateEntidad")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateEntidad([FromBody] CreateEntidadCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateEntidad")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateEntidad([FromBody] UpdateEntidadCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
