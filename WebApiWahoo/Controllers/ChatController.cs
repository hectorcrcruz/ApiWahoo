using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Chat.Commands.AddChat;
using WahooApplication.Features.Chat.Commands.UpChat;
using WahooApplication.Features.Chat.Queries.ListChat;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly ILogger<ChatController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public ChatController(ILogger<ChatController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListChat")]
        public async Task<ActionResult<IEnumerable<ChatModel>>> ListChat(int? Id)
        {
            var query = await _mediator.Send(new ListChatQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateChat")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateChat([FromBody] CreateChatCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateChat")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateChat([FromBody] UpdateChatCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
