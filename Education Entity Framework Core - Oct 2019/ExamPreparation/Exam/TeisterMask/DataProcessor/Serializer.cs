namespace TeisterMask.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using TeisterMask.DataProcessor.ExportDto;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportProjectWithTheirTasks(TeisterMaskContext context)
        {
            StringBuilder sb = new StringBuilder();

            var projects = context.Projects
                                  .Where(p => p.Tasks.Count>0)
                                  .Select(p => new ProjectAndTaskExportDto
                                  {
                                      TasksCount = p.Tasks.Count,
                                      ProjectName = p.Name,
                                      HasEndDate = p.DueDate != null ? "Yes" : "No", 
                                      TasksList = p.Tasks.Select(t => new TaskExportDto
                                      {
                                          TaskName = t.Name,
                                          TaskLabel = t.LabelType.ToString()  

                                      })
                                      .OrderBy(t => t.TaskName)
                                     .ToArray()

                                  })
                                  .OrderByDescending(p => p.TasksCount)
                                  .ThenBy(p => p.ProjectName)
                                  .ToArray();


            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProjectAndTaskExportDto[]),
                                          new XmlRootAttribute("Projects"));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            using (StringWriter writer = new StringWriter(sb))
            {
                xmlSerializer.Serialize(writer, projects, namespaces);
            }

            return sb.ToString().TrimEnd();


        }

        public static string ExportMostBusiestEmployees(TeisterMaskContext context, DateTime date)
        {
        

            var employees = context.Employees
                    .Where(e => e.EmployeesTasks.Any(et => et.Task.OpenDate >= date))
                    .OrderByDescending(e => e.EmployeesTasks.Count(et => et.Task.OpenDate >= date))
                    .ThenBy(e => e.Username)
                    .Select(e => new EmployeeTaskDto
                    {
                        Username = e.Username,
                        Tasks = e.EmployeesTasks
                                  .Where(t=>t.Task.OpenDate>=date)
                                  .Select(t => new TaskEmployeeDto
                        {
                            TaskName = t.Task.Name,
                            OpenDate = t.Task.OpenDate.ToString("d", CultureInfo.InvariantCulture), //MM/dd/yyyy
                            DueDate = t.Task.DueDate.ToString("d", CultureInfo.InvariantCulture), //MM/dd/yyyy
                            LabelType = t.Task.LabelType.ToString(),
                            ExecutionType = t.Task.ExecutionType.ToString()
                        }
                         )
                        .OrderByDescending(t => DateTime.ParseExact(t.DueDate, "MM/dd/yyyy", CultureInfo.InvariantCulture))
                        .ThenBy(t => t.TaskName)
                        .ToList()
                    })
                    .Take(10)
                    .ToList();



            return JsonConvert.SerializeObject(employees, Formatting.Indented);
        }
    }
}