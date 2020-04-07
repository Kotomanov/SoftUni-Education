namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Enums.Entities;
    using EGovernment.Data.Models.Models.Health.Entities;

    internal class MinistrySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<string> listOfMinistries = Enum.GetNames(typeof(MinistryCode)).ToList();

            if (listOfMinistries.Count > dbContext.Ministries.Count())
            {
                for (int i = 0; i < listOfMinistries.Count; i++)
                {
                    Ministry ministryToAdd = new Ministry { Name = listOfMinistries[i], MinistryCode = (MinistryCode)i };
                    await dbContext.Ministries.AddAsync(ministryToAdd);
                }
            }
        }
    }
}
