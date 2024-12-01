using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 8 - Divide Two Numbers

namespace Lecture5
{
    public class Task8
    {
        public static void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        public void Run()
        {
            Console.Write("Enter the dividend: ");
            if (!int.TryParse(Console.ReadLine(), out int dividend))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the divisor: ");
            if (!int.TryParse(Console.ReadLine(), out int divisor))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            try
            {
                Divide(dividend, divisor, out int quotient, out int remainder);

                Console.WriteLine($"Quotient: {quotient}");
                Console.WriteLine($"Remainder: {remainder}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
