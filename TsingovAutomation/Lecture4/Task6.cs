using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Task6
    {
        public void Run()
        {
            // Task 6 -  A Miner Task

            // Dictionary to store resources and their quantities
            Dictionary<string, long> resources = new Dictionary<string, long>();

            while (true)
            {
                // Read the resource name
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break; // End the input loop
                }

                // Read the quantity
                long quantity = long.Parse(Console.ReadLine());

                // Add or update the resource in the dictionary
                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                resources[resource] += quantity;
            }

            // Print the results
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
