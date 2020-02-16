using System;
using System.Collections.Generic;
using System.Text;

namespace SharedTrip.ViewModel.UsersViewModels
{
    public class UserRegisterInputModel
    {

        public string Username { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
