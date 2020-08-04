using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAnimal someAnimal = new ConcreteAnimal("Jimmy", "pears");
            //Lizard myLizard = new Lizard("Alex", "mealworms");
            Dog myDog = new Dog("Bob", "treats");

            someAnimal.PrintInfo();
            Console.WriteLine();

            //myLizard.PrintInfo();
            Console.WriteLine();

            myDog.PrintInfo();

            //someAnimal.TryFeed();
        }
    }
}
