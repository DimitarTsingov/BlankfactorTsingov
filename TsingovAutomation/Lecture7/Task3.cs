using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 3 -  Division Calculator

namespace Lecture7
{
    public class Task3
    {
        public static string DivideNumbers(int dividend, int divisor)
        {
            try
            {
                int result = dividend / divisor;
                return $"The result of dividing {dividend} by {divisor} is: {result}";
            }
            catch (DivideByZeroException)
            {
                return "Error: Division by zero is not allowed.";
            }
            catch (Exception ex)
            {

                return $"Unexpected error: {ex.Message}";
            }
        }

        public void Run()
        {
            try
            {
                Console.Write("Enter the dividend: ");
                int dividend = int.Parse(Console.ReadLine());

                Console.Write("Enter the divisor: ");
                int divisor = int.Parse(Console.ReadLine());

                string result = DivideNumbers(dividend, divisor);
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid integers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
