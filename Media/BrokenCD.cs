using System;
using System.Collections.Generic;
using System.Text;

namespace MediaExample
{
    class BrokenCD : Media
    {
        public BrokenCD() { }
        public BrokenCD(List<string> Scenes) : base(Scenes)
        {

        }

        public override string Play()
        {
            Random r = new Random();
            int choice = r.Next(0, Scenes.Count);

            return Scenes[choice];
        }
    }
}
