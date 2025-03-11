using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.MedioPago.Commands.AddMedioPago;
using WahooApplication.Features.MedioPago.Commands.UpMedioPago;
using WahooApplication.Features.MedioPago.Queries.ListMedioPago;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class MedioPagoController : ControllerBase
    {
        private readonly ILogger<MedioPagoController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public MedioPagoController(ILogger<MedioPagoController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListMedioPago")]
        public async Task<ActionResult<IEnumerable<MedioPagoModel>>> ListMedioPago(int? Id)
        {
            var query = await _mediator.Send(new ListMedioPagoQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateMedioPago")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateMedioPago([FromBody] CreateMedioPagoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateMedioPago")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateMedioPago([FromBody] UpdateMedioPagoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
