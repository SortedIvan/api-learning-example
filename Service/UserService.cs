using System;
using System.Collections.Generic;
using api_learning_project.Model;

namespace api_learning_project.Service
{
    public class UserService : IUserService
    {
        private List<User> users;
        private int idCounter = 0;

        public UserService()
        {
            users = new List<User>();
        }

        public bool CreateAccount(string username, string password, string email)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                return false; 
            }

            if (users.Exists(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                return false;  
            }

            User newUser = new User(idCounter++, username, password, email);
            users.Add(newUser);

            return true; 
        }
        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}