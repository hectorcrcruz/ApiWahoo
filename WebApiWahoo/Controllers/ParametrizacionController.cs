using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Parametrizacion.Commands.AddParametrizacion;
using WahooApplication.Features.Parametrizacion.Commands.UpParametrizacion;
using WahooApplication.Features.Parametrizacion.Queries.ListParametrizacion;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class ParametrizacionController : ControllerBase
    {
        private readonly ILogger<ParametrizacionController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public ParametrizacionController(ILogger<ParametrizacionController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpGet("ListParametrizacion")]
        public async Task<ActionResult<IEnumerable<ParametrizacionModel>>> ListParametrizacion(int? IdParametrizacion)
        {
            var query = await _mediator.Send(new ListParametrizacionQuery(IdParametrizacion));
            return Ok(query);
        }

        [HttpPost("CreateParametrizacion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateParametrizacion([FromBody] CreateParametrizacionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPut("UpdateParametrizacion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateParametrizacion([FromBody] UpdateParametrizacionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
