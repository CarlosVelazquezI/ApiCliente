using ClashToday.CommonServices.PinValidator.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace ClashToday.CommonServices.PinValidator.Infrastructure.Persistence.Seeds
{
    public class PaisSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var dataJson = File.ReadAllText("../ClashToday.CommonServices.PinValidator.Infrastructure/Persistence/Seeds/Data/paises.json");
            var paises = JsonSerializer.Deserialize<List<Pais>>(dataJson);

            modelBuilder.Entity<Pais>().HasData(paises!);
        }
    }
}
