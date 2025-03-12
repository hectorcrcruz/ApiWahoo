using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.TipoIdentificacion.Commands.AddTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Commands.UpTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Queries.ListTipoIdentificacion;
using WahooApplication.Features.Transaccion.Commands.AddTransaccion;
using WahooApplication.Features.Transaccion.Commands.UpTransaccion;
using WahooApplication.Features.Transaccion.Queries.ListTransaccion;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class TransaccionController : ControllerBase
    {
        private readonly ILogger<TransaccionController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public TransaccionController(ILogger<TransaccionController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListTransaccion")]
        public async Task<ActionResult<IEnumerable<TransaccionModel>>> ListTransaccion(int? Id)
        {
            var query = await _mediator.Send(new ListTransaccionQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateTransaccion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateTransaccion([FromBody] CreateTransaccionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateTransaccion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateTransaccion([FromBody] UpdateTransaccionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
