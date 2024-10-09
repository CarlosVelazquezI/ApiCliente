using Microsoft.EntityFrameworkCore;
using ClashToday.CommonServices.PinValidator.Business.Domain;
using ClashToday.CommonServices.PinValidator.Business.Domain.Common;
using ClashToday.CommonServices.PinValidator.Infrastructure.Persistence.Seeds;

namespace ClashToday.CommonServices.PinValidator.Infrastructure.Persistence;

public class ContextDb : DbContext
{
    public ContextDb(DbContextOptions<ContextDb> options) : base(options)
    {
    }

    // Aqui se agregan los DbSet de las entidades
    public DbSet<Pais> Pais { get; set; } = null!;
    public DbSet<Ciudad> Ciudad { get; set; } = null!;
    public DbSet<Cliente> Cliente { get; set; } = null!;

    // Sobreescribir el metodo SaveChangesAsync para que se actualicen las propiedades de auditoria
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.FechaCreacion = DateTime.UtcNow;
                    entry.Entity.UsuarioCreacion = string.IsNullOrEmpty(entry.Entity.UsuarioCreacion) ? "System" : entry.Entity.UsuarioCreacion;
                    break;
                case EntityState.Modified:
                    entry.Entity.FechaModificacion = DateTime.UtcNow;
                    entry.Entity.UsuarioModificacion = string.IsNullOrEmpty(entry.Entity.UsuarioModificacion) ? "System" : entry.Entity.UsuarioModificacion;
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Aqui se agregan las configuraciones de las entidades para ser mapeadas a la base de datos
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContextDb).Assembly);

        PaisSeed.Seed(modelBuilder);
        CiudadSeed.Seed(modelBuilder);

        // Aqui se agregan los datos iniciales de la base de datos
        ContextDbSeed.Seed(modelBuilder);
    }
}
