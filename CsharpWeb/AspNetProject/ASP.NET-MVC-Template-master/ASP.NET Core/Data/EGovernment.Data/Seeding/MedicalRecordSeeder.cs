namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Models.Health;

    internal class MedicalRecordSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<MedicalRecord> recordsList = new List<MedicalRecord>();

            for (int i = 1; i <= 30; i++)
            {
                var record = new MedicalRecord();

                recordsList.Add(record);
            }

            dbContext.MedicalRecords.AddRange(recordsList);
            dbContext.SaveChanges();
        }
    }
}
