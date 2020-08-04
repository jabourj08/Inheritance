using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Lizard : ConcreteAnimal
    {
        public string TailRegrowth { get; set; }
        public Lizard(string Name, string FavoriteFood, bool TailRegrowth) :base(Name, FavoriteFood)
        {
        }
        public override string GetSound()
        {
            return "idk lum or something";
        }
    }
}
