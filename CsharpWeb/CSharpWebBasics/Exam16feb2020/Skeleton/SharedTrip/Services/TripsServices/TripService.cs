using SharedTrip.Models;
using SharedTrip.ViewModel.TripsViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SharedTrip.Services.TripsServices
{
    public class TripService : ITripService
    {
        private readonly ApplicationDbContext db;

        public TripService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public string CreateTrip(string startPoint, string endPoint, string departureTime, string carImage, int seatsCount, string description)
        {
            Trip trip = new Trip
            {
                StartPoint = startPoint,
                EndPoint = endPoint,
                DepartureTime = departureTime,
                Seats = seatsCount,
                Description = description,
                ImagePath = carImage,

            };

            this.db.Trips.Add(trip);
            this.db.SaveChanges();

            return trip.Id;
        }

        public IEnumerable<TripDetailsViewModel> GetAll()
        => this.db.Trips.Select(x => new TripDetailsViewModel
        {
            StartPoint = x.StartPoint,
            EndPoint = x.EndPoint,
            DepartureTime = x.DepartureTime,
            Seats = x.Seats,
            Description = x.Description,
        }).ToArray();

        public TripDetailsViewModel TripDetails(string tripId)
        {

            var trip = this.db.Trips.Where(t => t.Id == tripId)
                .Select(x => new TripDetailsViewModel
                {
                    StartPoint = x.StartPoint,
                    EndPoint = x.EndPoint,
                    DepartureTime = x.DepartureTime,
                    Seats = x.Seats,
                    Description = x.Description,
                }).FirstOrDefault();

            return trip;
        }

        public bool TripExists(string tripId)
        {
            return this.db.Trips.Any(x => x.Id == tripId);
        }
    }

}
