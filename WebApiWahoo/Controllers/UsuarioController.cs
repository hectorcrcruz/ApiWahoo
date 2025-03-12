using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.TipoIdentificacion.Commands.AddTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Commands.UpTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Queries.ListTipoIdentificacion;
using WahooApplication.Features.Usuario.Commands.AddUsuario;
using WahooApplication.Features.Usuario.Commands.UpUsuario;
using WahooApplication.Features.Usuario.Queries.ListUsuario;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public UsuarioController(ILogger<UsuarioController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListUsuario")]
        public async Task<ActionResult<IEnumerable<UsuarioModel>>> ListUsuario(int? Id)
        {
            var query = await _mediator.Send(new ListUsuarioQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateUsuario")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateUsuario([FromBody] CreateUsuarioCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateUsuario")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateUsuario([FromBody] UpdateUsuarioCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
