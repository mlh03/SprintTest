using System;
namespace MoeQuiz
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int LegCount { get; set; }

        public abstract string GetInfo();
        

        
    }
}
