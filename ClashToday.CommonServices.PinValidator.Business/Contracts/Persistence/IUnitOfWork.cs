using ClashToday.CommonServices.PinValidator.Business.Domain.Common;

namespace ClashToday.CommonServices.PinValidator.Business.Contracts.Persistence;

public interface IUnitOfWork : IDisposable
{
    IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseDomainModel;
}
