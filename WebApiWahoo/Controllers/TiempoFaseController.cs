using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.TiempoFase.Commands.AddTiempoFase;
using WahooApplication.Features.TiempoFase.Commands.UpTiempoFase;
using WahooApplication.Features.TiempoFase.Queries.ListTempoFase;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class TiempoFaseController : ControllerBase
    {
        private readonly ILogger<TiempoFaseController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public TiempoFaseController(ILogger<TiempoFaseController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListTiempoFase")]
        public async Task<ActionResult<IEnumerable<TiempoFaseModel>>> ListTiempoFase(int? Id)
        {
            var query = await _mediator.Send(new ListTiempoFaseQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateTiempoFase")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateTiempoFase([FromBody] CreateTiempoFaseCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateTiempoFase")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateTiempoFase([FromBody] UpdateTiempoFaseCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
