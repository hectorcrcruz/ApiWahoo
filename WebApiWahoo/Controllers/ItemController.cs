using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Item.Commands.AddItem;
using WahooApplication.Features.Item.Commands.UpItem;
using WahooApplication.Features.Item.Queries.ListItem;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ILogger<ItemController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public ItemController(ILogger<ItemController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListItem")]
        public async Task<ActionResult<IEnumerable<ItemModel>>> ListItem(int? Id)
        {
            var query = await _mediator.Send(new ListItemQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateItem")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateItem([FromBody] CreateItemCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateItem")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateItem([FromBody] UpdateItemCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
