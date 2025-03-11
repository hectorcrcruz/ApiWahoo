using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Producto.Commands.UpProducto;
using WahooApplication.Features.Promocion.Commands.AddPromocion;
using WahooApplication.Features.Promocion.Commands.UpPromocion;
using WahooApplication.Features.Promocion.Queries.ListPromocion;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class PromocionController : ControllerBase
    {
        private readonly ILogger<PromocionController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public PromocionController(ILogger<PromocionController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListPromocion")]
        public async Task<ActionResult<IEnumerable<PromocionModel>>> ListPromocion(int? Id)
        {
            var query = await _mediator.Send(new ListPromocionQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreatePromocion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreatePromocion([FromBody] CreatePromocionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdatePromocion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdatePromocion([FromBody] UpdatePromocionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
