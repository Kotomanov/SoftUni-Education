using SharedTrip.Services.TripsServices;
using SharedTrip.ViewModel.TripsViewModels;
using SIS.HTTP;
using SIS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedTrip.Controllers
{
    public class TripController : Controller
    {
        //Datetime to string !!!!!! 
        // ToString("dd.MM.yyyy HH:mm")???


        private readonly ITripService service;
        public TripController(ITripService service)
        {
            this.service = service;

        }

        public HttpResponse Add()
        {
            if (!this.IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Add(TripAddInputModel inputModel)
        {
            if (!this.IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");

            }

            if (string.IsNullOrWhiteSpace(inputModel.StartPoint))
            {
                return this.Error("Please provide a startpoint");
            }

            if (string.IsNullOrWhiteSpace(inputModel.EndPoint))
            {
                return this.Error("Please provide a endpoint");
            }

            if (string.IsNullOrWhiteSpace(inputModel.DepartureTime))
            {
                return this.Error("Please provide departuretime");
            }

            if (inputModel.Seats < 2 || inputModel.Seats > 6)
            {
                return this.Error("Seatscount need to be between 2 and 6.");
            }

            if (string.IsNullOrWhiteSpace(inputModel.Description))
            {
                return this.Error("Please provide a description");
            }

            if (inputModel.Description.Length > 80)
            {
                return this.Error("Description needs to be less than 80 characters");
            }

            this.service.CreateTrip(inputModel.StartPoint, inputModel.EndPoint, inputModel.DepartureTime, inputModel.ImagePath, inputModel.Seats, inputModel.Description);

            return this.Redirect($"/Trips/Details?tripId={inputModel} ");

        }

        public HttpResponse All()
        {
            if (!this.IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            //var viewModel = new AllTripViewModel
            //{

            //    var tripsView = new AllTripViewModel
            //    { 
            //     this.service.GetAll(x => new AllTripViewModel
            //    {
            //         StartPoint = x.StartPoint,
            //         EndPoint = x.EndPoint,
            //         DepartureTime = x.DepartureTime,
            //         Seats = x.Seats,
            //         Details = x.Details,

            //    }),

            //    }

            //};

            return this.View();

        }

        public HttpResponse Details(string id)
        {
            if (!this.IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var trip = this.service.TripDetails(id);

            return this.View(trip);

        }


    }
}
