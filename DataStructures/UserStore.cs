using System;
using System.Collections.Generic;
using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.DataStructures
{
    public static class UserStore
    {
        private static readonly Dictionary<string, User> users =
            new Dictionary<string, User>(StringComparer.OrdinalIgnoreCase);

        static UserStore()
        {
            // DEMO ONLY. Replace with secure configuration and hashed passwords before deployment.
            AddUserInternal(new User
            {
                FirstName = "System",
                LastName = "Administrator",
                Email = "admin@municipal-demo.local",
                Password = "DemoAdmin#2026!",
                City = "Cape Town",
                Role = UserRole.Admin
            });
        }

        private static bool AddUserInternal(User user)
        {
            if (user == null || string.IsNullOrWhiteSpace(user.Email)) return false;
            string email = user.Email.Trim();
            if (users.ContainsKey(email)) return false;
            user.Email = email;
            users.Add(email, user);
            return true;
        }

        // Public registration can ONLY create citizen accounts.
        public static bool AddUser(User user)
        {
            if (user == null) return false;
            user.Role = UserRole.Citizen;
            return AddUserInternal(user);
        }

        // Only the admin service should call this after checking the current session.
        internal static bool AddAdministrator(User user)
        {
            if (user == null) return false;
            user.Role = UserRole.Admin;
            return AddUserInternal(user);
        }

        public static User GetUserByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return null;
            User user;
            users.TryGetValue(email.Trim(), out user);
            return user;
        }

        public static bool UserExists(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && users.ContainsKey(email.Trim());
        }

        public static int Count { get { return users.Count; } }
        public static IEnumerable<User> GetAllUsers() { return users.Values; }
    }
}
