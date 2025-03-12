using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Catalogo.Commands.AddCatalogo;
using WahooApplication.Features.Catalogo.Commands.UpCatalogo;
using WahooApplication.Features.Catalogo.Queries.ListCatalogo;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CatalogoController : ControllerBase
    {
        private readonly ILogger<CatalogoController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public CatalogoController(ILogger<CatalogoController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListCatalogo")]
        public async Task<ActionResult<IEnumerable<CatalogoModel>>> ListCatalogo(int? Id)
        {
            var query = await _mediator.Send(new ListCatalogoQuery(Id));
            //_writeLog.WriteLog("La calificacion fue creada con el id {EntityAdd.Id}");
            return Ok(query);
        }

        [HttpPost("CreateCatalogo")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateCatalogo([FromBody] CreateCatalogoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateCatalogo")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateCatalogo([FromBody] UpdateCatalogoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
