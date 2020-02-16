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
        // • Guest(not logged in) users can access Index page.
        //•	Guest(not logged in) users can access Login page.
        //•	Guest(not logged in) users can access Register page.
        ////NOTE: If the user is logged in and he tries to go the home page, the application must redirect him to the /Trips/All
        

        private readonly IUserService service; 
        public HomeController(IUserService service)
        {
            this.service = service; 
        }

        [HttpGet("/")]
        public HttpResponse IndexFullPage()
        {
            return this.Index();
        }

        [HttpGet("/Home/Index")]
        public HttpResponse Index()
        {
            //NOTE: If the user is logged in and he tries to go the home page, the application must redirect him to the /Trips/All
           
            if (this.IsUserLoggedIn()) //??
            {
                //var viewModel = this.service.GetAll();
                //viewModel.Username = this.service.GetAll(this.User);
                return this.View();//viewModel,"Index"
            }

            return this.View();
        }
    }
}