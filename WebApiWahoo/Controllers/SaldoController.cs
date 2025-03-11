using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Saldo.Commands.AddSaldo;
using WahooApplication.Features.Saldo.Commands.UpSaldo;
using WahooApplication.Features.Saldo.Queries.ListSaldo;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class SaldoController : ControllerBase
    {
        private readonly ILogger<SaldoController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public SaldoController(ILogger<SaldoController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListSaldo")]
        public async Task<ActionResult<IEnumerable<SaldoModel>>> ListSaldo(int? Id)
        {
            var query = await _mediator.Send(new ListSaldoQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateSaldo")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateSaldo([FromBody] CreateSaldoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateSaldo")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateSaldo([FromBody] UpdateSaldoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
