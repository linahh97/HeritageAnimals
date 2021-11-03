using System;

namespace HeritageAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Zoo!");
            Bears bear = new Bears();
            bear._Species = "Björn";
            bear._Feet = "tassar";
            bear._Teeth = "huggtänder";
            bear._Type = "rovdjur, allätare";
            bear._Environment = "skog, regnskog, fjäll";
            bear.Ears = "runda";
            bear.PrintAnimal();
            bear.PrintEars();
            bear.makeSound();
            bear.Sleep();
            Console.WriteLine("");
            Polarbear polar = new Polarbear();
            polar._Species = "Isjörn";
            polar._Feet = "tassar";
            polar._Teeth = "huggtänder";
            polar._Type = "rovdjur, köttätare";
            polar._Environment = "Arktis, havsis";
            polar.PrintAnimal();
            bear.makeSound();
            polar.Fur = "vit.";
            polar.PrintFur();
            polar.Sleep();
            Console.WriteLine("");
            GrizzlyBear grizzly = new GrizzlyBear();
            grizzly._Species = "Grizzlybjörn";
            grizzly._Feet = "tassar";
            grizzly._Teeth = "huggtänder";
            grizzly._Type = "rovdjur, allätare";
            grizzly._Environment = "fjäll, skog, tundra";
            grizzly.PrintAnimal();
            bear.makeSound();
            grizzly.Population = 55000;
            grizzly.PrintNum();
            grizzly.Sleep();
            Console.WriteLine("");
            
            Antelope ante = new Antelope();
            ante._Species = "Antilop";
            ante._Feet = "hovar";
            ante._Teeth = "idisslare";
            ante._Type = "bytesdjur, växtätare";
            ante._Environment = "savann, halvöknar";
            ante.Horns = "långa och krulliga";
            ante.PrintAnimal();
            ante.PrintHorns();
            ante.makeSound();
            ante.Play();
            Console.WriteLine("");

            Shark sh = new Shark();
            sh._Species = "Blåhaj";
            sh._Feet = "fenor";
            sh._Teeth = "räfflade huggtänder";
            sh._Type = "rovdjur, köttätare";
            sh._Environment = "havet";
            sh.Skin = "blå";
            sh.PrintAnimal();
            sh.PrintSkin();
            sh.makeSound();
            sh.Eat();

            Console.ReadKey();
        }
    }
}
