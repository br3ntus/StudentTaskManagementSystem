using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace StudentTaskManagementData
{
    public class TaskDataService
    {
        private List<TaskItem> _tasks = new List<TaskItem>();
        private readonly string _jsonFileName;

        public TaskDataService()
        {
            _jsonFileName = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "taskitems.json");

            LoadTasks();
        }

        private void LoadTasks()
        {
            string text = File.ReadAllText(_jsonFileName);

            _tasks = JsonSerializer.Deserialize<List<TaskItem>>(
                text,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                ?? new List<TaskItem>();
        }

        private void SaveTasks()
        {
            string text = JsonSerializer.Serialize(
                _tasks,
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(_jsonFileName, text);
        }

        public bool IsTaskExists(string owner, string title)
        {
            if (string.IsNullOrWhiteSpace(owner) || string.IsNullOrWhiteSpace(title))
                return false;

            string ownerTarget = owner.Trim();
            string titleTarget = title.Trim();

            return _tasks.Any(t =>
                string.Equals(t.Owner, ownerTarget, StringComparison.OrdinalIgnoreCase)
                && string.Equals(t.Title, titleTarget, StringComparison.OrdinalIgnoreCase));
        }

        public bool AddTask(TaskItem task)
        {
            if (task == null
                || string.IsNullOrWhiteSpace(task.Title)
                || string.IsNullOrWhiteSpace(task.Owner))
                return false;

            string owner = task.Owner.Trim();
            string title = task.Title.Trim();

            if (IsTaskExists(owner, title))
                return false;

            int newId = _tasks.Any() ? _tasks.Max(t => t.Id) + 1 : 1;

            _tasks.Add(new TaskItem
            {
                Id = newId,
                Owner = owner,
                Title = title,
                IsDone = task.IsDone
            });

            SaveTasks();
            return true;
        }

        public List<TaskItem> GetTasksByOwner(string owner)
        {
            if (string.IsNullOrWhiteSpace(owner))
                return new List<TaskItem>();

            string target = owner.Trim();

            return _tasks
                .Where(t => string.Equals(t.Owner, target, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public bool DeleteTask(int id)
        {
            TaskItem? task = _tasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
                return false;

            _tasks.Remove(task);
            SaveTasks();
            return true;
        }

        public bool MarkAsDone(int id)
        {
            TaskItem? task = _tasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
                return false;

            task.IsDone = true;
            SaveTasks();
            return true;
        }
    }
}