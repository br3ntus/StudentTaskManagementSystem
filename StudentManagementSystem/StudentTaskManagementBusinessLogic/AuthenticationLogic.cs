using System;
using System.Collections.Generic;
using System.Text;
using StudentTaskManagementData;

namespace StudentTaskManagementBusinessLogic
{
    public class AuthenticationLogic
    {
        public bool IsLoginValid(string username, string password)
        {
            UserDataService dataService = new UserDataService();
            List<User> users = dataService.GetAllUsers();

            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
