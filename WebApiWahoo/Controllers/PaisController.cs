using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Pais.Commands.AddPais;
using WahooApplication.Features.Pais.Commands.UpPais;
using WahooApplication.Features.Pais.Queries.ListPais;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class PaisController : ControllerBase
    {
        private readonly ILogger<PaisController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public PaisController(ILogger<PaisController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListPais")]
        public async Task<ActionResult<IEnumerable<PaisModel>>> ListPais(int? Id)
        {
            var query = await _mediator.Send(new ListPaisQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreatePais")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreatePais([FromBody] CreatePaisCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdatePais")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdatePais([FromBody] UpdatePaisCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
