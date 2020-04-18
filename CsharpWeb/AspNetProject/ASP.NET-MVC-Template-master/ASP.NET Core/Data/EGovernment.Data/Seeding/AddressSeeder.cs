namespace EGovernment.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Models.Geographical;

    internal class AddressSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            Address address = new Address
            {
                CountryName = "Dummy",
                DistrictName = "Dummy",
                CityName = "Dummy",
                PostalCode = 0000,
                AddressDetails = "Dummy",
            };

            if (!dbContext.Addresses.Any(x => x.DistrictName == null))
            {
                await dbContext.Addresses.AddAsync(address);
            }
        }
    }
}
