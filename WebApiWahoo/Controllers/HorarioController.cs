using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Horario.Commands.AddHorario;
using WahooApplication.Features.Horario.Commands.UpHorario;
using WahooApplication.Features.Horario.Queries.ListHorario;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class HorarioController : ControllerBase
    {
        private readonly ILogger<HorarioController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public HorarioController(ILogger<HorarioController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListHorario")]
        public async Task<ActionResult<IEnumerable<HorarioModel>>> ListHorario(int? Id)
        {
            var query = await _mediator.Send(new ListHorarioQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateHorario")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateHorario([FromBody] CreateHorarioCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPut("UpdateHorario")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateHorario([FromBody] UpdateHorarioCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
