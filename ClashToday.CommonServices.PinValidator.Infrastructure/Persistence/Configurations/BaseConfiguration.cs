using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ClashToday.CommonServices.PinValidator.Business.Domain.Common;

namespace ClashToday.CommonServices.PinValidator.Infrastructure.Persistence.Configurations;

public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseDomainModel
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.Property(x => x.FechaCreacion)
            .IsRequired();

        builder.Property(x => x.UsuarioCreacion)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.UsuarioModificacion)
            .HasMaxLength(100);
    }
}
