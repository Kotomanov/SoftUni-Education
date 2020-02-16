using SharedTrip.Models;
using SharedTrip.ViewModel.TripsViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedTrip.Services.TripsServices
{
    public interface ITripService
    {
        
        string CreateTrip(string startPoint, string endPoint, string departureTime, string carImage, int seatsCount, string description);

        TripDetailsViewModel TripDetails(string tripId);

        bool TripExists(string tripId);

        IEnumerable<TripDetailsViewModel> GetAll();

    }
}
