namespace Cinema.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Cinema.Data.Models;
    using Cinema.Data.Models.Enums;
    using Cinema.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";
        private const string SuccessfulImportMovie
            = "Successfully imported {0} with genre {1} and rating {2}!";
        private const string SuccessfulImportHallSeat
            = "Successfully imported {0}({1}) with {2} seats!";
        private const string SuccessfulImportProjection
            = "Successfully imported projection {0} on {1}!";
        private const string SuccessfulImportCustomerTicket
            = "Successfully imported customer {0} {1} with bought tickets: {2}!";

        public static string ImportMovies(CinemaContext context, string jsonString)
        {

            var moviesDto = JsonConvert.DeserializeObject<MoviesImportDto[]>(jsonString);

            var sb = new StringBuilder();

            var moviesList = new List<Movie>();

            foreach (var m in moviesDto)
            {
                if (!IsValid(m))
                {
                    sb.AppendLine(ErrorMessage);
                }

                else
                {
                    if (context.Movies.Any(f => f.Title == m.Title))
                    {
                        sb.AppendLine(ErrorMessage);
                    }

                    else
                    {
                        Movie movie = new Movie()
                        {
                            Title = m.Title,
                            Genre = m.Genre,//(Genre)Enum.Parse(typeof(Genre), m.Genre, true), //?
                            Duration = m.Duration,//TimeSpan.ParseExact(m.Duration, "hh:mm:ss", CultureInfo.InvariantCulture),
                            Rating = m.Rating,
                            Director = m.Director

                        };

                        moviesList.Add(movie);
                        sb.AppendLine(string.Format(SuccessfulImportMovie, movie.Title, movie.Genre, movie.Rating.ToString("F2")));
                    }
                }


            }

            context.Movies.AddRange(moviesList);


            context.SaveChanges();

            var result = sb.ToString().TrimEnd();

            return result;
        }

        public static string ImportHallSeats(CinemaContext context, string jsonString)
        {
            var hallSeatsDto = JsonConvert.DeserializeObject<HallSeatImportDto[]>(jsonString);

            var sb = new StringBuilder();

            var hallList = new List<Hall>();


            foreach (var h in hallSeatsDto)
            {
                if (!IsValid(h))
                {
                    sb.AppendLine(ErrorMessage);
                }

                else
                {
                    Hall newHall = new Hall()
                    {
                        Name = h.Name,
                        Is4Dx = h.Is4Dx,
                        Is3D = h.Is3D,

                    };

                    for (int i = 0; i < h.Seats; i++)
                    {
                        Seat newSeat = new Seat()
                        {
                            HallId = newHall.Id,
                            Hall = newHall
                        };

                        newHall.Seats.Add(newSeat);
                        hallList.Add(newHall);
                    }

                    string projectionType = "Normal";
                    if (h.Is3D && h.Is4Dx)
                    {
                        projectionType = "4Dx/3D";
                    }

                    else if (h.Is3D && !h.Is4Dx)
                    {
                        projectionType = "3D";
                    }

                    else if (!h.Is3D && h.Is4Dx)
                    {
                        projectionType = "4Dx";
                    }

                    sb.AppendLine(String.Format(SuccessfulImportHallSeat, h.Name, projectionType, h.Seats));

                }
            }


            context.Halls.AddRange(hallList);

            context.SaveChanges();

            var result = sb.ToString().TrimEnd();

            return result;
        }

        public static string ImportProjections(CinemaContext context, string xmlString)
        {

            var xmlSerializer = new XmlSerializer(typeof(ProjectionImportDto[]),
                                new XmlRootAttribute("Projections"));

            using (var reader = new StringReader(xmlString))
            {
                ProjectionImportDto[] projectionDtos = (ProjectionImportDto[])xmlSerializer.Deserialize(reader);

                StringBuilder sb = new StringBuilder();


                foreach (var p in projectionDtos)
                {

                    if (context.Movies.Any(m => m.Id == p.MovieId)
                       && context.Halls.Any(h => h.Id == p.HallId))
                    {

                        Projection projection = new Projection()
                        {
                            MovieId = p.MovieId,
                            HallId = p.HallId,
                            DateTime = DateTime.ParseExact(p.DateTime, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)

                        };


                        context.Projections.Add(projection);

                        sb.AppendLine(String.Format(SuccessfulImportProjection, projection.Movie.Title, projection.DateTime.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)));
                    }

                    else// (!IsValid(p))
                    {
                        sb.AppendLine(ErrorMessage);
                    }

                }


                context.SaveChanges();

                var result = sb.ToString().TrimEnd();

                return result;
            }


        }

        public static string ImportCustomerTickets(CinemaContext context, string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(CustomerTicketsImportDto[]),
                                new XmlRootAttribute("Customers"));

            using (var reader = new StringReader(xmlString))
            {
                CustomerTicketsImportDto[] customerTicketsDtos = (CustomerTicketsImportDto[])xmlSerializer.Deserialize(reader);

                StringBuilder sb = new StringBuilder();

                // List<Ticket> ticketList = new List<Ticket>(); 

                foreach (var item in customerTicketsDtos)
                {
                    if (!IsValid(item))
                    {
                        sb.AppendLine(ErrorMessage);
                    }

                    else
                    {
                        Customer customer = new Customer()
                        {
                            FirstName = item.FirstName,
                            LastName = item.LastName,
                            Age = item.Age,
                            Balance = item.Balance,

                        };

                        context.Customers.Add(customer);

                        foreach (var t in item.Tickets)
                        {
                            Ticket ticket = new Ticket()
                            {
                                ProjectionId = t.ProjectionId,
                                Price = t.Price,
                                CustomerId = customer.Id ///???????
                            };

                            customer.Tickets.Add(ticket);
                        }

                        sb.AppendLine(String.Format(SuccessfulImportCustomerTicket, customer.FirstName, customer.LastName, customer.Tickets.Count));
                    }
                }
                

                context.SaveChanges();

                var result = sb.ToString().TrimEnd();

                return result;

            }
        }



        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}

