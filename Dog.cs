using System;
namespace MoeQuiz
{
    public class Dog : Animal
    {
        public string Sound { get; set; }

       

        public override string GetInfo()
        {
            return $"Name: {Name}, Color: {Color}, Legs: {LegCount}, Sound: {Sound}";   
        }
    }
}
