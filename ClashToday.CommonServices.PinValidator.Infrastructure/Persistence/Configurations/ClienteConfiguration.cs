using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ClashToday.CommonServices.PinValidator.Business.Domain;

namespace ClashToday.CommonServices.PinValidator.Infrastructure.Persistence.Configurations;

public class ClientenConfiguration : BaseConfiguration<Cliente>
{
    public override void Configure(EntityTypeBuilder<Cliente> builder)
    {
        base.Configure(builder);

        builder.ToTable("Cliente");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();


        builder.Property(x => x.CveUsuario)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Telefono)
            .HasMaxLength(10)
            .IsRequired();

        builder.Property(x => x.Nombre)
            .IsRequired();

        builder.Property(x => x.Apellido)
            .IsRequired();

    }
}