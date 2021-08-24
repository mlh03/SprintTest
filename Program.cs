using System;

namespace MoeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.Name = "Flash";
            d1.Color = "Black";
            d1.LegCount = 4;
            d1.Sound = "RRRUF";
            Console.WriteLine(d1.getInfo());
            Cat c1 = new Cat();
            c1.Name = "Dior";
            c1.Color = "Mixed";
            c1.LegCount = 4;
            c1.Sound = "MEWWOOO";
            Console.WriteLine(c1.getInfo());
        }
    }
}
