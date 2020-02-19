using SharedTrip.Services.UserServices;
using SharedTrip.ViewModel.UsersViewModels;
using SIS.HTTP;
using SIS.MvcFramework;

namespace SharedTrip.Controllers
{
    public class UserController : Controller
    {
        
        //Users can Add Trips and see Added Trips on the Home Page. From the Home Page they can also view Info about each one of those Trips and Join in a Trip.
        // match both passwords 
        private readonly IUserService usersService;

        public UserController(IUserService usersService)
        {
            this.usersService = usersService;
        }

        public HttpResponse Login()
        {
            if (this.IsUserLoggedIn())
            {
                //If the user is logged in and he tries to go to the home page, the application must redirect him to the / Trips / All
                return this.Redirect("Trips/All");  
            }
            return this.View();
        }

        [HttpPost]
        public HttpResponse Login(UserLoginInputModel input)
        {
            var userId = this.usersService.GetUserId(input.Username, input.Password);

            if (userId != null)
            {
                this.SignIn(userId);
                return this.Redirect("/Trips/All");
            }

            return this.Redirect("/Users/Login");
        }


        public HttpResponse Register()
        {
            if (this.IsUserLoggedIn())
            {
                return this.Redirect("/"); 
            }

            return this.View();
        }


        [HttpPost]
        public HttpResponse Register(UserRegisterInputModel input)
        {
            if (string.IsNullOrWhiteSpace(input.EmailAddress))
            {
                return this.Error("Email cannot be empty!");
            }

            if (input.Password.Length < 6 || input.Password.Length > 20)
            {
                return this.Error("Password must be between  6 and  20 characters long.");
            }


            if (input.Username.Length < 5 || input.Username.Length > 20)
            {
                return this.Error("Username must be between  5 and  20 characters long.");
            }


            if (input.Password != input.ConfirmPassword)
            {
                return this.Error("Passwords should match.");
            }



            if (this.usersService.EmailExists(input.EmailAddress))
            {
                return this.Error("Email already in use.");
            }


            if (this.usersService.UsernameExists(input.Username))
            {
                return this.Error("Username already in use.");
            }

            this.usersService.Register(input.Username, input.EmailAddress, input.Password);

            return this.Redirect("/Users/Login");

        }

        public HttpResponse Logout()
        {
            if (!this.IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            this.SignOut();

            return this.Redirect("/");
        }

    }
}
