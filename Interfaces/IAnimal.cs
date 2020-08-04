using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IAnimal
    {
        //Interfaces can contain 2 things:
        //1. Properties
        //2. Method Stubs

        public void PrintInfo();

        public string MakeSound();

        public bool TryFeed(string food);
    }
}
