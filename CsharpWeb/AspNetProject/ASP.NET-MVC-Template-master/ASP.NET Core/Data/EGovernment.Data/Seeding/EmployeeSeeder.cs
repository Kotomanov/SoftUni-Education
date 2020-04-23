namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Models.People;

    internal class EmployeeSeeder : ISeeder
    {
        public Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<Employee> employeesList = new List<Employee>();

            var employee = new Employee
            {
                FirstName = "Surueya",
                LastName = "Burak",
                EGN = "1234567890",
                AddressId = 1,
                Salary = 500M,
            };


            throw new NotImplementedException();
        }
    }
}
