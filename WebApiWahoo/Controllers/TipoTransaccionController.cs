using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.TipoIdentificacion.Commands.AddTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Commands.UpTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Queries.ListTipoIdentificacion;
using WahooApplication.Features.TipoTransacion.Commands.AddTipoTransaccion;
using WahooApplication.Features.TipoTransacion.Commands.UpTipoTransaccion;
using WahooApplication.Features.TipoTransacion.Queries.ListTipoTransaccion;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class TipoTransaccionController : ControllerBase
    {
        private readonly ILogger<TipoTransaccionController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public TipoTransaccionController(ILogger<TipoTransaccionController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListTipoTransaccion")]
        public async Task<ActionResult<IEnumerable<TipoTransaccionModel>>> ListTipoTransaccion(int? Id)
        {
            var query = await _mediator.Send(new ListTipoTransaccionQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateTipoTransaccion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateTipoTransaccion([FromBody] CreateTipoTransaccionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateTipoTransaccion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateTipoTransaccion([FromBody] UpdateTipoTransaccionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
