using System;
using System.Collections.Generic;
using System.Text;

namespace MediaExample
{
    class VHS : Media
    {
        public int Current { get; set; }
        public VHS() { }
        public VHS(List<string> Scenes) : base(Scenes)
        {

        }

        public override string Play()
        {
            
            if (Current < Scenes.Count)
            {
                string sceneToPlay = Scenes[Current];
                Current++;
                return sceneToPlay;
            }
            else
            {
                return "Movie is over. You need to rewind to watch again.";
            }
        }
    }
}
