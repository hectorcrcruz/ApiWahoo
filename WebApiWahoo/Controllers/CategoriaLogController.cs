using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.CategoriaLog.Commands.AddCategoriaLogs;
using WahooApplication.Features.CategoriaLog.Commands.UpCategoriaLog;
using WahooApplication.Features.CategoriaLog.Queries.ListCategoriaLog;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CategoriaLogController : ControllerBase
    {
        private readonly ILogger<CategoriaLogController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public CategoriaLogController(ILogger<CategoriaLogController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpGet("ListCategoriaLog")]
        public async Task<ActionResult<IEnumerable<CategoriaLogModel>>> ListCategoriaLog(int? Id)
        {
            var query = await _mediator.Send(new ListCategoriaLogQuery(Id));
            return Ok(query);
        }
        [HttpPost("CreateCategoriaLog")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateCategoriaLog([FromBody] CreateCategoriaLogCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPut("UpdateCategoriaLog")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateCategoriaLog([FromBody] UpdateCategoriaLogCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
