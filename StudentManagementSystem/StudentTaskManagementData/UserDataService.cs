using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace StudentTaskManagementData
{
    public class UserDataService
    {
        private string _fileName = $"{AppDomain.CurrentDomain.BaseDirectory}/users.json";

        public List<User> GetAllUsers()
        {
            string text = File.ReadAllText(_fileName);
            return JsonSerializer.Deserialize<List<User>>(text,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                ?? new List<User>();
        }
    }
}
