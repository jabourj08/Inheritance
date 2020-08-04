using System;
using System.Collections.Generic;

namespace MediaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            VHS landBeforeTime = new VHS(new List<string>() { "scene1", "scene2", "scene3"});

            for (int i = 0; i < landBeforeTime.Scenes.Count; i++) //get count of list of object in 2nd argument
            {
                Console.WriteLine(landBeforeTime.Play());
            }
            Console.WriteLine();

            DVD avengersEndgame = new DVD(new List<string>() { "scene1", "scene2", "scene3", "scene4", "scene5" });

            Console.WriteLine(avengersEndgame.Play());
            Console.WriteLine();

            BrokenCD windwaker = new BrokenCD(new List<string>() { "scene1", "scene2", "scene3", "scene4", "scene5", "scene6", "scene7", "scene8", "scene9", "scene10" });
            for (int i = 0; i < windwaker.Scenes.Count; i++)
            {
                Console.WriteLine(windwaker.Play());
            }
        }
    }
}
