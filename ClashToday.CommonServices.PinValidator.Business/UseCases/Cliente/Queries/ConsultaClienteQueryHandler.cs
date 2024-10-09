
using AutoMapper;
using ClashToday.CommonServices.PinValidator.Business.Contracts.Persistence;
using ClashToday.CommonServices.PinValidator.Business.UseCases.ViewModels;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ClashToday.CommonServices.PinValidator.Business.UseCases.Cliente.Queries
{
    public class ConsultaClienteQueryHandler : IRequestHandler<ConsultaClienteQuery, IEnumerable<ClienteVm>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ConsultaClienteQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ConsultaClienteQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<ConsultaClienteQueryHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger; 
        }

        public async Task<IEnumerable<ClienteVm>> Handle(ConsultaClienteQuery request, CancellationToken cancellationToken)
        {
            var clientes = await _unitOfWork.GetRepository<Domain.Cliente>().GetAllAsync();
            return _mapper.Map<IEnumerable<ClienteVm>>(clientes)!;
        }
    }
}
