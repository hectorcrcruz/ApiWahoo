using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.TipoEntidad.Commands.AddTipoEntidad;
using WahooApplication.Features.TipoEntidad.Commands.UpTipoEntidad;
using WahooApplication.Features.TipoEntidad.Queries.ListTipoEntidad;
using WahooApplication.Features.TipoIdentificacion.Commands.AddTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Commands.UpTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Queries.ListTipoIdentificacion;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class TipoEntidadController : ControllerBase
    {
        private readonly ILogger<TipoEntidadController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public TipoEntidadController(ILogger<TipoEntidadController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListTipoEntidad")]
        public async Task<ActionResult<IEnumerable<TipoEntidadModel>>> ListTipoEntidad(int? Id)
        {
            var query = await _mediator.Send(new ListTipoEntidadQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateTipoEntidad")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateTipoEntidad([FromBody] CreateTipoEntidadCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateTipoEntidad")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateTipoEntidad([FromBody] UpdateTipoEntidadCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
