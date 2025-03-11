using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.TipoIdentificacion.Commands.AddTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Commands.UpTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Queries.ListTipoIdentificacion;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class TipoIdentificacionController : ControllerBase
    {
        private readonly ILogger<TipoIdentificacionController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public TipoIdentificacionController(ILogger<TipoIdentificacionController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListTipoIdentificacion")]
        public async Task<ActionResult<IEnumerable<TipoIdentificacionModel>>> ListTipoIdentificacion(int? Id)
        {
            var query = await _mediator.Send(new ListTipoIdentificacionQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateTipoIdentificacion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateTipoIdentificacion([FromBody] CreateTipoIdentificacionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateTipoIdentificacion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateTipoIdentificacion([FromBody] UpdateTipoIdentificacionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
