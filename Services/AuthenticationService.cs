using CityOfCapeTownMunicipalServices.DataStructures;
using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.Services
{
    public class AuthenticationService
    {
        // =====================================================
        // REGISTER
        // =====================================================

        public bool Register(
            User user,
            out string message)
        {
            if (user == null)
            {
                message =
                    "User information could not be created.";

                return false;
            }


            if (UserStore.UserExists(
                user.Email))
            {
                message =
                    "An account with this email address already exists.";

                return false;
            }


            bool added =
                UserStore.AddUser(
                    user);


            if (!added)
            {
                message =
                    "Unable to create the account.";

                return false;
            }


            message =
                "Account created successfully.";

            return true;
        }


        // =====================================================
        // SIGN IN
        // =====================================================

        public User SignIn(
            string email,
            string password)
        {
            User user =
                UserStore.GetUserByEmail(
                    email);


            if (user == null)
            {
                return null;
            }


            if (user.Password != password)
            {
                return null;
            }


            return user;
        }
    }
}