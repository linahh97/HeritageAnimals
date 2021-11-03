using System;
using System.Collections.Generic;
using System.Text;

namespace HeritageAnimals
{
    public class Animals
    {
        public string _Species;
        public string _Teeth;
        public string _Feet;
        public string _Type;
        public string _Environment;

        public Animals() : this("Ingen art given","inga tänder","inga fötter","ingen typ","ingen miljö") { }

        public Animals(string species, string teeth, string feet, string type, string environment)
        {
            this._Species = species;
            this._Teeth = teeth;
            this._Feet = feet;
            this._Type = type;
            this._Environment = environment;
        }
 
        public void PrintAnimal()
        {
            Console.WriteLine("Art: {0}", this._Species);
            Console.WriteLine("Typ av djur: {0}", this._Type);
            Console.WriteLine("Miljö: {0}", this._Environment);
            Console.WriteLine("Tänder: {0}", this._Teeth);
            Console.WriteLine("Fötter: {0}", this._Feet); 
        }
        public void Play()
        {
            Console.WriteLine(_Species + "en leker.");
        }
        public void Eat()
        {
            Console.WriteLine(_Species + "en äter.");
        }
        public void Sleep()
        {
            Console.WriteLine(_Species + "en sover.");
        }
    }
}
