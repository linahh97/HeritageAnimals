using System;
using System.Collections.Generic;
using System.Text;

namespace HeritageAnimals
{
    public class Bear : Animals
    {
        public string _Ears;

        public void PrintEars()
        {
            Console.WriteLine("Öron: " + _Ears);
        }
        public void makeSound()
        {
            Console.WriteLine("RAAAAWW");
        }
    }
}
