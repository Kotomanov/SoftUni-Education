using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Connection:
            // Scaffold-DbContext -Connection "Server=DESKTOP-1SHT5A0\SQLEXPRESS;Database=SoftUni;Integrated Security=True" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data

            SoftUniContext context = new SoftUniContext();

            string result = GetEmployeesInPeriod(context);

            Console.WriteLine(result.ToString());
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();


            var result = context.Employees
                .Select(e => new
                {
                    e.EmployeeId,
                    e.FirstName,
                    e.LastName,
                    e.MiddleName,
                    e.JobTitle,
                    e.Salary
                })
                .OrderBy(e => e.EmployeeId);

            foreach (var entry in result)
            {
                sb.AppendLine($"{entry.FirstName} {entry.LastName} {entry.MiddleName} {entry.JobTitle} {entry.Salary:f2}");
            }

            return sb.ToString().TrimEnd();



        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var result = context.Employees
                .Where(e => e.Salary > 50000)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName);

            foreach (var person in result)
            {
                sb.AppendLine($"{person.FirstName} - {person.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }


        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var result = context.Employees
                .Where(e => e.Department.Name == "Research and Development")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Department.Name,
                    e.Salary

                })
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName).ToList();


            foreach (var person in result)
            {
                sb.AppendLine($"{person.FirstName} {person.LastName} from {person.Name} - ${person.Salary:f2}");
            }

            return sb.ToString().TrimEnd();

        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Address address = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4

            };

            context.Addresses.Add(address);

            context.SaveChanges();

            int id = context
                .Addresses
                .Where(a => a.AddressText == "Vitoshka 15")
                .FirstOrDefault()
                .AddressId;

            var nakov = context
                .Employees
                .Where(e => e.LastName == "Nakov")
                .FirstOrDefault();

            nakov.AddressId = id;

            context.SaveChanges();

            var result = context.Employees.Select(e => new
            {
                e.EmployeeId,
                e.Address.AddressText,
                e.AddressId
            })
                .OrderByDescending(e => e.AddressId)
                .Take(10);

            StringBuilder sb = new StringBuilder();

            foreach (var item in result)
            {
                sb.AppendLine($"{item.AddressText}");
            }

            return sb.ToString().TrimEnd();
        }


        public static string GetAddressesByTown(SoftUniContext context)
        {
            var selection = context.Addresses
                .Select(a => new
                {
                    AddressText = a.AddressText,
                    TownName = a.Town.Name,
                    EmployeesCount = a.Employees.Count // who live there
                })
                 .OrderByDescending(a => a.EmployeesCount)
                 .ThenBy(a => a.TownName)
                 .ThenBy(a => a.AddressText)
                 .ToList()
                 .Take(10);

            StringBuilder sb = new StringBuilder();

            foreach (var item in selection)
            {
                sb.AppendLine($"{item.AddressText}, {item.TownName} - {item.EmployeesCount} employees");
            }

            return sb.ToString().TrimEnd();

        }


        public static string GetEmployee147(SoftUniContext context)
        {

            var selection = context
                                 .Employees
                                 .Where(e => e.EmployeeId == 147)
                                 .Select(e => new
                                 {
                                     e.FirstName,
                                     e.LastName,
                                     e.JobTitle,
                                     List = e.EmployeesProjects
                                         .Select(ep => new
                                         {
                                             ep.Project.Name
                                         })
                                     .OrderBy(ep => ep.Name)
                                     .ToList()
                                 })
                                 .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var item in selection)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName} - {item.JobTitle}");

                foreach (var project in item.List)
                {
                    sb.AppendLine($"{project.Name}");
                }

            }

            return sb.ToString().TrimEnd();
        }


        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {

            var selection = context.Departments
                .Where(d => d.Employees.Count > 5)
                .Select(d => new
                {
                    d.Name,
                    d.Manager.FirstName,
                    d.Manager.LastName,
                    d.Employees.Count,
                    List = d.Employees.Select
                                       (e => new
                                       {
                                           e.FirstName,
                                           e.LastName,
                                           e.JobTitle
                                       }
                                       )
                                       .OrderBy(e => e.FirstName)
                                       .ThenBy(e => e.LastName)

                })
                .OrderBy(d => d.Count)
                .ThenBy(d => d.Name);


            StringBuilder sb = new StringBuilder();

            foreach (var row in selection)
            {
                sb.AppendLine($"{row.Name} - {row.FirstName} {row.LastName}");

                foreach (var item in row.List)
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName} - {item.JobTitle}");
                }
            }

            return sb.ToString().TrimEnd();
        }


        public static string GetLatestProjects(SoftUniContext context)
        {

            var selection = context.Projects.Select(p => new
            {
                p.Name,
                p.Description,
                p.StartDate
            })
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .OrderBy(p => p.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var entry in selection)
            {
                sb.AppendLine($"{entry.Name}");
                sb.AppendLine($"{entry.Description}");
                sb.AppendLine($"{entry.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");

            }

            return sb.ToString().TrimEnd();
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {

            var selection = context
                .Employees
                .Where(e => e.Department.Name == "Engineering" ||
                            e.Department.Name == "Tool Design" ||
                            e.Department.Name == "Marketing" ||
                            e.Department.Name == "Information Services")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    NewSalary = e.Salary * 1.12m
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName);

            StringBuilder sb = new StringBuilder();

            foreach (var person in selection)
            {
                sb.AppendLine($"{person.FirstName} {person.LastName} (${person.NewSalary:f2})");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var selection = context.Employees
                .Where(e => e.FirstName.StartsWith("Sa"))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var item in selection)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName} - {item.JobTitle} - (${item.Salary:f2})");
            }

            return sb.ToString().TrimEnd();
        }


        public static string GetEmployeesInPeriod(SoftUniContext context)
        {

            var selection = context.Employees
                .Where(e => e.EmployeesProjects.Any(p => p.Project.StartDate.Year >= 2001 &&
                       p.Project.StartDate.Year <= 2003))
                .Select(e => new
                {
                    FullName = e.FirstName + " " + e.LastName,
                    ManagerFullName = e.Manager.FirstName + " " + e.Manager.LastName,
                    List = e.EmployeesProjects
                    .Select(p => new
                    {
                        p.Project.Name,
                        p.Project.StartDate,
                        p.Project.EndDate
                    })
                    .ToList()
                })
                .Take(10)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var item in selection)
            {
                sb.AppendLine($"{item.FullName} – manager: {item.ManagerFullName}");

                foreach (var project in item.List)
                {
                    if (project.EndDate == null)
                    {
                        sb.AppendLine($"--{project.Name} - {project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - not finished");
                    }

                    else
                    {
                        sb.AppendLine($"--{project.Name} - {project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - {project.EndDate?.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            return sb.ToString().TrimEnd();

        }



        public static string DeleteProjectById(SoftUniContext context)
        {
                         
            var projectToDelete = context
                       .EmployeesProjects
                       .Where(p=>p.ProjectId ==2)
                       .ToList();

           

            context.EmployeesProjects.RemoveRange(projectToDelete);

             

            var projectToDeleteFromProjects = context.Projects
                                                     .Where(p => p.ProjectId == 2)
                                                     .ToList();

            context.Projects
                   .RemoveRange(projectToDeleteFromProjects);

            context.SaveChanges();

            var projectsToDisplay = context.Projects
                                           .Select(p => p.Name)
                                           .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var project in projectsToDisplay)
            {
                sb.AppendLine($"{project}");
            }

            return sb.ToString().TrimEnd();

        }


        public static string RemoveTown(SoftUniContext context)
        {
            var town = context.Towns
                              .Where(t => t.Name == "Seattle")
                              .First(); 

            var addresses = context.Addresses
                                   .Where(a => a.Town == town);

            int addressesCount = addresses.Count(); 

            var employees = context.Employees
                                   .Where(e =>  addresses.Contains(e.Address)); 
                                    

            foreach (var e in employees)
            {
                e.AddressId = null;
            }


            context.Addresses.RemoveRange(addresses);

            context.Towns.Remove(town);

            context.SaveChanges();

            return $"{addressesCount} addresses in Seattle were deleted";
        }




    }
}
