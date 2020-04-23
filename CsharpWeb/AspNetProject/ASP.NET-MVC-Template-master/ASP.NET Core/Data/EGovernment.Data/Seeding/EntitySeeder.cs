namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Enums.Entities.Health;
    using EGovernment.Data.Models.Models.Health.Entities;

    internal class EntitySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<Entity> entitiesList = new List<Entity>();

            Entity entity1 = new Entity
            {
                Name = "VMA",
                AddressId = 1,
                EntityType = (EntityType)0,
            };

            Entity entity2 = new Entity
            {
                Name = "Pirogov",
                AddressId = 1,
                EntityType = (EntityType)4,
            };

            Entity entity3 = new Entity
            {
                Name = "Karlukovo",
                AddressId = 1,
                EntityType = (EntityType)2,
            };

            Entity entity4 = new Entity
            {
                Name = "Alexandrovska",
                AddressId = 1,
                EntityType = (EntityType)0,
            };

            Entity entity5 = new Entity
            {
                Name = "Rodilnoto AG",
                AddressId = 1,
                EntityType = (EntityType)6,
            };

            Entity entity6 = new Entity
            {
                Name = "Pazardjishkata...",
                AddressId = 1,
                EntityType = (EntityType)6,
            };

            Entity entity7 = new Entity
            {
                Name = "Pavel Banya",
                AddressId = 1,
                EntityType = (EntityType)3,
            };

            entitiesList.Add(entity1);
            entitiesList.Add(entity2);
            entitiesList.Add(entity3);
            entitiesList.Add(entity4);
            entitiesList.Add(entity5);
            entitiesList.Add(entity6);
            entitiesList.Add(entity7);

            await dbContext.Entities.AddRangeAsync(entitiesList);
            await dbContext.SaveChangesAsync();
        }
    }
}
