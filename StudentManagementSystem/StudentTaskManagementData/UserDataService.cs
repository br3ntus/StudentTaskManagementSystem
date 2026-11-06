    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.Json;

namespace StudentTaskManagementData
{
    public class UserDataService
    {
        private List<User> _users = new List<User>();
        private readonly string _jsonFileName;

        public UserDataService()
        {
            _jsonFileName = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "users.json");

            LoadUsers();
        }

        private void LoadUsers()
        {
            string text = File.ReadAllText(_jsonFileName);

            _users = JsonSerializer.Deserialize<List<User>>(
                text,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                ?? new List<User>();
        }

        private void SaveUsers()
        {
            string text = JsonSerializer.Serialize(
                _users,
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(_jsonFileName, text);
        }

        public bool IsUsernameTaken(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            string target = username.Trim();

            return _users.Any(u =>
                string.Equals(u.Username, target, StringComparison.OrdinalIgnoreCase));
        }

        public bool AddUser(User user)
        {
            if (user == null
                || string.IsNullOrWhiteSpace(user.Username)
                || string.IsNullOrWhiteSpace(user.Password))
                return false;

            if (IsUsernameTaken(user.Username))
                return false;

            _users.Add(new User
            {
                Username = user.Username.Trim(),
                Password = user.Password
            });

            SaveUsers();
            return true;
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }
    }
}