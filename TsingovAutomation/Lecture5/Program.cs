﻿using System;
using System.Threading.Tasks;
using Lecture5;



class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a task to run (1-9):");
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
            case "6":
                var task6 = new Task6();
                task6.Run();
                break;
            case "7":
                var task7 = new Task7();
                task7.Run();
                break;
            case "8":
                var task8 = new Task8();
                task8.Run();
                break;
            case "9":
                var task9 = new Task9();
                task9.Run();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
