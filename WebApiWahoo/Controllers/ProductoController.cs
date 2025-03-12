using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Producto.Commands.AddProducto;
using WahooApplication.Features.Producto.Commands.UpProducto;
using WahooApplication.Features.Producto.Queries.ListProducto;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public ProductoController(ILogger<ProductoController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListProducto")]
        public async Task<ActionResult<IEnumerable<ProductoModel>>> ListProducto(int? Id)
        {
            var query = await _mediator.Send(new ListProductoQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateProducto")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateProducto([FromBody] CreateProductoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateProducto")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateProducto([FromBody] UpdateProductoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

    }
}
