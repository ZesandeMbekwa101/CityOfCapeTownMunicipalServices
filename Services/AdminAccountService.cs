using CityOfCapeTownMunicipalServices.DataStructures;
using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.Services
{
    public class AdminAccountService
    {
        public bool RegisterAdmin(User newAdmin, out string message)
        {
            if (UserSession.CurrentUser == null ||
                UserSession.CurrentUser.Role != UserRole.Admin)
            {
                message = "Access denied. Administrator sign-in is required.";
                return false;
            }
            if (newAdmin == null || string.IsNullOrWhiteSpace(newAdmin.Email) ||
                string.IsNullOrWhiteSpace(newAdmin.Password))
            {
                message = "Please enter an email and password.";
                return false;
            }
            if (UserStore.UserExists(newAdmin.Email))
            {
                message = "This email is already registered.";
                return false;
            }
            bool added = UserStore.AddAdministrator(newAdmin);
            message = added ? "Administrator created." : "Unable to create administrator.";
            return added;
        }
    }
}
