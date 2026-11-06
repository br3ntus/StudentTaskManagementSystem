using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTaskManagementData
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
