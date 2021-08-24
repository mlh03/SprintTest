using System;
namespace MoeQuiz
{
    public class Cat : Animal
    {
        public string Sound { get; set; }

        public override string GetInfo()
        {
          return $"Name: {Name}, Color: {Color}, Legs: {LegCount}, Sound: {Sound}";
        }
    }
}
