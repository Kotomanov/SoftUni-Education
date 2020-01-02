namespace Cinema.DataProcessor
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Cinema.DataProcessor.ExportDto;
    using Data;
    using Newtonsoft.Json;

    public class Serializer
    {
        public static string ExportTopMovies(CinemaContext context, int rating)
        {
            var movies = context
                         .Movies
                         .Where(m => m.Rating >= rating && m.Projections.Any(p => p.Tickets.Count > 0))
                         .OrderByDescending(m => m.Rating)
                         .ThenByDescending(m => m.Projections
                                             .Sum(p => p.Tickets
                                                         .Sum(t => t.Price)))
                         .Select(m => new MovieExportDto
                         {
                             MovieName = m.Title,
                             Rating = m.Rating.ToString("F2"),
                             TotalIncomes = m.Projections
                                             .Sum(p => p.Tickets
                                                         .Sum(t => t.Price)).ToString("F2"), // format F2??
                             Customers = m.Projections.SelectMany(p => p.Tickets)
                                                                 .Select(t => new CustomersExportDto
                                                                 {
                                                                     FirstName = t.Customer.FirstName,
                                                                     LastName = t.Customer.LastName,
                                                                     Balance = t.Customer.Balance.ToString("F2")

                                                                 }).OrderByDescending(c => c.Balance)
                                                                 .ThenBy(c => c.FirstName)
                                                                 .ThenBy(c => c.LastName)
                                                                  .ToArray()
                         })
                         .Take(10)  
                         .ToArray();


            return JsonConvert.SerializeObject(movies, Formatting.Indented);
        }

        public static string ExportTopCustomers(CinemaContext context, int age)
        {
            StringBuilder sb = new StringBuilder();


            var customers = context
                           .Customers
                           .Where(c => c.Age >= age)
                           .OrderByDescending(c=>c.Tickets.Sum(t => t.Price))
                           .Select(c => new CustomerTicketsExport 
                                                              {
                                                               FirstName = c.FirstName, 
                                                               LastName = c.LastName,
                                                               SpentMoney = c.Tickets.Sum(t=>t.Price).ToString("f2"),
                                                               SpentTime = TimeSpan.FromMilliseconds(c.Tickets.Sum(t => t.Projection.Movie.Duration.TotalMilliseconds)).ToString(@"hh\:mm\:ss")



                           })
                           .Take(10)
                           .ToArray();



            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CustomerTicketsExport[]),
                                          new XmlRootAttribute("Customers"));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            using (StringWriter writer = new StringWriter(sb))
            {
                xmlSerializer.Serialize(writer, customers, namespaces);
            }

            return sb.ToString().TrimEnd();
        }
    }
}