namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Models.Health;

    internal class MedicineSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<Medicine> medicinesList = new List<Medicine>();

            Medicine medicine = new Medicine
            {
                Name = "Antinapukopetin",
                Description = "Unoparatodoslosdolores",
                AvailableQuantity = 100,
                TotalQuantity = 100,
            };

            Medicine medicine1 = new Medicine
            {
                Name = "MagNezii",
                Description = "Paraquenohayadolores",
                AvailableQuantity = 200,
                TotalQuantity = 200,
            };

            Medicine medicine2 = new Medicine
            {
                Name = "DeGuzin",
                Description = "Quitagases",
                AvailableQuantity = 1200,
                TotalQuantity = 1200,
            };

            Medicine medicine3 = new Medicine
            {
                Name = "AntiPollaDolores",
                Description = "Perderlosdolores en la polla",
                AvailableQuantity = 6200,
                TotalQuantity = 6200,
            };

            Medicine medicine4 = new Medicine
            {
                Name = "Anti Perspirant",
                Description = "Sin sudores y sin olor",
                AvailableQuantity = 16540,
                TotalQuantity = 16540,
            };

            Medicine medicine5 = new Medicine
            {
                Name = "Rikki Ya",
                Description = "No habra ningun problema con la salud",
                AvailableQuantity = 116540,
                TotalQuantity = 116540,
            };

            Medicine medicine6 = new Medicine
            {
                Name = "Vod Kaa 6",
                Description = "Kao upoika",
                AvailableQuantity = 11745,
                TotalQuantity = 11745,
            };

            Medicine medicine7 = new Medicine
            {
                Name = "Bebidas sin tapas",
                Description = "Se puede",
                AvailableQuantity = 5,
                TotalQuantity = 5,
            };

            Medicine medicine8 = new Medicine
            {
                Name = "Gradmas teeth",
                Description = "Para levantar el avion",
                AvailableQuantity = 15,
                TotalQuantity = 15,
            };

            Medicine medicine9 = new Medicine
            {
                Name = "Ajos",
                Description = "Para despedir los vampires",
                AvailableQuantity = 15,
                TotalQuantity = 15,
            };

            Medicine medicine10 = new Medicine
            {
                Name = "Viruslava",
                Description = "Curonavirusscarer",
                AvailableQuantity = 4515,
                TotalQuantity = 4515,
            };

            Medicine medicine11 = new Medicine
            {
                Name = "Karantinyo",
                Description = "Remove Remove",
                AvailableQuantity = 415,
                TotalQuantity = 415,
            };

            Medicine medicine12 = new Medicine
            {
                Name = "Viruslava",
                Description = "Me duele el otro trabajo",
                AvailableQuantity = 415,
                TotalQuantity = 415,
            };

            medicinesList.Add(medicine);
            medicinesList.Add(medicine1);
            medicinesList.Add(medicine2);
            medicinesList.Add(medicine3);
            medicinesList.Add(medicine4);
            medicinesList.Add(medicine5);
            medicinesList.Add(medicine6);
            medicinesList.Add(medicine7);
            medicinesList.Add(medicine8);
            medicinesList.Add(medicine9);
            medicinesList.Add(medicine10);
            medicinesList.Add(medicine11);
            medicinesList.Add(medicine12);

            dbContext.Medicines.AddRange(medicinesList);
            await dbContext.SaveChangesAsync();
        }
    }
}
