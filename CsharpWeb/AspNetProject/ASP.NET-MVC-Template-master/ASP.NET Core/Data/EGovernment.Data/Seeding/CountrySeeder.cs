namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Enums.Geography;
    using EGovernment.Data.Models.Models.Geographical;

    internal class CountrySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<string> listOfCountries = Enum.GetNames(typeof(CountryCode)).ToList();

            if (listOfCountries.Count > dbContext.Countries.Count())
            {
                // clear the old information first
                dbContext.Countries.RemoveRange(dbContext.Countries);

                for (int i = 0; i < listOfCountries.Count; i++)
                {
                    Country countryToAdd = new Country { Name = listOfCountries[i], CountryCode = (CountryCode)i };
                    await dbContext.Countries.AddAsync(countryToAdd);
                }
            }
        }
    }
}
