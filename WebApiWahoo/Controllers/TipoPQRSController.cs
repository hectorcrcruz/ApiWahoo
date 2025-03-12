using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.TipoIdentificacion.Commands.AddTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Commands.UpTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Queries.ListTipoIdentificacion;
using WahooApplication.Features.TipoPQRS.Commands.AddTipoPQRS;
using WahooApplication.Features.TipoPQRS.Commands.UpTipoPQRS;
using WahooApplication.Features.TipoPQRS.Queries.ListTipoPQRS;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class TipoPQRSController : ControllerBase
    {
        private readonly ILogger<TipoPQRSController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public TipoPQRSController(ILogger<TipoPQRSController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListTipoPQRS")]
        public async Task<ActionResult<IEnumerable<TipoPQRSModel>>> ListTipoPQRS(int? Id)
        {
            var query = await _mediator.Send(new ListTipoPQRSQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateTipoPQRS")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateTipoPQRS([FromBody] CreateTipoPQRSCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateTipoPQRS")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateTipoPQRS([FromBody] UpdateTipoPQRSCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
