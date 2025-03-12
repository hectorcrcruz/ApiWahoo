using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.TipoIdentificacion.Commands.AddTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Commands.UpTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Queries.ListTipoIdentificacion;
using WahooApplication.Features.TipoPromocion.Commands.AddTipoPromocion;
using WahooApplication.Features.TipoPromocion.Commands.UpTipoPromocion;
using WahooApplication.Features.TipoPromocion.Queries.ListTipoPromocion;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class TipoPromocionController : ControllerBase
    {
        private readonly ILogger<TipoPromocionController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public TipoPromocionController(ILogger<TipoPromocionController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListTipoPromocion")]
        public async Task<ActionResult<IEnumerable<TipoPromocionModel>>> ListTipoPromocion(int? Id)
        {
            var query = await _mediator.Send(new ListTipoPromocionQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateTipoPromocion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateTipoPromocion([FromBody] CreateTipoPromocionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateTipoPromocion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateTipoPromocion([FromBody] UpdateTipoPromocionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
