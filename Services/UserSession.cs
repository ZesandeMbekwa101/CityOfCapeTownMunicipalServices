using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.Services
{
    public static class UserSession
    {
        public static User CurrentUser
        {
            get;
            private set;
        }


        public static bool IsLoggedIn
        {
            get
            {
                return CurrentUser != null;
            }
        }


        public static void StartSession(
            User user)
        {
            CurrentUser =
                user;
        }


        public static void EndSession()
        {
            CurrentUser =
                null;
        }
    }
}