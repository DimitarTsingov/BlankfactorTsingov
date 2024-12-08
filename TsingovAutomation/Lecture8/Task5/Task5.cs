using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 5 - Create a class Animal, which holds two fields

namespace Lecture8.Task5
{
    public class Animal
    {
        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my favourite food is {FavouriteFood}";
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "\nMEEOW";
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "\nDJAAF";
        }
    }

    public class Task5
    {
        public void Run()
        {
            Console.WriteLine("Enter details for the Cat:");

            Console.Write("Enter the name of the Cat: ");
            string catName = Console.ReadLine();

            Console.Write("Enter the favourite food of the Cat: ");
            string catFood = Console.ReadLine();

            Animal cat = new Cat(catName, catFood);

            Console.WriteLine("\nEnter details for the Dog:");

            Console.Write("Enter the name of the Dog: ");
            string dogName = Console.ReadLine();

            Console.Write("Enter the favourite food of the Dog: ");
            string dogFood = Console.ReadLine();

            Animal dog = new Dog(dogName, dogFood);

            Console.WriteLine("\n" + cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}