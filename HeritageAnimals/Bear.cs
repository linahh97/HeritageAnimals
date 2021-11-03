using System;
using System.Collections.Generic;
using System.Text;

namespace HeritageAnimals
{
    public class Bears : Animals
    {
        public string Ears;

        public Bears() : this("Inga öron") { }
       
        public Bears(string ears)
        {
            this.Ears = ears;
        }

        public void PrintEars()
        {
            Console.WriteLine("Björnens öron är {0}", this.Ears);
        }
        public void makeSound()
        {
            Console.WriteLine("RAAAAWW");
        }
    }
}
