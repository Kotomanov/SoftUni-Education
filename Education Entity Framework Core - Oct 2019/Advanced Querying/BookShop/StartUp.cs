namespace BookShop
{
    using BookShop.Models;
    using Data;
    using System;
    using System.Linq;
    using System.Text;
    using Z.EntityFramework.Plus;

    public class StartUp
    {
        static StringBuilder sb;
        public static void Main()
        {
            using (var db = new BookShopContext())
            {
                // DbInitializer.ResetDatabase(db);

                //string input = Console.ReadLine();

                //int year = int.Parse(Console.ReadLine());

                //int bookLength = int.Parse(Console.ReadLine());

                // var result = IncreasePrices(db);

                // Console.WriteLine(result);

                //IncreasePrices(db);

                Console.WriteLine(RemoveBooks(db)); 
            }
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            sb = new StringBuilder();

            var books = context.Books
                .Where(b => b.AgeRestriction
                             .ToString()
                             .ToLower() == command.ToLower())
                .Select(b => new
                {
                    b.Title
                })
                .OrderBy(b => b.Title)
                .ToList();

            foreach (var book in books)
            {
                //Console.WriteLine($"{book.Title}");

                sb.AppendLine($"{book.Title}");
            }

            return sb.ToString().TrimEnd();
        }


        public static string GetGoldenBooks(BookShopContext context)
        {
            sb = new StringBuilder();

            var books = context.Books
                                .Where(b => b.EditionType.ToString() == "Gold" && b.Copies < 5000)
                                .OrderBy(b => b.BookId)
                                .Select(b => new
                                {
                                    b.Title
                                })
                                 .ToList();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            sb = new StringBuilder();

            var books = context.Books
                                .Where(b => b.Price > 40)
                                .Select(b => new
                                {
                                    b.Title,
                                    b.Price

                                })
                .OrderByDescending(b => b.Price)
                .ToList();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            sb = new StringBuilder();

            var books = context.Books
                               .Where(b => b.ReleaseDate.Value.Year != year)
                               .OrderBy(b => b.BookId)
                               .Select(b => new
                               {
                                   b.Title

                               });

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(c => c.ToLower())
                      .ToArray();

            var booksList = context.Books
                .Where(b => b.BookCategories
                             .Select(bc => new { bc.Category.Name })
                             .Any(bc => categories.Contains(bc.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();


            return String.Join(Environment.NewLine, booksList);
        }


        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            sb = new StringBuilder();

            var convertedInput = DateTime.Parse(date);

            var books = context.Books
                                .OrderByDescending(b => b.ReleaseDate)
                                .Where(b => b.ReleaseDate < convertedInput)
                                .Select(b => new
                                {
                                    b.Title,
                                    EditionType = b.EditionType.ToString(),
                                    b.Price
                                })
                                .ToList();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }


        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            sb = new StringBuilder();

            var authors = context.Authors
                                 .Where(a => a.FirstName.EndsWith(input))
                                 .Select(a => new
                                 {
                                     FullName = a.FirstName + " " + a.LastName
                                 })
                                 .OrderBy(a => a.FullName)
                                 .ToList();


            foreach (var author in authors)
            {
                sb.AppendLine($"{author.FullName}");
            }

            return sb.ToString().TrimEnd();

        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            sb = new StringBuilder();

            var books = context.Books
                                .Where(b => b.Title
                                             .ToLower()
                                             .Contains(input.ToLower()))
                                .Select(b => new
                                {
                                    b.Title
                                })
                                .OrderBy(b => b.Title)
                                .ToList();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {


            var booksAuthors = context.Books
                                       .Where(b => b.Author
                                                  .LastName
                                                  .ToLower()
                                                  .StartsWith(input.ToLower()))
                                       .OrderBy(b => b.BookId)
                                       .Select(b => new
                                       {
                                           b.Title,
                                           b.Author
                                       })
                                       .ToList();

            foreach (var book in booksAuthors)
            {
                sb.AppendLine($"{book.Title} ({book.Author.FirstName} {book.Author.LastName})");
            }

            return sb.ToString().TrimEnd();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var books = context.Books
                               .Where(b => b.Title.Length > lengthCheck)
                               .Select(b => new
                               {
                                   b.BookId
                               })
                               .ToList();

            return books.Count();
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            sb = new StringBuilder();

            var authors = context.Authors
                               .Select(a => new
                               {
                                   FullName = a.FirstName + " " + a.LastName,
                                   BookCopies = a.Books.Sum(b => b.Copies)
                               })
                               .OrderByDescending(a => a.BookCopies)
                               .ToList();

            foreach (var book in authors)
            {
                sb.AppendLine($"{book.FullName} - {book.BookCopies}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            sb = new StringBuilder();

            var categoriesTotal = context.Categories
                                         .Select(c => new
                                         {
                                             CategoryName = c.Name,
                                             Amount = c.CategoryBooks.Select(cb => new
                                             {
                                                 BookSum = cb.Book.Copies * cb.Book.Price
                                             }).ToList()
                                         })
                                         .OrderByDescending(cb => cb.Amount.Sum(s => s.BookSum))
                                         .ThenBy(c => c.CategoryName)
                                         .ToList();


            foreach (var category in categoriesTotal)
            {
                sb.AppendLine($"{category.CategoryName} ${category.Amount.Sum(c => c.BookSum):f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            sb = new StringBuilder();

            var books = context.Categories
                               .Select(c => new
                               {
                                   CategoryName = c.Name,
                                   BookList = c.CategoryBooks
                                              .OrderByDescending(cb => cb.Book.ReleaseDate)
                                              .Take(3)
                                              .Select(cb => new
                                              {
                                                  BookTitle = cb.Book.Title,
                                                  BookYear = cb.Book.ReleaseDate.Value.Year
                                              })
                                              .ToList()
                               })
                               .OrderBy(c => c.CategoryName)
                               .ToList();


            foreach (var category in books)
            {
                sb.AppendLine($"--{category.CategoryName}");

                foreach (var book in category.BookList)
                {
                    sb.AppendLine($"{book.BookTitle} ({book.BookYear})");
                }
            }

            return sb.ToString().TrimEnd();
        }


        public static void IncreasePrices(BookShopContext context)
        {
            context.Books
                        .Where(book => book.ReleaseDate.Value.Year < 2010)
                        .Update(b => new Book() { Price = b.Price + 5 });
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var booksToDelete = context.Books
                                       .Where(b => b.Copies < 4200)
                                       .ToList(); 

            context.Books
                .Where(b => b.Copies < 4200)
                .Delete();

            return booksToDelete.Count();
        }

    }
}
