using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Dia.Commands.AddDia;
using WahooApplication.Features.Dia.Commands.UpDia;
using WahooApplication.Features.Dia.Queries.ListDia;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class DiaController : ControllerBase
    {
        private readonly ILogger<DiaController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public DiaController(ILogger<DiaController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListDia")]
        public async Task<ActionResult<IEnumerable<DiaModel>>> ListDia(int? Id)
        {
            var query = await _mediator.Send(new ListDiaQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateDia")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateDia([FromBody] CreateDiaCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateDia")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateDia([FromBody] UpdateDiaCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

    }
}
