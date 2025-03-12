using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Rol.Commands.AddRol;
using WahooApplication.Features.Rol.Commands.UpRol;
using WahooApplication.Features.Rol.Queries.ListRol;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class RolController : ControllerBase
    {
        private readonly ILogger<RolController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public RolController(ILogger<RolController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListRol")]
        public async Task<ActionResult<IEnumerable<RolModel>>> ListRol(int? Id)
        {
            var query = await _mediator.Send(new ListRolQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateRol")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateRol([FromBody] CreateRolCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateRol")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateRol([FromBody] UpdateRolCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
