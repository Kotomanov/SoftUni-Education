using SIS.HTTP;
using SIS.MvcFramework;

namespace IRunes.App.Controllers
{
    public class UsersController : Controller
    {
        // TODO

        public HttpResponse Login()
        {
            // if already logged in , cannot log in again 

            return this.View();

        }

        public HttpResponse Register()
        {
            // if already logged in , cannot register 

            //return this.Redirect("/Users/Login");

            return this.View();
        }
    }
}
