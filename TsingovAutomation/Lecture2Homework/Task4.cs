using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsingovAutomation.Lecture2Homework
{
    public class Task4
    {
        public void Run()
        {
            // Prompt user for radius
            Console.Write("Enter the radius of the circle: ");
            string input = Console.ReadLine();

            try
            {
                // Convert to double and calculate area
                double radius = double.Parse(input);
                double area = Math.PI * radius * radius;

                // Display the result formatted to 2 decimal places
                Console.WriteLine($"The area of the circle is: {area:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value for the radius.");
            }
        }
    }
}
