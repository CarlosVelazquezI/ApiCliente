using ClashToday.CommonServices.PinValidator.Business.Domain.Common;

namespace ClashToday.CommonServices.PinValidator.Business.Domain
{
    public class Pais : BaseDomainModel
    {
        public int Id { get; set; }
        public string NombrePais { get; set; } = string.Empty;
        public ICollection<Ciudad> Sucursales { get; set; } = null!;
    }
}
