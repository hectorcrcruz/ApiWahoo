using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.CategoriaLog.Queries.ListCategoriaLog;
using WahooApplication.Features.CategoriaProducto.Commands.AddCategoriaProducto;
using WahooApplication.Features.CategoriaProducto.Commands.UpCategoriaProducto;
using WahooApplication.Features.CategoriaProducto.Queries.ListCategoria;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CategoriaProductoController : ControllerBase
    {
        private readonly ILogger<CategoriaProductoController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public CategoriaProductoController(ILogger<CategoriaProductoController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListCategoriaProducto")]
        public async Task<ActionResult<IEnumerable<CategoriaProductoModel>>> ListCategoriaProducto(int? Id)
        {
            var query = await _mediator.Send(new ListCategoriaProductoQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateCategoriaProducto")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateCategoriaProducto([FromBody] CreateCategoriaProductoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateCategoriaProducto")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateCategoriaProducto([FromBody] UpdateCategoriaProductoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
