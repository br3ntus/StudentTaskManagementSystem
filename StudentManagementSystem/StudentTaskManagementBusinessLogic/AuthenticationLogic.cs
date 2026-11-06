using System;
using System.Collections.Generic;
using System.Text;
using StudentTaskManagementData;

namespace StudentTaskManagementBusinessLogic
{
    public class AuthenticationLogic
    {
        private readonly UserDataService _dataService = new UserDataService();

        public bool IsLoginValid(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
                return false;

            string target = username.Trim();

            foreach (User user in _dataService.GetAllUsers())
            {
                if (string.Equals(user.Username, target, StringComparison.OrdinalIgnoreCase)
                    && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Register(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
                return false;

            if (_dataService.IsUsernameTaken(username))
                return false;

            return _dataService.AddUser(new User
            {
                Username = username,
                Password = password
            });
        }
    }
}