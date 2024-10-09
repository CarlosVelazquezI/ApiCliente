using AutoMapper;
using ClashToday.CommonServices.PinValidator.Business.Behaviors;
using ClashToday.CommonServices.PinValidator.Business.Contracts.Persistence;
using ClashToday.CommonServices.PinValidator.Business.Domain;
using ClashToday.CommonServices.PinValidator.Business.Exceptions;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ClashToday.CommonServices.PinValidator.Business.UseCases.Cliente.Commands
{
    public class InsertaClienteCommandHandler : IRequestHandler<InsertaClienteCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<InsertaClienteCommandHandler> _logger;
        private readonly ILocalizer _localizer;

        public InsertaClienteCommandHandler(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            ILogger<InsertaClienteCommandHandler> logger,
            ILocalizer localizer)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _localizer = localizer;
        }

        public async Task<Guid> Handle(InsertaClienteCommand request, CancellationToken cancellationToken)
        {
            if (!await _unitOfWork.GetRepository<Domain.Ciudad>().ExistAsync(e => e.Id == request.CiudadId))
            {
                _logger.LogWarning(_localizer.GetLoggerMessage("ActionFail"),
                    request.GetType().Name,
                    request.CiudadId,
                    string.Empty);

                throw new NotFoundException(string.Format(_localizer.GetExceptionMessage("NotFound"),
                    typeof(Domain.Ciudad).Name,
                    request.CiudadId));
            }

            var cliente = _mapper.Map<Domain.Cliente>(request);

            await _unitOfWork.GetRepository<Domain.Cliente>().AddAsync(cliente!);

            _logger.LogInformation(_localizer.GetLoggerMessage("ActionSuccess"),
                            request.GetType().Name,
                            cliente!.GetType().Name,
                            cliente.CveUsuario,
                            string.Empty);

            return cliente.CveUsuario;
        }

    }
}
