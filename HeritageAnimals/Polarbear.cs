using System;
using System.Collections.Generic;
using System.Text;

namespace HeritageAnimals
{
    public class Polarbear : Bear
    {
        public string Fur;

        public Polarbear() : this("Ingen päls") { }

        public Polarbear(string fur)
        {
            this.Fur = fur;
        }

        public void PrintFur()
        {
            Console.WriteLine("Isbjörnens päls är {0}", this.Fur);
        }
    }
}
