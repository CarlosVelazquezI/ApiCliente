using MediatR;
using ClashToday.CommonServices.PinValidator.Business.Domain;
using ClashToday.CommonServices.PinValidator.Business.UseCases.ViewModels;

namespace ClashToday.CommonServices.PinValidator.Business.UseCases.Cliente.Queries
{
    public class ConsultaClienteQuery : IRequest<IEnumerable<ClienteVm>>
    {
    }
}
