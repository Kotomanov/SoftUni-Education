﻿namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    public class ApplicationDbContextSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger(typeof(ApplicationDbContextSeeder));

            // Add here refernce to every seeder class
            var seeders = new List<ISeeder>
                          {
                             /// new RolesSeeder(),
                              // new SettingsSeeder(),

                              // new RoleSeeder(),
                              // new DepartmentSeeder(),
                              // new SpecialtySeeder(),
                              // new AddressSeeder(),
                              // new CountrySeeder(),
                              // new BgDistrictsSeeder(),
                              // new CitySeeder(),
                              // new MinistrySeeder(),
                              // new DiagnoseSeeder(),
                              // new EmployeeSeeder(),
                              // new DoctorSeeder(),
                              // new MedicineSeeder(),
                              // new MedicalRecordSeeder(),
                              // new PatientSeeder(),
                              // new EntitySeeder(),
                              // new VehicleSeeder(),
                          };

            foreach (var seeder in seeders)
            {
                await seeder.SeedAsync(dbContext, serviceProvider);
                await dbContext.SaveChangesAsync();
                logger.LogInformation($"Seeder {seeder.GetType().Name} done.");
            }
        }
    }
}
