using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    public class Task3
    {
        public void Run()
        {
            // Task 3 - Salary Deduction

            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < tabs; i++)
            {
                string website = Console.ReadLine();
                if (website == "Facebook") salary -= 150;
                else if (website == "Instagram") salary -= 100;
                else if (website == "Reddit") salary -= 50;

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }

            Console.WriteLine(salary);
        }
    }
}
