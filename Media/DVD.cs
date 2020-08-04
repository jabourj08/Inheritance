using System;
using System.Collections.Generic;
using System.Text;

namespace MediaExample
{
    class DVD : Media
    {
        public DVD()
        {

        }
        public DVD(List<string> Scenes) : base (Scenes)
        {

        }

        public override string Play()
        {
            Console.WriteLine($"Please select a scene to watch...");
            Console.WriteLine($"Enter 0 - {Scenes.Count}");
            string choice = Console.ReadLine();
            int num = int.Parse(choice);

            return Scenes[num - 1];
        }
    }
}
