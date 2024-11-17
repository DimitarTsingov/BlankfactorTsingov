using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsingovAutomation.Lecture2Homework
{
    public class Task1
    {
        public void Run()
        {
            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            // Try to parse the inputs
            if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
            {
                // Calculate the sum
                int sum = number1 + number2;
                // Display the result
                Console.WriteLine($"The sum of {number1} and {number2} is {sum}.");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a valid numbers.");
            }
        }
    }
}
