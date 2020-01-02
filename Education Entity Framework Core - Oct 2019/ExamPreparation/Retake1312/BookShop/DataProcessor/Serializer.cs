namespace BookShop.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using BookShop.DataProcessor.ExportDto;
    using Data;
    using Newtonsoft.Json;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportMostCraziestAuthors(BookShopContext context)
        {
            var authors = context
                         .Authors
                         .Select(a => new ExportAuthorsDto
                         {
                             AuthorName = a.FirstName + " " + a.LastName,
                             Books = a.AuthorsBooks.Select(ab => new BooksExportDto
                             {
                                 BookName = ab.Book.Name,
                                 BookPrice = ab.Book.Price.ToString("F2")

                             })
                             .OrderByDescending(ab => ab.BookPrice)
                             .ToList()

                         }).ToList()
                         .OrderByDescending(a => a.Books.Count)
                         .ThenBy(a => a.AuthorName)
                         .ToList(); // or List??


            return JsonConvert.SerializeObject(authors, Formatting.Indented);
        }

        public static string ExportOldestBooks(BookShopContext context, DateTime date)
        {


            var books = context
                .Books
                .Where(b => b.PublishedOn < date && b.Genre.ToString() == "Science")
                .Take(10)
                .Select(b => new OldestBooksExport
                {
                    Pages = b.Pages,
                    Name = b.Name,
                    Date = b.PublishedOn.ToString("d", CultureInfo.InvariantCulture)

                })
                .ToArray()
                .OrderByDescending(b => b.Pages)
                .ThenBy(b => b.Date)
                .ToArray();

            var xmlSerializer = new XmlSerializer(typeof(OldestBooksExport[]),
                                          new XmlRootAttribute("Books"));

            StringBuilder sb = new StringBuilder();

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            using (StringWriter writer = new StringWriter(sb))
            {
                xmlSerializer.Serialize(writer, books, namespaces);
            }

            return sb.ToString().TrimEnd();
        }
    }
}