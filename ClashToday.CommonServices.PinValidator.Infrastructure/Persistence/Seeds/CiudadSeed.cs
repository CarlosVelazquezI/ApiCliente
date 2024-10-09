using ClashToday.CommonServices.PinValidator.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ClashToday.CommonServices.PinValidator.Infrastructure.Persistence.Seeds
{
    public class CiudadSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var dataJson = File.ReadAllText("../ClashToday.CommonServices.PinValidator.Infrastructure/Persistence/Seeds/Data/ciudades.json");

            var options = new JsonSerializerOptions
            {
                Converters = { new JsonStringEnumConverter() },

                NumberHandling =
                JsonNumberHandling.AllowReadingFromString |
                JsonNumberHandling.AllowNamedFloatingPointLiterals
            };

            var ciudades = JsonSerializer.Deserialize<List<Ciudad>>(dataJson, options);

            modelBuilder.Entity<Ciudad>().HasData(ciudades!);
        }
    }
}
