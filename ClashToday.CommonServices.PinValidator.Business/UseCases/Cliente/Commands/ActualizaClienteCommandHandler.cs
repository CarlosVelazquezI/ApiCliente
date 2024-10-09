using AutoMapper;
using ClashToday.CommonServices.PinValidator.Business.Behaviors;
using ClashToday.CommonServices.PinValidator.Business.Contracts.Persistence;
using ClashToday.CommonServices.PinValidator.Business.Exceptions;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ClashToday.CommonServices.PinValidator.Business.UseCases.Cliente.Commands
{
    public class ActualizaClienteCommandHandler : IRequestHandler<ActualizaClienteCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ActualizaClienteCommandHandler> _logger;
        private readonly ILocalizer _localizer;

        public ActualizaClienteCommandHandler(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            ILogger<ActualizaClienteCommandHandler> logger,
            ILocalizer localizer)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _localizer = localizer;
        }

        public async Task<Unit> Handle(ActualizaClienteCommand request, CancellationToken cancellationToken)
        {
            var cliente = await _unitOfWork.GetRepository<Domain.Cliente>().GetByIdAsync(request.Id);

            if (cliente is null)
            {
                _logger.LogWarning(_localizer.GetLoggerMessage("ActionFail"),
                    request.GetType().Name,
                    request.Id,
                    string.Empty);

                throw new NotFoundException(string.Format(_localizer.GetExceptionMessage("NotFound"),
                    typeof(Domain.Cliente).Name,
                    request.Id));
            }

            _mapper.Map(request, cliente);

            await _unitOfWork.GetRepository<Domain.Cliente>().UpdateAsync(cliente);

            _logger.LogInformation(_localizer.GetLoggerMessage("ActionSuccess"),
                request.GetType().Name,
                typeof(Domain.Cliente).Name,
                request.Id,
                string.Empty);

            return Unit.Value;
        }

    }
}
