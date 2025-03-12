using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Notificacion.Commands.AddNotificacion;
using WahooApplication.Features.Notificacion.Commands.UpNotificacion;
using WahooApplication.Features.Notificacion.Queries.ListNotificacion;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class NotificacionController : ControllerBase
    {
        private readonly ILogger<NotificacionController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public NotificacionController(ILogger<NotificacionController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListNotificacion")]
        public async Task<ActionResult<IEnumerable<NotificacionModel>>> ListNotificacion(int? Id)
        {
            var query = await _mediator.Send(new ListNotificacionQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateNotificacion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateNotificacion([FromBody] CreateNotificacionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateNotificacion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateNotificacion([FromBody] UpdateNotificacionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
