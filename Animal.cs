using System;
namespace MoeQuiz
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int LegCount { get; set; }

        public string GetInfo()
        {
            return $"Name, {Name}, Color: {Color}, Legs: {LegCount}";
        }
    }
}
