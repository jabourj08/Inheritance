using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class ConcreteAnimal
    {
        public string Name { get; set; }
        public string FavoriteFood { get; set; }


        public ConcreteAnimal(string Name, string FavoriteFood)
        {
            this.Name = Name;
            this.FavoriteFood = FavoriteFood;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Favorite Food: {FavoriteFood}");
        }

        public virtual string GetSound()
        {
            return "idk roar or something";
        }

        public bool TryFeed(string food)
        {
            if(food == FavoriteFood)
            {
                Console.WriteLine($"{Name} ate up their {food}");
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} ignores their bowl of {food}");
                return false;
            }
        }
    }
}
