using System;
using System.Collections.Generic;
using System.Text;
using StudentTaskManagementData;

namespace StudentTaskManagementBusinessLogic
{
    public class TaskLogic
    {
        private const int MaxTitleLength = 100;
        private readonly TaskDataService _dataService = new TaskDataService();

        public bool AddTask(string owner, string title)
        {
            if (string.IsNullOrWhiteSpace(owner) || string.IsNullOrWhiteSpace(title))
                return false;

            if (title.Trim().Length > MaxTitleLength)
                return false;

            return _dataService.AddTask(new TaskItem
            {
                Owner = owner,
                Title = title
            });
        }

        public List<TaskItem> GetPendingTasks(string owner)
        {
            return _dataService.GetTasksByOwner(owner)
                .Where(t => !t.IsDone)
                .ToList();
        }

        public List<TaskItem> GetCompletedTasks(string owner)
        {
            return _dataService.GetTasksByOwner(owner)
                .Where(t => t.IsDone)
                .ToList();
        }

        public bool MarkAsDone(string owner, int id)
        {
            if (!OwnsTask(owner, id))
                return false;

            return _dataService.MarkAsDone(id);
        }

        public bool DeleteTask(string owner, int id)
        {
            if (!OwnsTask(owner, id))
                return false;

            return _dataService.DeleteTask(id);
        }

        private bool OwnsTask(string owner, int id)
        {
            return _dataService.GetTasksByOwner(owner).Any(t => t.Id == id);
        }
    }
}
