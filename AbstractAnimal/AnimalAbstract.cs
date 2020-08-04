using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace AbstractAnimal
{
    abstract class AnimalAbstract
    {
        public string Name {get; set;}
        public string FavoriteFood {get; set;}

        public AnimalAbstract(string Name, string FavoriteFood)
        {
            this.Name = Name;
            this.FavoriteFood = FavoriteFood;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Favorite Food: {FavoriteFood}");
        }

        public abstract string MakeSound(); //complete abstract method

        public bool TryFeed(string food)
        {
            if (food == FavoriteFood)
            {
                Console.WriteLine($"{Name} ate their bowl of {food}!");
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} ignored their bowl of {food}. :[");
                return false;
            }
        }
    }
}
