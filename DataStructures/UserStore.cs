using System;
using System.Collections.Generic;
using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.DataStructures
{
    public static class UserStore
    {
        private static readonly Dictionary<string, User> users =
            new Dictionary<string, User>(
                StringComparer.OrdinalIgnoreCase);

        public static bool AddUser(User user)
        {
            if (user == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.Email))
            {
                return false;
            }

            string email =
                user.Email.Trim();

            if (users.ContainsKey(email))
            {
                return false;
            }

            users.Add(email, user);

            return true;
        }

        public static User GetUserByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return null;
            }

            User user;

            users.TryGetValue(
                email.Trim(),
                out user);

            return user;
        }

        public static bool UserExists(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            return users.ContainsKey(
                email.Trim());
        }

        public static int Count
        {
            get
            {
                return users.Count;
            }
        }

        public static IEnumerable<User> GetAllUsers()
        {
            return users.Values;
        }
    }
}