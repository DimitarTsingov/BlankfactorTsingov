using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsingovAutomation.Lecture2Homework
{
    public class Task2
    {
        public void Run()
        {
            // Ask for first name
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            // Ask for last name
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            // Format the full name
            string fullName = $"{lastName}, {firstName}";

            // Display the result
            Console.WriteLine($"Full Name: {fullName}");
        }
    }
}
