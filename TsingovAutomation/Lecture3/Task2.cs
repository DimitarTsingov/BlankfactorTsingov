using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    public class Task2
    {
        public void Run()
        {
            // Task 2 - Fishing Trip

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double boatPrice = season switch
            {
                "Spring" => 3000,
                "Summer" or "Autumn" => 4200,
                "Winter" => 2600,
                _ => 0
            };

            if (fishermen <= 6) boatPrice *= 0.9;
            else if (fishermen <= 11) boatPrice *= 0.85;
            else boatPrice *= 0.75;

            if (fishermen % 2 == 0 && season != "Autumn")
                boatPrice *= 0.95;

            if (budget >= boatPrice)
                Console.WriteLine($"Yes! You have {budget - boatPrice:F2} BGN left.");
            else
                Console.WriteLine($"Not enough money! You need {boatPrice - budget:F2} BGN.");
        }
    }
}
