using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.ParametroEvaluacion.Commands.AddParametroEvaluacion;
using WahooApplication.Features.ParametroEvaluacion.Commands.UpParametroEvaluacion;
using WahooApplication.Features.ParametroEvaluacion.Queries.ListParametroEvaluacion;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class ParametroEvaluacionController : ControllerBase
    {
        private readonly ILogger<ParametroEvaluacionController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public ParametroEvaluacionController(ILogger<ParametroEvaluacionController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListParametroEvaluacion")]
        public async Task<ActionResult<IEnumerable<ParametroEvaluacionModel>>> ListParametroEvaluacion(int? Id)
        {
            var query = await _mediator.Send(new ListParametroEvaluacionQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateParametroEvaluacion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateParametroEvaluacion([FromBody] CreateParametroEvaluacionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateParametroEvaluacion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateParametroEvaluacion([FromBody] UpdateParametroEvaluacionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
