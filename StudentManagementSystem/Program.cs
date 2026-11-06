using System;
using System.Collections.Generic;
using StudentTaskManagementBusinessLogic;
using StudentTaskManagementData;

namespace StudentTaskManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AuthenticationLogic authLogic = new AuthenticationLogic();
            TaskLogic taskLogic = new TaskLogic();

            Console.WriteLine("CRAM");
            string? username = StartMenu(authLogic);

            if (username == null)
            {
                Console.WriteLine("Goodbye.");
                return;
            }

            int choice;

            do
            {
                Console.WriteLine($"\nWelcome, {username}!");
                choice = DisplayMenu();

                switch (choice)
                {
                    case 1:
                        ShowTasks(taskLogic.GetPendingTasks(username), "Pending tasks");
                        break;
                    case 2:
                        AddTask(taskLogic, username);
                        break;
                    case 3:
                        MarkTaskDone(taskLogic, username);
                        break;
                    case 4:
                        ShowTasks(taskLogic.GetCompletedTasks(username), "Completed tasks");
                        break;
                    case 5:
                        DeleteTask(taskLogic, username);
                        break;
                    case 6:
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Pick a number from 1 to 6.");
                        break;
                }
            } while (choice != 6);
        }

        static string? StartMenu(AuthenticationLogic authLogic)
        {
            while (true)
            {
                Console.WriteLine("\n1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");
                Console.Write("Input: ");
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    string? username = Login(authLogic);

                    if (username != null)
                        return username;

                    Console.WriteLine("Too many failed attempts.");
                }
                else if (input == "2")
                {
                    Register(authLogic);
                }
                else if (input == "3")
                {
                    return null;
                }
                else
                {
                    Console.WriteLine("Pick 1, 2, or 3.");
                }
            }
        }

        static string? Login(AuthenticationLogic authLogic)
        {
            for (int attempt = 1; attempt <= 3; attempt++)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine() ?? "";
                Console.Write("Password: ");
                string password = Console.ReadLine() ?? "";

                if (authLogic.IsLoginValid(username, password))
                    return username.Trim();

                Console.WriteLine("Wrong Username or Password. Try Again");
            }

            return null;
        }

        static void Register(AuthenticationLogic authLogic)
        {
            Console.Write("Choose a username: ");
            string username = Console.ReadLine() ?? "";
            Console.Write("Choose a password: ");
            string password = Console.ReadLine() ?? "";
            Console.Write("Confirm password: ");
            string confirm = Console.ReadLine() ?? "";

            if (password != confirm)
            {
                Console.WriteLine("Passwords don't match.");
                return;
            }

            if (authLogic.Register(username, password))
                Console.WriteLine("Account created. You can log in now.");
            else
                Console.WriteLine("Could not register. The username may be taken, or something was blank.");
        }

        static int DisplayMenu()
        {
            Console.WriteLine("1. View pending tasks");
            Console.WriteLine("2. Add a task");
            Console.WriteLine("3. Mark a task as done");
            Console.WriteLine("4. View completed tasks");
            Console.WriteLine("5. Delete a task");
            Console.WriteLine("6. Exit");
            Console.Write("Input: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
                return choice;

            return -1;
        }

        static void ShowTasks(List<TaskItem> tasks, string heading)
        {
            Console.WriteLine($"\n{heading}:");

            if (tasks.Count == 0)
            {
                Console.WriteLine("  Nothing here yet.");
                return;
            }

            foreach (TaskItem task in tasks)
            {
                Console.WriteLine($"  {task.Id}. {task.Title}");
            }
        }

        static void AddTask(TaskLogic taskLogic, string username)
        {
            Console.Write("Enter the task you want to add: ");
            string title = Console.ReadLine() ?? "";

            if (taskLogic.AddTask(username, title))
                Console.WriteLine("Task added.");
            else
                Console.WriteLine("Could not add it. Check that it's not empty, not too long, and not a duplicate.");
        }

        static void MarkTaskDone(TaskLogic taskLogic, string username)
        {
            List<TaskItem> pending = taskLogic.GetPendingTasks(username);
            ShowTasks(pending, "Pending tasks");

            if (pending.Count == 0)
                return;

            if (!TryReadId("Enter the task number to mark as done: ", out int id))
            {
                Console.WriteLine("That's not a number.");
                return;
            }

            if (taskLogic.MarkAsDone(username, id))
                Console.WriteLine("Marked as done.");
            else
                Console.WriteLine("No task with that number.");
        }

        static void DeleteTask(TaskLogic taskLogic, string username)
        {
            ShowTasks(taskLogic.GetPendingTasks(username), "Pending tasks");
            ShowTasks(taskLogic.GetCompletedTasks(username), "Completed tasks");

            if (!TryReadId("Enter the task number to delete: ", out int id))
            {
                Console.WriteLine("That's not a number.");
                return;
            }

            if (taskLogic.DeleteTask(username, id))
                Console.WriteLine("Task deleted.");
            else
                Console.WriteLine("No task with that number.");
        }

        static bool TryReadId(string prompt, out int id)
        {
            Console.Write(prompt);
            return int.TryParse(Console.ReadLine(), out id);
        }
    }
}