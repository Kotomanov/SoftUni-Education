namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Enums.Entities.Health;
    using EGovernment.Data.Models.Models.Health.Entities;

    internal class DepartmentSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<string> listOfDepartments = Enum.GetNames(typeof(DepartmentCode)).ToList();

            if (listOfDepartments.Count > dbContext.Departments.Count())
            {
                for (int i = 0; i < listOfDepartments.Count; i++)
                {
                    Department departmentToAdd = new Department { Name = listOfDepartments[i], DepartmentCode = (DepartmentCode)i };
                    await dbContext.Departments.AddAsync(departmentToAdd);
                }
            }
        }
    }
}
