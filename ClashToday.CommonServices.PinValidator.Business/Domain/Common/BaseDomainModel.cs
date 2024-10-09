namespace ClashToday.CommonServices.PinValidator.Business.Domain.Common;

public abstract class BaseDomainModel
{
    public BaseDomainModel()
    {
        Activo = true;
        FechaCreacion = DateTime.UtcNow; // Establece la fecha de creaci�n a la fecha y hora actual
        UsuarioCreacion = "System";
    }
    public DateTime FechaCreacion { get; set; }
    public string UsuarioCreacion { get; set; } = null!;
    public DateTime? FechaModificacion { get; set; }
    public string? UsuarioModificacion { get; set; }
    public bool Activo { get; set; }
}
