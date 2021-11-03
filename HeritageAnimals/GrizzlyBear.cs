using System;
using System.Collections.Generic;
using System.Text;

namespace HeritageAnimals
{
    public class GrizzlyBear : Bear
    {
        public int Population;

        public GrizzlyBear() : this(0) { }

        public GrizzlyBear(int pop)
        {
            this.Population = pop;
        }

        public void PrintNum()
        {
            Console.WriteLine("Det finns ungefär {0} grizzlybjörnar kvar i Nordamerika.", this.Population);
        }
    }
}
