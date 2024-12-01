using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 6 - Swap Two Numbers

namespace Lecture5
{
    public class Task6
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void Run()
        {
            Console.Write("Enter the first number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the second number: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.WriteLine($"Before swap: First Number = {num1}, Second Number = {num2}");

            Swap(ref num1, ref num2);

            Console.WriteLine($"After swap: First Number = {num1}, Second Number = {num2}");
        }
    }
}
