namespace SharedTrip.App.Controllers
{
    using SharedTrip.Services.TripsServices;
    using SharedTrip.Services.UserServices;
    using SharedTrip.ViewModel.HomePage;
    using SIS.HTTP;
    using SIS.MvcFramework;

    public class HomeController : Controller
    {
        //Guests can Register, Login and view the Index Page. 
        //Users can Add Trips and see Added Trips on the Home Page. From the Home Page they can also view Info about each one of those Trips and Join in a Trip.
        //NOTE: If the user is logged in and he tries to go the home page, the application must redirect him to the /Trips/All


        // private readonly IUserService service; 
        //public HomeController(IUserService service)
        //{
        //    this.service = service; 
        //}

        [HttpGet("/")]
        public HttpResponse IndexFullPage()
        {
            return this.Index();
        }

        [HttpGet("/Home/Index")]
        public HttpResponse Index()
        {
            return this.View();
        }
    }
}