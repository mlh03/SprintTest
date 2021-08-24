using System;

namespace MoeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.Name = "Cow";
            a1.LegCount = 4;
            a1.Color = "Black and White";
            Console.WriteLine(a1.GetInfo());

        }
    }
}
