using CityOfCapeTownMunicipalServices.DataStructures;
using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.Services
{
    public class AuthenticationService
    {
        public bool Register(User user, out string message)
        {
            if (user == null || string.IsNullOrWhiteSpace(user.Email) ||
                string.IsNullOrWhiteSpace(user.Password))
            {
                message = "User information is incomplete.";
                return false;
            }

            if (UserStore.UserExists(user.Email))
            {
                message = "An account with this email address already exists.";
                return false;
            }

            user.Role = UserRole.Citizen;
            if (!UserStore.AddUser(user))
            {
                message = "Unable to create the account.";
                return false;
            }

            message = "Citizen account created successfully.";
            return true;
        }

        public User SignIn(string email, string password)
        {
            User user = UserStore.GetUserByEmail(email);
            if (user == null || user.Password != password) return null;
            return user;
        }
    }
}
