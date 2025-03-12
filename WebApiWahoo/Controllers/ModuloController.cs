using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Modulo.Commands.AddMdulo;
using WahooApplication.Features.Modulo.Commands.UpModulo;
using WahooApplication.Features.Modulo.Queries.ListModulo;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class ModuloController : ControllerBase
    {
        private readonly ILogger<ModuloController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public ModuloController(ILogger<ModuloController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListModulo")]
        public async Task<ActionResult<IEnumerable<ModuloModel>>> ListModulo(int? Id)
        {
            var query = await _mediator.Send(new ListModuloQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateModulo")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateModulo([FromBody] CreateModuloCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateModulo")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateModulo([FromBody] UpdateModuloCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
