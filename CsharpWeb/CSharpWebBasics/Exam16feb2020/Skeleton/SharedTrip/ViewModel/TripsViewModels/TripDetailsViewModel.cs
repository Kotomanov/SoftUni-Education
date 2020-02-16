using System;

namespace SharedTrip.ViewModel.TripsViewModels
{
    public class TripDetailsViewModel
    {
        ///Trips/Details?tripId={tripId} (logged-in user) 
        
        public string ImagePath { get; set; }

        public string StartPoint { get; set; }

        public string EndPoint { get; set; }
        
        public string DepartureTime { get; set; }
         
        public int Seats { get; set; }
         
        public string Description { get; set; }

       
    }
}
