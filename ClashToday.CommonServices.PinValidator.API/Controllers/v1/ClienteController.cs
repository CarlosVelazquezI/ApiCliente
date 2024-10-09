using ClashToday.CommonServices.PinValidator.Business.UseCases.Cliente.Commands;
using ClashToday.CommonServices.PinValidator.Business.UseCases.Cliente.Queries;
using ClashToday.CommonServices.PinValidator.Business.UseCases.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClashToday.CommonServices.PinValidator.API.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ClienteController : BaseController
    {
        private readonly IMediator _mediator;

        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(IEnumerable<ClienteVm>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ClienteVm>>> GetAllClientes()
        => Ok(await _mediator.Send(new ConsultaClienteQuery()));

        [HttpPost("")]
        [ProducesResponseType(typeof(Guid), StatusCodes.Status200OK)]
        public async Task<ActionResult<Guid>> CrearUsuario(InsertaClienteCommand insertaClienteCommand)
        => Ok(await _mediator.Send(insertaClienteCommand));

        [HttpPut("")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<int>> ActualizarUsuario(ActualizaClienteCommand actualizaClienteCommand)
        {
            await _mediator.Send(actualizaClienteCommand);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<Guid>> DeleteSucursal(int id)
        {
            await _mediator.Send(new EliminaClienteCommand(id));
            return NoContent();
        }


    }
}
