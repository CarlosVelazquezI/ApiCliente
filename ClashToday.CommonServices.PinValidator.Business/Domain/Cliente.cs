using ClashToday.CommonServices.PinValidator.Business.Domain.Common;

namespace ClashToday.CommonServices.PinValidator.Business.Domain
{
    public class Cliente : BaseDomainModel
    {
        public Cliente() {
            CveUsuario = Guid.NewGuid();

        }
        public int Id { get; set; }
        public Guid CveUsuario {  get; set; } 
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string NumIdentificacion { get; set; } = string.Empty;
        public string TipoIdentificacion { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
        public int CiudadId { get; set; }
        public virtual Ciudad? Ciudad { get; set; } // Relación con Ciudad
    }
}
