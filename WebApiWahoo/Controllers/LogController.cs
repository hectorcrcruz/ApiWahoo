using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Log.Commands.AddLog;
using WahooApplication.Features.Log.Commands.UpLog;
using WahooApplication.Features.Log.Queries.ListLog;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class LogController : ControllerBase
    {
        private readonly ILogger<LogController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public LogController(ILogger<LogController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListLog")]
        public async Task<ActionResult<IEnumerable<LogModel>>> ListLog(int? Id)
        {
            var query = await _mediator.Send(new ListLogQuery (Id));
            return Ok(query);
        }

        [HttpPost("CreateLog")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateLog([FromBody] CreateLogCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateLog")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateLog([FromBody] UpdateLogCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
