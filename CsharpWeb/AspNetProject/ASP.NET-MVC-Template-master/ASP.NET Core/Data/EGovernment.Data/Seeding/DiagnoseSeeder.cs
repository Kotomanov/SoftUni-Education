namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Models.Health;

    internal class DiagnoseSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<Diagnose> diagnoseList = new List<Diagnose>();

            Diagnose diagnose = new Diagnose
            {
                Name = "CuronaVirus",
                Description = "Fantasmagoricus lafchitus",
            };

            Diagnose diagnose1 = new Diagnose
            {
                Name = "JujonaVirus",
                Description = "Hablara muchisimo",
            };

            Diagnose diagnose2 = new Diagnose
            {
                Name = "Who you ball",
                Description = "Sam sym si records",
            };

            Diagnose diagnose3 = new Diagnose
            {
                Name = "LighthouseAches",
                Description = "Bombilla fundida",
            };

            Diagnose diagnose4 = new Diagnose
            {
                Name = "GuzoAches",
                Description = "Dolores de culo",
            };

            Diagnose diagnose5 = new Diagnose
            {
                Name = "TheOtherJobAches",
                Description = "Me duele el trabajo",
            };

            Diagnose diagnose6 = new Diagnose
            {
                Name = "Corana Virus",
                Description = "when I was your age",
            };

            Diagnose diagnose7 = new Diagnose
            {
                Name = "Medical Students Syndrome",
                Description = "Topykedno Uchene",
            };

            Diagnose diagnose8 = new Diagnose
            {
                Name = "Triskadekaphobia",
                Description = "fear of number 13",
            };

            Diagnose diagnose9 = new Diagnose
            {
                Name = "Hexakosioihexekontahexaphobia",
                Description = "fear of 666",
            };

            Diagnose diagnose10 = new Diagnose
            {
                Name = "Phalacrophobia",
                Description = "Bald, becoming",
            };

            diagnoseList.Add(diagnose);
            diagnoseList.Add(diagnose1);
            diagnoseList.Add(diagnose2);
            diagnoseList.Add(diagnose3);
            diagnoseList.Add(diagnose4);
            diagnoseList.Add(diagnose5);
            diagnoseList.Add(diagnose6);
            diagnoseList.Add(diagnose7);
            diagnoseList.Add(diagnose8);
            diagnoseList.Add(diagnose9);
            diagnoseList.Add(diagnose10);

            if (diagnoseList.Count() > dbContext.Diagnoses.Count())
            {
                dbContext.Diagnoses.RemoveRange(dbContext.Diagnoses);
                await dbContext.AddRangeAsync(diagnoseList);
            }
        }
    }
}
