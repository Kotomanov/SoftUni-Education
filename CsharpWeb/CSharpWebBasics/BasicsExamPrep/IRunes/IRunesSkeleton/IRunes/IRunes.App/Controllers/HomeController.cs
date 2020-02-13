using SIS.HTTP;
using SIS.MvcFramework;

namespace IRunes.App.Controllers
{
    public class HomeController : Controller
    {
        // TODO
        [HttpGet("/")]
        public HttpResponse Index()
        {
            // if user is logged in 

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
