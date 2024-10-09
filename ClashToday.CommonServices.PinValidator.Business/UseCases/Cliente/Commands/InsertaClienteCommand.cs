using MediatR;

namespace ClashToday.CommonServices.PinValidator.Business.UseCases.Cliente.Commands
{
    public class InsertaClienteCommand : IRequest<Guid>
    {
        public int Id { get; set; }
        public int CiudadId { get; set; }
        public Guid CveUsuario { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string NumIdentificacion { get; set; } = string.Empty;
        public string TipoIdentificacion { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
    }
}
