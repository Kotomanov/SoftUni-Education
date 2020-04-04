﻿namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using EGovernment.Data.Models;
    using EGovernment.Data.Models.Enums.Roles;

    public class RoleSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<string> listOfRoles = Enum.GetNames(typeof(Role)).ToList();

            if (listOfRoles.Count > dbContext.Roles.Count())
            {
                for (int i = 1; i < listOfRoles.Count; i++)
                {
                    ApplicationRole roleToAdd = new ApplicationRole { Name = listOfRoles[i], RoleCode = (Role)i };
                    await dbContext.Roles.AddAsync(roleToAdd);
                }
            }
        }
    }
}
