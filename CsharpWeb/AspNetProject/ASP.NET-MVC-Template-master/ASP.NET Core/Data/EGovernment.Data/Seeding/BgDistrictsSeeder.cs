namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Enums;
    using EGovernment.Data.Models.Models.Geographical;

    internal class BgDistrictsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            //if (dbContext.Districts.Count() == 0)
            //{
            //District districtToAdd = new District
            //{
            //    Name = "Dummy",
            //    CountryId = 1,
            //    DistrictCode = 0,
            //};

            //await dbContext.Districts.AddAsync(districtToAdd);
            // }

            List<string> listOfDistricts = Enum.GetNames(typeof(DistrictCode)).ToList();

            var countryId = dbContext.Countries.First().Id;

            if (listOfDistricts.Count > dbContext.Districts.Count())
            {
                dbContext.Districts.RemoveRange(dbContext.Districts);

                for (int i = 0; i < listOfDistricts.Count; i++)
                {
                    District districtToAdd = new District
                    {
                        Name = listOfDistricts[i],
                        CountryId = countryId + 1,
                        DistrictCode = (DistrictCode)i,
                    };

                    await dbContext.Districts.AddAsync(districtToAdd);
                }
            }
        }
    }
}
