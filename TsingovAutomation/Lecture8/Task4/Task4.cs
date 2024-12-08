using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 4 - Create a class MathOperations, which should have 3 times method Add()

namespace Lecture8.Task4
{
    public class MathOperations
    {
        // Add method for integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Add method for doubles
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }

        // Add method for decimals
        public decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }
    }

    public class Task4
    {
        public void Run()
        {
            MathOperations mo = new MathOperations();

            // Prompt the user to choose the type of numbers to add
            Console.WriteLine("Choose the type of numbers you want to add:");
            Console.WriteLine("1. Integers");
            Console.WriteLine("2. Doubles");
            Console.WriteLine("3. Decimals");
            Console.Write("Enter your choice (1, 2, or 3): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // User chooses integers
                Console.Write("Enter the first integer: ");
                int int1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second integer: ");
                int int2 = Convert.ToInt32(Console.ReadLine());

                int result = mo.Add(int1, int2);
                Console.WriteLine($"The result of adding {int1} and {int2} is: {result}");
            }
            else if (choice == "2")
            {
                // User chooses doubles
                Console.Write("Enter the first double: ");
                double double1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second double: ");
                double double2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the third double: ");
                double double3 = Convert.ToDouble(Console.ReadLine());

                double result = mo.Add(double1, double2, double3);
                Console.WriteLine($"The result of adding {double1}, {double2}, and {double3} is: {result}");
            }
            else if (choice == "3")
            {
                // User chooses decimals
                Console.Write("Enter the first decimal: ");
                decimal decimal1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter the second decimal: ");
                decimal decimal2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter the third decimal: ");
                decimal decimal3 = Convert.ToDecimal(Console.ReadLine());

                decimal result = mo.Add(decimal1, decimal2, decimal3);
                Console.WriteLine($"The result of adding {decimal1}, {decimal2}, and {decimal3} is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
            }
        }
    }
}
    
