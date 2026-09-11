using System;
using System.Collections.Generic;

namespace StudentTaskManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your own way to manage your Task");
            List<string> tasks = new List<string>();
            int userInput;
            do
            {
                Console.WriteLine("Type 1 to View Task");
                Console.WriteLine("Type 2 to Add Task");
                Console.WriteLine("Type 3 to Mark Task Done");
                Console.WriteLine("Type 4 to Exit");

                Console.Write("Input: ");
                userInput = Convert.ToInt16(Console.ReadLine());
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

                else
                {
                    foreach (string task in tasks)
                    {
                        Console.WriteLine(task);
                    }
                    Console.Write("Enter the Task number you wanna Mark as Done: ");
                    int markAsDone = Convert.ToInt16(Console.ReadLine());
                    tasks.RemoveAt(markAsDone - 1);
                }

            } while (userInput != 4);
        }
    }
}
