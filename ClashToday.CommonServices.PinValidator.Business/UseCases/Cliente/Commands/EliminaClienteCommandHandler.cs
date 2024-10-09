using AutoMapper;
using ClashToday.CommonServices.PinValidator.Business.Behaviors;
using ClashToday.CommonServices.PinValidator.Business.Contracts.Persistence;
using ClashToday.CommonServices.PinValidator.Business.Exceptions;
using MediatR;
using Microsoft.Extensions.Logging;


namespace ClashToday.CommonServices.PinValidator.Business.UseCases.Cliente.Commands
{
    public class EliminaClienteCommandHandler : IRequestHandler<EliminaClienteCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<EliminaClienteCommandHandler> _logger;
        private readonly ILocalizer _localizer;

        public EliminaClienteCommandHandler(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            ILogger<EliminaClienteCommandHandler> logger,
            ILocalizer localizer)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _localizer = localizer;
        }

        public async Task<Unit> Handle(EliminaClienteCommand request, CancellationToken cancellationToken)
        {
            if (!await _unitOfWork.GetRepository<Domain.Cliente>().ExistAsync(s => s.Id == request.Id))
            {
                _logger.LogWarning(_localizer.GetLoggerMessage("ActionFail"),
                    request.GetType().Name,
                    request.Id,
                    string.Empty);

                throw new NotFoundException(string.Format(_localizer.GetExceptionMessage("NotFound"),
                    typeof(Domain.Cliente).Name,
                    request.Id));
            }

            await _unitOfWork.GetRepository<Domain.Cliente>().DeleteAsync(request.Id);

            _logger.LogInformation(_localizer.GetLoggerMessage("ActionSuccess"),
                request.GetType().Name,
                typeof(Domain.Cliente).Name,
                request.Id,
                string.Empty);

            return Unit.Value;
        }

    }
}
