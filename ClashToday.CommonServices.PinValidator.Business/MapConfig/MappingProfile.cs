using AutoMapper;
using ClashToday.CommonServices.PinValidator.Business.Common;
using ClashToday.CommonServices.PinValidator.Business.Domain;
using ClashToday.CommonServices.PinValidator.Business.UseCases.Cliente.Commands;
using ClashToday.CommonServices.PinValidator.Business.UseCases.ViewModels;

namespace ClashToday.CommonServices.PinValidator.Business.MapConfig;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Command to Domain
        CreateMap<InsertaClienteCommand, Cliente>();
        CreateMap<ActualizaClienteCommand, Cliente>();


        // Domain to ViewModel
        CreateMap<Cliente, ClienteVm>();

    }
}
