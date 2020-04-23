namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EGovernment.Data.Models.Enums.Entities.Health;
    using EGovernment.Data.Models.Enums.Vehicles;
    using EGovernment.Data.Models.Models.Vehicles;

    internal class VehicleSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<Vehicle> vehiclesList = new List<Vehicle>();

            Vehicle vehicle1 = new Vehicle
            {
                CarPlate = "CB1111CB",
                Made = "Bri4ka",
                Model = "Scariest",
                VehicleType = (VehicleType)5,
                FuelType = (FuelType)9,
                Millage = 1000000,
                VIN = "Ne6tosi",
                PassangersCapacity = 33,
                OwningEntity = (EntityType)6,
            };

            Vehicle vehicle2 = new Vehicle
            {
                CarPlate = "CB2222CB",
                Made = "Ko4ina",
                Model = "Modern",
                VehicleType = (VehicleType)7,
                FuelType = (FuelType)8,
                Millage = 1,
                VIN = "KaraiDaVyrvi666",
                PassangersCapacity = 3,
                OwningEntity = (EntityType)2,
            };

            Vehicle vehicle3 = new Vehicle
            {
                CarPlate = "OB4444AP",
                Made = "Brykmata",
                Model = "NaBaiIvan",
                VehicleType = (VehicleType)3,
                FuelType = (FuelType)9,
                Millage = 3456,
                VIN = "DaIma3456",
                PassangersCapacity = 49,
                OwningEntity = (EntityType)1,
            };

            vehiclesList.Add(vehicle1);
            vehiclesList.Add(vehicle2);
            vehiclesList.Add(vehicle3);

            await dbContext.Vehicles.AddRangeAsync(vehiclesList);
            await dbContext.SaveChangesAsync();
        }
    }
}
