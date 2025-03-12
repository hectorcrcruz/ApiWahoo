using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Ciudad.Commands.AddCiudad;
using WahooApplication.Features.Ciudad.Commands.UpCiudad;
using WahooApplication.Features.Ciudad.Queries.ListCiudad;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CiudadController : ControllerBase
    {
        private readonly ILogger<CiudadController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public CiudadController(ILogger<CiudadController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListCiudad")]
        public async Task<ActionResult<IEnumerable<CiudadModel>>> ListCiudad(int? Id)
        {
            var query = await _mediator.Send(new ListCiudadQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateCiudad")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateCiudad([FromBody] CreateCiudadCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateCiudad")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateCiudad([FromBody] UpdateCiudadCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
