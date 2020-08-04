using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Emu : IAnimal
    {

        public string Name { get; set; }
        public string FavoriteFood { get; set; }

        //constructor
        public Emu()
        {

        }
        public Emu(string Name, string FavoriteFood)
        {
            this.Name = Name;
            this.FavoriteFood = FavoriteFood;
        }
        public string MakeSound()
        {
            return "SQwUAAACK!";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Favorite Food: {FavoriteFood}");
        }

        public bool TryFeed(string food)
        {
            if (food == FavoriteFood)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
