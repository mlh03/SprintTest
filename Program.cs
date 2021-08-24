using System;

namespace MoeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
           Animal a1 = new Animal();
           a1.Color = "Black";
           a1.Name = "Max";
           a1.LegCount = 4;
           a1.DogSound = "RRRUFF";
           a1.CatSound = "MEWOOOOWW";
           Console.WriteLine(a1.CatInfo());
           Console.WriteLine(a1.DogInfo());
        }
    }
}
