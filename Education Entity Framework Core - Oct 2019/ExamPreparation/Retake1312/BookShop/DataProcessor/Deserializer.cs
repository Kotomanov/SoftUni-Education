namespace BookShop.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using BookShop.Data.Models;
    using BookShop.Data.Models.Enums;
    using BookShop.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedBook
            = "Successfully imported book {0} for {1:F2}.";

        private const string SuccessfullyImportedAuthor
            = "Successfully imported author - {0} with {1} books.";

        public static string ImportBooks(BookShopContext context, string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(BookImportDto[]),
                                new XmlRootAttribute("Books"));


            using (var reader = new StringReader(xmlString))
            {

                BookImportDto[] bookDtos = (BookImportDto[])xmlSerializer.Deserialize(reader);

                StringBuilder sb = new StringBuilder();

                // list 
                List<Book> books = new List<Book>();

                // foreach ... 

                // is valid ... sb message

                foreach (var b in bookDtos)
                {
                    if (IsValid(b))
                    {
                        // check date ????!!!!!

                        var testGenre = (Genre)b.Genre;  // test the genre 
                        var testdate = DateTime.ParseExact(b.PublishedOn, "MM/dd/yyyy", CultureInfo.InvariantCulture);

                        if (b.Pages < 50 || b.Pages > 5000)
                        {
                            sb.AppendLine(ErrorMessage);
                        }

                        else if (!IsValid(testdate)) //??
                        {
                            sb.AppendLine(ErrorMessage);
                        }

                        else if (b.Genre == 1 || b.Genre == 2 || b.Genre == 3) // valid
                        {
                            Book newBook = new Book()
                            {
                                Name = b.Name,
                                Genre = (Genre)b.Genre,
                                Price = b.Price,
                                Pages = b.Pages,
                                PublishedOn = DateTime.ParseExact
                            (b.PublishedOn, "MM/dd/yyyy", CultureInfo.InvariantCulture) //??

                            };

                            books.Add(newBook);

                            sb.AppendLine(String.Format(SuccessfullyImportedBook, newBook.Name, newBook.Price));
                        }

                        else if (b.Genre != 1 && b.Genre != 2 && b.Genre != 3)
                        {
                            sb.AppendLine(ErrorMessage);
                        }


                    }

                    else
                    {
                        sb.AppendLine(ErrorMessage);
                    }
                }

                context.Books.AddRange(books);

                context.SaveChanges();

                var result = sb.ToString().TrimEnd();

                return result;

            }



        }

        public static string ImportAuthors(BookShopContext context, string jsonString)
        {

            var authorsDto = JsonConvert.DeserializeObject<ImportAuthorstDto[]>(jsonString);

            var sb = new StringBuilder();

            List<Author> authorsList = new List<Author>();

            // list of booknumbers
            List<Book> bookList = new List<Book>();

            foreach (var a in authorsDto)
            {
                if (a.Books == null)
                {
                    continue;
                }

                if (IsValid(a)) // valid checks 
                {
                    var mailToCheck = a.Email; // get the mail 

                    if (context.Authors.Any(b => b.Email == mailToCheck))
                    //	If an email exists, do not import the author 
                    {
                        sb.AppendLine(ErrorMessage);
                    }

                    else
                    {
                        Author newAuthor = new Author()
                        {
                            FirstName = a.FirstName,
                            LastName = a.LastName,
                            Phone = a.Phone,
                            Email = a.Email,

                        };

                        foreach (var b in a.Books) // b is DTO
                        {
                            if (b.Id == null)
                            {
                                continue;
                            }

                            var bookId = int.Parse(b.Id);

                            if (context.Books.Any(e=>e.Id == bookId)) // DB has such book 
                            {
                                var book = context.Books.Where(g => g.Id == bookId).First(); // take the book

                                bookList.Add(book); ///????

                                context.Authors.Add(newAuthor);

                                AuthorBook newEntry = new AuthorBook() 
                                { BookId = book.Id,
                                AuthorId = newAuthor.Id
                                };

                                newAuthor.AuthorsBooks.Add(newEntry);

                            }

                            //var fullname = newAuthor.FirstName + " " + newAuthor.LastName;
                            //sb.AppendLine(string.Format(SuccessfullyImportedAuthor, fullname, newAuthor.AuthorsBooks.Count));
                            // feed the newAuthor with the book
                        }

                        if (bookList.Count < 1) // booksList.count>0
                        {
                            sb.AppendLine(ErrorMessage);
                            continue;

                        }

                        var fullname = newAuthor.FirstName + " " + newAuthor.LastName;
                        sb.AppendLine(string.Format(SuccessfullyImportedAuthor, fullname, newAuthor.AuthorsBooks.Count));

                        

                    }

                }

                else //invalid first name, last name, email or phone
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

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