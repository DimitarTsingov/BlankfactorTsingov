using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsingovAutomation.Lecture2Homework
{
    internal class Task5
    {
        public void Run()
        {
            // Prompt user for age
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            // Validate using TryParse
            if (int.TryParse(input, out int age))
            {
                Console.WriteLine($"Your age is: {age}");
            }
            else
            {
                Console.WriteLine("Invalid age entered.");
            }
        }
    }
}
