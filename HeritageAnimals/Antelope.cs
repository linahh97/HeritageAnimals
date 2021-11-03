using System;
using System.Collections.Generic;
using System.Text;

namespace HeritageAnimals
{
    class Antelope : Animals
    {
        public string Horns;

        public Antelope() : this("Inga horn") { }

        public Antelope(string horns)
        {
            this.Horns = horns;
        }

        public void PrintHorns()
        {
            Console.WriteLine("Hornens utseende: {0}", this.Horns);
        }
        public void makeSound()
        {
            Console.WriteLine("MRÖÖÖÖGHH");
        }

    }
}
