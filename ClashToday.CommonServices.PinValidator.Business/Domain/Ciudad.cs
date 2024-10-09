using ClashToday.CommonServices.PinValidator.Business.Domain.Common;

namespace ClashToday.CommonServices.PinValidator.Business.Domain
{
    public class Ciudad : BaseDomainModel
    {
        public int Id { get; set; }
        public string NombreCiudad { get; set; } = string.Empty;
        public int PaisId { get; set; }
        public virtual Pais? Pais { get; set; }
        public ICollection<Cliente> Cliente { get; set; } = null!;
    }
}
