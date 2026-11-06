using System;
using System.Collections.Generic;
using StudentTaskManagementBusinessLogic;

namespace StudentTaskManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CRAM");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            List<string> tasks = new List<string>();
            int userInput;

            AuthenticationLogic authLogic = new AuthenticationLogic();

            if (authLogic.IsLoginValid(username, password))
            {
                do
                {
                    Console.WriteLine($"Welcome, {username}!");
                    userInput = DisplayMenu();

                    if (userInput == 1)
                    {
                        foreach (string task in tasks)
                        {
                            Console.WriteLine(task);
                        }
                    }
                    else if (userInput == 2)
                    {
                        Console.Write("Enter the task you wanna Add: ");
                        string taskToAdd = Console.ReadLine();
                        tasks.Add(taskToAdd);
                    }

                    else if (userInput == 3)
                    {
                        foreach (string task in tasks)
                        {
                            Console.WriteLine(task);
                        }
                        Console.Write("Enter the Task number you wanna Mark as Done: ");
                        int markAsDone = Convert.ToInt16(Console.ReadLine());
                        tasks.RemoveAt(markAsDone - 1);
                    }

                    else
                    {
                        Console.WriteLine("Exiting the program...");
                    }

                } while (userInput != 4);
            }
            else
            {
                Console.WriteLine("Wrong Username or Password. Try Again");
            }
        }

        static int DisplayMenu()
        {
            Console.WriteLine("Type 1 to View Task");
            Console.WriteLine("Type 2 to Add Task");
            Console.WriteLine("Type 3 to Mark Task Done");
            Console.WriteLine("Type 4 to Exit");

            Console.Write("Input: ");
            int userInput = Convert.ToInt16(Console.ReadLine());

            return userInput;
        }
    }
}
