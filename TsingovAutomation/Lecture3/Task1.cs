using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    public class Task1
    {
        public void Run()
        {
            // Task 1 - Cinema Hall

            string screeningType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double pricePerTicket = screeningType switch
            {
                "Premiere" => 12.00,
                "Normal" => 7.50,
                "Discount" => 5.00,
                _ => 0.00
            };

            double totalRevenue = rows * columns * pricePerTicket;
            Console.WriteLine($"{totalRevenue:F2}");
        }
    }
}
