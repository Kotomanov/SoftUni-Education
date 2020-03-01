using Andreys.Services.Users;
using Andreys.ViewModels.Users;
using SIS.HTTP;
using SIS.MvcFramework;

namespace Andreys.Controllers
{
    public  class UsersController : Controller
    {
        private readonly IUsersService usersService;
        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        public HttpResponse Login()
        {
            // if already logged in , cannot log in again 

            if (IsUserLoggedIn())
            {
                return this.Redirect("/"); //or /Home
            }

            return this.View();

        }

        [HttpPost]
        public HttpResponse Login(LoginInputModel inputModel)
        {
            var userId
                = this.usersService
                       .GetUserId(inputModel.Username,
                                  inputModel.Password);

            if (userId != null)
            {
                this.SignIn(userId);
                return this.Redirect("/"); // Home
            }

            return this.Redirect("/Users/Login");

        }

        public HttpResponse Register()
        {
            if (!IsUserLoggedIn())
            {
                return this.View();
            }
            

            return this.Redirect("/");
        }

        [HttpPost]
        public HttpResponse Register(RegisterInputModel registerModel)
        {

            if (string.IsNullOrWhiteSpace(registerModel.Email))
            {
                return this.Redirect("/Users/Register");
            }


            if (registerModel.Username.Length < 4 || registerModel.Username.Length > 10)
            {
                return this.Redirect("/Users/Register");
            }

            if (registerModel.Password.Length < 6 || registerModel.Password.Length > 20)
            {
                return this.Redirect("/Users/Register");
            }

            if (registerModel.Password != registerModel.ConfirmPassword)
            {
                return this.Redirect("/Users/Register");
            }

            if (this.usersService.EmailExists(registerModel.Email))
            {
                return this.Redirect("/Users/Register");
            }

            if (this.usersService.UsernameExists(registerModel.Username))
            {
                return this.Redirect("/Users/Register");
            }

            this.usersService.Register(registerModel.Username, registerModel.Email, registerModel.Password);
            return this.Redirect("/Users/Login");
        }

        public HttpResponse Logout()
        {
            if (!IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            this.SignOut();
            return this.Redirect("/");

        }
    }
}
