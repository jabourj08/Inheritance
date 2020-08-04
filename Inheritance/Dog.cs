using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Dog : ConcreteAnimal
    {
        public Dog(string Name, string FavoriteFood) : base(Name, FavoriteFood)
        {
        }
        public override string GetSound()
        {
            return "idk woof or something";
        }
    }
}
