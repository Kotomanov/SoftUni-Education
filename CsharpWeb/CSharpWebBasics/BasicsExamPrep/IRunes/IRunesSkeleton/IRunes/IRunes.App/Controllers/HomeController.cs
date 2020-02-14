using IRunes.App.Services;
using IRunes.App.ViewModels.Home;
using SIS.HTTP;
using SIS.MvcFramework;

namespace IRunes.App.Controllers
{
    public class HomeController : Controller
    {
        // TODO
        private readonly IUsersService userservice; 
        public HomeController(IUsersService userservice)
        {
            this.userservice = userservice; 
        }
        [HttpGet("/")]
        public HttpResponse Index()
        {
            // if user is logged in 
            if (this.IsUserLoggedIn())
            {
                var viewModel = new IndexViewModel();
                viewModel.Username = this.userservice.GetUsername(this.User); 
                return this.View(viewModel, "Home");
            }

            return this.View();

            // if not logged in 

            //return this.Redirect("/Users/Login");

        }

        [HttpGet("/Home/Index")]
        public HttpResponse IndexFullPage()
        {
            // if user is logged in 

            return this.Index();

            // if not logged in 

            //return this.Redirect("/Users/Login");

        }

    }
}
