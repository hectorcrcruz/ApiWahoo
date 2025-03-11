using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Calificacion.Queries.ListCalificacion;
using WahooApplication.Features.Departamento.Commands.AddDepartamento;
using WahooApplication.Features.Departamento.Commands.UpDepartamento;
using WahooApplication.Features.Departamento.Queries.ListDepartamento;
using WahooApplication.Logs;
using WahooApplication.Models;

namespace WebApiWahoo.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class DepartamentoController : ControllerBase
    {
        private readonly ILogger<DepartamentoController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public DepartamentoController(ILogger<DepartamentoController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("ListDepartamento")]
        public async Task<ActionResult<IEnumerable<DepartamentoModel>>> ListDepartamento(int? Id)
        {
            var query = await _mediator.Send(new ListDepartamentoQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateDepartamento")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateDepartamento([FromBody] CreateDepartamentoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("UpdateDepartamento")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateDepartamento([FromBody] UpdateDepartamentoCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
