namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Enums.Roles;
    using EGovernment.Data.Models.Models.People;

    internal class SpecialtySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<string> listOfSpecialties = Enum.GetNames(typeof(DoctorSpecialty)).ToList();

            if (listOfSpecialties.Count > dbContext.Specialties.Count())
            {
                for (int i = 0; i < listOfSpecialties.Count; i++)
                {
                    Specialty specialtyToAdd = new Specialty { Name = listOfSpecialties[i], DoctorSpecialty = (DoctorSpecialty)i };
                    await dbContext.Specialties.AddAsync(specialtyToAdd);
                }
            }
        }
    }
}
