using IRunes.App.Services;
using IRunes.App.ViewModels.Users;
using SIS.HTTP;
using SIS.MvcFramework;

namespace IRunes.App.Controllers
{
    public class UsersController : Controller
    {
        // TODO

        private readonly IUsersService usersService;
        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        public HttpResponse Login()
        {
            // if already logged in , cannot log in again 

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
                return this.Redirect("/");
            }

             return this.Redirect("/Users/Login");
            
        }

        public HttpResponse Register()
        {
            return this.View();
        }

        [HttpPost]
        public HttpResponse Register(RegisterInputModel registerModel)
        {

            if (string.IsNullOrWhiteSpace(registerModel.Email))
            {
                return this.Error("Please enter a valid email.");
            }


            if (registerModel.Username.Length < 4 || registerModel.Username.Length > 10)
            {
                return this.Error("Username needs to be between 4 and 10 characters long.");// error message
            }

            if (registerModel.Password.Length < 6 || registerModel.Password.Length > 20)
            {
                return this.Error("Password needs to be between 6 and 20 characters long.");
            }

            if (registerModel.Password != registerModel.ConfirmPassword)
            {
                return this.Error("Passwords do not match.");
            }

            if (this.usersService.EmailExists(registerModel.Email))
            {
                return Error("This e-mail has been used.");
            }

            if (this.usersService.UsernameExists(registerModel.Username))
            {
                return Error("This user has been registered already.");
            }

            this.usersService.Register(registerModel.Username, registerModel.Email, registerModel.Password);
            return this.Redirect("/Users/Login");
        }

        public HttpResponse Logout()
        {
            this.SignOut();
            return this.Redirect("/");

        }
    }
}
