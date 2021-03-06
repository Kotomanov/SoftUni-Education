﻿namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Models.People;

    internal class EmployeeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<Employee> employeesList = new List<Employee>();

            var employee = new Employee
            {
                FirstName = "Surueya",
                LastName = "Burak",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee1 = new Employee
            {
                FirstName = "Bat",
                LastName = "Boiko",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee2 = new Employee
            {
                FirstName = "Djehide ",
                LastName = "Karaoglu",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee3 = new Employee
            {
                FirstName = "Mumun ",
                LastName = "Hassan",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee4 = new Employee
            {
                FirstName = "Suhan",
                LastName = "Alemdarolu",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee5 = new Employee
            {
                FirstName = "Siham",
                LastName = "Sihamova",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee6 = new Employee
            {
                FirstName = "Farukh",
                LastName = "Buran",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee7 = new Employee
            {
                FirstName = "Esma",
                LastName = "Sultan",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee8 = new Employee
            {
                FirstName = "Ali",
                LastName = "Rezza",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee9 = new Employee
            {
                FirstName = "Gino",
                LastName = "Dupkorovoff",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee10 = new Employee
            {
                FirstName = "Djesur",
                LastName = "Karahasanolu",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee11 = new Employee
            {
                FirstName = "Bade",
                LastName = "Bidem",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee12 = new Employee
            {
                FirstName = "Ohne",
                LastName = "Boly",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee13 = new Employee
            {
                FirstName = "Adalet",
                LastName = "Mehmetolu",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee14 = new Employee
            {
                FirstName = "Kumar",
                LastName = "Vinot",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee15 = new Employee
            {
                FirstName = "Amador",
                LastName = "Rivas",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee16 = new Employee
            {
                FirstName = "Lola",
                LastName = "Trujillo",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee17 = new Employee
            {
                FirstName = "Berta",
                LastName = "Escobar",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee18 = new Employee
            {
                FirstName = "Enrique",
                LastName = "Pastor",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee19 = new Employee
            {
                FirstName = "Maite",
                LastName = "Figueroa",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee20 = new Employee
            {
                FirstName = "Coque",
                LastName = "Calatrava",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee21 = new Employee
            {
                FirstName = "Rizwan",
                LastName = "Nioka",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee22 = new Employee
            {
                FirstName = "Araceli",
                LastName = "Madariaga",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee23 = new Employee
            {
                FirstName = "Raquel",
                LastName = "Villanueva",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee24 = new Employee
            {
                FirstName = "Estela",
                LastName = "Reynolds",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee25 = new Employee
            {
                FirstName = "Leonardo",
                LastName = "Romani",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                IsManager = true,
                Salary = 500M,
            };

            var employee26 = new Employee
            {
                FirstName = "Vicente",
                LastName = "Maroto",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee27 = new Employee
            {
                FirstName = "Nines",
                LastName = "Villanueva",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee28 = new Employee
            {
                FirstName = "Fermín",
                LastName = "Trujillo",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee29 = new Employee
            {
                FirstName = "Maximo",
                LastName = "Angulo",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee30 = new Employee
            {
                FirstName = "Antonio",
                LastName = "Fagaldo",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee31 = new Employee
            {
                FirstName = "Rosario",
                LastName = "Parrales",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee32 = new Employee
            {
                FirstName = "Teodoro",
                LastName = "Rivas",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee33 = new Employee
            {
                FirstName = "Yolanda",
                LastName = "Morcillo",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee34 = new Employee
            {
                FirstName = "Dina",
                LastName = "Stoeva",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee35 = new Employee
            {
                FirstName = "Michael",
                LastName = "Petrov",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee36 = new Employee
            {
                FirstName = "Mihail",
                LastName = "Traichev",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee37 = new Employee
            {
                FirstName = "Garderobcho",
                LastName = "Ivanov",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee38 = new Employee
            {
                FirstName = "Nu",
                LastName = "Pogodi",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee39 = new Employee
            {
                FirstName = "Tomi",
                LastName = "Djeri",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee40 = new Employee
            {
                FirstName = "Kumcho",
                LastName = "Vulkan",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee41 = new Employee
            {
                FirstName = "Kuma",
                LastName = "Lisana",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee42 = new Employee
            {
                FirstName = "Lady",
                LastName = "Gabba",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee43 = new Employee
            {
                FirstName = "Shushana",
                LastName = "Dimitrova",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee44 = new Employee
            {
                FirstName = "Chicho",
                LastName = "Potyo",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee45 = new Employee
            {
                FirstName = "Profesor",
                LastName = "Maitapchyiski",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            var employee46 = new Employee
            {
                FirstName = "La",
                LastName = "Chusa",
                EGN = "1234567890",
                AddressId = 1,
                ManagerId = 2,
                Salary = 500M,
            };

            employeesList.Add(employee);
            employeesList.Add(employee1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            employeesList.Add(employee4);
            employeesList.Add(employee5);
            employeesList.Add(employee6);
            employeesList.Add(employee7);
            employeesList.Add(employee8);
            employeesList.Add(employee9);
            employeesList.Add(employee10);
            employeesList.Add(employee11);
            employeesList.Add(employee12);
            employeesList.Add(employee13);
            employeesList.Add(employee14);
            employeesList.Add(employee15);
            employeesList.Add(employee16);
            employeesList.Add(employee17);
            employeesList.Add(employee18);
            employeesList.Add(employee19);
            employeesList.Add(employee20);
            employeesList.Add(employee21);
            employeesList.Add(employee22);
            employeesList.Add(employee23);
            employeesList.Add(employee24);
            employeesList.Add(employee25);
            employeesList.Add(employee26);
            employeesList.Add(employee27);
            employeesList.Add(employee28);
            employeesList.Add(employee29);
            employeesList.Add(employee30);
            employeesList.Add(employee31);
            employeesList.Add(employee32);
            employeesList.Add(employee33);
            employeesList.Add(employee34);
            employeesList.Add(employee35);
            employeesList.Add(employee36);
            employeesList.Add(employee37);
            employeesList.Add(employee38);
            employeesList.Add(employee39);
            employeesList.Add(employee40);
            employeesList.Add(employee41);
            employeesList.Add(employee42);
            employeesList.Add(employee43);
            employeesList.Add(employee44);
            employeesList.Add(employee45);
            employeesList.Add(employee46);

            await dbContext.AddRangeAsync(employeesList);
            await dbContext.SaveChangesAsync();
        }
    }
}
