using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Permiso.Commands.AddPermiso;
using WahooApplication.Features.Permiso.Commands.UpPermiso;
using WahooApplication.Features.Permiso.Queries.ListPermiso;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class PermisoController : ControllerBase
    {
        private readonly ILogger<PermisoController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public PermisoController(ILogger<PermisoController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListPermiso")]
        public async Task<ActionResult<IEnumerable<PermisoModel>>> ListPermiso(int? Id)
        {
            var query = await _mediator.Send(new ListPermisoQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreatePermiso")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreatePermiso([FromBody] CreatePermisoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdatePermiso")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdatePermiso([FromBody] UpdatePermisoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
