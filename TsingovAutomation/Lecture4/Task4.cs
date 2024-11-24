using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Task4
    {
        public void Run()
        {
            // Task 4 - Cards Game

            // Read the initial decks for both players
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            // Simulate the game
            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                int firstCard = firstPlayer[0];
                int secondCard = secondPlayer[0];

                if (firstCard > secondCard)
                {
                    // First player wins the round
                    firstPlayer.Add(firstCard);
                    firstPlayer.Add(secondCard);
                }
                else if (secondCard > firstCard)
                {
                    // Second player wins the round
                    secondPlayer.Add(secondCard);
                    secondPlayer.Add(firstCard);
                }
                // Remove the first card from both players' decks (draw phase is over)
                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }

            // Determine and print the winner
            if (firstPlayer.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}
