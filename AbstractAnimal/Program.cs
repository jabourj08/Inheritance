using System;

namespace AbstractAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //wont work because an Abstract class is only a template...cannot be called to create an object
            //AnimalAbstract a = new AnimalAbstract(); 

            Octopus o = new Octopus("Oli", "Clams");
            o.PrintInfo();
            Console.WriteLine(o.MakeSound());
            Console.WriteLine(o.TryFeed("Clams"));
        }
    }
}
