using System;
using System.Collections.Generic;
using System.Text;

namespace MediaExample
{
    abstract class Media
    {
        //properties
        public List<string> Scenes { get; set; }

        //constructors
        public Media() { }
        public Media(List<string> Scenes) 
        {
            this.Scenes = Scenes;
        }

        public abstract string Play();
    }
}
