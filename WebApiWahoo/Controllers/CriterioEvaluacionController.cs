using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.CriterioEvaluacion.Commands.AddCriterioEvaluacion;
using WahooApplication.Features.CriterioEvaluacion.Commands.UpCriterioEvaluacion;
using WahooApplication.Features.CriterioEvaluacion.Queries.ListCriterioEvaluacion;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CriterioEvaluacionController : ControllerBase
    {
        private readonly ILogger<CriterioEvaluacionController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public CriterioEvaluacionController(ILogger<CriterioEvaluacionController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListCriterioEvaluacion")]
        public async Task<ActionResult<IEnumerable<CriterioEvaluacionModel>>> ListCriterioEvaluacion(int? Id)
        {
            var query = await _mediator.Send(new ListCriterioEvaluacionQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateCriterioEvaluacion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateCriterioEvaluacion([FromBody] CreateCriterioEvaluacionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPut("UpdateCriterioEvaluacion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateCriterioEvaluacion([FromBody] UpdateCriterioEvaluacionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
