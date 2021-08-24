using System;
namespace MoeQuiz
{
    public class Animal : IDog , ICat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int LegCount { get; set; }
        public string DogSound { get; set; }
        public string CatSound { get; set; }

        public string CatInfo()
        {
            return $"Name: {Name}, Color: {Color}, Legs: {LegCount}, Sound: {CatSound}";
        }
        public string DogInfo()
        {
            return $"Name: {Name}, Color: {Color}, Legs: {LegCount}, Sound: {DogSound}";
        }

    }
}
