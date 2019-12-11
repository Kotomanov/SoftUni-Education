namespace TeisterMask.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    using Data;
    using System.Xml.Serialization;
    using TeisterMask.DataProcessor.ImportDto;
    using System.IO;
    using System.Text;
    using System.Linq;
    using System.Globalization;
    using Newtonsoft.Json;
    using TeisterMask.Data.Models;
    using TeisterMask.Data.Models.Enums;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedProject
            = "Successfully imported project - {0} with {1} tasks.";

        private const string SuccessfullyImportedEmployee
            = "Successfully imported employee - {0} with {1} tasks.";

        public static string ImportProjects(TeisterMaskContext context, string xmlString)
        {


            var xmlSerializer = new XmlSerializer(typeof(ProjectImportDto[]),
                                new XmlRootAttribute("Projects"));

            using (var reader = new StringReader(xmlString))
            {
                ProjectImportDto[] projectDtos = (ProjectImportDto[])xmlSerializer.Deserialize(reader);

                StringBuilder sb = new StringBuilder();

                List<Task> taskList = new List<Task>();
                List<Project> projectList = new List<Project>();

                foreach (var dto in projectDtos)
                {
                    if (!IsValid(dto))
                    {
                        sb.AppendLine(ErrorMessage);
                    }

                    else
                    {
                        Project newproject = new Project()

                        {
                            Name = dto.Name,
                            OpenDate = DateTime.ParseExact(dto.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            DueDate = string.IsNullOrEmpty(dto.DueDate) ? (DateTime?)null : DateTime.ParseExact(dto.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),

                        };



                        foreach (var task in dto.Tasks)
                        {
                            DateTime taskOpenDate = DateTime.ParseExact(task.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            DateTime taskDuedate = DateTime.ParseExact(task.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            if (!IsValid(task))
                            {
                                sb.AppendLine(ErrorMessage);
                            }

                            else if (taskOpenDate < newproject.OpenDate || taskDuedate > newproject.DueDate)
                            {
                                sb.AppendLine(ErrorMessage);
                            }

                            else
                            {
                                Boolean executionType = Enum.TryParse(task.ExecutionType, out ExecutionType execType);
                                Boolean labeltype = Enum.TryParse(task.LabelType, out LabelType labType);

                                if (!executionType || !labeltype)
                                {
                                    sb.AppendLine(ErrorMessage);
                                }

                                else
                                {
                                    Task newTask = new Task()
                                    {

                                        Name = task.Name,
                                        OpenDate = DateTime.ParseExact(task.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                                        DueDate = DateTime.ParseExact(task.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                                        ExecutionType = (ExecutionType)Enum.Parse(typeof(ExecutionType), task.ExecutionType, true),
                                        LabelType = (LabelType)Enum.Parse(typeof(LabelType), task.LabelType, true) //?/
                                    };

                                    newproject.Tasks.Add(newTask);

                                }
                            }

                        }
                        projectList.Add(newproject);

                        sb.AppendLine(String.Format(SuccessfullyImportedProject, newproject.Name, newproject.Tasks.Count));
                    }

                }


                context.Projects.AddRange(projectList);

                context.SaveChanges();

                var result = sb.ToString().TrimEnd();

                return result;
            }

        }



        public static string ImportEmployees(TeisterMaskContext context, string jsonString)
        {
            var employeesDto = JsonConvert.DeserializeObject<EmployeesImportDto[]>(jsonString);

            var sb = new StringBuilder();

            var employees = new List<Employee>();

            foreach (var dto in employeesDto)
            {
                if (!IsValid(dto))   //  not a valid employee
                {
                    sb.AppendLine(ErrorMessage); // ErrorMessage
                }

                else
                {
                    var employee = new Employee() // create employee
                    {
                        Username = dto.Username,
                        Email = dto.Email,
                        Phone = dto.Phone
                    };

                    foreach (var task in dto.Tasks.Distinct()) // check each task 
                    {
                        if (!context.Tasks.Any(t => t.Id == task)) // not a valid task ???
                        {
                            sb.AppendLine(ErrorMessage); //ErrorMessage
                        }

                        else
                        {
                            var employeeTask = new EmployeeTask()
                            {
                                TaskId = task,
                                Employee = employee

                            };

                            employee.EmployeesTasks.Add(employeeTask); // add this task to the employee

                        }

                    }

                    employees.Add(employee); // add the employee to the list of valid employees
                    sb.AppendLine(string.Format(SuccessfullyImportedEmployee, dto.Username, employee.EmployeesTasks.Count));

                }
            }

            context.Employees.AddRange(employees);

            context.SaveChanges();

            var result = sb.ToString().TrimEnd();

            return result;
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}