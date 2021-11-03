using System;
using System.Collections.Generic;
using System.Text;

namespace HeritageAnimals
{
    public class Shark : Animals
    {
        public string Skin;

        public Shark() : this("Ingen hud") { }

        public Shark(string skin)
        {
            this.Skin = skin;
        }

        public void PrintSkin()
        {
            Console.WriteLine("Färg på huden: {0}", this.Skin);
        }
        public void makeSound()
        {
            Console.WriteLine("Blublubblub");
        }
    }
}
