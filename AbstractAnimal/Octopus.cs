using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAnimal
{
    class Octopus : AnimalAbstract
    {
        public bool HasGills { get; set; }
        //Constructor
        public Octopus(string Name, string FavoriteFood) : base(Name, FavoriteFood)
        {

        }

        public override string MakeSound()
        {
            return "blub blub sqush";
        }
    }
}
