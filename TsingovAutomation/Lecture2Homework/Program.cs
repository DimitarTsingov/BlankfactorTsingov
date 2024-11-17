using System;
using TsingovAutomation.Lecture2Homework;

namespace Lecture2Homework
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose a task to run (1-5):");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var task1 = new Task1();
                    task1.Run();
                    break;
                case "2":
                    var task2 = new Task2();
                    task2.Run();
                    break;
                case "3":
                    var task3 = new Task3();
                    task3.Run();
                    break;
                case "4":
                    var task4 = new Task4();
                    task4.Run();
                    break;
                case "5":
                    var task5 = new Task5();
                    task5.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
