using MediatR;

namespace ClashToday.CommonServices.PinValidator.Business.UseCases.Cliente.Commands
{
    public class EliminaClienteCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public EliminaClienteCommand(int id)
        {
            Id = id;
        }
    }
}
