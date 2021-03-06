﻿namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using EGovernment.Data.Models;
    using EGovernment.Data.Models.Enums.Roles;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    internal class RoleSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

            List<string> listOfRoles = Enum.GetNames(typeof(Role)).ToList();

            if (listOfRoles.Count > dbContext.Roles.Count())
            {
                // clear the old information first - MAY CONFUSE THE ADMIN ONE!
                dbContext.Roles.RemoveRange(dbContext.Roles);

                for (int i = 1; i < listOfRoles.Count; i++)
                {
                    ApplicationRole roleToAdd = new ApplicationRole { Name = listOfRoles[i], RoleCode = (Role)i };
                    await roleManager.CreateAsync(new ApplicationRole(listOfRoles[i]));

                    // await dbContext.Roles.AddAsync(roleToAdd);
                }
            }
        }
    }
}
