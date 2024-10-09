using ClashToday.CommonServices.PinValidator.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashToday.CommonServices.PinValidator.Business.UseCases.ViewModels
{
    public class ClienteVm
    {
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
