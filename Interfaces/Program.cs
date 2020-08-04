using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Emu e = new Emu("Bert", "Fruit");
            e.PrintInfo();
            Console.WriteLine(e.MakeSound());
            Console.WriteLine(e.TryFeed("Meat"));
        }
    }
}
